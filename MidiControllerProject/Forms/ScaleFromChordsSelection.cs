using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MidiControllerProject.Library.Chords;
using MidiControllerProject.Library.Notes;
using MidiControllerProject.Library.Scales;
using System.ComponentModel;

namespace ApplicationForms.Forms
{
    public partial class ScaleFromChordsSelection : Form
    {

        /// <summary>
        /// The list of selected chords.
        /// </summary>
        public BindingList<Chord> Chords { get; }

        /// <summary>
        /// The list of matching scales.
        /// </summary>
        public BindingList<Scale> MatchingScales { get; }

        public ScaleFromChordsSelection()
        {
            InitializeComponent();
            this.Chords = new BindingList<Chord>();
            this.MatchingScales = new BindingList<Scale>();

            chordSelectorList.ItemSelectionChanged += ChordSelectorList_ItemSelectionChanged;

            selectedChordsListBox.DataSource = this.Chords;
            selectedChordsListBox.SelectedValueChanged += SelectedChordsListBox_SelectedValueChanged;
            selectedChordsListBox.DisplayMember = "ChordName";
            selectedChordsListBox.ValueMember = "ChordName";

            matchingScalesListBox.DataSource = this.MatchingScales;
            matchingScalesListBox.DisplayMember = "ScaleName";
            matchingScalesListBox.ValueMember = "ScaleName";

            chordTypeComboBox.DataSource = Enum.GetNames(typeof(ModeType)).Skip(1).ToList();
            populateListFromSelectedChordType(ModeType.Major);
        }


        /* EVENTS */

        private void SelectedChordsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Chord chord = (Chord)selectedChordsListBox.SelectedItem;
            if (chord != null)
            {
                this.Chords.Remove(chord);
            }
            DetermineScaleFromNotes();
        }

        private void chordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeType type = (ModeType)Enum.Parse(typeof(ModeType), chordTypeComboBox.SelectedValue.ToString());

            populateListFromSelectedChordType(type);
        }

        private void ChordSelectorList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ModeType type = (ModeType)Enum.Parse(typeof(ModeType), chordTypeComboBox.SelectedValue.ToString());

                if (type == ModeType.Major)
                {
                    this.Chords.Add(new Chord(new Note(e.Item.Text + "0", 0), type));

                }
                else if (type == ModeType.Minor)
                {
                    switch (e.Item.Text)
                    {
                        case "Cm":
                            this.Chords.Add(new Chord(new Note("C0", 0), type));
                            break;
                        case "C#m":
                            this.Chords.Add(new Chord(new Note("C#0", 0), type));
                            break;
                        case "Dm":
                            this.Chords.Add(new Chord(new Note("D0", 0), type));
                            break;
                        case "D#m":
                            this.Chords.Add(new Chord(new Note("D#0", 0), type));
                            break;
                        case "Em":
                            this.Chords.Add(new Chord(new Note("E0", 0), type));
                            break;
                        case "Fm":
                            this.Chords.Add(new Chord(new Note("F0", 0), type));
                            break;
                        case "F#m":
                            this.Chords.Add(new Chord(new Note("F#0", 0), type));
                            break;
                        case "Gm":
                            this.Chords.Add(new Chord(new Note("G0", 0), type));
                            break;
                        case "G#m":
                            this.Chords.Add(new Chord(new Note("G#0", 0), type));
                            break;
                        case "Am":
                            this.Chords.Add(new Chord(new Note("A0", 0), type));
                            break;
                        case "A#m":
                            this.Chords.Add(new Chord(new Note("A#0", 0), type));
                            break;
                        case "Bm":
                            this.Chords.Add(new Chord(new Note("B0", 0), type));
                            break;
                    }
                }
                else
                {
                    return;
                }
                DetermineScaleFromNotes();
            }
        }


        /* PRIVATE FUNCTIONS */

        private void populateListFromSelectedChordType(ModeType type)
        {
            chordSelectorList.Items.Clear();

            if (type == ModeType.Major)
            {
                chordSelectorList.Items.Add(new ListViewItem("C"));
                chordSelectorList.Items.Add(new ListViewItem("C#"));
                chordSelectorList.Items.Add(new ListViewItem("D"));
                chordSelectorList.Items.Add(new ListViewItem("D#"));
                chordSelectorList.Items.Add(new ListViewItem("E"));
                chordSelectorList.Items.Add(new ListViewItem("F"));
                chordSelectorList.Items.Add(new ListViewItem("F#"));
                chordSelectorList.Items.Add(new ListViewItem("G"));
                chordSelectorList.Items.Add(new ListViewItem("G#"));
                chordSelectorList.Items.Add(new ListViewItem("A"));
                chordSelectorList.Items.Add(new ListViewItem("A#"));
                chordSelectorList.Items.Add(new ListViewItem("B"));
            }
            else
            {
                chordSelectorList.Items.Add(new ListViewItem("Cm"));
                chordSelectorList.Items.Add(new ListViewItem("C#m"));
                chordSelectorList.Items.Add(new ListViewItem("Dm"));
                chordSelectorList.Items.Add(new ListViewItem("D#m"));
                chordSelectorList.Items.Add(new ListViewItem("Em"));
                chordSelectorList.Items.Add(new ListViewItem("Fm"));
                chordSelectorList.Items.Add(new ListViewItem("F#m"));
                chordSelectorList.Items.Add(new ListViewItem("Gm"));
                chordSelectorList.Items.Add(new ListViewItem("G#m"));
                chordSelectorList.Items.Add(new ListViewItem("Am"));
                chordSelectorList.Items.Add(new ListViewItem("A#m"));
                chordSelectorList.Items.Add(new ListViewItem("Bm"));
            }
        }

        private List<Note> GetDistinctNotesFromChordList()
        {
            List<Note> notes = new List<Note>();

            foreach (Chord chord in this.Chords)
            {
                notes = notes.Concat(chord.GetNotes()).ToList();
            }
            return notes.GroupBy(x => x.NoteType).Select(x => x.First()).ToList();
        }

        private void DetermineScaleFromNotes()
        {
            List<Note> distinctNotes = GetDistinctNotesFromChordList();

            List<Scale> matchingScales = ScalesBook.GetMatchingScales(distinctNotes);
            this.MatchingScales.Clear();
            foreach (Scale scale in matchingScales)
            {
                this.MatchingScales.Add(scale);
            }
        }

        private void clearChordsButton_Click(object sender, EventArgs e)
        {
            this.Chords.Clear();
            this.MatchingScales.Clear();
        }
    }
}
