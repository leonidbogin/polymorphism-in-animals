namespace polymorphism_in_animals
{
    internal class Animal
    {
        private string Name { get; set; }
        private int FootNumber { get; set; }
        private bool HasMustache { get; set; }

        public Animal()
        {

        }

        public Animal(string name, int footNumber, bool hasMustache)
        {
            Name = name;
            FootNumber = footNumber;
            HasMustache = hasMustache;
        }

        public virtual string Voice()
        {
            return "голос";
        }

        public virtual string Move()
        {
            return "движение";
        }

        public virtual string IsHungry()
        {
            return "не голоден";
        }
    }
}
