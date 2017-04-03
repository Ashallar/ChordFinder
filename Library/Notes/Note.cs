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

        public Note(NoteType type)
        {
            this.NoteType = type;
            this.Velocity = 0;
            this.Octave = 0;
        }

        public NoteType NoteType { get; }

        public int Octave { get; }

        public int? Velocity { get; }

        public override string ToString()
        {
            return this.NoteType.ToStringDisplayable();
        }

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



        /// <summary>
        /// Returns the second flat (+1 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteSecondFlat()
        {
            NoteType secondFlatType = ((int)this.NoteType + 1) > 12 ? (this.NoteType + 1) - 12 : (this.NoteType + 1);

            return new Note(secondFlatType);
        }

        /// <summary>
        /// Returns the second (+2 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteSecond()
        {
            NoteType secondType = ((int)this.NoteType + 2) > 12 ? (this.NoteType + 2) - 12 : (this.NoteType + 2);

            return new Note(secondType);
        }

        /// <summary>
        /// Returns the minor third (+3 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteMinorThird()
        {
            NoteType minorThirdType = ((int)this.NoteType + 3) > 12 ? (this.NoteType + 3) - 12 : (this.NoteType + 3);

            return new Note(minorThirdType);
        }

        /// <summary>
        /// Returns the major third (+4 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteThird()
        {
            NoteType majorThirdType = ((int)this.NoteType + 4) > 12 ? (this.NoteType + 4) - 12 : (this.NoteType + 4);

            return new Note(majorThirdType);
        }

        /// <summary>
        /// Returns the fourth (+5 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteFourth()
        {
            NoteType fourthType = ((int)this.NoteType + 5) > 12 ? (this.NoteType + 5) - 12 : (this.NoteType + 5);

            return new Note(fourthType);
        }

        /// <summary>
        /// Returns the diminished fifth (+6 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteDiminishedFifth()
        {
            NoteType diminishedFifhtType = ((int)this.NoteType + 6) > 12 ? (this.NoteType + 6) - 12 : (this.NoteType + 6);

            return new Note(diminishedFifhtType);
        }

        /// <summary>
        /// Returns the perfect fifth (+7 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteFifth()
        {
            NoteType majorThirdType = ((int)this.NoteType + 7) > 12 ? (this.NoteType + 7) - 12 : (this.NoteType + 7);

            return new Note(majorThirdType);
        }

        /// <summary>
        /// Returns the augmented fifth (+8 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteAugmentedFifth()
        {
            NoteType augmentedFifhtType = ((int)this.NoteType + 8) > 12 ? (this.NoteType + 8) - 12 : (this.NoteType + 8);

            return new Note(augmentedFifhtType);
        }

        /// <summary>
        /// Returns the sixth (+9 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteSixth()
        {
            NoteType sixthType = ((int)this.NoteType + 9) > 12 ? (this.NoteType + 9) - 12 : (this.NoteType + 9);

            return new Note(sixthType);
        }

        /// <summary>
        /// Returns the minor seventh (+10 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteMinorSeventh()
        {
            NoteType minorSeventhType = ((int)this.NoteType + 10) > 12 ? (this.NoteType + 10) - 12 : (this.NoteType + 10);

            return new Note(minorSeventhType);
        }

        /// <summary>
        /// Returns the seventh (+11 half-tones) of the note.
        /// </summary>
        /// <returns></returns>
        public Note GetNoteSeventh()
        {
            NoteType seventhType = ((int)this.NoteType + 11) > 12 ? (this.NoteType + 11) - 12 : (this.NoteType + 11);

            return new Note(seventhType);
        }

    }
}
