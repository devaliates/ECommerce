using Core.Interfaces.ECommerceItems;

using System;

namespace UI.BlazorWASM.Models.ECommerceItems
{
    public class MobilePhoneModel : IMobilePhone
    {
        public string Title { get; set; }
        public Guid Id { get; set; }
        public bool IsSellable { get; set; }
        public decimal Price { get; set; }
        public short Count { get; set; }
    }
}