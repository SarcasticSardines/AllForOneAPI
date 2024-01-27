
namespace AllForOneAPI.Services.ReverseNum;

    public class ReverseNumService : IReverseNumService
    {
         public string GetRNum(string reverseNum)
    {
        int num = 0;
        bool reverseN = int.TryParse(reverseNum, out num);
        string numResults = "";

        if (reverseN == true)
        {
            for (int i = reverseNum.Length; i > 0; i--)
            {
                numResults = (numResults + "" + (reverseNum[i - 1]));
            }
            return "Your number reversed is " + numResults + "!";
        }
        else
        {
            return "Unable to execute, please enter numerical values only.";
        }
    }

    }
