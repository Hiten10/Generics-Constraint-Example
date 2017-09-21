using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ChildClassB:BaseDisposable
    {
        public override void DisposeManagedResource()
        {
            base.DisposeManagedResource();
        }

        public override void DisposeUnmanagedResource()
        {
            base.DisposeUnmanagedResource();
        }
    }
}
