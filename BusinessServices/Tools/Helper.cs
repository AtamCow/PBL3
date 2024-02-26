using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;



namespace OnlineExamSystem
{
    public class Helper
    {
        public static bool VerifyPassword(string password, string storedHash)
        {
            // Compare the provided password with the stored hash
            bool isVerified = BC.Verify(password, storedHash);
            return isVerified;
        }

        public static string HashPassword(string password)
        {
            // Generate a salted and hashed password using the default work factor
            string hashedPassword = BC.HashPassword(password);
            return hashedPassword;
        }

        public static string GetAccRoleString(int Role)
        {
            AccRole x = (AccRole)Enum.ToObject(typeof(AccRole), Role);
            return x.ToString();
        }
        public static string RemoveVietnameseAccents(string text)
        {
            text = text.ToLowerInvariant();
            Dictionary<char, char> map = new Dictionary<char, char>
            {
                {'à', 'a'}, {'á', 'a'}, {'ả', 'a'}, {'ã', 'a'}, {'ạ', 'a'},
                {'ă', 'a'}, {'ằ', 'a'}, {'ắ', 'a'}, {'ẳ', 'a'}, {'ẵ', 'a'}, {'ặ', 'a'},
                {'â', 'a'}, {'ầ', 'a'}, {'ấ', 'a'}, {'ẩ', 'a'}, {'ẫ', 'a'}, {'ậ', 'a'},
                {'đ', 'd'},
                {'è', 'e'}, {'é', 'e'}, {'ẻ', 'e'}, {'ẽ', 'e'}, {'ẹ', 'e'},
                {'ê', 'e'}, {'ề', 'e'}, {'ế', 'e'}, {'ể', 'e'}, {'ễ', 'e'}, {'ệ', 'e'},
                {'ì', 'i'}, {'í', 'i'}, {'ỉ', 'i'}, {'ĩ', 'i'}, {'ị', 'i'},
                {'ò', 'o'}, {'ó', 'o'}, {'ỏ', 'o'}, {'õ', 'o'}, {'ọ', 'o'},
                {'ô', 'o'}, {'ồ', 'o'}, {'ố', 'o'}, {'ổ', 'o'}, {'ỗ', 'o'}, {'ộ', 'o'},
                {'ơ', 'o'}, {'ờ', 'o'}, {'ớ', 'o'}, {'ở', 'o'}, {'ỡ', 'o'}, {'ợ', 'o'},
                {'ù', 'u'}, {'ú', 'u'}, {'ủ', 'u'}, {'ũ', 'u'}, {'ụ', 'u'},
                {'ư', 'u'}, {'ừ', 'u'}, {'ứ', 'u'}, {'ử', 'u'}, {'ữ', 'u'}, {'ự', 'u'},
                {'ỳ', 'y'}, {'ý', 'y'}, {'ỷ', 'y'}, {'ỹ', 'y'}, {'ỵ', 'y'}
            };
            foreach (KeyValuePair<char, char> pair in map)
            {
                text = text.Replace(pair.Key, pair.Value);
            }

            return text;
        }
        public static void ExitProcess()
        {
            Environment.Exit(0);
        }
        public static void Shuffle<T>(IList<T> list)
        {
            Random random = new Random();

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}
