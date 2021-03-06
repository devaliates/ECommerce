using Core.Interfaces.DataLayer;
using Core.Interfaces.ECommerceItems;
using Core.Interfaces.Services;

using System;
using System.Threading.Tasks;

namespace Services.FakeService
{
    public class LaptopService<T> : ILaptopService<T> where T : ILaptop
    {
        private ILaptopDataLayer<T> service;

        public LaptopService(ILaptopDataLayer<T> service)
        {
            this.service = service;
        }

        public T Add(T item) => service.Add(item);

        public async Task<T> AddAsync(T item) => await service.AddAsync(item);

        public T Get(Guid id) => service.Get(id);

        public async Task<T> GetAsync(Guid id) => await service.GetAsync(id);

        public T Remove(Guid id) => service.Remove(id);

        public async Task<T> RemoveAsync(Guid id) => await service.RemoveAsync(id);
    }
}