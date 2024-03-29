﻿using System.ComponentModel.DataAnnotations;

namespace CofeeProject.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Key { get; set; }
        [MaxLength(250)]
        public string Value { get; set; }
    }
}
