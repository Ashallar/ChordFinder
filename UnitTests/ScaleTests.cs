using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiControllerProject.Library.Notes;
using MidiControllerProject.Library.Scales;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class ScaleTests
    {
        [TestMethod]
        public void ScaleTest()
        {
            MajorScale cScale = new MajorScale(new Note(NoteType.C));

            List<Note> notes = new List<Note>();

            notes.Add(new Note("C3", 0));
            notes.Add(new Note("E3", 0));
            notes.Add(new Note("G3", 0));
            notes.Add(new Note("B3", 0));

            Assert.AreEqual(true, cScale.IsMatchingScale(notes));

            notes.Add(new Note("C#3", 0));

            Assert.AreEqual(false, cScale.IsMatchingScale(notes));
        }
    }
}
