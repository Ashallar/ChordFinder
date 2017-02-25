using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Extensions
{
    public static class NoteTypeExtensions
    {
        /// <summary>
        /// Returns a displayable string for a note. Transform CSharp into C# for example.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string ToStringDisplayable(this NoteType type)
        {
            switch (type)
            {
                case NoteType.CSharp:
                    return "C#";
                case NoteType.DSharp:
                    return "D#";
                case NoteType.FSharp:
                    return "F#";
                case NoteType.GSharp:
                    return "G#";
                case NoteType.ASharp:
                    return "A#";
                default:
                    return type.ToString();
            }
        }
    }
}
