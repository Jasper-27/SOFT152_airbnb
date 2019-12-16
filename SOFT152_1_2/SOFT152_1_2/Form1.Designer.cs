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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.OFDGetData = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.dgDist = new System.Windows.Forms.DataGridView();
            this.distName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNeig = new System.Windows.Forms.DataGridView();
            this.neigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProp = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNeig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(585, 458);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(469, 82);
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
            this.btnOpenFile.Location = new System.Drawing.Point(57, 505);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(98, 54);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Select file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgDist
            // 
            this.dgDist.AllowUserToAddRows = false;
            this.dgDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distName});
            this.dgDist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgDist.Location = new System.Drawing.Point(12, 12);
            this.dgDist.MultiSelect = false;
            this.dgDist.Name = "dgDist";
            this.dgDist.Size = new System.Drawing.Size(187, 440);
            this.dgDist.TabIndex = 7;
            this.dgDist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDist_CellContentClick);
            // 
            // distName
            // 
            this.distName.HeaderText = "Name";
            this.distName.Name = "distName";
            // 
            // dgNeig
            // 
            this.dgNeig.AllowUserToAddRows = false;
            this.dgNeig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNeig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.neigName});
            this.dgNeig.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgNeig.Location = new System.Drawing.Point(205, 12);
            this.dgNeig.MultiSelect = false;
            this.dgNeig.Name = "dgNeig";
            this.dgNeig.Size = new System.Drawing.Size(187, 440);
            this.dgNeig.TabIndex = 8;
            this.dgNeig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNeig_CellContentClick);
            // 
            // neigName
            // 
            this.neigName.HeaderText = "Name";
            this.neigName.Name = "neigName";
            // 
            // dgProp
            // 
            this.dgProp.AllowUserToAddRows = false;
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
            this.dgProp.Location = new System.Drawing.Point(398, 12);
            this.dgProp.MultiSelect = false;
            this.dgProp.Name = "dgProp";
            this.dgProp.Size = new System.Drawing.Size(1218, 440);
            this.dgProp.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 521);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "read";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 748);
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
            this.ResumeLayout(false);

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
    }
}

