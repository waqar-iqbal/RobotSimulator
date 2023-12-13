using RobotSimulatorCLI;

namespace RobotSimulatorTest
{
    public class InterpreterTest
    {
        private const string EXPECTEDOUTPUT = "Expected output:";

        [Test]
        public void Test()
        {
            var interpreters = Program.GetInterpreters();

            var commands = File.ReadAllLines("commands.txt");

            string actualOutput = null;

            foreach (var command in commands.Where(p => string.IsNullOrWhiteSpace(p) == false))
            {
                string expectedOutput = null;

                if (command.StartsWith(EXPECTEDOUTPUT))
                {
                    expectedOutput = command.Replace(EXPECTEDOUTPUT, "").Trim();

                    Assert.AreEqual(expectedOutput, actualOutput);
                    actualOutput = null;
                }

                var interpreter = interpreters.FirstOrDefault(c => c.CanExecute(command));
                if (interpreter != null)
                {
                    var result = interpreter.Execute(command);
                    if (result.Success && result.HasMessage)
                    {
                        actualOutput = result.Message;
                        Console.WriteLine(actualOutput);
                    }
                }
            }
        }
    }
}
