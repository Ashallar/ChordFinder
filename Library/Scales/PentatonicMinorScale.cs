using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales
{
    public class PentatonicMinorScale : Scale
    {
        public PentatonicMinorScale(Note rootNote) : base(rootNote)
        {
            this.ScaleName = $"{rootNote.ToString()} pentatonic minor scale";

            this.Notes.Add(rootNote);
            this.Notes.Add(rootNote.GetNoteMinorThird());
            this.Notes.Add(rootNote.GetNoteFourth());
            this.Notes.Add(rootNote.GetNoteFifth());
            this.Notes.Add(rootNote.GetNoteMinorSeventh());
        }
    }
}
