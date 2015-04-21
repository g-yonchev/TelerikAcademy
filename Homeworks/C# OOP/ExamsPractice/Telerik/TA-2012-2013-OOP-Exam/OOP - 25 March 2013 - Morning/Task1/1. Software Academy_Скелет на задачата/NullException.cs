namespace SoftwareAcademy
{
    using System;

    public static class NullException
    {
        public static void ValidateName(string name, string a)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("value", string.Format("Name of the {0} cannot be null or empty", a));
            }
        }
    }
}
