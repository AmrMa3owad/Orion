﻿namespace Orion.Models
{
    public class CartProduct
    {
        public int ProductId {  get; set; }
        public int? CartId {  get; set; }
        public object MaterialId { get; internal set; }
    }
}
