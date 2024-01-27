
namespace AllForOneAPI.Services.Magic8;

    public class Magic8Service : IMagic8Service
    {
         public string GetMagic(string myQuestion)
        {
            string[] magicReply = {"Without a doubt", "As I see it, yes", "Outlook good", "Better not tell you now", "Reply hazy, try again", "Don't count on it", "Outlook not so good", "My sources say no"};
            Random random = new Random();
            int rand = random.Next(0, magicReply.Length);
            return $"{myQuestion} \n {magicReply[rand]}";
        }
        
    }
