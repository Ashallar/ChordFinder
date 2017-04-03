using MidiControllerProject.Library.Notes;
using MidiControllerProject.Library.Scales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales
{
    public class MinorScale : Scale
    {
        public MinorScale(Note rootNote) : base(rootNote)
        {
            this.ScaleName = $"{rootNote.ToString()} minor scale";

            this.Notes.Add(rootNote);
            this.Notes.Add(rootNote.GetNoteSecond());
            this.Notes.Add(rootNote.GetNoteMinorThird());
            this.Notes.Add(rootNote.GetNoteFourth());
            this.Notes.Add(rootNote.GetNoteFifth());
            this.Notes.Add(rootNote.GetNoteAugmentedFifth());
            this.Notes.Add(rootNote.GetNoteMinorSeventh());
        }
    }
}
