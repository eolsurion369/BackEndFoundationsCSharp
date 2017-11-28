using System;
using System.Collections.Generic;
using System.Linq;
using BackEndFoundationsCSharp.Models;
using BackEndFoundationsCSharp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFoundationsCSharp.Controllers {
    [Route ("api/Characters")]
    public class CharactersContorller : Controller {

        [HttpGet ("{firstName}")]
        public Character Get (string firstName) {
            List<Character> characters = new CharactersRepository ().GetCharacters ();
            Character ch = characters.FirstOrDefault (c => c.FirstName == firstName);
            return ch;
        }
    }
}