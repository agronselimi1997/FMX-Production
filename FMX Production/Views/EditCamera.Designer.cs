namespace FMX_Production.Views
{
    partial class EditCamera
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.chbHD = new System.Windows.Forms.CheckBox();
            this.chb4K = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modeli ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(95, 38);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(203, 30);
            this.tbModel.TabIndex = 2;
            // 
            // chbHD
            // 
            this.chbHD.AutoSize = true;
            this.chbHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHD.Location = new System.Drawing.Point(95, 74);
            this.chbHD.Name = "chbHD";
            this.chbHD.Size = new System.Drawing.Size(64, 29);
            this.chbHD.TabIndex = 3;
            this.chbHD.Text = "HD";
            this.chbHD.UseVisualStyleBackColor = true;
            // 
            // chb4K
            // 
            this.chb4K.AutoSize = true;
            this.chb4K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb4K.Location = new System.Drawing.Point(165, 74);
            this.chb4K.Name = "chb4K";
            this.chb4K.Size = new System.Drawing.Size(61, 29);
            this.chb4K.TabIndex = 4;
            this.chb4K.Text = "4K";
            this.chb4K.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chb4K);
            this.Controls.Add(this.chbHD);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "EditCamera";
            this.Text = "EditCamera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.CheckBox chbHD;
        private System.Windows.Forms.CheckBox chb4K;
        private System.Windows.Forms.Button btnCancel;
    }
}