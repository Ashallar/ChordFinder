using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace Library.Chords
{
    public class Chord
    {
        public Chord(Note rootNote, ChordType type)
        {
            if (rootNote == null || type == ChordType.Undefined)
                throw new ArgumentException("The note you provided is null or the type of the ChordType is undefined");
        }

        public Note RootNote { get; set; }

        public ChordType Type { get; set; }
    }
}
