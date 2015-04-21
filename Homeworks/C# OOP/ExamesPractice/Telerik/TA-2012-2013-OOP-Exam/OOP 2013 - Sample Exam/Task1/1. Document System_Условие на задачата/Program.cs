using System;
using System.Collections.Generic;
using DocumentSystem;

namespace DocumentSystem
{


    public class Program
    {
        public static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {

            DocumentSystem documentSystem = new DocumentSystem();

            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                documentSystem.AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                documentSystem.AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                documentSystem.AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                documentSystem.AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                documentSystem.AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                documentSystem.AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                documentSystem.ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                documentSystem.EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                documentSystem.DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                documentSystem.EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                documentSystem.ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }
    }
}