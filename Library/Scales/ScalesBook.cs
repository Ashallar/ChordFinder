using MidiControllerProject.Library.Notes;
using MidiControllerProject.Library.Scales.Modes;
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
                .Concat(GetModesScales())
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

        /// <summary>
        /// Returns all modes scales.
        /// </summary>
        /// <returns></returns>
        public static List<Scale> GetModesScales()
        {
            List<Scale> scales = new List<Scale>();

            scales.Add(new AeolianScale(new Note(NoteType.C)));
            scales.Add(new AeolianScale(new Note(NoteType.CSharp)));
            scales.Add(new AeolianScale(new Note(NoteType.D)));
            scales.Add(new AeolianScale(new Note(NoteType.DSharp)));
            scales.Add(new AeolianScale(new Note(NoteType.E)));
            scales.Add(new AeolianScale(new Note(NoteType.F)));
            scales.Add(new AeolianScale(new Note(NoteType.FSharp)));
            scales.Add(new AeolianScale(new Note(NoteType.G)));
            scales.Add(new AeolianScale(new Note(NoteType.GSharp)));
            scales.Add(new AeolianScale(new Note(NoteType.A)));
            scales.Add(new AeolianScale(new Note(NoteType.ASharp)));
            scales.Add(new AeolianScale(new Note(NoteType.B)));

            scales.Add(new DorianScale(new Note(NoteType.C)));
            scales.Add(new DorianScale(new Note(NoteType.CSharp)));
            scales.Add(new DorianScale(new Note(NoteType.D)));
            scales.Add(new DorianScale(new Note(NoteType.DSharp)));
            scales.Add(new DorianScale(new Note(NoteType.E)));
            scales.Add(new DorianScale(new Note(NoteType.F)));
            scales.Add(new DorianScale(new Note(NoteType.FSharp)));
            scales.Add(new DorianScale(new Note(NoteType.G)));
            scales.Add(new DorianScale(new Note(NoteType.GSharp)));
            scales.Add(new DorianScale(new Note(NoteType.A)));
            scales.Add(new DorianScale(new Note(NoteType.ASharp)));
            scales.Add(new DorianScale(new Note(NoteType.B)));

            scales.Add(new IonianScale(new Note(NoteType.C)));
            scales.Add(new IonianScale(new Note(NoteType.CSharp)));
            scales.Add(new IonianScale(new Note(NoteType.D)));
            scales.Add(new IonianScale(new Note(NoteType.DSharp)));
            scales.Add(new IonianScale(new Note(NoteType.E)));
            scales.Add(new IonianScale(new Note(NoteType.F)));
            scales.Add(new IonianScale(new Note(NoteType.FSharp)));
            scales.Add(new IonianScale(new Note(NoteType.G)));
            scales.Add(new IonianScale(new Note(NoteType.GSharp)));
            scales.Add(new IonianScale(new Note(NoteType.A)));
            scales.Add(new IonianScale(new Note(NoteType.ASharp)));
            scales.Add(new IonianScale(new Note(NoteType.B)));

            scales.Add(new LocrianScale(new Note(NoteType.C)));
            scales.Add(new LocrianScale(new Note(NoteType.CSharp)));
            scales.Add(new LocrianScale(new Note(NoteType.D)));
            scales.Add(new LocrianScale(new Note(NoteType.DSharp)));
            scales.Add(new LocrianScale(new Note(NoteType.E)));
            scales.Add(new LocrianScale(new Note(NoteType.F)));
            scales.Add(new LocrianScale(new Note(NoteType.FSharp)));
            scales.Add(new LocrianScale(new Note(NoteType.G)));
            scales.Add(new LocrianScale(new Note(NoteType.GSharp)));
            scales.Add(new LocrianScale(new Note(NoteType.A)));
            scales.Add(new LocrianScale(new Note(NoteType.ASharp)));
            scales.Add(new LocrianScale(new Note(NoteType.B)));

            scales.Add(new LydianScale(new Note(NoteType.C)));
            scales.Add(new LydianScale(new Note(NoteType.CSharp)));
            scales.Add(new LydianScale(new Note(NoteType.D)));
            scales.Add(new LydianScale(new Note(NoteType.DSharp)));
            scales.Add(new LydianScale(new Note(NoteType.E)));
            scales.Add(new LydianScale(new Note(NoteType.F)));
            scales.Add(new LydianScale(new Note(NoteType.FSharp)));
            scales.Add(new LydianScale(new Note(NoteType.G)));
            scales.Add(new LydianScale(new Note(NoteType.GSharp)));
            scales.Add(new LydianScale(new Note(NoteType.A)));
            scales.Add(new LydianScale(new Note(NoteType.ASharp)));
            scales.Add(new LydianScale(new Note(NoteType.B)));

            scales.Add(new MelodicMajorScale(new Note(NoteType.C)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.CSharp)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.D)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.DSharp)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.E)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.F)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.FSharp)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.G)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.GSharp)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.A)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.ASharp)));
            scales.Add(new MelodicMajorScale(new Note(NoteType.B)));

            scales.Add(new MelodicMinorScale(new Note(NoteType.C)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.CSharp)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.D)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.DSharp)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.E)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.F)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.FSharp)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.G)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.GSharp)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.A)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.ASharp)));
            scales.Add(new MelodicMinorScale(new Note(NoteType.B)));

            scales.Add(new MixolydianScale(new Note(NoteType.C)));
            scales.Add(new MixolydianScale(new Note(NoteType.CSharp)));
            scales.Add(new MixolydianScale(new Note(NoteType.D)));
            scales.Add(new MixolydianScale(new Note(NoteType.DSharp)));
            scales.Add(new MixolydianScale(new Note(NoteType.E)));
            scales.Add(new MixolydianScale(new Note(NoteType.F)));
            scales.Add(new MixolydianScale(new Note(NoteType.FSharp)));
            scales.Add(new MixolydianScale(new Note(NoteType.G)));
            scales.Add(new MixolydianScale(new Note(NoteType.GSharp)));
            scales.Add(new MixolydianScale(new Note(NoteType.A)));
            scales.Add(new MixolydianScale(new Note(NoteType.ASharp)));
            scales.Add(new MixolydianScale(new Note(NoteType.B)));

            scales.Add(new PhrygianScale(new Note(NoteType.C)));
            scales.Add(new PhrygianScale(new Note(NoteType.CSharp)));
            scales.Add(new PhrygianScale(new Note(NoteType.D)));
            scales.Add(new PhrygianScale(new Note(NoteType.DSharp)));
            scales.Add(new PhrygianScale(new Note(NoteType.E)));
            scales.Add(new PhrygianScale(new Note(NoteType.F)));
            scales.Add(new PhrygianScale(new Note(NoteType.FSharp)));
            scales.Add(new PhrygianScale(new Note(NoteType.G)));
            scales.Add(new PhrygianScale(new Note(NoteType.GSharp)));
            scales.Add(new PhrygianScale(new Note(NoteType.A)));
            scales.Add(new PhrygianScale(new Note(NoteType.ASharp)));
            scales.Add(new PhrygianScale(new Note(NoteType.B)));

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
