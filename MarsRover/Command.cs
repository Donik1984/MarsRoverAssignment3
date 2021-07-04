using System;
namespace MarsRover
{
    public class Command
    {
        public string CommandType { get; set; }
        public int NewPosition { get; set; }
        public string NewMode { get; set; }


        //public Command() { }

        public Command(string commandType)
        {
            string CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(CommandType, "Oops");
            }
        }

        public Command(string commandType, int value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            NewPosition = value;
        }
        public Command(string commandType, string value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType) || String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(commandType + " " + value, "Command type required.");
            }
            NewMode = value;
        }
    }
}