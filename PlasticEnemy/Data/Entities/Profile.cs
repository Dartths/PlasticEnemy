using System;

namespace PlasticEnemy.Data.Entities
{
    public class Profile
    {
        public Guid ProfileId { get; set; }

        //UserId

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string DisplayName { get; set; }

        public string Country { get; set; }

        public string County { get; set; }

        public DateTime DOB { get; set; }

        //GoalID
    }
}
