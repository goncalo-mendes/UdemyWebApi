using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
       private static List<Character> characters = new List<Character>
       {
           new Character(),
           new Character {Name = "Sam", Id = 1},
           new Character {Name = "Shredder"}
       };
       [HttpGet]//this most for good docs and for swagger
       [Route("GetAll")]
       public ActionResult<List<Character>> Get()
       {
           return Ok(characters);
       }
       [HttpGet]
       [Route("{id}")]
       public ActionResult<Character> getSingle(int id)
       {
           return Ok(characters.FirstOrDefault(c => c.Id == id));
       }
       [HttpPost]
       [Route("Post1")]
       public ActionResult<List<Character>> AddCharacter(Character newCharacter)
       {
           characters.Add(newCharacter);
           return Ok(characters);
       }
    }
}