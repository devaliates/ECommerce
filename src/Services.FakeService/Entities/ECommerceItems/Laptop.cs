using Core.Interfaces.ECommerceItems;

using System;

namespace Services.FakeService.Entities.ECommerceItems
{
    public class Laptop : ILaptop
    {
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSellable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public short Count { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}