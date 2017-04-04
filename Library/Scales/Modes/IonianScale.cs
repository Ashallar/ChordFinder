using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales.Modes
{
    public class IonianScale : Scale
    {
        public IonianScale(Note rootNote) : base(rootNote)
        {
            this.ScaleName = $"{rootNote.ToString()} ionian scale";

            this.Notes.Add(rootNote);
            this.Notes.Add(rootNote.GetNoteSecond());
            this.Notes.Add(rootNote.GetNoteThird());
            this.Notes.Add(rootNote.GetNoteFourth());
            this.Notes.Add(rootNote.GetNoteFifth());
            this.Notes.Add(rootNote.GetNoteSixth());
            this.Notes.Add(rootNote.GetNoteSeventh());
        }
    }
}
