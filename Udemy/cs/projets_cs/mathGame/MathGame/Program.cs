

namespace MathGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static int _numberOne;
        private static int _numberTwo;
        private static int _userResult;
        private static int _computedResult;
        private static int _numberOfGoodResults;

        enum Operations
        {
            Addition = 1,
            Multiplication = 2
        }

        private static Operations _operationType;

        private static int GetUserNumber(string messageToPrint = "")
        {
            Boolean invalidNumber = true;
            int userNumberConverted = 0;
            while (invalidNumber)
            {
                Console.WriteLine(messageToPrint);
                string? userNumber = Console.ReadLine();
                try
                {
                    userNumberConverted = int.Parse(userNumber);
                    invalidNumber = false;
                }
                catch
                {
                    Console.WriteLine("Error select a number");
                }
            }

            return userNumberConverted;
        }

        private static int RandomizeNumber(int limit)
        {
            var randomizer = new Random();
            return randomizer.Next(1, limit);
        }

        private static void CreateOperation()
        {
            _numberOne = RandomizeNumber(100);
            _numberTwo = RandomizeNumber(100);
            _operationType = (Operations) RandomizeNumber(3);
        }

        private static void SubmitOperationToUser()
        {
            string operationOperator = string.Empty;
            switch (_operationType)
            {
                case Operations.Addition:
                    operationOperator = "+";
                    break;

                case Operations.Multiplication:
                    operationOperator = "*";
                    break;
            }

            Console.Write(_numberOne + " " + operationOperator + " " + _numberTwo + "=");
            _userResult = GetUserNumber();
        }

        private static void CheckOperation()
        {
            switch (_operationType)
            {
                case Operations.Addition:
                    _computedResult = _numberOne + _numberTwo;
                    break;

                case Operations.Multiplication:
                    _computedResult = _numberOne * _numberTwo;
                    break;
            }

            if (_computedResult == _userResult)
            {
                Console.WriteLine(" good answer");
                _numberOfGoodResults++;
                return;
            }
            Console.WriteLine(" wrong answer");
        }

        static void Main(string[] args)
        {
            _numberOfGoodResults = 0;
            int operationNumber = Math.Abs(GetUserNumber("Enter the number of operations"));
            Console.WriteLine($"The number of operation(s) is {operationNumber}");
            for (int i = 0; i < operationNumber; i++)
            {
                CreateOperation();
                SubmitOperationToUser();
                CheckOperation();
            }
            Console.WriteLine($"You had {_numberOfGoodResults} good answer(s) on {operationNumber}");
        }
    }
}