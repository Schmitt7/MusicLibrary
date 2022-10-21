
namespace MusicLibrary
{
    partial class frmDisplay
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
            this.lvMusic = new System.Windows.Forms.ListView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtBand = new System.Windows.Forms.TextBox();
            this.lblBand = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvMusic
            // 
            this.lvMusic.FullRowSelect = true;
            this.lvMusic.GridLines = true;
            this.lvMusic.HideSelection = false;
            this.lvMusic.Location = new System.Drawing.Point(23, 27);
            this.lvMusic.Name = "lvMusic";
            this.lvMusic.Size = new System.Drawing.Size(1115, 525);
            this.lvMusic.TabIndex = 0;
            this.lvMusic.UseCompatibleStateImageBehavior = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(939, 561);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(161, 48);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(18, 601);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(156, 25);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter Choices: ";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(231, 573);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 25);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // txtBand
            // 
            this.txtBand.Location = new System.Drawing.Point(420, 601);
            this.txtBand.Name = "txtBand";
            this.txtBand.Size = new System.Drawing.Size(157, 31);
            this.txtBand.TabIndex = 5;
            // 
            // lblBand
            // 
            this.lblBand.AutoSize = true;
            this.lblBand.Location = new System.Drawing.Point(471, 573);
            this.lblBand.Name = "lblBand";
            this.lblBand.Size = new System.Drawing.Size(61, 25);
            this.lblBand.TabIndex = 6;
            this.lblBand.Text = "Artist";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(658, 601);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 31);
            this.txtName.TabIndex = 7;
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(668, 573);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(124, 25);
            this.lblSongName.TabIndex = 8;
            this.lblSongName.Text = "Song Name";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(939, 624);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(161, 48);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo Filter";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(201, 602);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(135, 31);
            this.txtGenre.TabIndex = 10;
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 707);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.txtBand);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lvMusic);
            this.Name = "frmDisplay";
            this.Text = "LibraryDisplay";
            this.Load += new System.EventHandler(this.frmDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusic;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtBand;
        private System.Windows.Forms.Label lblBand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TextBox txtGenre;
    }
}