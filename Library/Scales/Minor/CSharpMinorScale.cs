using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class CSharpMinorScale : Scale
    {
        public CSharpMinorScale()
        {
            this.ScaleName = "C# Minor scale";

            this.Notes.Add(new Note(NoteType.CSharp));
            this.Notes.Add(new Note(NoteType.DSharp));
            this.Notes.Add(new Note(NoteType.E));
            this.Notes.Add(new Note(NoteType.FSharp));
            this.Notes.Add(new Note(NoteType.GSharp));
            this.Notes.Add(new Note(NoteType.A));
            this.Notes.Add(new Note(NoteType.B));
        }
    }
}
