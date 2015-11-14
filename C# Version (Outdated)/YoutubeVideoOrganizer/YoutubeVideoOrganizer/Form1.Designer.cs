namespace YoutubeVideoOrganizer
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
            this.rTBAllChannelNames = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.btnGetVideos = new System.Windows.Forms.Button();
            this.dGVNewVideos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rTBHPChannelNames = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chBDelete1 = new System.Windows.Forms.CheckBox();
            this.btnLoadWebsite1 = new System.Windows.Forms.Button();
            this.btnDeleteRow1 = new System.Windows.Forms.Button();
            this.dGVHPResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chBDelete2 = new System.Windows.Forms.CheckBox();
            this.btnLoadWebsite2 = new System.Windows.Forms.Button();
            this.btnDeleteRow2 = new System.Windows.Forms.Button();
            this.dGVAllResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNewVideos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHPResults)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAllResults)).BeginInit();
            this.SuspendLayout();
            // 
            // rTBAllChannelNames
            // 
            this.rTBAllChannelNames.Location = new System.Drawing.Point(34, 346);
            this.rTBAllChannelNames.Name = "rTBAllChannelNames";
            this.rTBAllChannelNames.Size = new System.Drawing.Size(309, 215);
            this.rTBAllChannelNames.TabIndex = 0;
            this.rTBAllChannelNames.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Channel Names:";
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(128, 582);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(77, 40);
            this.btnUpdateAll.TabIndex = 2;
            this.btnUpdateAll.Text = "Update";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetVideos
            // 
            this.btnGetVideos.Location = new System.Drawing.Point(369, 6);
            this.btnGetVideos.Name = "btnGetVideos";
            this.btnGetVideos.Size = new System.Drawing.Size(82, 40);
            this.btnGetVideos.TabIndex = 3;
            this.btnGetVideos.Text = "Get Videos";
            this.btnGetVideos.UseVisualStyleBackColor = true;
            this.btnGetVideos.Click += new System.EventHandler(this.btnGetVideos_Click);
            // 
            // dGVNewVideos
            // 
            this.dGVNewVideos.AllowUserToAddRows = false;
            this.dGVNewVideos.AllowUserToDeleteRows = false;
            this.dGVNewVideos.AllowUserToResizeColumns = false;
            this.dGVNewVideos.AllowUserToResizeRows = false;
            this.dGVNewVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNewVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dGVNewVideos.Location = new System.Drawing.Point(8, 52);
            this.dGVNewVideos.MultiSelect = false;
            this.dGVNewVideos.Name = "dGVNewVideos";
            this.dGVNewVideos.ReadOnly = true;
            this.dGVNewVideos.RowHeadersVisible = false;
            this.dGVNewVideos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVNewVideos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVNewVideos.Size = new System.Drawing.Size(844, 593);
            this.dGVNewVideos.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Video Title";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Channel";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Duration";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Link";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 280;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 678);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cyan;
            this.tabPage2.Controls.Add(this.dGVNewVideos);
            this.tabPage2.Controls.Add(this.btnGetVideos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Results";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.rTBHPChannelNames);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rTBAllChannelNames);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnUpdateAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Channel Names";
            // 
            // rTBHPChannelNames
            // 
            this.rTBHPChannelNames.Location = new System.Drawing.Point(34, 31);
            this.rTBHPChannelNames.Name = "rTBHPChannelNames";
            this.rTBHPChannelNames.Size = new System.Drawing.Size(309, 215);
            this.rTBHPChannelNames.TabIndex = 3;
            this.rTBHPChannelNames.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "High Priority Channel Names:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.chBDelete1);
            this.tabPage3.Controls.Add(this.btnLoadWebsite1);
            this.tabPage3.Controls.Add(this.btnDeleteRow1);
            this.tabPage3.Controls.Add(this.dGVHPResults);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(861, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "High Priority Results";
            // 
            // chBDelete1
            // 
            this.chBDelete1.AutoSize = true;
            this.chBDelete1.Checked = true;
            this.chBDelete1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBDelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBDelete1.Location = new System.Drawing.Point(376, 3);
            this.chBDelete1.Name = "chBDelete1";
            this.chBDelete1.Size = new System.Drawing.Size(184, 52);
            this.chBDelete1.TabIndex = 9;
            this.chBDelete1.Text = "Delete Row After\r\nWebsite is Loaded";
            this.chBDelete1.UseVisualStyleBackColor = true;
            // 
            // btnLoadWebsite1
            // 
            this.btnLoadWebsite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWebsite1.Location = new System.Drawing.Point(566, 3);
            this.btnLoadWebsite1.Name = "btnLoadWebsite1";
            this.btnLoadWebsite1.Size = new System.Drawing.Size(140, 42);
            this.btnLoadWebsite1.TabIndex = 8;
            this.btnLoadWebsite1.Text = "Load Website";
            this.btnLoadWebsite1.UseVisualStyleBackColor = true;
            this.btnLoadWebsite1.Click += new System.EventHandler(this.btnLoadWebsite1_Click);
            // 
            // btnDeleteRow1
            // 
            this.btnDeleteRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRow1.Location = new System.Drawing.Point(712, 3);
            this.btnDeleteRow1.Name = "btnDeleteRow1";
            this.btnDeleteRow1.Size = new System.Drawing.Size(140, 42);
            this.btnDeleteRow1.TabIndex = 7;
            this.btnDeleteRow1.Text = "Delete Row";
            this.btnDeleteRow1.UseVisualStyleBackColor = true;
            this.btnDeleteRow1.Click += new System.EventHandler(this.btnDeleteRow1_Click);
            // 
            // dGVHPResults
            // 
            this.dGVHPResults.AllowUserToAddRows = false;
            this.dGVHPResults.AllowUserToDeleteRows = false;
            this.dGVHPResults.AllowUserToResizeColumns = false;
            this.dGVHPResults.AllowUserToResizeRows = false;
            this.dGVHPResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHPResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dGVHPResults.Location = new System.Drawing.Point(8, 61);
            this.dGVHPResults.MultiSelect = false;
            this.dGVHPResults.Name = "dGVHPResults";
            this.dGVHPResults.ReadOnly = true;
            this.dGVHPResults.RowHeadersVisible = false;
            this.dGVHPResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVHPResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVHPResults.Size = new System.Drawing.Size(844, 583);
            this.dGVHPResults.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Video Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Channel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Link";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 280;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.chBDelete2);
            this.tabPage4.Controls.Add(this.btnLoadWebsite2);
            this.tabPage4.Controls.Add(this.btnDeleteRow2);
            this.tabPage4.Controls.Add(this.dGVAllResults);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(861, 652);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "All Results";
            // 
            // chBDelete2
            // 
            this.chBDelete2.AutoSize = true;
            this.chBDelete2.Checked = true;
            this.chBDelete2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBDelete2.Location = new System.Drawing.Point(375, 3);
            this.chBDelete2.Name = "chBDelete2";
            this.chBDelete2.Size = new System.Drawing.Size(184, 52);
            this.chBDelete2.TabIndex = 10;
            this.chBDelete2.Text = "Delete Row After\r\nWebsite is Loaded";
            this.chBDelete2.UseVisualStyleBackColor = true;
            // 
            // btnLoadWebsite2
            // 
            this.btnLoadWebsite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWebsite2.Location = new System.Drawing.Point(565, 3);
            this.btnLoadWebsite2.Name = "btnLoadWebsite2";
            this.btnLoadWebsite2.Size = new System.Drawing.Size(140, 42);
            this.btnLoadWebsite2.TabIndex = 7;
            this.btnLoadWebsite2.Text = "Load Website";
            this.btnLoadWebsite2.UseVisualStyleBackColor = true;
            this.btnLoadWebsite2.Click += new System.EventHandler(this.btnLoadWebsite2_Click);
            // 
            // btnDeleteRow2
            // 
            this.btnDeleteRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRow2.Location = new System.Drawing.Point(711, 3);
            this.btnDeleteRow2.Name = "btnDeleteRow2";
            this.btnDeleteRow2.Size = new System.Drawing.Size(140, 42);
            this.btnDeleteRow2.TabIndex = 6;
            this.btnDeleteRow2.Text = "Delete Row";
            this.btnDeleteRow2.UseVisualStyleBackColor = true;
            this.btnDeleteRow2.Click += new System.EventHandler(this.btnDeleteRow2_Click);
            // 
            // dGVAllResults
            // 
            this.dGVAllResults.AllowUserToAddRows = false;
            this.dGVAllResults.AllowUserToDeleteRows = false;
            this.dGVAllResults.AllowUserToResizeColumns = false;
            this.dGVAllResults.AllowUserToResizeRows = false;
            this.dGVAllResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAllResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dGVAllResults.Location = new System.Drawing.Point(8, 61);
            this.dGVAllResults.Name = "dGVAllResults";
            this.dGVAllResults.ReadOnly = true;
            this.dGVAllResults.RowHeadersVisible = false;
            this.dGVAllResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVAllResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVAllResults.Size = new System.Drawing.Size(844, 583);
            this.dGVAllResults.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Video Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Channel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Link";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 280;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 678);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNewVideos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHPResults)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAllResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBAllChannelNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Button btnGetVideos;
        private System.Windows.Forms.DataGridView dGVNewVideos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rTBHPChannelNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dGVHPResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dGVAllResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnDeleteRow2;
        private System.Windows.Forms.Button btnDeleteRow1;
        private System.Windows.Forms.Button btnLoadWebsite1;
        private System.Windows.Forms.Button btnLoadWebsite2;
        private System.Windows.Forms.CheckBox chBDelete1;
        private System.Windows.Forms.CheckBox chBDelete2;
    }
}

