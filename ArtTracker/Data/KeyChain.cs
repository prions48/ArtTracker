namespace ArtTracker.Data
{
    /// <summary>
    /// In-app settings not needed to be abstracted to user secrets
    /// </summary>
    public static class KeyChain
    {
        public static string AppName
        {
            get
            {
                return "Art Trophies";
            }
        }
        public static string AppCode
        {
            get
            {
                return "ArtTrophies";
            }
        }
        public static string Container
        {
            get
            {
                return "trophypfilestorage";
            }
        }
        public static string OwnerEmail
        {
            get
            {
                return "prions48@gmail.com";
            }
        }
    }
    public enum Environ
    {
        Trophies
    }

}