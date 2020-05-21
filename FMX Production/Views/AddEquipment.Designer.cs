namespace FMX_Production.Views
{
    partial class AddEquipment
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
            this.lbEquipment = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbCamera = new System.Windows.Forms.RadioButton();
            this.rbFlycam = new System.Windows.Forms.RadioButton();
            this.rbDron = new System.Windows.Forms.RadioButton();
            this.rbKran = new System.Windows.Forms.RadioButton();
            this.rbAparat = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.chB4k = new System.Windows.Forms.CheckBox();
            this.chBhd = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLensSerial = new System.Windows.Forms.TextBox();
            this.cbCameraId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.lbCameras1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbEquipment
            // 
            this.lbEquipment.FormattingEnabled = true;
            this.lbEquipment.ItemHeight = 16;
            this.lbEquipment.Location = new System.Drawing.Point(12, 324);
            this.lbEquipment.Name = "lbEquipment";
            this.lbEquipment.Size = new System.Drawing.Size(296, 324);
            this.lbEquipment.TabIndex = 6;
            this.lbEquipment.DoubleClick += new System.EventHandler(this.lbEquipment_DoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 664);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 51);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anulo";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbCamera
            // 
            this.rbCamera.AutoSize = true;
            this.rbCamera.Checked = true;
            this.rbCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCamera.Location = new System.Drawing.Point(23, 34);
            this.rbCamera.Name = "rbCamera";
            this.rbCamera.Size = new System.Drawing.Size(102, 29);
            this.rbCamera.TabIndex = 9;
            this.rbCamera.TabStop = true;
            this.rbCamera.Text = "Kamerë";
            this.rbCamera.UseVisualStyleBackColor = true;
            this.rbCamera.CheckedChanged += new System.EventHandler(this.rbCamera_CheckedChanged);
            // 
            // rbFlycam
            // 
            this.rbFlycam.AutoSize = true;
            this.rbFlycam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFlycam.Location = new System.Drawing.Point(131, 34);
            this.rbFlycam.Name = "rbFlycam";
            this.rbFlycam.Size = new System.Drawing.Size(96, 29);
            this.rbFlycam.TabIndex = 10;
            this.rbFlycam.Text = "Flycam";
            this.rbFlycam.UseVisualStyleBackColor = true;
            this.rbFlycam.CheckedChanged += new System.EventHandler(this.rbFlycam_CheckedChanged);
            // 
            // rbDron
            // 
            this.rbDron.AutoSize = true;
            this.rbDron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDron.Location = new System.Drawing.Point(233, 34);
            this.rbDron.Name = "rbDron";
            this.rbDron.Size = new System.Drawing.Size(75, 29);
            this.rbDron.TabIndex = 11;
            this.rbDron.Text = "Dron";
            this.rbDron.UseVisualStyleBackColor = true;
            this.rbDron.CheckedChanged += new System.EventHandler(this.rbDron_CheckedChanged);
            // 
            // rbKran
            // 
            this.rbKran.AutoSize = true;
            this.rbKran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKran.Location = new System.Drawing.Point(314, 34);
            this.rbKran.Name = "rbKran";
            this.rbKran.Size = new System.Drawing.Size(75, 29);
            this.rbKran.TabIndex = 12;
            this.rbKran.Text = "Kran";
            this.rbKran.UseVisualStyleBackColor = true;
            this.rbKran.CheckedChanged += new System.EventHandler(this.rbKran_CheckedChanged);
            // 
            // rbAparat
            // 
            this.rbAparat.AutoSize = true;
            this.rbAparat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAparat.Location = new System.Drawing.Point(395, 34);
            this.rbAparat.Name = "rbAparat";
            this.rbAparat.Size = new System.Drawing.Size(135, 29);
            this.rbAparat.TabIndex = 13;
            this.rbAparat.Text = "Foto Aparat";
            this.rbAparat.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOther.Location = new System.Drawing.Point(545, 34);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(83, 29);
            this.rbOther.TabIndex = 14;
            this.rbOther.Text = "Tjetër";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Emri dhe Modeli";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(164, 83);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(295, 30);
            this.tbName.TabIndex = 16;
            // 
            // chB4k
            // 
            this.chB4k.AutoSize = true;
            this.chB4k.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chB4k.Location = new System.Drawing.Point(501, 83);
            this.chB4k.Name = "chB4k";
            this.chB4k.Size = new System.Drawing.Size(61, 29);
            this.chB4k.TabIndex = 19;
            this.chB4k.Text = "4K";
            this.chB4k.UseVisualStyleBackColor = true;
            // 
            // chBhd
            // 
            this.chBhd.AutoSize = true;
            this.chBhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBhd.Location = new System.Drawing.Point(602, 83);
            this.chBhd.Name = "chBhd";
            this.chBhd.Size = new System.Drawing.Size(64, 29);
            this.chBhd.TabIndex = 20;
            this.chBhd.Text = "HD";
            this.chBhd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lens Serial N";
            // 
            // tbLensSerial
            // 
            this.tbLensSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLensSerial.Location = new System.Drawing.Point(164, 119);
            this.tbLensSerial.Name = "tbLensSerial";
            this.tbLensSerial.Size = new System.Drawing.Size(244, 30);
            this.tbLensSerial.TabIndex = 22;
            // 
            // cbCameraId
            // 
            this.cbCameraId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCameraId.FormattingEnabled = true;
            this.cbCameraId.Location = new System.Drawing.Point(164, 155);
            this.cbCameraId.Name = "cbCameraId";
            this.cbCameraId.Size = new System.Drawing.Size(153, 33);
            this.cbCameraId.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kamera";
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(164, 248);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(114, 46);
            this.btnAddEquipment.TabIndex = 28;
            this.btnAddEquipment.Text = "Shto";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(294, 248);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(114, 46);
            this.btnResetForm.TabIndex = 29;
            this.btnResetForm.Text = "Reset";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // lbCameras1
            // 
            this.lbCameras1.FormattingEnabled = true;
            this.lbCameras1.ItemHeight = 16;
            this.lbCameras1.Location = new System.Drawing.Point(314, 324);
            this.lbCameras1.Name = "lbCameras1";
            this.lbCameras1.Size = new System.Drawing.Size(296, 324);
            this.lbCameras1.TabIndex = 30;
            this.lbCameras1.DoubleClick += new System.EventHandler(this.lbCameras1_DoubleClick);
            // 
            // AddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 727);
            this.Controls.Add(this.lbCameras1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCameraId);
            this.Controls.Add(this.tbLensSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chBhd);
            this.Controls.Add(this.chB4k);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbAparat);
            this.Controls.Add(this.rbKran);
            this.Controls.Add(this.rbDron);
            this.Controls.Add(this.rbFlycam);
            this.Controls.Add(this.rbCamera);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbEquipment);
            this.Name = "AddEquipment";
            this.Text = "Shto Aparaturë";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbEquipment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbCamera;
        private System.Windows.Forms.RadioButton rbFlycam;
        private System.Windows.Forms.RadioButton rbDron;
        private System.Windows.Forms.RadioButton rbKran;
        private System.Windows.Forms.RadioButton rbAparat;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox chB4k;
        private System.Windows.Forms.CheckBox chBhd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLensSerial;
        private System.Windows.Forms.ComboBox cbCameraId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.ListBox lbCameras1;
    }
}