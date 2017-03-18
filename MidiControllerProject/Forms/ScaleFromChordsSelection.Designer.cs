namespace ApplicationForms.Forms
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
            this.matchingScalesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearChordsButton = new System.Windows.Forms.Button();
            this.selectedChordsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chordTypeComboBox
            // 
            this.chordTypeComboBox.FormattingEnabled = true;
            this.chordTypeComboBox.Items.AddRange(new object[] {
            "Majeur",
            "Mineur",
            "Septième"});
            this.chordTypeComboBox.Location = new System.Drawing.Point(276, 12);
            this.chordTypeComboBox.Name = "chordTypeComboBox";
            this.chordTypeComboBox.Size = new System.Drawing.Size(252, 24);
            this.chordTypeComboBox.TabIndex = 0;
            this.chordTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.chordTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type d\'accord:";
            // 
            // chordSelectorList
            // 
            this.chordSelectorList.Location = new System.Drawing.Point(166, 57);
            this.chordSelectorList.Name = "chordSelectorList";
            this.chordSelectorList.Size = new System.Drawing.Size(1008, 62);
            this.chordSelectorList.TabIndex = 2;
            this.chordSelectorList.UseCompatibleStateImageBehavior = false;
            // 
            // matchingScalesTextBox
            // 
            this.matchingScalesTextBox.Location = new System.Drawing.Point(166, 409);
            this.matchingScalesTextBox.Multiline = true;
            this.matchingScalesTextBox.Name = "matchingScalesTextBox";
            this.matchingScalesTextBox.Size = new System.Drawing.Size(362, 185);
            this.matchingScalesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gammes correspondantes:";
            // 
            // clearChordsButton
            // 
            this.clearChordsButton.Location = new System.Drawing.Point(352, 160);
            this.clearChordsButton.Name = "clearChordsButton";
            this.clearChordsButton.Size = new System.Drawing.Size(176, 23);
            this.clearChordsButton.TabIndex = 5;
            this.clearChordsButton.Text = "Supprimer accords";
            this.clearChordsButton.UseVisualStyleBackColor = true;
            this.clearChordsButton.Click += new System.EventHandler(this.clearChordsButton_Click);
            // 
            // selectedChordsTextBox
            // 
            this.selectedChordsTextBox.Location = new System.Drawing.Point(166, 189);
            this.selectedChordsTextBox.Multiline = true;
            this.selectedChordsTextBox.Name = "selectedChordsTextBox";
            this.selectedChordsTextBox.Size = new System.Drawing.Size(362, 184);
            this.selectedChordsTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Accords sélectionnés:";
            // 
            // ScaleFromChordsSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedChordsTextBox);
            this.Controls.Add(this.clearChordsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matchingScalesTextBox);
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
        private System.Windows.Forms.TextBox matchingScalesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearChordsButton;
        private System.Windows.Forms.TextBox selectedChordsTextBox;
        private System.Windows.Forms.Label label3;
    }
}