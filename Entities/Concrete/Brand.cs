using ReCapProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.Concrete
{
    public class Brand:IEntity
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
    }
}
