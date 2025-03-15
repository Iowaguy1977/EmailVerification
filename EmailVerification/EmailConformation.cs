using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Emailverification
{
    
    public class EmailConformation
    {
       
        public  Boolean VerifyEmail(String Email)
        {
            Boolean conformation = true;
            Boolean AtFound=false;
            Boolean FirstDot=false;
            Char[] unAcceptedCharacters = { '!', '#', '$', '%', '^', '&', '*', '(', ')','|','\'','/','=','{','}','[',']',':',';','"','\\','<','>','?',',','~','`' };

            String _Email = Email;
            for (int i = 0; i < _Email.Length; i++)
            {
                if (AtFound == true && FirstDot == true)
                {
                    if (_Email[i] == '.')
                    {
                        conformation = false;
                    }

                }
                if (_Email[i] == '@')
                {
                    AtFound = true;

                }
                if (AtFound == true && _Email[i] == '.')
                {
                    FirstDot = true;

                }
               
                for (int j = 0; j < unAcceptedCharacters.Length; j++)
                {
                   
                    if (_Email[i] == ' ' || _Email[0] == '@' || _Email[i] == unAcceptedCharacters[j] || _Email.Length>320 || !_Email.Contains('@') || !_Email.EndsWith(".com"))
                    {
                        conformation = false;
                        goto LoopEnd;

                    }
                    
                   
                }

            }
            LoopEnd:

            return conformation;
        }

    }
}
