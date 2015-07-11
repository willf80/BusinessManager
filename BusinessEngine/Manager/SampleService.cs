using System;
using NHibernate;

namespace BusinessEngine.Manager
{
    public class SampleManager
    {
        private static SampleManager _instance;

        public static SampleManager GetInstance()
        {
            if (_instance != null) return _instance;
            _instance = new SampleManager();

            return _instance;
        }

        public String GetData()
        {
            using (ISession session = Dao.GetCurrentSession())
            {
                return "Good";
            }
        }
    }
}