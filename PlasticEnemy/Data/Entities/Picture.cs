using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticEnemy.Data.Entities
{
    public class Picture
    {
        //columns
        public int PictureId { get; set; }

        public bool PictureType { get; set; }

        public string PictureLocation { get; set; }
    }
}
