using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Alumno
    {
        private string _noControl;
        private string _password;

        public Alumno(string noControl, string password)
        {
            _noControl = noControl;
            _password = password;
        }

        public string getNoControl()
        {
            return _noControl;
        }


        public string getPassword()
        {
            return _password;
        }

    }

}
