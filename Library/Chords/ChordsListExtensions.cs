using MidiControllerProject.Library.Chords;
using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Chords
{
    public static class ChordsListExtensions
    {
        public static List<Note> GetDistinctNotesFromChordList(this List<Chord> chords)
        {
            List<Note> notes = new List<Note>();

            foreach (Chord chord in chords)
            {
                notes = notes.Concat(chord.GetNotes()).ToList();
            }
            return notes.GroupBy(x => x.NoteType).Select(x => x.First()).ToList();
        }
    }
}
