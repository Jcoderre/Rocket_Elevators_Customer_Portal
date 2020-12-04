using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Rocket_Elevators_Customer_Portal.Models;


namespace Rocket_Elevators_Customer_Portal.Services
{
    public class BuildingService : IBuildingService
    {
        public readonly HttpClient HttpClient;

        public BuildingService(HttpClient httpClient)
        {
            this.HttpClient = httpClient;

        }
        public Task<IEnumerable<Building>> GetBuildings()
        {
            throw new NotImplementedException();
        }
    }

}