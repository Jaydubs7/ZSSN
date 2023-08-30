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
            if (survivor != null)
            {
                await _survivorService.AddSurvivor(survivor);
                return CreatedAtAction(nameof(Get), survivor);
            }
            else 
                return BadRequest();
        }

        [HttpPost("{id}/infected")]
        public async Task<IActionResult> FlagInfected(string id) 
        { 
            await _survivorService.FlagInfectedSurvivor(id);
            return Ok(id);
        }

        [HttpPut("{id}/location")]
        
        public async Task<IActionResult> UpdateLocation(string id, [FromBody] Location newLocation) 
        { 
            await _survivorService.UpdateLocation(id, newLocation); 
            return Ok(id);
        }
    }
}
