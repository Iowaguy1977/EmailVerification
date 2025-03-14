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
            Boolean conformation = false;
            Char[] unAcceptedCharacters = { '!', '#', '$', '%', '^', '&', '*', '(', ')','|','\'','/','=','{','}','[',']',':',';','"','\\','<','>','?',',','~','`' };

            String _Email = Email;
            for (int i = 0; i < _Email.Length; i++)
            {
                for (int j = 0; j < unAcceptedCharacters.Length; j++)
                {
                    if (_Email[i] == ' ' || _Email[0] == '@' || _Email[i] == unAcceptedCharacters[j] || _Email.Length>320 || !_Email.Contains('@') || !_Email.EndsWith(".com") || _Email.)
                    {
                        conformation = false;
                        goto LoopEnd;

                    }
                    else
                    {
                        conformation = true;
                    }
                }

            }
            LoopEnd:

            return conformation;
        }

    }
}
