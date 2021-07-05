using Core.Interfaces.DataLayer;
using Core.Interfaces.ECommerceItems;

using System;
using System.Threading.Tasks;

namespace DataLayer.FakeDatabase
{
    public class LaptopDataLayer<T> : ILaptopDataLayer<T> where T : ILaptop
    {
        private BaseDataLayer<T> dataLayer = new BaseDataLayer<T>();

        public T Add(T item) => dataLayer.Add(item);

        public async Task<T> AddAsync(T item) => await dataLayer.AddAsync(item);

        public T Get(Guid id) => dataLayer.Get(id);

        public async Task<T> GetAsync(Guid id) => await dataLayer.GetAsync(id);

        public T Remove(Guid id) => dataLayer.Remove(id);

        public async Task<T> RemoveAsync(Guid id) => await dataLayer.RemoveAsync(id);
    }
}