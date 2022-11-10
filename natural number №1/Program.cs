namespace natural_number__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное натуральное число:");
            var A = Convert.ToInt32(Console.ReadLine());
            var numbers = intToDigit(A).OrderBy(x => x);    
        }
        static List<int> intToDigit(int A)
        {
            A = Math.Abs(A);
            var numbers = new List<int>();
            while (A>0)
            {
                int number = A % 10;
                A /= 10;
                numbers.Add(number);
            }
            var result = 0;
            var amount = numbers.Count();
            foreach (var q in numbers)
            {
                result *= 10;
                result += q;
            }
             result*=result;
            Console.WriteLine("Число 'наоборот' возведённое в квадрат:");
            Console.WriteLine(result);
            return numbers;
        }
    }
}
