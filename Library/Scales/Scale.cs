using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidiControllerProject.Library.Notes;

namespace MidiControllerProject.Library.Scales
{
    public class Scale
    {
        protected Scale()
        {
            this.Notes = new List<Note>();
        }


        public List<Note> Notes { get; set; }

        public bool IsMatchingScale(List<Note> notes)
        {
            return this.Notes.Select(x => x.NoteType).Intersect(notes.Select(x => x.NoteType)).Count() == notes.Count;
        }
    }
}
