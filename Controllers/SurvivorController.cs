using System;
using Microsoft.AspNetCore.Mvc;
using ZSSN_Octoco_technical_assessment.Services;
using SurvivorsTracking.Models;

namespace SurvivorsTracking.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class SurvivorController: Controller
    {

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
            if (ModelState.IsValid)
            {
                await _survivorService.AddSurvivor(survivor);
                return CreatedAtAction(nameof(Get), survivor);
            }
            else 
                return BadRequest(ModelState);
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
            if (ModelState.IsValid)
            {
                await _survivorService.UpdateLocation(id, newLocation); 
                return Ok(id);
            }
            else 
                return BadRequest(ModelState);
        }
    }
}
