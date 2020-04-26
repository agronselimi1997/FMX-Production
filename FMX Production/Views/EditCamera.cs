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
namespace FMX_Production.Views
{
    public partial class EditCamera : Form
    {
        int editCameraId;
        DataAcess dataAcess = new DataAcess();
        
        public EditCamera()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string model = tbModel.Text;
            bool is4K = chb4K.Checked;
            bool isHD = chbHD.Checked;
            
            if(dataAcess.editCamera(editCameraId, model, isHD, is4K))
            {
                this.Close();
            }else
            {
                MessageBox.Show("Edit Camera Error", "Edit Camera", MessageBoxButtons.OK);
            }

        }
        public void editCamera(int id, string name, bool isHD, bool is4K)
        {
            editCameraId = id;
            tbModel.Text = name;
            chb4K.Checked = is4K;
            chbHD.Checked = isHD;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
