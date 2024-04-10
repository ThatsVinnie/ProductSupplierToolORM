namespace Domain
{
    // Declaração da entidade Product
    public class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int IdSupplier {  get; set; }
        public Supplier Supplier { get; set; }
    }
}
