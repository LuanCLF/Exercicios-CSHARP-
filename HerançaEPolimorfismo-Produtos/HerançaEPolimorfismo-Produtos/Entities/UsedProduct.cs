
namespace HerançaEPolimorfismo_Produtos.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct(string name, double price,DateTime manufactureDate) : base(name, price)

        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) R${Price:F2} (Manufacture date: {ManufactureDate.ToString("dd-MM-yyyy")})";
        }

    }
}
