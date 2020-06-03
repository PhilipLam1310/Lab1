using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Students
    {
        protected String _uuid;
        protected String _fullname;
        protected String _birthday;
        protected Boolean _gender;

        public String UUID { get { return _uuid; } }
        public String FullName { get { return _fullname; } }
        public String Birthday { get { return _birthday; } }
        public Boolean Gender { get { return _gender; } }


    }
}
