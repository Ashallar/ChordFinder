using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Chords;
using MidiControllerProject.Library.Notes;

namespace TestEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {
            ChordFinder finder = new ChordFinder();
            Note a = new Note("C3", 0);
            Note b = new Note("E3", 0);
            Note c = new Note("G3", 0);
            Note d = new Note("B3", 0);

            finder.Notes.TryAdd(a.GetNoteIdentifier(), a);
            finder.Notes.TryAdd(b.GetNoteIdentifier(), b);
            finder.Notes.TryAdd(c.GetNoteIdentifier(), c);
            finder.Notes.TryAdd(d.GetNoteIdentifier(), d);



        }
    }
}
