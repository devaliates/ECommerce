using Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.FakeDatabase
{
    public class BaseDataLayer<T> where T : IGuidKey
    {
        private List<T> items = new List<T>();

        public T Add(T item)
        {
            try
            {
                items.Add(item);

                return item;
            }
            catch (Exception)
            {
                throw new Exception("DataLayer Add Exception!");
            }
        }

        public async Task<T> AddAsync(T item)
        {
            return await Task.Run(() =>
            {
                try
                {
                    items.Add(item);

                    return item;
                }
                catch (Exception)
                {
                    throw new Exception("DataLayer AddAsync Exception!");
                }
            });
        }

        public T Get(Guid id)
        {
            try
            {
                var item = items.FirstOrDefault(x => x.Id == id);

                return item;
            }
            catch (Exception)
            {
                throw new Exception("DataLayer Get Exception!");
            }
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var item = items.FirstOrDefault(x => x.Id == id);

                    return item;
                }
                catch (Exception)
                {
                    throw new Exception("DataLayer GetAsync Exception!");
                }
            });
        }

        public T Remove(Guid id)
        {
            try
            {
                var item = items.FirstOrDefault(x => x.Id == id);

                if (item == null)
                    throw new Exception("DataLayer Remove Exception!");

                items.Remove(item);

                return item;
            }
            catch (Exception)
            {
                throw new Exception("DataLayer Remove Exception!");
            }
        }

        public async Task<T> RemoveAsync(Guid id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var item = items.FirstOrDefault(x => x.Id == id);

                    if (item == null)
                        throw new Exception("DataLayer RemoveAsync Exception!");

                    items.Remove(item);

                    return item;
                }
                catch (Exception)
                {
                    throw new Exception("DataLayer RemoveAsync Exception!");
                }
            });
        }
    }
}