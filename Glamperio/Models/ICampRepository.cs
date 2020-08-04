using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glamperio.Models
{
    interface ICampRepository
    {
        public IEnumerable<Campgrounds> GetAllCampgrounds();
        public Campgrounds GetCampgrounds();
       

    }
}
