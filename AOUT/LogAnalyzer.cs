using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOUT
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;
        private bool wasLastFileNameValid;

        public LogAnalyzer()
        {
            manager = ExtensionManagerFactory.Create();
        }

        public IExtensionManager ExtensionManager
        {
            get { return manager; }
            set { manager = value; }
        }

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public bool WasLastFileNameValid
        {
            get { return wasLastFileNameValid; }
            set { wasLastFileNameValid = value;}
        }

        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName)
            && Path.GetFileNameWithOutExtension(fileName).Length > 5;
        }
    }
}
