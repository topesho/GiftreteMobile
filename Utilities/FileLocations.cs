using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GiftreteMobileApp.Utilities
{
    class FileLocations
    {
        public string GetFolderLocation(string folder)
        {
            return Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).ToString()) + @"\" + folder + @"\";

        }
    }
}
