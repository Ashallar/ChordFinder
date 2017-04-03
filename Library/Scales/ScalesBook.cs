using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales
{
    public static class ScalesBook
    {
        /// <summary>
        /// Returns all scales.
        /// </summary>
        /// <returns></returns>
        public static List<Scale> GetAllScales()
        {
            return GetMajorScales()
                .Concat(GetMinorScales())
                .ToList();
        }

        /// <summary>
        /// Returns all Major Scales.
        /// </summary>
        /// <returns></returns>
        public static List<Scale> GetMajorScales()
        {
            List<Scale> scales = new List<Scale>();

            scales.Add(new MajorScale(new Note(NoteType.C)));
            scales.Add(new MajorScale(new Note(NoteType.CSharp)));
            scales.Add(new MajorScale(new Note(NoteType.D)));
            scales.Add(new MajorScale(new Note(NoteType.DSharp)));
            scales.Add(new MajorScale(new Note(NoteType.E)));
            scales.Add(new MajorScale(new Note(NoteType.F)));
            scales.Add(new MajorScale(new Note(NoteType.FSharp)));
            scales.Add(new MajorScale(new Note(NoteType.G)));
            scales.Add(new MajorScale(new Note(NoteType.GSharp)));
            scales.Add(new MajorScale(new Note(NoteType.A)));
            scales.Add(new MajorScale(new Note(NoteType.ASharp)));
            scales.Add(new MajorScale(new Note(NoteType.B)));

            scales.Add(new PentatonicMajorScale(new Note(NoteType.C)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.CSharp)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.D)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.DSharp)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.E)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.F)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.FSharp)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.G)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.GSharp)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.A)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.ASharp)));
            scales.Add(new PentatonicMajorScale(new Note(NoteType.B)));

            return scales;
        }

        /// <summary>
        /// Returns all Minor Scales.
        /// </summary>
        /// <returns></returns>
        public static List<Scale> GetMinorScales()
        {
            List<Scale> scales = new List<Scale>();

            scales.Add(new MinorScale(new Note(NoteType.C)));
            scales.Add(new MinorScale(new Note(NoteType.CSharp)));
            scales.Add(new MinorScale(new Note(NoteType.D)));
            scales.Add(new MinorScale(new Note(NoteType.DSharp)));
            scales.Add(new MinorScale(new Note(NoteType.E)));
            scales.Add(new MinorScale(new Note(NoteType.F)));
            scales.Add(new MinorScale(new Note(NoteType.FSharp)));
            scales.Add(new MinorScale(new Note(NoteType.G)));
            scales.Add(new MinorScale(new Note(NoteType.GSharp)));
            scales.Add(new MinorScale(new Note(NoteType.A)));
            scales.Add(new MinorScale(new Note(NoteType.ASharp)));
            scales.Add(new MinorScale(new Note(NoteType.B)));

            scales.Add(new PentatonicMinorScale(new Note(NoteType.C)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.CSharp)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.D)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.DSharp)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.E)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.F)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.FSharp)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.G)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.GSharp)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.A)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.ASharp)));
            scales.Add(new PentatonicMinorScale(new Note(NoteType.B)));

            return scales;
        }


        public static List<Scale> GetMatchingScales(List<Note> notes)
        {
            List<Scale> matchingScales = new List<Scale>();

            foreach (Scale scale in GetAllScales())
            {
                if (scale.IsMatchingScale(notes))
                    matchingScales.Add(scale);
            }

            return matchingScales;
        }
    }
}
