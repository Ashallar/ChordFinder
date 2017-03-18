using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Chords
{
    public static class ChordTypeExtensions
    {
        public static string ToStringDisplayable(this ChordType type)
        {
            switch (type)
            {
                case ChordType.Major:
                    return "Majeur";
                case ChordType.Minor:
                    return "mineur";
                case ChordType.Seventh:
                    return "Septième";
                default:
                    return type.ToString();
            }
        }

    }
}
