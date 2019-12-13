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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProp = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumHostProperties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataGridViewTextBoxColumn1});
            this.dgNeig.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgNeig.Location = new System.Drawing.Point(205, 12);
            this.dgNeig.MultiSelect = false;
            this.dgNeig.Name = "dgNeig";
            this.dgNeig.Size = new System.Drawing.Size(187, 440);
            this.dgNeig.TabIndex = 8;
            this.dgNeig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNeig_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dgProp
            // 
            this.dgProp.AllowUserToAddRows = false;
            this.dgProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.HostID,
            this.hostName,
            this.NumHostProperties,
            this.Latitude,
            this.Longitude,
            this.roomType,
            this.Price,
            this.minNight,
            this.daysAvailable});
            this.dgProp.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgProp.Location = new System.Drawing.Point(398, 12);
            this.dgProp.MultiSelect = false;
            this.dgProp.Name = "dgProp";
            this.dgProp.Size = new System.Drawing.Size(1218, 440);
            this.dgProp.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // HostID
            // 
            this.HostID.HeaderText = "HostID";
            this.HostID.Name = "HostID";
            // 
            // hostName
            // 
            this.hostName.HeaderText = "Host Name";
            this.hostName.Name = "hostName";
            // 
            // NumHostProperties
            // 
            this.NumHostProperties.HeaderText = "Host Properties";
            this.NumHostProperties.Name = "NumHostProperties";
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.Name = "Latitude";
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.Name = "Longitude";
            // 
            // roomType
            // 
            this.roomType.HeaderText = "Room Type";
            this.roomType.Name = "roomType";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // minNight
            // 
            this.minNight.HeaderText = "Min. stay ";
            this.minNight.Name = "minNight";
            // 
            // daysAvailable
            // 
            this.daysAvailable.HeaderText = "Days Available";
            this.daysAvailable.Name = "daysAvailable";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 748);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn distName;
        private System.Windows.Forms.DataGridView dgNeig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumHostProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn minNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysAvailable;
        private System.Windows.Forms.Button button1;
    }
}

