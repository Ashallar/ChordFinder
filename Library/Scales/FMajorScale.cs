using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class FMajorScale : Scale
    {
        public FMajorScale()
        {
            this.Notes.Add(new Note("F0", 0));
            this.Notes.Add(new Note("G0", 0));
            this.Notes.Add(new Note("A0", 0));
            this.Notes.Add(new Note("A#0", 0)); //Bb
            this.Notes.Add(new Note("C0", 0));
            this.Notes.Add(new Note("D0", 0));
            this.Notes.Add(new Note("E0", 0));
        }
    }
}
