using System;


namespace Listas_InserirEditar.domain
{
    public class Functionary(int id, string name, double salary)
    {
        public int Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public double Salary { get; private set; } = salary;

        public void Increase(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary:F2}";
        }
    }
}
