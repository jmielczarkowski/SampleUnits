
Console.WriteLine("Zwróć pierwszy powtarzajacy się element z tablicy.");

char[] inputArray = { 'a', 'b', 'd', 'b', 'a' };
Console.WriteLine($"Dane wejściowe: {string.Join(", ", inputArray)}");


var firstRepeatingCharacter = ArrayMethods.FindFirstRepeatingCharacter(inputArray);
if(firstRepeatingCharacter.hasResult)
    Console.WriteLine($"Wynik to: {firstRepeatingCharacter.result}");
else
    Console.WriteLine("Nie znaleziono takiego elementu.");


public static class ArrayMethods
{
    public static(bool hasResult, char result) FindFirstRepeatingCharacter(char[] myArray)
    {
        // Array is empty.
        if (!myArray.Any())
            return (false, default);

        var dict = new Dictionary<char, int>();
        for (int i = 0; i < myArray.Length; i++)
        {
            if (dict.ContainsKey(myArray[i]))
                return (true, myArray[i]);
            else
                dict.Add(myArray[i], i);
        }

        // All characters are unique.
        return (false, '\0');
    }
}