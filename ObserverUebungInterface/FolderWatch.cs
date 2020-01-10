using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverUebungInterface
{
    class FolderWatch
    {
        public List<IFileAddedListener> FileAddedListeners = new List<IFileAddedListener>();

        public FolderWatch(string folder)
        {

        }
        public void FileAdded(string file)
        {
            foreach(IFileAddedListener listener in FileAddedListeners)
            {
                listener.NotifyFileAdded(file);
            }
        }
    }
}
