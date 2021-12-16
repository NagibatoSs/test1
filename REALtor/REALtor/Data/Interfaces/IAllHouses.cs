using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REALtor.Data.Models;

namespace REALtor.Data.Interfaces
{
    public interface IAllHouses
    {
        IEnumerable<House> Houses { get; }
        IEnumerable<House> GetAvailableHouses { get; }
        House getObjectHouse(int houseId);
    }
}
