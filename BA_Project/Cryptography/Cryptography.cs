namespace BA_Project.Cryptography
{
    public static class MD5
    {
        public static string Encrypt(string text)
        {
            using (System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hash = md5.ComputeHash(bytes);

                return Convert.ToHexString(hash);
            }
        }
    }
}