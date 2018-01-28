using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;


namespace ParserApp
{
    public partial class Form1 : Form
    {

        private Thread tr;

        private int first_page;

        private int last_page;

        private char param_separator = '?';

        private const string main_url = "http://vamto.net";

        public delegate void add_text(string str);

        public add_text my_delegate;
        public void add_text_method(string str)
        {
            rtb_output.Text += str;
        }

        public delegate void set_text(string[] ar);
        public set_text a_delegate;

        public void set_text_method (string [] ar)
        {
            rtb_output.Lines = ar;
        }
        public Form1()
        {
            InitializeComponent();
            UrlTxtBox.Text = main_url + "/news/";
        }


    public string getRequest(string url)
        {
            try
            {
                var httpWedRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWedRequest.AllowAutoRedirect = false;
                httpWedRequest.Method = "GET";
                httpWedRequest.Referer = "http://google.com";

                using (var httpWebResponse =(HttpWebResponse) httpWedRequest.GetResponse() )
                {
                    using (var stream = httpWebResponse.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.GetEncoding(httpWebResponse.CharacterSet)))
                        {
                            return reader.ReadToEnd();
                        }
                    }

                }
            }
            catch
            {
                return String.Empty;
            }
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            this.first_page = string2int(primariPageTxtBox.Text);

            if (this.first_page == -1 || this.first_page == 0) return;

            this.last_page = string2int(EndPageTxtBox.Text);

            if (this.last_page == -1) return;

            //tr = new Thread(start);

            start();
        }


        private void start()
        {
            my_delegate = new add_text(add_text_method);

            for (int i = this.first_page - 1; i < this.last_page; i++)
            {

                string content;
                if (i == 0)
                {
                    content = getRequest(UrlTxtBox.Text);
                }
                else
                {
                    content = getRequest(UrlTxtBox.Text + this.param_separator + "PAGEN_5=" + (i+1));
                }

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                doc.LoadHtml(content);

                HtmlAgilityPack.HtmlNodeCollection c = doc.DocumentNode.SelectNodes("//div[@class='mid pt']/h3[@class='h3 mt']/a");

                List<string> url_news = new List<string>();
                int g = 0;

                if (c != null)
                {

                    foreach (HtmlAgilityPack.HtmlNode n in c)
                    {
                        //url_news.Add(n.Attributes["href"].Value);
                        /*if(n.Attributes["href"] != null)
                        {
                            string url = n.Attributes["href"].Value;

                            rtb_output.Text += url;
                        }*/
                        //url_news.Add(n.Attributes["href"].Value);
                        url_news.Add(n.InnerText.Trim() + "\n");
                        rtb_output.Text += (url_news[g]);

                        g++;
                    }

                }

                




                //rtb_output.Invoke(a_delegate, new object[] { array_unique(rtb_output.Lines) });

                //tr.Abort();

            }
        }

        /// <summary>
        /// Убираем повторы из массива строк
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string[] array_unique (string[] input)
        {
            Dictionary<int, string> tmp = new Dictionary<int, string>();
            for(int i=0;i<input.Length;i++)
            {
                if (get_key_by_val(tmp,input[i])== -1)
                {
                    tmp.Add(i, input[i]);
                }
            }
            string[] output = new string[tmp.Count];
            int j = 0;
            foreach(string v in tmp.Values)
            {
                output[j] = v;
                j++;
            }
            return output;
        }



        /// <summary>
        /// Возвращаем ключ в словаре
        /// </summary>
        /// <param name="d"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        private int get_key_by_val(Dictionary<int,string> d, string v)
        {
            foreach(int k in d.Keys)
            {
                if (d[k] == v) return k;
            }
            return -1; 
        }


        /// <summary>
        /// Переводим строку в число
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int string2int(string str)
        {
            try
            {
                int i = Convert.ToInt16(str);
                if (i <= 0) return -1;
                else return i;
            }
            catch { return -1; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { tr.Abort(); }
            catch { }
        }
    }
}
