using Core.Interfaces.DataLayer;
using Core.Interfaces.ECommerceItems;

using System;
using System.Threading.Tasks;

namespace DataLayer.FakeDatabase
{
    public class MobilePhoneDataLayer<T, TKey> : IMobilePhoneDataLayer<T, TKey> where T : IMobilePhone
    {
        public T Add(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public T Get(T key)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(TKey key)
        {
            throw new NotImplementedException();
        }

        public T Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task<T> RemoveAsync(TKey key)
        {
            throw new NotImplementedException();
        }
    }
}