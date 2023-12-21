namespace FP.Patterns.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        public string mensaje = "";

        private Singleton()
        {
            mensaje = "Hola mundo";
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }
    }
}
