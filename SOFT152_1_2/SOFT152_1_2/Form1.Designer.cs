namespace SOFT152_1_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.OFDGetData = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.dgDist = new System.Windows.Forms.DataGridView();
            this.distName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNeig = new System.Windows.Forms.DataGridView();
            this.neigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProp = new System.Windows.Forms.DataGridView();
            this.propID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propHostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propHostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propHostProperties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propMinNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propDaysAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdbFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnAddNeig = new System.Windows.Forms.Button();
            this.btnAddDist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNeig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1455, 362);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 91);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // OFDGetData
            // 
            this.OFDGetData.FileName = "data";
            this.OFDGetData.Filter = "Text files (*.txt)|*.txt";
            this.OFDGetData.InitialDirectory = "/";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(1455, 276);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(149, 86);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // dgDist
            // 
            this.dgDist.AllowUserToAddRows = false;
            this.dgDist.AllowUserToDeleteRows = false;
            this.dgDist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDist.BackgroundColor = System.Drawing.Color.White;
            this.dgDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distName});
            this.dgDist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgDist.Location = new System.Drawing.Point(29, 184);
            this.dgDist.MultiSelect = false;
            this.dgDist.Name = "dgDist";
            this.dgDist.Size = new System.Drawing.Size(157, 269);
            this.dgDist.TabIndex = 7;
            this.dgDist.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDist_RowEnter);
            // 
            // distName
            // 
            this.distName.HeaderText = "Name";
            this.distName.Name = "distName";
            // 
            // dgNeig
            // 
            this.dgNeig.AllowUserToAddRows = false;
            this.dgNeig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNeig.BackgroundColor = System.Drawing.Color.White;
            this.dgNeig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNeig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.neigName});
            this.dgNeig.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgNeig.Location = new System.Drawing.Point(29, 517);
            this.dgNeig.MultiSelect = false;
            this.dgNeig.Name = "dgNeig";
            this.dgNeig.Size = new System.Drawing.Size(157, 319);
            this.dgNeig.TabIndex = 8;
            this.dgNeig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNeig_CellContentClick);
            this.dgNeig.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNeig_RowEnter);
            // 
            // neigName
            // 
            this.neigName.HeaderText = "Name";
            this.neigName.Name = "neigName";
            // 
            // dgProp
            // 
            this.dgProp.AllowUserToAddRows = false;
            this.dgProp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propID,
            this.propName,
            this.propHostID,
            this.propHostName,
            this.propHostProperties,
            this.propLatitude,
            this.propLongitude,
            this.propRoomType,
            this.propPrice,
            this.propMinNight,
            this.propDaysAvailable});
            this.dgProp.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgProp.Location = new System.Drawing.Point(243, 184);
            this.dgProp.MultiSelect = false;
            this.dgProp.Name = "dgProp";
            this.dgProp.Size = new System.Drawing.Size(1145, 619);
            this.dgProp.TabIndex = 9;
            // 
            // propID
            // 
            this.propID.HeaderText = "ID";
            this.propID.Name = "propID";
            // 
            // propName
            // 
            this.propName.HeaderText = "Name";
            this.propName.Name = "propName";
            // 
            // propHostID
            // 
            this.propHostID.HeaderText = "HostID";
            this.propHostID.Name = "propHostID";
            // 
            // propHostName
            // 
            this.propHostName.HeaderText = "Host Name";
            this.propHostName.Name = "propHostName";
            // 
            // propHostProperties
            // 
            this.propHostProperties.HeaderText = "Host Properties";
            this.propHostProperties.Name = "propHostProperties";
            // 
            // propLatitude
            // 
            this.propLatitude.HeaderText = "Latitude";
            this.propLatitude.Name = "propLatitude";
            // 
            // propLongitude
            // 
            this.propLongitude.HeaderText = "Longitude";
            this.propLongitude.Name = "propLongitude";
            // 
            // propRoomType
            // 
            this.propRoomType.HeaderText = "Room Type";
            this.propRoomType.Name = "propRoomType";
            // 
            // propPrice
            // 
            this.propPrice.HeaderText = "Price";
            this.propPrice.Name = "propPrice";
            // 
            // propMinNight
            // 
            this.propMinNight.HeaderText = "Min. stay ";
            this.propMinNight.Name = "propMinNight";
            // 
            // propDaysAvailable
            // 
            this.propDaysAvailable.HeaderText = "Days Available";
            this.propDaysAvailable.Name = "propDaysAvailable";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1455, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 98);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Districts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Neighbourhoods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Properties";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2949, 117);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdbFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1658, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdbFile
            // 
            this.tsdbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.tsdbFile.Image = ((System.Drawing.Image)(resources.GetObject("tsdbFile.Image")));
            this.tsdbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbFile.Name = "tsdbFile";
            this.tsdbFile.Size = new System.Drawing.Size(41, 22);
            this.tsdbFile.Text = "File.";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(243, 802);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(1145, 34);
            this.btnAddProperty.TabIndex = 16;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnAddNeig
            // 
            this.btnAddNeig.Location = new System.Drawing.Point(29, 835);
            this.btnAddNeig.Name = "btnAddNeig";
            this.btnAddNeig.Size = new System.Drawing.Size(157, 34);
            this.btnAddNeig.TabIndex = 17;
            this.btnAddNeig.Text = "Add Neighbourhood";
            this.btnAddNeig.UseVisualStyleBackColor = true;
            this.btnAddNeig.Click += new System.EventHandler(this.btnAddNeig_Click);
            // 
            // btnAddDist
            // 
            this.btnAddDist.Location = new System.Drawing.Point(29, 452);
            this.btnAddDist.Name = "btnAddDist";
            this.btnAddDist.Size = new System.Drawing.Size(157, 34);
            this.btnAddDist.TabIndex = 18;
            this.btnAddDist.Text = "Add District";
            this.btnAddDist.UseVisualStyleBackColor = true;
            this.btnAddDist.Click += new System.EventHandler(this.btnAddDist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 881);
            this.Controls.Add(this.btnAddDist);
            this.Controls.Add(this.btnAddNeig);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgProp);
            this.Controls.Add(this.dgNeig);
            this.Controls.Add(this.dgDist);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnRefresh);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNeig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.OpenFileDialog OFDGetData;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataGridView dgDist;
        private System.Windows.Forms.DataGridView dgNeig;
        private System.Windows.Forms.DataGridView dgProp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn distName;
        private System.Windows.Forms.DataGridViewTextBoxColumn neigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn propID;
        private System.Windows.Forms.DataGridViewTextBoxColumn propName;
        private System.Windows.Forms.DataGridViewTextBoxColumn propHostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn propHostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn propHostProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn propLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn propLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn propRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn propPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn propMinNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn propDaysAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsdbFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnAddNeig;
        private System.Windows.Forms.Button btnAddDist;
    }
}

