using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace MidiControllerProject.Library
{
    public class ChordFinder
    {
        public ChordFinder()
        {
            this.Notes = new ConcurrentBag<Note>();
        }


        /// <summary>
        /// A thread-safe ConcurrentBag containing all notes currently played
        /// </summary>
        public ConcurrentBag<Note> Notes { get; }
    }
}
