using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.DependencyInversion.DogruOrnek
{
    public interface IDB
    {
        void Add(Exception exception);
    }
}
