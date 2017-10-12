namespace MovieLib.Windows {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItemMovies = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripMenuItemFile,
            this._toolStripMenuItemMovies,
            this._toolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "&File";
            // 
            // _toolStripMenuItemFile
            // 
            this._toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._childItemExit});
            this._toolStripMenuItemFile.Name = "_toolStripMenuItemFile";
            this._toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this._toolStripMenuItemFile.Text = "&File";
            // 
            // _childItemExit
            // 
            this._childItemExit.Name = "_childItemExit";
            this._childItemExit.Size = new System.Drawing.Size(92, 22);
            this._childItemExit.Text = "E&xit";
            this._childItemExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // _toolStripMenuItemMovies
            // 
            this._toolStripMenuItemMovies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._childItemAdd,
            this._childItemDelete,
            this._childItemEdit});
            this._toolStripMenuItemMovies.Name = "_toolStripMenuItemMovies";
            this._toolStripMenuItemMovies.Size = new System.Drawing.Size(57, 20);
            this._toolStripMenuItemMovies.Text = "&Movies";
            // 
            // _childItemAdd
            // 
            this._childItemAdd.Name = "_childItemAdd";
            this._childItemAdd.Size = new System.Drawing.Size(152, 22);
            this._childItemAdd.Text = "&Add";
            this._childItemAdd.Click += new System.EventHandler(this.OnMovieAdd);
            // 
            // _childItemDelete
            // 
            this._childItemDelete.Name = "_childItemDelete";
            this._childItemDelete.Size = new System.Drawing.Size(152, 22);
            this._childItemDelete.Text = "&Delete";
            // 
            // _childItemEdit
            // 
            this._childItemEdit.Name = "_childItemEdit";
            this._childItemEdit.Size = new System.Drawing.Size(152, 22);
            this._childItemEdit.Text = "&Edit";
            this._childItemEdit.Click += new System.EventHandler(this.OnMovieEdit);
            // 
            // _toolStripMenuItemHelp
            // 
            this._toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._childItemAbout});
            this._toolStripMenuItemHelp.Name = "_toolStripMenuItemHelp";
            this._toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this._toolStripMenuItemHelp.Text = "&Help";
            // 
            // _childItemAbout
            // 
            this._childItemAbout.Name = "_childItemAbout";
            this._childItemAbout.Size = new System.Drawing.Size(107, 22);
            this._childItemAbout.Text = "&About";
            this._childItemAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Movie Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem _childItemExit;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemMovies;
        private System.Windows.Forms.ToolStripMenuItem _childItemAdd;
        private System.Windows.Forms.ToolStripMenuItem _childItemEdit;
        private System.Windows.Forms.ToolStripMenuItem _childItemDelete;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem _childItemAbout;
    }
}

