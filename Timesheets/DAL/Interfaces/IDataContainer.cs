using System.Collections.Generic;
using Timesheets.Models;

namespace Timesheets.DAL.Interfaces
{
    public interface IDataContainer<T> where T: BaseEntity
    {
        public List<T> Entities { get; set; }
    }
}
