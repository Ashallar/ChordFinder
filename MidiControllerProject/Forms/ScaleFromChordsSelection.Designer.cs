﻿namespace ApplicationForms.Forms
{
    partial class ScaleFromChordsSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chordTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chordSelectorList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // chordTypeComboBox
            // 
            this.chordTypeComboBox.FormattingEnabled = true;
            this.chordTypeComboBox.Items.AddRange(new object[] {
            "Majeur",
            "Mineur",
            "Septième"});
            this.chordTypeComboBox.Location = new System.Drawing.Point(276, 58);
            this.chordTypeComboBox.Name = "chordTypeComboBox";
            this.chordTypeComboBox.Size = new System.Drawing.Size(252, 24);
            this.chordTypeComboBox.TabIndex = 0;
            this.chordTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.chordTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type d\'accord:";
            // 
            // chordSelectorList
            // 
            this.chordSelectorList.Location = new System.Drawing.Point(166, 127);
            this.chordSelectorList.Name = "chordSelectorList";
            this.chordSelectorList.Size = new System.Drawing.Size(1008, 88);
            this.chordSelectorList.TabIndex = 2;
            this.chordSelectorList.UseCompatibleStateImageBehavior = false;
            // 
            // ScaleFromChordsSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.chordSelectorList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chordTypeComboBox);
            this.Name = "ScaleFromChordsSelection";
            this.Text = "ScaleFromChordsSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chordTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView chordSelectorList;
    }
}