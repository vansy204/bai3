﻿namespace bai3.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
