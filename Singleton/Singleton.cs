namespace Singleton
{
    // A classe geralmente não é chamada singleton :)
    public class Singleton
    {
        #region Content
        public string Nome { get; set; }
        public int Idade { get; set; }
        #endregion

        #region Singleton
        public static Singleton _instance = new Singleton();
        private Singleton() { }
        public static Singleton Instance
        {
            get 
            { 
                return _instance; 
            }
        }
        #endregion
    }
}
