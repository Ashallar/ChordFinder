using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Chords;

namespace ApplicationForms.Forms
{
    public partial class ScaleFromChordsSelection : Form
    {
        public ScaleFromChordsSelection()
        {
            InitializeComponent();

            chordTypeComboBox.DataSource = Enum.GetNames(typeof(ChordType)).Skip(1).ToList();
            populateListFromSelectedChordType(ChordType.Major);
        }


        /* EVENTS */

        private void chordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChordType type = (ChordType)Enum.Parse(typeof(ChordType), chordTypeComboBox.SelectedValue.ToString());
        }


        private void populateListFromSelectedChordType(ChordType type)
        {
            //todo:
        }
    }
}
