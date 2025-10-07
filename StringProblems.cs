using System.Diagnostics.Metrics;

public class StringProblem
{
    /// <summary>
    /// Program No 1
    /// </summary>
    /// <param name="inputKey"></param>
    public void CountStringCharacter(string inputKey)
    {
        int count = 0;
        // for (int i = 0; i < inputKey.Length; i++)
        // {
        //     count++;
        // }

        foreach (char item in inputKey)
        {
            count++;
        }

        Console.WriteLine("Total Number of Character is : " + count);
    }
    /// <summary>
    /// Program No 2
    /// </summary>
    /// <param name="inputKey"></param>
    public void CountEachCharatcerString(string inputKey)
    {

        List<char> processed = new List<char>();

        foreach (char item in inputKey)
        {
            if (!processed.Contains(item))
            {
                int count = 0;
                foreach (char innerItem in inputKey)
                {
                    if (innerItem == item)
                    {
                        count++;
                    }
                }
                Console.WriteLine(item + "-" + count);
                processed.Add(item);

            }
        }

    }

    public void CountEachCharatcerStringUsingDictionary(string inputKey)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (var item in inputKey)
        {
            if (!charCount.ContainsKey(item))
            {
                charCount[item] = 1;
            }
            else
            {
                charCount[item]++;
            }
        }

        foreach (var pair in charCount)
        {
            Console.WriteLine(pair.Key + "-" + pair.Value);
        }

    }

    public void WordFrequencyCounter(string inputKey)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string[] inputList = inputKey.Split();

        foreach (var item in inputList)
        {
            if (wordCount.ContainsKey(item))
            {
                wordCount[item]++;
            }
            else
            {
                wordCount[item] = 1;
            }
        }

        foreach (var item in wordCount)
        {

            Console.WriteLine(item.Key + "-" + item.Value);
        }
    }

    public void CountVowelsInString(string inputVowel)
    {
        Dictionary<char, int> vowelCount = new Dictionary<char, int>();
        var inputVowelToLower = inputVowel.ToLower();

        foreach (char item in inputVowelToLower)
        {
            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
            {
                if (vowelCount.ContainsKey(item))
                {
                    vowelCount[item]++;
                }
                else
                {
                    vowelCount[item] = 1;
                }
            }
        }

        foreach (var pair in vowelCount)
        {
            Console.WriteLine(pair.Key + "-" + pair.Value);
        }
    }

    public void StoreStudentMarks()
    {
        Dictionary<string, int> studentDetails = new Dictionary<string, int>();
        int studentListCount = 5;
        for (int i = 0; i < studentListCount; i++)
        {

            Console.WriteLine("Enter Students Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Students Marks: ");
            int marks = int.Parse(Console.ReadLine());
            studentDetails.Add(name, marks);
        }

        foreach (var item in studentDetails)
        {
            Console.WriteLine(item.Key + "-" + item.Value);
        }

        Console.WriteLine("========================================================");


        Console.WriteLine("Enter Students Name : ");
        string searchName = Console.ReadLine();

        if (studentDetails.ContainsKey(searchName))
        {
            Console.WriteLine(searchName + "- " + studentDetails[searchName]);
        }
        else
        {
            Console.WriteLine($" Student  with name {searchName} does not exist");
        }


    }

    public void CountandSortNumber(long inputNumber)
    {
        Dictionary<char, int> countedNumbers = new Dictionary<char, int>();

        foreach (var item in inputNumber.ToString())
        {
            if (countedNumbers.ContainsKey(item))
            {
                countedNumbers[item]++;
            }
            else
            {
                countedNumbers[item] = 1;
            }
        }

        // UnSorted Frequency
        foreach (var item in countedNumbers)
        {
            Console.WriteLine(item.Key + "-" + item.Value);
        }


        Console.WriteLine("====================================");

        // Sorted frequency 
        var sorted = countedNumbers.OrderBy(x => x.Key);

        foreach (var item in sorted)
        {
            Console.WriteLine(item.Key + "-" + item.Value);
        }
    }

    public void RemoveDuplicateFromArray(int[] num)
    {


        // int[] unique = num.Distinct().ToArray();

        // Console.WriteLine(string.Join(", ", unique));


        HashSet<int> uniqueSet = new HashSet<int>(num);

        int[] unique = new int[uniqueSet.Count];
        uniqueSet.CopyTo(unique);

        Console.WriteLine(string.Join(", ", unique));


        List<int> uniques = new List<int>();

        foreach (var item in num)
        {
            if (!unique.Contains(item))
            {
                uniques.Add(item);
            }
        }

        Console.WriteLine(string.Join(", ", unique));
    }

}
