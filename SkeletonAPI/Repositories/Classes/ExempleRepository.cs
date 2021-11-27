using SkeletonAPI.ExempleDBContext;
using SkeletonAPI.Models;
using SkeletonAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkeletonAPI.Repositories.Classes
{
    public class ExempleRepository: IExempleRepository
    {
        public readonly ExempleContext _context;

        public ExempleRepository(ExempleContext context)
        {
            _context = context;
        }

        public void CreateExemple(Exemple exemple)
        {
            _context.Exemple.Add(exemple);
            _context.SaveChanges();
        }

        public void DeleteExemple(int exempleId)
        {
            Exemple exempleEntity = _context.Exemple.Find(exempleId);
            _context.Exemple.Remove(exempleEntity);
            _context.SaveChanges();
        }

        public Exemple GetExempleById(int exempleId)
        {
            return _context.Exemple.Find(exempleId);
        }

        public IEnumerable<Exemple> GetExemples()
        {
            return _context.Exemple.ToList();
        }

        public void PutExemple(int exempleId, Exemple exemple)
        {
            Exemple exempleEntity = _context.Exemple.Find(exempleId);
            exempleEntity.ExempleId = exemple.ExempleId;
            exempleEntity.Exemples = exemple.Exemples;

            _context.Exemple.Update(exempleEntity);
            _context.SaveChanges();
        }
    }
}
