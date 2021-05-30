using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharactersService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
       {
           new Character(),
           new Character {Name = "Sam", Id = 1},
           new Character {Name = "Shredder"}
       };
        public async Task<ServiceResponse<List<Character>>> addCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacter(int id)
        {
           var serviceResponse = new ServiceResponse<Character>();
           serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
           return serviceResponse;
        }
    }
}