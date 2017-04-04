using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales.Modes
{
    public class PhrygianScale : Scale
    {
        public PhrygianScale(Note rootNote) : base(rootNote)
        {
            this.ScaleName = $"{rootNote.ToString()} phrygian scale";

            this.Notes.Add(rootNote);
            this.Notes.Add(rootNote.GetNoteSecondFlat());
            this.Notes.Add(rootNote.GetNoteMinorThird());
            this.Notes.Add(rootNote.GetNoteFourth());
            this.Notes.Add(rootNote.GetNoteFifth());
            this.Notes.Add(rootNote.GetNoteAugmentedFifth());
            this.Notes.Add(rootNote.GetNoteMinorSeventh());
        }
    }
}