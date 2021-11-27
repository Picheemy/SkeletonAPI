using SkeletonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkeletonAPI.Repositories.Interfaces
{
    public interface IExempleRepository
    {
        IEnumerable<Exemple> GetExemples();
        Exemple GetExempleById(int exempleId);
        void CreateExemple(Exemple exemple);
        void DeleteExemple(int exempleId);
        void PutExemple(int exempleId, Exemple exemple);
    }
}
