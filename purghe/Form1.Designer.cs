using System.Drawing;
using System.Windows.Forms;

namespace purghe
{
    partial class Form1
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
            this.FilePicker = new System.Windows.Forms.OpenFileDialog();
            this.DrawImageButton = new System.Windows.Forms.Button();
            this.BlackScreenButton = new System.Windows.Forms.Button();
            this.CaneDiDioButton = new System.Windows.Forms.Button();
            this.PrintTextButton = new System.Windows.Forms.Button();
            this.PayloadTimedCheck = new System.Windows.Forms.CheckBox();
            this.PayloadDuration = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.KillCodeBlocksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePicker
            // 
            this.FilePicker.Filter = "deve essere un\'immagine|*.*";
            this.FilePicker.Multiselect = true;
            // 
            // DrawImageButton
            // 
            this.DrawImageButton.Location = new System.Drawing.Point(78, 295);
            this.DrawImageButton.Name = "DrawImageButton";
            this.DrawImageButton.Size = new System.Drawing.Size(113, 43);
            this.DrawImageButton.TabIndex = 2;
            this.DrawImageButton.Text = "DISEGNA IMMAGINE";
            this.DrawImageButton.UseVisualStyleBackColor = true;
            this.DrawImageButton.Click += new System.EventHandler(this.DrawImageButton_Click);
            // 
            // BlackScreenButton
            // 
            this.BlackScreenButton.Location = new System.Drawing.Point(261, 295);
            this.BlackScreenButton.Name = "BlackScreenButton";
            this.BlackScreenButton.Size = new System.Drawing.Size(113, 43);
            this.BlackScreenButton.TabIndex = 3;
            this.BlackScreenButton.Text = "SCHERMO NERO";
            this.BlackScreenButton.UseVisualStyleBackColor = true;
            this.BlackScreenButton.Click += new System.EventHandler(this.BlackScreenButtonClick);
            // 
            // CaneDiDioButton
            // 
            this.CaneDiDioButton.Location = new System.Drawing.Point(501, 295);
            this.CaneDiDioButton.Name = "CaneDiDioButton";
            this.CaneDiDioButton.Size = new System.Drawing.Size(113, 43);
            this.CaneDiDioButton.TabIndex = 6;
            this.CaneDiDioButton.Text = "EPILESSIA";
            this.CaneDiDioButton.UseVisualStyleBackColor = true;
            this.CaneDiDioButton.Click += new System.EventHandler(this.EpilepsyButtonClick);
            // 
            // PrintTextButton
            // 
            this.PrintTextButton.Location = new System.Drawing.Point(27, 196);
            this.PrintTextButton.Name = "PrintTextButton";
            this.PrintTextButton.Size = new System.Drawing.Size(155, 48);
            this.PrintTextButton.TabIndex = 7;
            this.PrintTextButton.Text = "TESTO PER NIENTE SUS";
            this.PrintTextButton.UseVisualStyleBackColor = true;
            this.PrintTextButton.Click += new System.EventHandler(this.PrintTextButtonClick);
            // 
            // PayloadTimedCheck
            // 
            this.PayloadTimedCheck.AutoSize = true;
            this.PayloadTimedCheck.Checked = true;
            this.PayloadTimedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PayloadTimedCheck.Location = new System.Drawing.Point(27, 12);
            this.PayloadTimedCheck.Name = "PayloadTimedCheck";
            this.PayloadTimedCheck.Size = new System.Drawing.Size(62, 17);
            this.PayloadTimedCheck.TabIndex = 8;
            this.PayloadTimedCheck.Text = "infinito?";
            this.PayloadTimedCheck.UseVisualStyleBackColor = true;
            this.PayloadTimedCheck.CheckedChanged += new System.EventHandler(this.PayloadTimedCheckChanged);
            // 
            // PayloadDuration
            // 
            this.PayloadDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.PayloadDuration.Location = new System.Drawing.Point(96, 12);
            this.PayloadDuration.Name = "PayloadDuration";
            this.PayloadDuration.Size = new System.Drawing.Size(100, 20);
            this.PayloadDuration.TabIndex = 9;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(95, 46);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(101, 13);
            this.DurationLabel.TabIndex = 10;
            this.DurationLabel.Text = "secondi di siumming";
            // 
            // KillCodeBlocksButton
            // 
            this.KillCodeBlocksButton.Location = new System.Drawing.Point(251, 202);
            this.KillCodeBlocksButton.Name = "KillCodeBlocksButton";
            this.KillCodeBlocksButton.Size = new System.Drawing.Size(164, 36);
            this.KillCodeBlocksButton.TabIndex = 11;
            this.KillCodeBlocksButton.Text = "DISTRUGGI CODEBLOCKS";
            this.KillCodeBlocksButton.UseVisualStyleBackColor = true;
            this.KillCodeBlocksButton.Click += new System.EventHandler(this.KillCodeBlocksButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.KillCodeBlocksButton);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.PayloadDuration);
            this.Controls.Add(this.PayloadTimedCheck);
            this.Controls.Add(this.PrintTextButton);
            this.Controls.Add(this.CaneDiDioButton);
            this.Controls.Add(this.BlackScreenButton);
            this.Controls.Add(this.DrawImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog FilePicker;
        private Button DrawImageButton;
        private Button BlackScreenButton;
        private Button CaneDiDioButton;
        private Button PrintTextButton;
        private CheckBox PayloadTimedCheck;
        private TextBox PayloadDuration;
        private Label DurationLabel;
        private Button KillCodeBlocksButton;
    }
}