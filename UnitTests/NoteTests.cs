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
    }
}
