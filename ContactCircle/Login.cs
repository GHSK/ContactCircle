using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCircle
{
     public class Login
    {
        public ErrorMessages createAccount(String userName, String passWord, String emailid)
         {
            //Check whether the username is already in use. If yes, warn the user.

             return ErrorMessages.UserNameExists;

            //if it does not exist , Check the email address(Validity). If there is an existing email id 
            //warn the user.
                //Check whether the email ID is valid
                return ErrorMessages.EmailNotValid;

                //If valid, Check whether it already exists
             return ErrorMessages.EmailExists;
            
            //check the password its strength. If not strong then return an error message

             return ErrorMessages.PasswordNotStrong;

                
            //if the email id is valid then send a mail to the user to check the validity.

             return ErrorMessages.Ok;
         }


         public bool isValidUserName(String UserName)
        {
            return true;
        }
        
         /// <summary>
         /// Tells you whether the email Id is valid
         /// </summary>
         /// <param name="emailId"></param>
         /// <returns></returns>
         public bool isValidEmailId(String emailId)
         {


             return true;
         }
         /// <summary>
         /// Tells you whether the email is already in use.
         /// </summary>
         /// <param name="emailId"></param>
         /// <returns></returns>

         public bool doesEmailIdExist(String emailId)
         {
             return true;
         }

         public bool isStrongPassword(String password)
         {
             return true;
         }


        
    }

    public enum ErrorMessages
    {Ok,UserNameExists,EmailExists,EmailNotValid,PasswordNotStrong}
}
