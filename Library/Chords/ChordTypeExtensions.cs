using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Chords
{
    public static class ChordTypeExtensions
    {
        public static string ToStringDisplayable(this ModeType type)
        {
            switch (type)
            {
                case ModeType.Major:
                    return "Majeur";
                case ModeType.Minor:
                    return "mineur";
                default:
                    return type.ToString();
            }
        }
        public static string ToShortString(this ModeType type)
        {
            switch (type)
            {
                case ModeType.Major:
                    return "";
                case ModeType.Minor:
                    return "m";
                default:
                    return type.ToString();
            }
        }
    }
}
