using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticEnemy.Data.Entities
{
    public class PlasticEntry
    {
        //columns
        public int PlasticEntryId { get; set; }

        public Guid ProfileId { get; set; }

        public DateTime Date { get; set; }

        public int PlasticTypeId { get; set; }

        public string Size { get; set; }

        public int ActionId { get; set; }

        //links to other tables using corresponding IDs one-to-one relationships
        public virtual Profile Profile { get; set; }

        public virtual PlasticType PlasticType { get; set; }

        public virtual Action Action { get; set; }

    }
}
