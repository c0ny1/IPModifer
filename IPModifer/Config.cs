using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPModifer
{
    public class Config:Network
    {
        private string name;
        private string time;
        private int id;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public int Id1
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
