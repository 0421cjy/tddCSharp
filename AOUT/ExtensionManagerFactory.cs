using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOUT
{
    class ExtensionManagerFactory : IExtensionManager
    {
        private IExtensionManager customManager = null;

        public IExtensionManager Create()
        {
            if (customManager != null)
            {
                return customManager;
            }

            return new FileExtensionManager();
        }

        public void SetManager(IExtensionManager manager)
        {
            customManager = manager;
        }

        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
