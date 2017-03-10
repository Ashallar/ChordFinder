﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NAudio.Midi;

namespace MidiControllerProject.Library.Notes
{
    public class Note : IComparable<Note>
    {
        public Note(NoteEvent e)
        {
            Tuple<NoteType, int> infos = ExtractInformationsFromNoteName(e.NoteName);

            this.NoteType = infos.Item1;
            this.Octave = infos.Item2;
            this.Velocity = e.Velocity;
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
    }
}