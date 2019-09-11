using System;

namespace NumbersInWords
{
    class Helper
    {
        
        public static string GetOnes(string number)
        {

            int test = int.Parse(number);
            string result = "";

            if (Enum.IsDefined(typeof(Ones), test))
            {
                result += Enum.GetName(typeof(Ones), test);
            }
          
            return result;
        }

        public static string GetTens(string number)
        {
            int test = int.Parse(number);
            string result = null;
            
            if (Enum.IsDefined(typeof(Tens), test))
            {
                result += Enum.GetName(typeof(Tens), test);
            }
            else
            if (test > 0)
            {
                result = GetTens(number.Substring(0, 1) + "0") + " " + GetOnes(number.Substring(1));
            }
            
            return result;
        }

        public static string ConvertWithPower(string number)
        {
            string result = "";
            if (number.StartsWith("-"))
            {
                result += "minus ";
                number = number.Replace("-", "");
            }
            bool isDone = false;    
            double dblAmt = double.Parse(number);
            
            //valid
            if (dblAmt > 0 )
            {
                    int numDigits = number.Length;
                    int position = 0;
                    string place = "";    
                    switch (numDigits)
                    {
                        case 1:   

                            result = GetOnes(number);
                            isDone = true;
                            break;
                        case 2: 
                            result = GetTens(number);
                            isDone = true;
                            break;
                        case 3:  
                            position = (numDigits % 3) + 1;
                            place =Settings.HUNDRED;
                            break;
                        case 4:  
                        case 5:
                        case 6:
                            position = (numDigits % 4) + 1;
                            place = Settings.THOUSAND;
                            break;
                        case 7:   
                        case 8:
                        case 9:
                            position = (numDigits % 7) + 1;
                            place = Settings.MILLION;
                            break;
                        case 10:    
                        case 11:
                        case 12:

                            position = (numDigits % 10) + 1;
                            place = Settings.BILLION;
                            break;                        
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {
                        if (number.Substring(0, position) != "0" && number.Substring(position) != "0")
                        {
                           result += ConvertWithPower(number.Substring(0, position)) +
                            place + ConvertWithPower(number.Substring(position));                            
                        }
                        else
                        {
                            result += ConvertWithPower(number.Substring(0, position)) 
                            + ConvertWithPower(number.Substring(position));
                        }
                       
                    }

                    //ignore digit grouping names    
                    if (result.Trim().Equals(place.Trim())) result = "";
                }
            return result.Trim();
        }

        public static string ConvertNumber(string number)
        {
            string result = "";
            if (number.StartsWith("-"))
            {
                result += "minus ";
                number = number.Replace("-", "");
            }
            return result;
          }      

    }
}
