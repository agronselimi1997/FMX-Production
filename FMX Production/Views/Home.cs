﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMX_Production.Views;
namespace FMX_Production
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            
            
            
            
        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            AddEmploye add = new AddEmploye();
            add.Show();
            
            
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            AddEquipment addEquipment = new AddEquipment();
            addEquipment.Show();
        }
    }
}