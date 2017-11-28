using System;
using Microsoft.AspNetCore.Mvc;
using BackEndFoundationsCSharp.Models;

namespace BackEndFoundationsCSharp.Controllers {
    [Route("api/Characters")]
    public class CharactersContorller : Controller {

        [HttpGet]
        public Character Get() {
            Character ch = new Character();
            return ch;
        }    
    }
}