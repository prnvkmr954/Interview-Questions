using System;

namespace InterviewPrep;

public class AsyncProblem
{
    public string GetData()
    {
         return GetDataAsync().GetAwaiter().GetResult();
    }
    
    public async Task<string> GetDataAsync()
    {
        await Task.Delay(1000);
        return "Data";
    }

}
