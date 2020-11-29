using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_in_animals
{
    internal class Horse : Animal
    {
        public Horse(string name, int footNumber, bool hasMustache)
            : base(name, footNumber, hasMustache)
        {

        }

        public override string Voice()
        {
            return "и-го-го";
        }

        public override string Move()
        {
            return "топ-топ";
        }

        public new string IsHungry()
        {
            return "хочу сено";
        }
    }
}
