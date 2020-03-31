namespace ZwajAPP.API.Models
 {
    public class Value {
        public Value (int id, string name) {
            this.id = id;
            this.Name = name;

        }
        public int id { get; set; }
        public string Name { get; set; }
    }
}