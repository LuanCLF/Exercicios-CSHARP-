
namespace HerançaEPolimorfismo_Produtos.Entities
{
    public class ImportedProduct : Product
    {

        public double CustomsFee { get; private set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        private double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} R${TotalPrice():F2} (Customs fee: R${CustomsFee:F2})";
        }

        

    }
}
