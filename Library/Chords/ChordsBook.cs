using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Chords
{
    /// <summary>
    /// ChordsBook is a class building all referenced chords.
    /// </summary>
    public static class ChordsBook
    {
        public static List<Chord> GetAllChords()
        {
            return GetMajorChords()
                .Concat(GetMinorChords())
                .ToList();
        }

        public static List<Chord> GetMajorChords()
        {
            List<Chord> majorChords = new List<Chord>();

            majorChords.Add(new Chord(NoteType.A, ModeType.Major));
            majorChords.Add(new Chord(NoteType.ASharp, ModeType.Major));
            majorChords.Add(new Chord(NoteType.B, ModeType.Major));
            majorChords.Add(new Chord(NoteType.C, ModeType.Major));
            majorChords.Add(new Chord(NoteType.CSharp, ModeType.Major));
            majorChords.Add(new Chord(NoteType.D, ModeType.Major));
            majorChords.Add(new Chord(NoteType.DSharp, ModeType.Major));
            majorChords.Add(new Chord(NoteType.E, ModeType.Major));
            majorChords.Add(new Chord(NoteType.F, ModeType.Major));
            majorChords.Add(new Chord(NoteType.FSharp, ModeType.Major));
            majorChords.Add(new Chord(NoteType.G, ModeType.Major));
            majorChords.Add(new Chord(NoteType.GSharp, ModeType.Major));

            return majorChords;
        }

        public static List<Chord> GetMinorChords()
        {
            List<Chord> minorChords = new List<Chord>();

            minorChords.Add(new Chord(NoteType.A, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.ASharp, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.B, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.C, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.CSharp, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.D, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.DSharp, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.E, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.F, ModeType.Minor));
            minorChords.Add(new Chord(NoteType.FSharp, ModeType.Minor));

            return minorChords;
        }
    }
}
