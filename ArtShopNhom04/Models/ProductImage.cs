﻿namespace ArtShopNhom04.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        //khoa ngoai
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
