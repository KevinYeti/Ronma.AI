using System;
using System.Collections.Generic;
using System.Text;

namespace Ronma.Core.Protocol.Interface.Service.Output
{
    public interface IOutputText : IOutput
    {
        void OutputText(string text);
    }
}
