﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Chords
{
    public class Chord
    {
        public Chord(Note rootNote, ChordType type)
        {
            if (rootNote == null || type == ChordType.Undefined)
                throw new ArgumentException("The note you provided is null or the type of the ChordType is undefined");

            this.RootNote = rootNote;
            this.Type = type;
        }

        public Note RootNote { get; set; }

        public ChordType Type { get; set; }

        public List<Note> GetNotes()
        {
            List<Note> notes = new List<Note>();

            notes.Add(RootNote);

            if (this.Type == ChordType.Major)
            {
                notes.Add(RootNote.GetNoteMajorThird());
                notes.Add(RootNote.GetNotePerfectFifth());
            }
            else if (this.Type == ChordType.Minor)
            {
                notes.Add(RootNote.GetNoteMinorThird());
                notes.Add(RootNote.GetNotePerfectFifth());
            }
            else { }

            return notes;
        }
    }
}
