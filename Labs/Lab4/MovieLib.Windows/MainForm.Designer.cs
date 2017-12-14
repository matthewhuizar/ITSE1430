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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._bsMovies = new System.Windows.Forms.BindingSource(this.components);
            this._toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItemMovies = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._childItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._gridMovies = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOwnedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._bsMovies)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // _bsMovies
            // 
            this._bsMovies.AllowNew = false;
            this._bsMovies.DataSource = typeof(MovieLib.Movie);
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
            this._childItemAdd.Size = new System.Drawing.Size(107, 22);
            this._childItemAdd.Text = "&Add";
            this._childItemAdd.Click += new System.EventHandler(this.OnMovieAdd);
            // 
            // _childItemDelete
            // 
            this._childItemDelete.Name = "_childItemDelete";
            this._childItemDelete.Size = new System.Drawing.Size(107, 22);
            this._childItemDelete.Text = "&Delete";
            this._childItemDelete.Click += new System.EventHandler(this.OnMovieDelete);
            // 
            // _childItemEdit
            // 
            this._childItemEdit.Name = "_childItemEdit";
            this._childItemEdit.Size = new System.Drawing.Size(107, 22);
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
            // _gridMovies
            // 
            this._gridMovies.AllowUserToAddRows = false;
            this._gridMovies.AllowUserToDeleteRows = false;
            this._gridMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._gridMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._gridMovies.AutoGenerateColumns = false;
            this._gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.isOwnedDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this._gridMovies.DataSource = this._bsMovies;
            this._gridMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridMovies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._gridMovies.Location = new System.Drawing.Point(0, 24);
            this._gridMovies.Name = "_gridMovies";
            this._gridMovies.ReadOnly = true;
            this._gridMovies.RowHeadersVisible = false;
            this._gridMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._gridMovies.Size = new System.Drawing.Size(684, 337);
            this._gridMovies.TabIndex = 1;
            this._gridMovies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEditRow);
            this._gridMovies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownGrid);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 300F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 300F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.FillWeight = 300F;
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // isOwnedDataGridViewCheckBoxColumn
            // 
            this.isOwnedDataGridViewCheckBoxColumn.DataPropertyName = "IsOwned";
            this.isOwnedDataGridViewCheckBoxColumn.HeaderText = "IsOwned?";
            this.isOwnedDataGridViewCheckBoxColumn.MinimumWidth = 50;
            this.isOwnedDataGridViewCheckBoxColumn.Name = "isOwnedDataGridViewCheckBoxColumn";
            this.isOwnedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isOwnedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this._gridMovies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Movie Library";
            ((System.ComponentModel.ISupportInitialize)(this._bsMovies)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource _bsMovies;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem _childItemExit;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemMovies;
        private System.Windows.Forms.ToolStripMenuItem _childItemAdd;
        private System.Windows.Forms.ToolStripMenuItem _childItemDelete;
        private System.Windows.Forms.ToolStripMenuItem _childItemEdit;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem _childItemAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView _gridMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOwnedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

