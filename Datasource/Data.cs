using System;
using System.Collections.Generic;
using System.Management;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Datasource {
    public class Data : List<Item> {
        private Data() {}

        public static async void ReadAsync(Action<Data> callback) {
            var data = new Data();
            await Task.Run(() => {
                data.ReadWmi("Win32_Processor");
                data.ReadWmi("Win32_PhysicalMemory");
                data.ReadWmi("Win32_NetworkAdapter");
                data.ReadWmi("Win32_OperatingSystem");
                data.ReadSoftware();
            });
            callback(data);
        }

        public static Data Read() {
            var data = new Data();
            data.ReadWmi("Win32_Processor");
            data.ReadWmi("Win32_PhysicalMemory");
            data.ReadWmi("Win32_NetworkAdapter");
            data.ReadSoftware();
            return data;
        }

        private void ReadWmi(string cls) {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", $"SELECT * FROM {cls}", new EnumerationOptions { ReturnImmediately = true, Rewindable = false });

            foreach (var queryObj in searcher.Get()) {
                var propList = new List<ItemProperty>();
                foreach (var p in queryObj.Properties) {
                    propList.Add(new ItemProperty(p.Name, p.Value));
                }
                this.Add(new Item(cls, propList));
            }

        }

        private void ReadSoftware() {
            const string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (var key = Registry.LocalMachine.OpenSubKey(registry_key)) {
                if (key != null) {
                    foreach (var subkey_name in key.GetSubKeyNames()) {
                        using (var subkey = key.OpenSubKey(subkey_name)) {
                            if (subkey != null) {
                                var disp = subkey.GetValue("DisplayName") as string;
                                if (!string.IsNullOrEmpty(disp)) {
                                    this.Add(new Item("Software", new List<ItemProperty> {new ItemProperty("Name", disp)}));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
