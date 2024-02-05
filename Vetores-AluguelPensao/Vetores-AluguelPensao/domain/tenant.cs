using System;

namespace Vetores_AluguelPensao.domain
{
    public class Tenant
    {
        public int Rent { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Room { get; private set; }

        public Tenant(int rent, string name, string email, int room)
        {
            Rent = rent;
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return $"{Room}: {Name}, {Email}";
        }
    }
}
