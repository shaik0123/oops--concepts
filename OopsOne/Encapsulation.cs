using System;
using System.Collections.Generic;
using System.Text;

namespace OopsOne
{
    public class Encapsulation
    {
        private String StdName;
        private int StdId;
        public String SchoolName = "oxford";

        public String Name
        {
            get
            {
                return StdName;
            }
            set
            {
                StdName = value;
            }
            
        }

        public int Stdid
        {
            get
            {
                return StdId;
            }
            set
            {
                StdId = value;
            }
           

        }
    }


}
    
