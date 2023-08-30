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

        private SurvivorService _survivorService;

        public SurvivorController(SurvivorService survivorService)
        {
            _survivorService = survivorService;
        }

        [HttpGet]
        public async Task<List<Survivor>> Get() 
        { 
            return await _survivorService.GetAllSurvivors(); 
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Survivor survivor) 
        {
            await _survivorRepository.CreateAsync(survivor);
            return CreatedAtAction(nameof(Get), new { id = survivor.Id }, survivor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLocation(string id, [FromBody] Location newLocation) { throw new NotImplementedException(); }

        [HttpPost("{id}")]
        public async Task<IActionResult> FlagInfected(string id) { throw new NotImplementedException(); }

    }
}
