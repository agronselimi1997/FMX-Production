 namespace FMX_Production
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
            this.btnAddEmploye = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnCreateOffer = new System.Windows.Forms.Button();
            this.btnAddWeeding = new System.Windows.Forms.Button();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chLbOffers = new System.Windows.Forms.CheckedListBox();
            this.lbWeedings = new System.Windows.Forms.ListBox();
            this.btnConfirmWeeding = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteWeeding = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCacnelWeeding = new System.Windows.Forms.Button();
            this.lwToday = new System.Windows.Forms.ListView();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmploye
            // 
            this.btnAddEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmploye.Location = new System.Drawing.Point(179, 12);
            this.btnAddEmploye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmploye.Name = "btnAddEmploye";
            this.btnAddEmploye.Size = new System.Drawing.Size(161, 58);
            this.btnAddEmploye.TabIndex = 0;
            this.btnAddEmploye.Text = "Shto Punëtorë";
            this.btnAddEmploye.UseVisualStyleBackColor = true;
            this.btnAddEmploye.Click += new System.EventHandler(this.btnAddEmploye_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(345, 12);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(161, 58);
            this.btnAddEquipment.TabIndex = 1;
            this.btnAddEquipment.Text = "Shto Kamerë";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnCreateOffer
            // 
            this.btnCreateOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOffer.Location = new System.Drawing.Point(512, 12);
            this.btnCreateOffer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateOffer.Name = "btnCreateOffer";
            this.btnCreateOffer.Size = new System.Drawing.Size(161, 58);
            this.btnCreateOffer.TabIndex = 2;
            this.btnCreateOffer.Text = "Krijo Ofertë";
            this.btnCreateOffer.UseVisualStyleBackColor = true;
            // 
            // btnAddWeeding
            // 
            this.btnAddWeeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWeeding.Location = new System.Drawing.Point(679, 14);
            this.btnAddWeeding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWeeding.Name = "btnAddWeeding";
            this.btnAddWeeding.Size = new System.Drawing.Size(161, 58);
            this.btnAddWeeding.TabIndex = 3;
            this.btnAddWeeding.Text = "Shto Dasëm";
            this.btnAddWeeding.UseVisualStyleBackColor = true;
            // 
            // lbWorkers
            // 
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.ItemHeight = 16;
            this.lbWorkers.Location = new System.Drawing.Point(12, 106);
            this.lbWorkers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(283, 580);
            this.lbWorkers.TabIndex = 4;
            this.lbWorkers.DoubleClick += new System.EventHandler(this.lbWorkers_DoubleClick);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWorker.Location = new System.Drawing.Point(179, 690);
            this.btnDeleteWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(117, 37);
            this.btnDeleteWorker.TabIndex = 5;
            this.btnDeleteWorker.Text = "Fshij";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puntorët e lirë :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1353, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ofertat :";
            // 
            // chLbOffers
            // 
            this.chLbOffers.FormattingEnabled = true;
            this.chLbOffers.Location = new System.Drawing.Point(1357, 107);
            this.chLbOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chLbOffers.Name = "chLbOffers";
            this.chLbOffers.Size = new System.Drawing.Size(532, 242);
            this.chLbOffers.TabIndex = 8;
            // 
            // lbWeedings
            // 
            this.lbWeedings.FormattingEnabled = true;
            this.lbWeedings.ItemHeight = 16;
            this.lbWeedings.Location = new System.Drawing.Point(1357, 410);
            this.lbWeedings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWeedings.Name = "lbWeedings";
            this.lbWeedings.Size = new System.Drawing.Size(535, 276);
            this.lbWeedings.TabIndex = 9;
            // 
            // btnConfirmWeeding
            // 
            this.btnConfirmWeeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmWeeding.Location = new System.Drawing.Point(1653, 367);
            this.btnConfirmWeeding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmWeeding.Name = "btnConfirmWeeding";
            this.btnConfirmWeeding.Size = new System.Drawing.Size(117, 37);
            this.btnConfirmWeeding.TabIndex = 10;
            this.btnConfirmWeeding.Text = "Konfirmo";
            this.btnConfirmWeeding.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1356, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dasmat :";
            // 
            // btnDeleteWeeding
            // 
            this.btnDeleteWeeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWeeding.Location = new System.Drawing.Point(1776, 367);
            this.btnDeleteWeeding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteWeeding.Name = "btnDeleteWeeding";
            this.btnDeleteWeeding.Size = new System.Drawing.Size(117, 37);
            this.btnDeleteWeeding.TabIndex = 12;
            this.btnDeleteWeeding.Text = "Fshij";
            this.btnDeleteWeeding.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sot : ";
            // 
            // btnCacnelWeeding
            // 
            this.btnCacnelWeeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCacnelWeeding.Location = new System.Drawing.Point(1776, 690);
            this.btnCacnelWeeding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCacnelWeeding.Name = "btnCacnelWeeding";
            this.btnCacnelWeeding.Size = new System.Drawing.Size(117, 37);
            this.btnCacnelWeeding.TabIndex = 14;
            this.btnCacnelWeeding.Text = "Anulo";
            this.btnCacnelWeeding.UseVisualStyleBackColor = true;
            // 
            // lwToday
            // 
            this.lwToday.HideSelection = false;
            this.lwToday.Location = new System.Drawing.Point(301, 107);
            this.lwToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lwToday.Name = "lwToday";
            this.lwToday.Size = new System.Drawing.Size(1051, 579);
            this.lwToday.TabIndex = 15;
            this.lwToday.UseCompatibleStateImageBehavior = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(7, 12);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(165, 58);
            this.btnLogIn.TabIndex = 16;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1175, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "FMX LOGO ";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.Location = new System.Drawing.Point(845, 12);
            this.btnCreateTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(161, 58);
            this.btnCreateTeam.TabIndex = 18;
            this.btnCreateTeam.Text = "Krijo Ekip";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 1033);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lwToday);
            this.Controls.Add(this.btnCacnelWeeding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteWeeding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmWeeding);
            this.Controls.Add(this.lbWeedings);
            this.Controls.Add(this.chLbOffers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteWorker);
            this.Controls.Add(this.lbWorkers);
            this.Controls.Add(this.btnAddWeeding);
            this.Controls.Add(this.btnCreateOffer);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnAddEmploye);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMX Production";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmploye;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnCreateOffer;
        private System.Windows.Forms.Button btnAddWeeding;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chLbOffers;
        private System.Windows.Forms.ListBox lbWeedings;
        private System.Windows.Forms.Button btnConfirmWeeding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteWeeding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCacnelWeeding;
        private System.Windows.Forms.ListView lwToday;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}

