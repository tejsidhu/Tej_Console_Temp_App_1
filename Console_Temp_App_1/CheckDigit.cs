using System;

namespace Console_Temp_App_1
{
    public class CheckDigit
    {
        private int checkDigitNo = 0;
        public int FindCheckDigit(int number)
        {
            int Sum;
            int checkSum = 0;
            string sNumber = number.ToString().Trim();
            try
            {
                //Go through the length of String 
                for (int i = 1; i <= sNumber.Length; i++)
                {
                    //Get the no from the right of the string
                    int tempNumber = Convert.ToInt32(sNumber.Substring(sNumber.Length - i, 1));

                    //double it at all odd positions
                    if (i % 2 == 1)
                        tempNumber *= 2;

                    //for digits > 10, take the two nos and add them together
                    if (tempNumber.ToString().Length > 1)
                        Sum = GetSumOfDigits(tempNumber);
                    else
                        Sum = tempNumber;

                    //Step 2: Adding all the digits together i.e. 1 + 1 + 1 = 3
                    checkSum += Sum;
                }
                //once you have the check Sum then calculate check digit
                checkDigitNo = 10 - (checkSum % 10);
                return checkDigitNo;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message.ToString());
            }
        }

        private int GetSumOfDigits(int tempNumber)
        {
            int sum = 0;
            for (int j = 0; j < tempNumber.ToString().Length; j++)
            {
                sum += Convert.ToInt32(tempNumber.ToString().Substring(j, 1));
            }
            return sum;
        }
    }
}
