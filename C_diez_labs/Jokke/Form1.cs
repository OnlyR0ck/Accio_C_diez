using System;
using System.IO;
using System.Windows.Forms;

namespace Jokke
{
    public partial class Form1 : Form
    {
        Create_Button cb = new Create_Button();
        Button btn1;
        ReadFile rf = new ReadFile();
        public Form1()
        {
            this.btn1 = btn1;
            InitializeComponent();
            cb.CreateMyButton(btn1, this, "Jokeeeeee", 50, 50,120,50,ClickMyButton  );
            
        }

        private string buff = "";
        private void ClickMyButton(object sender, EventArgs e)
        {
            string str;
            string[] joke;
            Random rand = new Random();
            int n = 0;
            StreamReader sr = new StreamReader(@"C:\Users\kiril\source\repos\Jokke\Jokke\Joke.txt");//Это мой путь к файлу
            str = rf.ReadJokeFile(sr);
            joke = str.Split(new char[] {Convert.ToChar("$")});
            n = rand.Next(8);
            while (true)
            {
                if (buff.IndexOf(Convert.ToChar(n)) == -1)
                {
                    buff += Convert.ToString(n);
                    if (buff.Length > 8)
                    {
                        buff = "";
                            MessageBox.Show("Joke Finished");
                    }
                    else MessageBox.Show(joke[n]);
                    break;
                }
                else
                {
                    rand.Next(8);
                }
            }
        }
    }

}
