using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SysVentory.ThirdParty
{
    public class Item {
        public Item(string itemType, List<ItemProperty> properties) {
            this.ItemType = itemType;
            this.Properties = properties;
        }

        public string ItemType { get; }
        public List<ItemProperty> Properties { get; }

        public override string ToString() {
            string item = "\t" + ItemType + ":\r\n";
            foreach(ItemProperty itemProperty in Properties) {
                if (itemProperty.ToString() != "")
                    item += "\t\t" + itemProperty.ToString() + "\r\n";
            }
            return item;

        }
    }
}