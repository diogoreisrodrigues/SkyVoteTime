﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyVoteTime.Server.Service;
using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeletePerson(int id)
        {
            return await _personService.DeletePerson(id);
            //return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdatePerson(int id, [FromBody] Person Object)
        {
            await _personService.UpdatePerson(id, Object);
            return true;
        }

    }
}
