using System.Collections.Generic;
using leetcodeproject.Model;

namespace leetcodeproject.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommand()
        {
            var commands = new List<Command>{
                new Command{Id = 0, HowTo = "Congratulate 1/cotvi", Line = "Congrates DoDo", Platform = "F&M"},
                new Command{Id = 1, HowTo = "Hello 1/cotvi", Line = "DoDo DoDo", Platform = "F&M"},
                new Command{Id = 2, HowTo = "Bye 1/cotvi", Line = "Chalo DoDo", Platform = "F&M"}
            };
            
            return commands;
        }

        public Command GetCommandByid(int id)
        {
            return new Command{Id = 0, HowTo = "Congratulate 1/cotvi", Line = "Congrates DoDo", Platform = "F&M"};
            //throw new System.NotImplementedException();
        }
    }
}