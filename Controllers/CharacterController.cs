using System.Collections.Generic;
using System.Linq;
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
        public ActionResult<List<Character>> Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Character> getSingle(int id)
        {
            return Ok(_characterService.GetCharacter(id));
        }
        [HttpPost]
        [Route("Post1")]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.addCharacter(newCharacter));
        }
    }
}