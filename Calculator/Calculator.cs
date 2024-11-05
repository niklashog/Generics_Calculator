namespace Calculator
{
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Rest
    }

    public class Calculator<T>
    {
        public T Calculate(T numberOne, T numberTwo, Operation operation)
        {
            while (true)
            {
                switch (operation)
                {
                    case Operation.Add:
                        return (dynamic)numberOne + (dynamic)numberTwo;
                        break;
                    case Operation.Subtract:
                        return (dynamic)numberOne - (dynamic)numberTwo;
                        break;
                    case Operation.Multiply:
                        return (dynamic)numberOne * (dynamic)numberTwo;
                        break;
                    case Operation.Divide:
                        if ((dynamic)numberTwo == 0)
                            Console.WriteLine("Du kan inte dividera ett tal med 0.");
                        return (dynamic)numberOne / (dynamic)numberTwo;
                        break;
                    case Operation.Rest:
                        return (dynamic)numberOne % (dynamic)numberTwo;
                        break;
                    default:
                        Console.WriteLine("Try with a correct operator: +, -, *, / or %");
                        break;
                }
            }
        }

        public T ParseAndCalculate(string input)
        {
            var parts = input.Split(' ');
            if (parts.Length != 3)
            {
                Console.WriteLine($"Utärkningen behöver anges enligt formatet: '1 + 2'");
            }

            T numberOne = (T)Convert.ChangeType(parts[0], typeof(T));
            T numberTwo = (T)Convert.ChangeType(parts[2], typeof(T));

            Operation operation = parts[1] switch
            {
                "+" => Operation.Add,
                "-" => Operation.Subtract,
                "*" => Operation.Multiply,
                "/" => Operation.Divide,
                "%" => Operation.Rest,
                _ => throw new InvalidOperationException($"Ogiltig operator. Använd +, -, *, / eller %")
            };

            return Calculate(numberOne, numberTwo, operation);
        }
    }
}

