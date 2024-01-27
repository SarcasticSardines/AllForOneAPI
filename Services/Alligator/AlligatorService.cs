namespace AllForOneAPI.Services.Alligator;

    public class AlligatorService : IAlligatorService
    {
        public string GorL(string numA, string numB)
    {
        double aNum = 0;
        double bNum = 0;
        bool oneTrue = double.TryParse(numA, out aNum);
        bool twoTrue = double.TryParse(numB, out bNum);

        if (oneTrue == true & twoTrue == true)
        {
            string resultA = "";

            if (aNum > bNum)
            {
                resultA = (aNum + " > " + bNum);
            }
            else if (aNum < bNum)
            {
                resultA = (aNum + " < " + bNum);
            }
            else
            {
                resultA = (aNum + " = " + bNum);
            }

            string resultB = "";

            if (bNum > aNum)
            {
                resultB = (bNum + " > " + aNum);
            }
            else if (bNum < aNum)
            {
                resultB = (bNum + " < " + aNum);
            }
            else
            {
                resultB = (bNum + " = " + aNum);
            }
            
            if (resultA == resultB)
            {
                return (resultA);
            }
            else
            {
                return (resultA + " and " + resultB);
            }
        }
        else
        {
            return "That was not a number";
        }
    }
    }
