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
            this.btnAddDslr = new System.Windows.Forms.Button();
            this.btnAddCamera = new System.Windows.Forms.Button();
            this.btnAddKran = new System.Windows.Forms.Button();
            this.btnAddDrone = new System.Windows.Forms.Button();
            this.btnAddFlyCam = new System.Windows.Forms.Button();
            this.btnAddOther = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDslr
            // 
            this.btnAddDslr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDslr.Location = new System.Drawing.Point(37, 38);
            this.btnAddDslr.Name = "btnAddDslr";
            this.btnAddDslr.Size = new System.Drawing.Size(185, 71);
            this.btnAddDslr.TabIndex = 0;
            this.btnAddDslr.Text = "Shto Aparat";
            this.btnAddDslr.UseVisualStyleBackColor = true;
            this.btnAddDslr.Click += new System.EventHandler(this.btnAddDslr_Click);
            // 
            // btnAddCamera
            // 
            this.btnAddCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCamera.Location = new System.Drawing.Point(228, 38);
            this.btnAddCamera.Name = "btnAddCamera";
            this.btnAddCamera.Size = new System.Drawing.Size(185, 71);
            this.btnAddCamera.TabIndex = 1;
            this.btnAddCamera.Text = "Shto Kamerë";
            this.btnAddCamera.UseVisualStyleBackColor = true;
            // 
            // btnAddKran
            // 
            this.btnAddKran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKran.Location = new System.Drawing.Point(419, 38);
            this.btnAddKran.Name = "btnAddKran";
            this.btnAddKran.Size = new System.Drawing.Size(185, 71);
            this.btnAddKran.TabIndex = 2;
            this.btnAddKran.Text = "Shto Kran";
            this.btnAddKran.UseVisualStyleBackColor = true;
            // 
            // btnAddDrone
            // 
            this.btnAddDrone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrone.Location = new System.Drawing.Point(37, 115);
            this.btnAddDrone.Name = "btnAddDrone";
            this.btnAddDrone.Size = new System.Drawing.Size(185, 71);
            this.btnAddDrone.TabIndex = 3;
            this.btnAddDrone.Text = "Shto Dron";
            this.btnAddDrone.UseVisualStyleBackColor = true;
            // 
            // btnAddFlyCam
            // 
            this.btnAddFlyCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlyCam.Location = new System.Drawing.Point(228, 115);
            this.btnAddFlyCam.Name = "btnAddFlyCam";
            this.btnAddFlyCam.Size = new System.Drawing.Size(185, 71);
            this.btnAddFlyCam.TabIndex = 4;
            this.btnAddFlyCam.Text = "Shto Flycam";
            this.btnAddFlyCam.UseVisualStyleBackColor = true;
            // 
            // btnAddOther
            // 
            this.btnAddOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOther.Location = new System.Drawing.Point(419, 115);
            this.btnAddOther.Name = "btnAddOther";
            this.btnAddOther.Size = new System.Drawing.Size(185, 71);
            this.btnAddOther.TabIndex = 5;
            this.btnAddOther.Text = "Tjetër";
            this.btnAddOther.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(625, 340);
            this.listBox1.TabIndex = 6;
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Location = new System.Drawing.Point(91, 566);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(165, 51);
            this.btnEditEquipment.TabIndex = 7;
            this.btnEditEquipment.Text = "Ndrysho";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 566);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 51);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anulo";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 663);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddOther);
            this.Controls.Add(this.btnAddFlyCam);
            this.Controls.Add(this.btnAddDrone);
            this.Controls.Add(this.btnAddKran);
            this.Controls.Add(this.btnAddCamera);
            this.Controls.Add(this.btnAddDslr);
            this.Name = "AddEquipment";
            this.Text = "Shto Aparaturë";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDslr;
        private System.Windows.Forms.Button btnAddCamera;
        private System.Windows.Forms.Button btnAddKran;
        private System.Windows.Forms.Button btnAddDrone;
        private System.Windows.Forms.Button btnAddFlyCam;
        private System.Windows.Forms.Button btnAddOther;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnCancel;
    }
}