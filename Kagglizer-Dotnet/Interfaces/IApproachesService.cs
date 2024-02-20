using global::Kagglizer_Dotnet.Models;

namespace Kagglizer_Dotnet.Interfaces
{
    public interface IApproachesService
    {
        List<Approach> GetAllApproaches();
        Approach GetApproachById(int id);
        void AddApproach(Approach approach);
        void UpdateApproach(Approach approach);
        void DeleteApproach(int id);
    }
}

