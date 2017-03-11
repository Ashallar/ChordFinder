using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace Library.Scales
{
    public class CMajorScale
    {
        public CMajorScale()
        {
            this.Notes = new List<Note>();

            this.Notes.Add(new Note("C0", 0));
            this.Notes.Add(new Note("D0", 0));
            this.Notes.Add(new Note("E0", 0));
            this.Notes.Add(new Note("F0", 0));
            this.Notes.Add(new Note("G0", 0));
            this.Notes.Add(new Note("A0", 0));
            this.Notes.Add(new Note("B0", 0));
        }

        public List<Note> Notes { get; set; }
    }
}
