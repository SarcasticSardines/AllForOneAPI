
namespace AllForOneAPI.Services.OddorEven;

    public class OddorEvenService : IOddorEvenService
    {
         public string GetEorO(string myNum)
        {
            double myHiddenNum = 0;
            bool EorOTrue = double.TryParse(myNum, out myHiddenNum);
            if(EorOTrue == true)
            {
            if(myHiddenNum % 2 == 0)
            {
                return myNum + " is an even number!";
            }else{
                return myNum + " is an odd number!";
            }
            }else{
                return "Unable to determine, please enter a number.";
            }
        }
    }
