using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10
{
   static class  Extention
    {

        public static bool ExtentionPasswordChecked( this string password)
        {
            
            
                bool islower = false;
                bool isupper = false;
                bool isnumber = false;
                bool result = false;

                if (password.Length >= 8)
                {


                    for (int i = 0; i < password.Length; i++)
                    {


                        if (char.IsUpper(password[i]))
                        {
                            isupper = true;

                        }

                        else if (char.IsNumber(password[i]))
                        {
                            isnumber = true;
                        }

                        else if (char.IsLower(password[i]))
                        {
                            islower = true;
                        }



                        else
                        {
                           
                            return false;
                        }
                    }

                }

                else
                {
                   
                    return false;
                }

                if (isupper == true && isnumber == true && islower == true)
                {
                    result = true;
                    


                }


                return result;


            



        }



    }
}
