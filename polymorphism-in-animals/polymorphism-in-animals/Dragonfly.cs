using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_in_animals
{
    internal class Dragonfly : Animal
    {
        public Dragonfly(string name, int footNumber, bool hasMustache)
            : base(name, footNumber, hasMustache)
        {

        }

        public override string Voice()
        {
            return "бж-ж-ж";
        }

        public override string Move()
        {
            return "полет";
        }

        public new string IsHungry()
        {
            return "хочу насекомых";
        }
    }
}
