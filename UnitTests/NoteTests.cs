using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiControllerProject.Library.Notes;

namespace UnitTests
{
    [TestClass]
    public class NoteTests
    {
        [TestMethod]
        public void DetermineHalfToneGap()
        {
            Note a = new Note("C1", 0);
            Note b = new Note("C1", 0);

            Assert.AreEqual(0, a.GetHalfToneGap(b));

            Note c = new Note("E1", 0);
            Note d = new Note("F1", 0);

            Assert.AreEqual(1, c.GetHalfToneGap(d));

            Note e = new Note("E1", 0);
            Note f = new Note("E2", 0);

            Assert.AreEqual(12, e.GetHalfToneGap(f));

            Note g = new Note("C#1", 0);
            Note h = new Note("C1", 0);

            Assert.AreEqual(-1, g.GetHalfToneGap(h));
        }

        [TestMethod]
        public void MajorThird()
        {
            Note a = new Note("C1", 0);
            Note b = new Note("E1", 0);

            Assert.AreEqual(true, a.IsMajorThird(b));

            Note c = new Note("C1", 0);
            Note d = new Note("D#1", 0);

            Assert.AreEqual(false, c.IsMajorThird(d));
        }


        [TestMethod]
        public void MinorThird()
        {
            Note a = new Note("C1", 0);
            Note b = new Note("D#1", 0);

            Assert.AreEqual(true, a.IsMinorThird(b));

            Note c = new Note("C1", 0);
            Note d = new Note("F1", 0);

            Assert.AreEqual(false, c.IsMinorThird(d));
        }

        [TestMethod]
        public void GetNotesFromTonic()
        {
            Note tonic = new Note(NoteType.C);

            Note secondFlat = tonic.GetNoteSecondFlat();
            Note second = tonic.GetNoteSecond();
            Note minorThird = tonic.GetNoteMinorThird();
            Note majorThird = tonic.GetNoteThird();
            Note fourth = tonic.GetNoteFourth();
            Note diminishedFifth = tonic.GetNoteDiminishedFifth();
            Note fifth = tonic.GetNoteFifth();
            Note augmentedFifth = tonic.GetNoteAugmentedFifth();
            Note sixth = tonic.GetNoteSixth();
            Note minorSeventh = tonic.GetNoteMinorSeventh();
            Note seventh = tonic.GetNoteSeventh();

            Assert.AreEqual(0, secondFlat.CompareTo(new Note(NoteType.CSharp)));
            Assert.AreEqual(0, second.CompareTo(new Note(NoteType.D)));
            Assert.AreEqual(0, minorThird.CompareTo(new Note(NoteType.DSharp)));
            Assert.AreEqual(0, majorThird.CompareTo(new Note(NoteType.E)));
            Assert.AreEqual(0, fourth.CompareTo(new Note(NoteType.F)));
            Assert.AreEqual(0, diminishedFifth.CompareTo(new Note(NoteType.FSharp)));
            Assert.AreEqual(0, fifth.CompareTo(new Note(NoteType.G)));
            Assert.AreEqual(0, augmentedFifth.CompareTo(new Note(NoteType.GSharp)));
            Assert.AreEqual(0, sixth.CompareTo(new Note(NoteType.A)));
            Assert.AreEqual(0, minorSeventh.CompareTo(new Note(NoteType.ASharp)));
            Assert.AreEqual(0, seventh.CompareTo(new Note(NoteType.B)));
        }
    }
}
