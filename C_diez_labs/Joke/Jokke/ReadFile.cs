
using System.IO;
namespace Jokke
{
    public class ReadFile
    {
        public string ReadJokeFile(StreamReader sr)
        {
            string str = null;
            str = sr.ReadToEnd();
            return str;
        }
    }
}