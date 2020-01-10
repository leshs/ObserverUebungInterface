using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObserverUebungInterface
{
    class Logger
    {
        TextWriter textWriter = null;

        public Logger(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public Logger(String logfile)
        {
            textWriter = new StreamWriter(logfile);
        }

        public void WriteLine(string line)
        {
            textWriter.WriteLine(line);
            textWriter.Flush();
        }
    }
}
