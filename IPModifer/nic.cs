using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPModifer
{
    class nic
    {
        string nicId;
        string caption;

        public string NicId
        {
            get
            {
                return nicId;
            }

            set
            {
                nicId = value;
            }
        }

        public string Caption
        {
            get
            {
                return caption;
            }

            set
            {
                caption = value;
            }
        }
    }
}
