using System;

namespace _35_lendo_arquivos.Entities
{
    class LogRecord
    {
        public string UserName;

        public LogRecord(string userName)
        {
            UserName = userName;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is LogRecord)) return false;
            LogRecord other = obj as LogRecord;
            return UserName.Equals(other.UserName);
        }
    }
}
