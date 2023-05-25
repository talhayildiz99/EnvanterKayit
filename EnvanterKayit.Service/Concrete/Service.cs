using EnvanterKayit.DataLayer;
using EnvanterKayit.DataLayer.Concrete;
using EnvanterKayit.Entities;
using EnvanterKayit.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterKayit.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext context) : base(context)
        {
        }
    }
}
