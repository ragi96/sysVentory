namespace SysVentory.ThirdParty
{
    public class ItemProperty {
        public ItemProperty(string name, object value) {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; }
        public object Value { get; }

        public override string ToString() {
            if (Value != null)
                return Name + " " + Value.ToString();
            else
                return "";
        }
    }
}
