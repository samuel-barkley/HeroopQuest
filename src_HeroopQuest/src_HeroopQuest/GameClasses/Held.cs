using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType {Barbaar, Dwerg, Elf, Tovenaar }
    class Held
    {
        public Held(HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    Aanvalsdobbelstenen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case HeldType.Tovenaar:
                    Aanvalsdobbelstenen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelligentie;
            huidigLichaam = MaxLichaam;
        }

        public string Naam { get; set; }
        public string Beschrijving { get;private set; }
        public int MaxIntelligentie { get;private set; }
        public int MaxLichaam { get;private set; }
        public int HuidigIntelligentie { get; set; }
        public int huidigLichaam { get; set; }
        public HeldType HeldType { get;private set; }

        public int Aanvalsdobbelstenen { get; private set; } = 2;
        public int VerdedigingsDobbelstenen { get;private set; } = 2;
        public int LoopDobbelstenen { get;private set; } = 2;
    }
}
