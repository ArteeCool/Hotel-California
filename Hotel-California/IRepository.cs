using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    interface IRepository<T>
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();
    }
}
