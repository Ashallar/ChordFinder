using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales.Modes
{
    public class LocrianScale : Scale
    {
        public LocrianScale(Note rootNote) : base(rootNote)
        {
            this.ScaleName = $"{rootNote.ToString()} locrian scale";

            this.Notes.Add(rootNote);
            this.Notes.Add(rootNote.GetNoteSecondFlat());
            this.Notes.Add(rootNote.GetNoteMinorThird());
            this.Notes.Add(rootNote.GetNoteFourth());
            this.Notes.Add(rootNote.GetNoteDiminishedFifth());
            this.Notes.Add(rootNote.GetNoteAugmentedFifth());
            this.Notes.Add(rootNote.GetNoteMinorSeventh());
        }
    }
}
