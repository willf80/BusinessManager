using System;
using System.IO;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;

namespace BusinessEngine
{
    public class Dao
    {
        private static ISessionFactory SessionFactory;

        private string configFile;

        public Dao(string configFile)
        {
            this.configFile = configFile;
        }

        private void OpenSession(string configFile)
        {
            {
                SessionFactory = new Configuration().Configure(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFile)).BuildSessionFactory();
            }
        }

        public ISession GetSession()
        {
            if (SessionFactory == null)
                this.OpenSession(this.configFile);

            return SessionFactory.OpenSession();
        }

        private static void OpenSession()
        {
            Configuration configuration = new Configuration();
            SessionFactory = new Configuration().Configure().BuildSessionFactory();
            configuration.AddAssembly(Assembly.GetCallingAssembly());
            SessionFactory = configuration.BuildSessionFactory();
        }

        public static ISession GetCurrentSession()
        {
            if (SessionFactory == null)
                Dao.OpenSession();

            return SessionFactory.OpenSession();
        }

        public static void CloseSessionFactory()
        {
            if (SessionFactory != null)
                SessionFactory.Close();
        }
    }
}
