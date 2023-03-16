using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NautilusSMS.Models
{
    //private string message = string.Empty;
    internal partial class Acerca
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
    }
    
}
