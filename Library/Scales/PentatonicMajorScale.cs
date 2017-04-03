using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales
{
    public class PentatonicMajorScale : Scale
    {
        public PentatonicMajorScale(Note rootNote) : base(rootNote)
        {
            this.ScaleName = $"{rootNote.ToString()} pentatonic major scale";

            this.Notes.Add(rootNote);
            this.Notes.Add(rootNote.GetNoteSecond());
            this.Notes.Add(rootNote.GetNoteThird());
            this.Notes.Add(rootNote.GetNoteFifth());
            this.Notes.Add(rootNote.GetNoteSixth());
        }
    }
}
