using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiControllerProject.Library.Notes;
using MidiControllerProject.Library.Chords;

namespace UnitTests
{
    [TestClass]
    public class ChordFinderTests
    {
        [TestMethod]
        public void CompareNotes_DifferentOctaves()
        {
            Note highNote = new Note("C3", 0);
            Note lowNote = new Note("C1", 0);

            ChordFinder finder = new ChordFinder();

            finder.Notes.TryAdd(highNote.GetNoteIdentifier(), highNote);
            finder.Notes.TryAdd(lowNote.GetNoteIdentifier(), lowNote);

            Assert.AreSame(finder.GetHighestNote(), highNote);
            Assert.AreSame(finder.GetLowestNote(), lowNote);
        }

        [TestMethod]
        public void CompareNotes_SameOctaves()
        {
            Note highNote = new Note("C#3", 0);
            Note lowNote = new Note("C3", 0);

            ChordFinder finder = new ChordFinder();

            finder.Notes.TryAdd(highNote.GetNoteIdentifier(), highNote);
            finder.Notes.TryAdd(lowNote.GetNoteIdentifier(), lowNote);

            Assert.AreSame(finder.GetHighestNote(), highNote);
            Assert.AreSame(finder.GetLowestNote(), lowNote);
        }
    }
}
