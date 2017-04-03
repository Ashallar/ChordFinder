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
        protected Scale(Note rootNote)
        {
            this.RootNote = rootNote;
            this.Notes = new List<Note>();
        }

        /// <summary>
        /// The scale root note.
        /// </summary>
        public Note RootNote { get; set; }

        /// <summary>
        /// The notes composing the scale.
        /// </summary>
        public List<Note> Notes { get; }

        /// <summary>
        /// The name of the scale.
        /// </summary>
        public string ScaleName { get; set; }

        /// <summary>
        /// Whether or not the note in the list are matching the scale.
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        public bool IsMatchingScale(List<Note> notes)
        {
            return this.Notes.Select(x => x.NoteType).Intersect(notes.Select(x => x.NoteType)).Count() == notes.Count;
        }
    }
}
