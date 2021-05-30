using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using dotnet_rpg.Services.CharactersService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
       
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            this._characterService = characterService;

        }
        [HttpGet]//this most for good docs and for swagger
        [Route("GetAll")]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Character>> getSingle(int id)
        {
            return Ok(await _characterService.GetCharacter(id));
        }
        [HttpPost]
        [Route("Post1")]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.addCharacter(newCharacter));
        }
    }
}