
namespace AllForOneAPI.Services.ReverseAlpha;

    public class ReverseAlphaService : IReverseAlphaService
    {
        public string GetRAlpha(string reverseAlpha)
        {
            string finalAlpha = "";

            for(int i = reverseAlpha.Length; i > 0; i--)
            {
                finalAlpha = (finalAlpha + "" + (reverseAlpha[i-1]));
            }
            return "Your word reversed is " + finalAlpha + "!";
        }
    }
