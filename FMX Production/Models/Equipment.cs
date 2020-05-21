using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMX_Production.Controllers;

namespace FMX_Production.Models
{
    class Equipment
    {
        DataAcess data = new DataAcess();
        public Camera equipedCamera;
        public int id { get; set; }
        public string name { get; set; }
        public string lensSerial { get; set; }
        public bool isCamera { get; set; }
        public bool isDron { get; set; }
        public bool isKran { get; set; }
        public bool isPhotoAparat { get; set; }
        public bool isFlycam { get; set; }
        public bool isHD { get; set; }
        public bool is4K { get; set; }
        public Nullable <int> CameraID { get; set; }
        public bool isOther { get; set; }


        public Equipment(int id, string name, string lensSerial, bool isCamera, bool isDron, bool isKran, bool isPhotoAparat, bool isFlycam, bool isHD, bool is4K, Nullable<int> cameraID, bool isOther)
        {
            this.id = id;
            this.name = name;
            this.lensSerial = lensSerial;
            this.isCamera = isCamera;
            this.isDron = isDron;
            this.isKran = isKran;
            this.isPhotoAparat = isPhotoAparat;
            this.isFlycam = isFlycam;
            this.isHD = isHD;
            this.is4K = is4K;
            this.CameraID = cameraID;
            this.isOther = isOther;
            this.equipedCamera = data.getCameraById(cameraID);
        }
        public bool editCameraById( int cameraId)
        {
            int equipmentId = this.id;
            if(!data.editEquipmentCamera(equipmentId, cameraId))
            {
                return false;
            }else
            {
                return true;
            }
        }
        Equipment(System.Int32 Id, System.String Name, System.String lensSerial, System.Boolean isDron, System.Boolean isKran, System.Boolean isPhotoAparat, System.Boolean isFlycam, Nullable<int> CameraID, System.Boolean isOther)
        {
            this.id = Id;
            this.name = Name;
            this.lensSerial = lensSerial;
            this.isDron = isDron;
            this.isKran = isKran;
            this.isPhotoAparat = isPhotoAparat;
            this.isFlycam = isFlycam;
            this.isHD = isHD;
            this.is4K = is4K;
            this.CameraID = CameraID;
            this.isOther = isOther;
            if(CameraID == null)
            {
            }
            else
            {
                var camera = data.getCameraById(CameraID);
                equipedCamera = camera;
            }
           

        }


    }
}
