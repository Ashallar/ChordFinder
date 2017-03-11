using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Midi;
using NAudio.CoreAudioApi.Interfaces;
using NAudio.Wave;
using MidiControllerProject.Library.Notes;
using MidiControllerProject.Library.Chords;

namespace ApplicationForms
{
    public partial class Form1 : Form
    {
        private int count = 0;

        private ChordFinder chordFinder;

        public Form1()
        {
            this.chordFinder = new ChordFinder();

            InitializeComponent();
            StartMonitoringMidi();
        }

        private void StartMonitoringMidi()
        {
            string[] drivers = AsioOut.GetDriverNames();

            MidiIn midi = new MidiIn(0);
            midi.MessageReceived += Midi_MessageReceived;
            midi.Start();
        }

        private void Midi_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            NoteEvent noteEvent = e.MidiEvent as NoteEvent;
            if (noteEvent != null)
            {
                count++;
                Note note = new Note(noteEvent.NoteName, noteEvent.Velocity);
                AddMessageToEventLogBox($"{count} - {note.NoteType.ToStringDisplayable()}{note.Octave.ToString()} Vel:{note.Velocity}{Environment.NewLine}");
                UpdateKeyboardImage(note);

                if (note.Velocity > 0)
                {
                    this.chordFinder.Notes.TryAdd(note.GetNoteIdentifier(), note);
                }
                else
                {
                    Note removedNote;
                    this.chordFinder.Notes.TryRemove(note.GetNoteIdentifier(), out removedNote);
                }
             }
        }



        /// <summary>
        /// Adds a message to the eventlogBox
        /// </summary>
        /// <param name="message">Message to add to eventLog</param>
        private void AddMessageToEventLogBox(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate { AddMessageToEventLogBox(message); });
                return;
            }
            eventlogBox.Items.Insert(0, message);
            if (eventlogBox.Items.Count > 100)
            {
                eventlogBox.Items.RemoveAt(eventlogBox.Items.Count - 1);
            }
        }

        private void UpdateKeyboardImage(Note note)
        {
            Button toUpdate = GetKeyboardNoteToUpdate(note);
            if (toUpdate != null)
            {
                if (InvokeRequired)
                {
                    BeginInvoke((MethodInvoker)delegate { UpdateKeyboardImage(note); });
                    return;
                }
                if (note.Velocity == 0)
                {
                    toUpdate.BackColor = Color.White;
                }
                else
                {
                    toUpdate.BackColor = Color.Red;
                }
            }
        }

        private Button GetKeyboardNoteToUpdate(Note note)
        {
            if (note.NoteType == NoteType.C && note.Octave == 3)
                return C3;
            if (note.NoteType == NoteType.CSharp && note.Octave == 3)
                return CS3;
            if (note.NoteType == NoteType.D && note.Octave == 3)
                return D3;
            if (note.NoteType == NoteType.DSharp && note.Octave == 3)
                return DS3;
            if (note.NoteType == NoteType.E && note.Octave == 3)
                return E3;
            if (note.NoteType == NoteType.F && note.Octave == 3)
                return F3;
            if (note.NoteType == NoteType.FSharp && note.Octave == 3)
                return FS3;
            if (note.NoteType == NoteType.G && note.Octave == 3)
                return G3;
            if (note.NoteType == NoteType.GSharp && note.Octave == 3)
                return GS3;
            if (note.NoteType == NoteType.A && note.Octave == 3)
                return A3;
            if (note.NoteType == NoteType.ASharp && note.Octave == 3)
                return AS3;
            if (note.NoteType == NoteType.B && note.Octave == 3)
                return B3;

            return null;
        }
    }
}
