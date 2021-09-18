using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet5_rpg.Models;

namespace dotnet5_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<List<Character>> GetAllCharacters();
         Task<Character> GetCharacterById(int id);
         Task<List<Character>> AddCharacter(Character newCharacter);
    }
}