using Core.Interfaces.DataLayer;

using DataLayer.FakeDatabase;

using Services.FakeService.Entities.ECommerceItems;

using System;

namespace Services.FakeService
{
    public class LaptopService
    {
        private ILaptopDataLayer<Laptop, Guid> service = new LaptopDataLayer<Laptop, Guid>();
    }
}