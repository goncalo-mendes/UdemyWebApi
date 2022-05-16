using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharactersService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
       {
           new Character(),
           new Character {Name = "Sam", Id = 1},
           new Character {Name = "Shredder", Id = 2}
       };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;
            characters.Add(character);
            serviceResponse.Data = characters.Select(c => _mapper.Map<Character>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<Character>(c)).ToList();;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacter(int id)
        {
           var serviceResponse = new ServiceResponse<Character>();
           serviceResponse.Data = _mapper.Map<Character>(characters.FirstOrDefault(c => c.Id == id));
           return serviceResponse;
        }
    }
}