using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Chords;
using MidiControllerProject.Library.Notes;
using MidiControllerProject.Library.Scales;


namespace TestEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {
            PentatonicMinorScale scale = new PentatonicMinorScale(new Note(NoteType.C));
            List<Note> notes = new List<Note>();

            notes.Add(new Note(NoteType.C));
            notes.Add(new Note(NoteType.G));

            var res = scale.IsMatchingScale(notes);

        }
    }
}
