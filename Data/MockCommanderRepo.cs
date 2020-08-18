using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pen"},
                new Command{id=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife & chopping board"},
                new Command{id=2, HowTo="Make cup of tea", Line="Place teabag in a cup", Platform="Kettle & cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pen"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}