
namespace AllForOneAPI.Services.MakeSentence;

    public class MakeSentenceService : IMakeSentenceService
    {
          public string GetBoth(string myName, string myZodiac)
        {
            return ("My name is " + myName + " and I'm a " + myZodiac + "!");
        }
    }
