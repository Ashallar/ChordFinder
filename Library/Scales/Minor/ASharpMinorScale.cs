using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class ASharpMinorScale : Scale
    {
        public ASharpMinorScale()
        {
            this.ScaleName = "A# Minor scale";

            this.Notes.Add(new Note(NoteType.ASharp));
            this.Notes.Add(new Note(NoteType.C));
            this.Notes.Add(new Note(NoteType.CSharp));
            this.Notes.Add(new Note(NoteType.DSharp));
            this.Notes.Add(new Note(NoteType.F));
            this.Notes.Add(new Note(NoteType.FSharp));
            this.Notes.Add(new Note(NoteType.GSharp));
        }
    }
}
