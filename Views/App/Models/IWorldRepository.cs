using System.Collections.Generic;

namespace TheWorld.Views.App.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
    }
}