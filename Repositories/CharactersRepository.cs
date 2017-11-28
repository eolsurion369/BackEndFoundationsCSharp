using System.Collections.Generic;
using BackEndFoundationsCSharp.Models;

namespace BackEndFoundationsCSharp.Repositories
{
    public class CharactersRepository
    {
        public List<Character> GetCharacters(){
            List<Character> characters = new List<Character>();
            characters.Add(new Character {FirstName = "Jamie", LastName = "Lannister"});
            characters.Add(new Character {FirstName = "Arya", LastName = "Stark"});
            characters.Add(new Character {FirstName = "Gilly", LastName = "Tarly"});

            return characters;
        }
            

    }
}