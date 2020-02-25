using System;
using System.Collections.Generic;

namespace PlasticEnemy.Data.Entities
{
    public class User
    {
        //columns
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        //links to other tables with one-to-many relationships
        public virtual List<Profile> Profiles { get; set; } 
    }
}