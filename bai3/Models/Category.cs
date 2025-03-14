﻿using System.ComponentModel.DataAnnotations;

namespace bai3.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        List<Product> products { get; set; }
    }
}
