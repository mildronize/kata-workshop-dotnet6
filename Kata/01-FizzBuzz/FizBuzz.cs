namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number){
        if(number % 3 == 0)
            return "Fizz";
        if(number % 5 == 0)
            return "Buzz";
        return number.ToString(CultureInfo.InvariantCulture);
    }
}
