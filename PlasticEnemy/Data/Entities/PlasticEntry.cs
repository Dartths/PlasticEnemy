using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticEnemy.Data.Entities
{
    public class PlasticEntry
    {
        public Guid PlasticEntryId { get; set; }

        //ProfileId

        public DateTime Date { get; set; }

        //PlasticTypeId

        public int Size { get; set; }

        //ActionID
    }
}
