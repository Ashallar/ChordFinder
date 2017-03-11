using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Notes
{
    public class Note : IComparable<Note>
    {
        /// <summary>
        /// WARNING: This constructor should be used only in UnitTests project.
        /// </summary>
        public Note(string noteName, int velocity)
        {
            Tuple<NoteType, int> infos = ExtractInformationsFromNoteName(noteName);

            if (infos.Item1 == NoteType.Undefined)
            {
                throw new InvalidOperationException("Couldn't determine note");
            }

            this.NoteType = infos.Item1;
            this.Octave = infos.Item2;
            this.Velocity = velocity;
        }

        public NoteType NoteType { get; }

        public int Octave { get; }

        public int? Velocity { get; }

        /// <summary>
        /// Extract NoteType and octave from NoteEvent.NoteName. Return a Tuple NoteType, int representing the note and the octave.
        /// </summary>
        /// <returns></returns>
        private static Tuple<NoteType, int> ExtractInformationsFromNoteName(string noteName)
        {
            int octave = int.Parse(Regex.Match(noteName, @"-?\d+").Value);
            NoteType note = GetNoteTypeFromString(new string(noteName.Where(x => char.IsLetter(x) || x.Equals('#')).ToArray()));

            return new Tuple<NoteType, int>(note, octave);
        }

        /// <summary>
        /// Determines the note based on a string.
        /// </summary>
        /// <param name="input">String representing a note</param>
        /// <returns></returns>
        private static NoteType GetNoteTypeFromString(string input)
        {
            switch (input)
            {
                case "C":
                    return NoteType.C;
                case "C#":
                    return NoteType.CSharp;
                case "D":
                    return NoteType.D;
                case "D#":
                    return NoteType.DSharp;
                case "E":
                    return NoteType.E;
                case "F":
                    return NoteType.F;
                case "F#":
                    return NoteType.FSharp;
                case "G":
                    return NoteType.G;
                case "G#":
                    return NoteType.GSharp;
                case "A":
                    return NoteType.A;
                case "A#":
                    return NoteType.ASharp;
                case "B":
                    return NoteType.B;
                default:
                    return NoteType.Undefined;
            }
        }


        /// <summary>
        /// Returns the a string allowing to identify the Note. The string is made of: {NoteType}{Octave}
        /// </summary>
        /// <returns></returns>
        public string GetNoteIdentifier()
        {
            return $"{this.NoteType.ToString()}{this.Octave}";
        }

        public int CompareTo(Note other)
        {
            return (this.Octave - other.Octave == 0) ? (this.NoteType - other.NoteType) : (this.Octave - other.Octave);
        }


        /// <summary>
        /// Get half-tone gap of the two notes.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int GetHalfToneGap(Note other)
        {
            return (other.NoteType - this.NoteType) + ((other.Octave - this.Octave) * 12);
        }

        /// <summary>
        /// Determines whether the other note is a Major Third of the note.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool IsMajorThird(Note other)
        {
            return this.GetHalfToneGap(other) == 4;
        }

        /// <summary>
        /// Determines whether the other note is a Minor Third of the note.
        /// </summary>
        /// <returns></returns>
        public bool IsMinorThird(Note other)
        {
            return this.GetHalfToneGap(other) == 3;
        }
    }
}
