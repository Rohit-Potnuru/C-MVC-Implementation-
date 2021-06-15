using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using leetcodeproject.Model;
using leetcodeproject.Data;

namespace leetcodeproject.Controllers
{
    //Commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            Console.WriteLine("This is C#");
            var commandItems = _repository.GetAppCommand();
            return Ok(commandItems);
        }
       
        //Get  api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandByid(int id)
        {
            var commandItem = _repository.GetCommandByid(id);
            return Ok(commandItem);
        }
    }
}