using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rocket_Elevators_Customer_Portal.Models;

namespace Rocket_Elevators_Customer_Portal.Services
{
    public interface IBuildingService {
        Task<IEnumerable<buildingview>> GetBuildings();
    }
    
}