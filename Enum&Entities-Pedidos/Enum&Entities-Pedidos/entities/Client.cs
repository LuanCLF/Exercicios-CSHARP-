

namespace Enum_Entities_Pedidos.entities
{
    internal class Client
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string BirthDate { get; private set; }

        public Client(string name, string email, string birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
