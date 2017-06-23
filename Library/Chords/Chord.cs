using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Chords
{
    public class Chord
    {
        public Chord(Note rootNote, ModeType type)
        {
            if (rootNote == null || type == ModeType.Undefined)
                throw new ArgumentException("The note you provided is null or the type of the ChordType is undefined");

            this.RootNote = rootNote;
            this.Type = type;
        }

        public Chord(NoteType rootNote, ModeType mode)
        {
            if (rootNote == NoteType.Undefined)
                throw new ArgumentException("NoteType cannot be undefined to instantiate a chord");
            if (mode == ModeType.Undefined)
                throw new ArgumentException("ModeType cannot be undefined to instantiate a chord");

            this.RootNote = new Note(rootNote);
            this.Type = mode;
        }

        /// <summary>
        /// Returns a string with the chord name.
        /// </summary>
        public string ChordName
        {
            get
            {
                return $"{this.RootNote.NoteType.ToStringDisplayable()} {this.Type.ToStringDisplayable()}";
            }
        }

        /// <summary>
        /// Returns a short string with the chord name.
        /// </summary>
        public string ShortChordName
        {
            get
            {
                return $"{this.RootNote.NoteType.ToStringDisplayable()}{this.Type.ToShortString()}";
            }
        }

        public Note RootNote { get; set; }

        public ModeType Type { get; set; }

        public List<Note> GetNotes()
        {
            List<Note> notes = new List<Note>();

            notes.Add(RootNote);

            if (this.Type == ModeType.Major)
            {
                notes.Add(RootNote.GetNoteThird());
                notes.Add(RootNote.GetNoteFifth());
            }
            else if (this.Type == ModeType.Minor)
            {
                notes.Add(RootNote.GetNoteMinorThird());
                notes.Add(RootNote.GetNoteFifth());
            }
            else { }

            return notes;
        }
    }
}
