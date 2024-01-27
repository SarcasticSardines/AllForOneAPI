namespace AllForOneAPI.Services.Sums;

    public class SumsService : ISumsService
    {
         public string GetNumbers(string num1, string num2)
        {
            double numO = 0;
            double numT = 0;
            bool isTrueO = double.TryParse(num1, out numO);
            bool isTrueT = double.TryParse(num2, out numT);
            if(isTrueO == true & isTrueT == true){
                double add = numO + numT;
                return "The sum of your numbers is: " + add.ToString();
            }else{
                return "That was not a number";
            }
            // return (num1+num2);
        }
    }
