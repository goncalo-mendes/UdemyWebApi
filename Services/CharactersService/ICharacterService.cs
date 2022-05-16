using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharactersService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacter(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}