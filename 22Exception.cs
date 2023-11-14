using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_task
{
    public class IncorrectPaswordException : Exception
    {

        public IncorrectPaswordException(string massage ) :base( massage )
        {

        }

    }
}
