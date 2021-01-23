
namespace ArmoryManagementSystemFinal
{
    partial class WeaponAdminDetail
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timetbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ownertbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mfacturertbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wnametbox = new System.Windows.Forms.TextBox();
            this.maskedSerial = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.totaltbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.currenttbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ammotbox = new System.Windows.Forms.TextBox();
            this.armoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armoryTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.armoryTableTableAdapter1 = new ArmoryManagementSystemFinal.ArmoryDBDataSet1TableAdapters.ArmoryTableTableAdapter();
            this.armoryTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.armoryDBDataSet12 = new ArmoryManagementSystemFinal.ArmoryDBDataSet1();
            this.armoryDBDataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.armoryDBDataSet2 = new ArmoryManagementSystemFinal.ArmoryDBDataSet();
            this.armoryTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.armoryTableTableAdapter2 = new ArmoryManagementSystemFinal.ArmoryDBDataSetTableAdapters.ArmoryTableTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryDBDataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.timetbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ownertbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mfacturertbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.wnametbox);
            this.groupBox1.Controls.Add(this.maskedSerial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Weapon with User";
            // 
            // timetbox
            // 
            this.timetbox.Location = new System.Drawing.Point(123, 207);
            this.timetbox.Name = "timetbox";
            this.timetbox.Size = new System.Drawing.Size(193, 28);
            this.timetbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time(Hour):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Owner:";
            // 
            // ownertbox
            // 
            this.ownertbox.Location = new System.Drawing.Point(123, 176);
            this.ownertbox.Name = "ownertbox";
            this.ownertbox.Size = new System.Drawing.Size(193, 28);
            this.ownertbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "M.facturer:";
            // 
            // mfacturertbox
            // 
            this.mfacturertbox.Location = new System.Drawing.Point(123, 142);
            this.mfacturertbox.Name = "mfacturertbox";
            this.mfacturertbox.Size = new System.Drawing.Size(193, 28);
            this.mfacturertbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "W. Name:";
            // 
            // wnametbox
            // 
            this.wnametbox.Location = new System.Drawing.Point(123, 108);
            this.wnametbox.Name = "wnametbox";
            this.wnametbox.Size = new System.Drawing.Size(193, 28);
            this.wnametbox.TabIndex = 2;
            // 
            // maskedSerial
            // 
            this.maskedSerial.Location = new System.Drawing.Point(123, 74);
            this.maskedSerial.Mask = "0000";
            this.maskedSerial.Name = "maskedSerial";
            this.maskedSerial.Size = new System.Drawing.Size(193, 28);
            this.maskedSerial.TabIndex = 1;
            this.maskedSerial.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.totaltbox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.currenttbox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ammotbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(358, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 507);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Weapon with User";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "T. Ammo:";
            // 
            // totaltbox
            // 
            this.totaltbox.Location = new System.Drawing.Point(123, 176);
            this.totaltbox.Name = "totaltbox";
            this.totaltbox.Size = new System.Drawing.Size(193, 28);
            this.totaltbox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "C. Ammo:";
            // 
            // currenttbox
            // 
            this.currenttbox.Location = new System.Drawing.Point(123, 142);
            this.currenttbox.Name = "currenttbox";
            this.currenttbox.Size = new System.Drawing.Size(193, 28);
            this.currenttbox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "A. Name:";
            // 
            // ammotbox
            // 
            this.ammotbox.Location = new System.Drawing.Point(123, 108);
            this.ammotbox.Name = "ammotbox";
            this.ammotbox.Size = new System.Drawing.Size(193, 28);
            this.ammotbox.TabIndex = 2;
            // 
            // armoryTableBindingSource
            // 
            this.armoryTableBindingSource.DataMember = "ArmoryTable";
            // 
            // armoryTableBindingSource1
            // 
            this.armoryTableBindingSource1.DataMember = "ArmoryTable";
            // 
            // armoryTableTableAdapter1
            // 
            this.armoryTableTableAdapter1.ClearBeforeFill = true;
            // 
            // armoryTableBindingSource2
            // 
            this.armoryTableBindingSource2.DataMember = "ArmoryTable";
            // 
            // armoryDBDataSet12
            // 
            this.armoryDBDataSet12.DataSetName = "ArmoryDBDataSet1";
            this.armoryDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // armoryDBDataSet12BindingSource
            // 
            this.armoryDBDataSet12BindingSource.DataSource = this.armoryDBDataSet12;
            this.armoryDBDataSet12BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.armoryTableBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(704, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 507);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // armoryDBDataSet2
            // 
            this.armoryDBDataSet2.DataSetName = "ArmoryDBDataSet";
            this.armoryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // armoryTableBindingSource3
            // 
            this.armoryTableBindingSource3.DataMember = "ArmoryTable";
            this.armoryTableBindingSource3.DataSource = this.armoryDBDataSet2;
            // 
            // armoryTableTableAdapter2
            // 
            this.armoryTableTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WeaponSerialID";
            this.dataGridViewTextBoxColumn2.HeaderText = "WeaponSerialID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 139;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WeaponName";
            this.dataGridViewTextBoxColumn3.HeaderText = "WeaponName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WeaponManufacturer";
            this.dataGridViewTextBoxColumn4.HeaderText = "WeaponManufacturer";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "WeaponOwner";
            this.dataGridViewTextBoxColumn5.HeaderText = "WeaponOwner";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AmmoType";
            this.dataGridViewTextBoxColumn6.HeaderText = "AmmoType";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CurrentAmmo";
            this.dataGridViewTextBoxColumn7.HeaderText = "CurrentAmmo";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TotalAmmo";
            this.dataGridViewTextBoxColumn8.HeaderText = "TotalAmmo";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SpentTime";
            this.dataGridViewTextBoxColumn9.HeaderText = "SpentTime";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // WeaponAdminDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WeaponAdminDetail";
            this.Text = "WeaponAdminDetail";
            this.Load += new System.EventHandler(this.WeaponAdminDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryDBDataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armoryTableBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wnametbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ownertbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mfacturertbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totaltbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox currenttbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ammotbox;
        private ArmoryDBDataSet armoryDBDataSet;
        private System.Windows.Forms.BindingSource armoryTableBindingSource;
        private ArmoryDBDataSetTableAdapters.ArmoryTableTableAdapter armoryTableTableAdapter;
        private System.Windows.Forms.TextBox timetbox;
        private ArmoryDBDataSet armoryDBDataSet1;
        private System.Windows.Forms.BindingSource armoryTableBindingSource1;
        private ArmoryDBDataSet1TableAdapters.ArmoryTableTableAdapter armoryTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn spentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource armoryTableBindingSource2;
        private ArmoryDBDataSet1 armoryDBDataSet11;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaponSerialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaponNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaponManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaponOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammoTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentAmmoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmmoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ArmoryDBDataSet1 armoryDBDataSet12;
        private System.Windows.Forms.BindingSource armoryDBDataSet12BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ArmoryDBDataSet armoryDBDataSet2;
        private System.Windows.Forms.BindingSource armoryTableBindingSource3;
        private ArmoryDBDataSetTableAdapters.ArmoryTableTableAdapter armoryTableTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}