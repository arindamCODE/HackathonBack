using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ScoreTable
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string EmailID { get; set; }

        [Required]
        public int Score { get; set; }

    }
}