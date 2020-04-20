using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMX_Production.Models
{
    class Camera
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is4K { get; set; }
        public bool isHD { get; set; }

        public int getId()
        {
            return id;
        }
        public Camera(int id, string name, bool is4K, bool isHD)
        {
            this.id = id;
            this.name = name;
            this.is4K = is4K;
            this.isHD = isHD;
        }
    }
}
