using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public enum geslacht
    {
        Man,
        Vrouw
    }
    class Bandlid
    {

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public geslacht Geslacht { get; set; }
        public bool Levend { get; set; }

    }
}
