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

            Assert.AreEqual(a.GetHalfToneGap(b), 0);

            Note c = new Note("E1", 0);
            Note d = new Note("F1", 0);

            Assert.AreEqual(c.GetHalfToneGap(d), 1);

            Note e = new Note("E1", 0);
            Note f = new Note("E2", 0);

            Assert.AreEqual(e.GetHalfToneGap(f), 12);

            Note g = new Note("C#1", 0);
            Note h = new Note("C1", 0);

            Assert.AreEqual(g.GetHalfToneGap(h), -1);
        }
    }
}
