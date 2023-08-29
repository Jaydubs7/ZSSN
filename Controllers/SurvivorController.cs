using System;
using Microsoft.AspNetCore.Mvc;
using ZSSN_Octoco_technical_assessment.Services;
using SurvivorsTracking.Models;
using ZSSN_Octoco_technical_assessment.Repository;
using ZSSN_Octoco_technical_assessment.IRepository;

namespace SurvivorsTracking.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class SurvivorController: Controller
    {
        private readonly ISurvivorRepository _survivorRepository;

        public SurvivorController(ISurvivorRepository survivorRepository)
        {
            _survivorRepository = survivorRepository;
        }

        [HttpGet]
        public async Task<List<Survivor>> Get() { throw new NotImplementedException(); }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Survivor survivor) 
        {
            await _survivorRepository.CreateAsync(survivor);
            return CreatedAtAction(nameof(Get), new { id = survivor.Id }, survivor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLocation(string id, [FromBody] Location newLocation) { throw new NotImplementedException(); }


    }
}
