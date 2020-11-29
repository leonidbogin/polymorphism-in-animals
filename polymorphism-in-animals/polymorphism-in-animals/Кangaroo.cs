using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_in_animals
{
    internal class Кangaroo : Animal
    {
        public Кangaroo(string name, int footNumber, bool hasMustache)
            : base(name, footNumber, hasMustache)
        {

        }

        public override string Voice()
        {
            return "кхе-кхе";
        }

        public override string Move()
        {
            return "прыг-прыг";
        }

        public new string IsHungry()
        {
            return "хочу ягоды";
        }
    }
}
