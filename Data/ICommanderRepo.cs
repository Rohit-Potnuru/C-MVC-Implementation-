using System.Collections.Generic;
using leetcodeproject.Model;

namespace leetcodeproject.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommand();
        Command GetCommandByid(int id); 
    }
}