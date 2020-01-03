namespace ApiSimples.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public override string ToString() => $"{Id} - {Name} - {IsComplete}";
    }
}