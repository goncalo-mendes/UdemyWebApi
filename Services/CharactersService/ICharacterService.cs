using System.Collections.Generic;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharactersService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacter(int id);
        List<Character> addCharacter(Character newCharacter);
    }
}