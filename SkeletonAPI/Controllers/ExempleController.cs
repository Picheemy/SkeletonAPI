using Microsoft.AspNetCore.Mvc;
using SkeletonAPI.Models;
using SkeletonAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkeletonAPI.Controllers
{
    [ApiController]
    [Route("api/exemple")]
    public class ExempleController: Controller
    {
        private readonly IExempleRepository _exempleRepository;

        public ExempleController(IExempleRepository exempleRepository)
        {
            _exempleRepository = exempleRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Exemple>> GetAllExemples()
        {
            return Ok(_exempleRepository.GetExemples());
        }

        [HttpGet("{exempleId}")]
        public ActionResult GetExempleById(int exempleId)
        {
            return Ok(_exempleRepository.GetExempleById(exempleId));
        }

        [HttpPost]
        public ActionResult CreateCourse(Exemple exemple)
        {
            _exempleRepository.CreateExemple(exemple);

            return Ok();
        }

        [HttpDelete("{exempleId}")]
        public ActionResult DeleteCourse(int exempleId)
        {
            _exempleRepository.DeleteExemple(exempleId);

            return NoContent();
        }

        [HttpPut("{exempleId}")]
        public ActionResult PutSubject(int exempleId, Exemple exemple)
        {
            _exempleRepository.PutExemple(exempleId, exemple);

            return NoContent();
        }
    }
}
