using System;

namespace MarTwFive.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public Guid ID { get; set; }
        public Guid GamesID { get; set; }
        public Guid CamperID { get; set; }
        public Grade? Grade { get; set; }

        public Game Game { get; set; }
        public Camper Camper { get; set; }
    }
}