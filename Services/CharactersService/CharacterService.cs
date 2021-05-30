using System.Collections.Generic;
using System.Linq;
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
        public List<Character> addCharacter(Character newCharacter)
        {
           characters.Add(newCharacter);
           return characters;
        }

        public List<Character> GetAllCharacters()
        {
           return characters;
        }

        public Character GetCharacter(int id)
        {
           return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}