using System;
using System.Collections.Generic;

namespace PlasticEnemy.Data.Entities
{
    public class Profile
    {
        //columns
        public Guid ProfileId { get; set; }

        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string DisplayName { get; set; }

        public string Country { get; set; }

        public string County { get; set; }

        public DateTime DOB { get; set; }

        public int GoalId { get; set; }

        //links to other tables using corresponding IDs one-to-one relationships
        public virtual User User { get; set; }

        public virtual Goal Goal { get; set; }

        //links to other tables with one-to-many relationships
        public virtual List<PlasticEntry> PlasticEntries { get; set; }
    }
}
