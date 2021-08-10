using System.Collections.Generic;
using Timesheets.DAL.Interfaces;
using Timesheets.Models;

namespace Timesheets.DAL
{
    public class DataContainer<T> : IDataContainer<T> where T : BaseEntity
    {
        public List<T> Entities { get; set; } 
    }
}
