using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Chords
{
    public class ChordFinder
    {
        public ChordFinder()
        {
            this.Notes = new ConcurrentDictionary<string, Note>();
        }


        /// <summary>
        /// A thread-safe ConcurrentBag containing all notes currently played
        /// </summary>
        public ConcurrentDictionary<string, Note> Notes { get; }


        /*  SET OF RULES  */

        /// <summary>
        /// Gets the lowest note of Notes
        /// </summary>
        /// <returns></returns>
        public Note GetLowestNote()
        {
            return Notes.Select(x => x.Value).Min();
        }

        /// <summary>
        /// Gets the lowest note of Notes
        /// </summary>
        /// <returns></returns>
        public Note GetHighestNote()
        {
            return Notes.Select(x => x.Value).Max();
        }
    }
}
