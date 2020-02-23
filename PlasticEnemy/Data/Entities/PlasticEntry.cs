using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticEnemy.Data.Entities
{
    public class PlasticEntry
    {
        public Guid PlasticEntryId { get; set; }

        public DateTime Date { get; set; }

        public string PlasticTypeId { get; set; }

        public int Size { get; set; }

        public string ActionID { get; set; }
    }
}
