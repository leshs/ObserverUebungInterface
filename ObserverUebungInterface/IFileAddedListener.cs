using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverUebungInterface
{
    interface IFileAddedListener
    {
        void NotifyFileAdded(string file);
    }
}
