using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMX_Production.Controllers;
using FMX_Production.Models;

namespace FMX_Production.Views
{
    public partial class AddEquipment : Form
    {
        DataAcess dataAcess = new DataAcess();
        List<Camera> cameras = new List<Camera>();
        List<Camera> Camera1 = new List<Camera>();
        List<Equipment> equipments = new List<Equipment>();
        public AddEquipment()
        {
            InitializeComponent();
            fillListBoxes();
            fillCameras();
            check();
        }

        private void btnAddDslr_Click(object sender, EventArgs e)
        {

        }

        public void check()
        {
            if (rbAparat.Checked == true)
            {
                resetForm();

                chB4k.Enabled = false;
                chBhd.Enabled = false;
                cbCameraId.Visible = false;

            }
            if (rbCamera.Checked == true)
            {
                resetForm();
                tbLensSerial.Enabled = false;

                cbCameraId.Visible = false;

            }
            if (rbDron.Checked == true)
            {
                resetForm();
                tbLensSerial.Enabled = false;

                cbCameraId.Visible = false;
            }
            if (rbFlycam.Checked == true)
            {
                resetForm();
                tbLensSerial.Enabled = false;

                cbCameraId.Visible = true;
                chB4k.Enabled = false;
                chBhd.Enabled = false;

            }
            if (rbOther.Checked == true)
            {
                resetForm();

            }
            if (rbKran.Checked == true)
            {
                resetForm();
                tbLensSerial.Enabled = false;
                chBhd.Enabled = false;
                chB4k.Enabled = false;

            }
        }
        public void fillCameras()
        {
            cameras = dataAcess.getCameras();
            cbCameraId.DataSource = cameras;
            cbCameraId.DisplayMember = "name";


        }
        public void fillListBoxes()
        {
            Camera1 = dataAcess.getCameras();
            lbCameras1.DataSource = Camera1;
            lbCameras1.DisplayMember = "name";
            equipments = dataAcess.getEquipment();
            lbEquipment.DataSource = equipments;
            lbEquipment.DisplayMember = "name";

        }
        public void resetForm()
        {
            tbLensSerial.Clear();
            chB4k.Checked = false;
            chBhd.Checked = false;
            chB4k.Enabled = true;
            chBhd.Enabled = true;
            tbName.Clear();

            tbLensSerial.Enabled = true;
            cbCameraId.Visible = true;
            fillCameras();
            fillListBoxes();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {

        }

        private void rbDron_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void rbKran_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void rbFlycam_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void rbCamera_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            bool is4K = chB4k.Checked;
            bool isHD = chBhd.Checked;
            string lensSerial = tbLensSerial.Text;
            bool isKran = rbKran.Checked;
            bool isDron = rbDron.Checked;
            bool isPhotoAparat = rbAparat.Checked;
            bool isFlycam = rbFlycam.Checked;
            bool isOther = rbOther.Checked;
            Camera selectedCamera = cbCameraId.SelectedItem as Camera;
            int cmeraID = selectedCamera.id;
            if (rbCamera.Checked == true)
            {
                if (dataAcess.addCamera(name, isHD, is4K))
                {
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong while adding camera", "Add Camera Messaage", MessageBoxButtons.OK);
                    resetForm();
                }
            }
            else
            {
                if (dataAcess.addEquipment(name, lensSerial, isDron, isKran, isPhotoAparat, isFlycam, cmeraID, isOther))
                {
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Adding Equipment Went Wrong", "Add Equipment Message", MessageBoxButtons.OK);
                    resetForm();
                }

            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
