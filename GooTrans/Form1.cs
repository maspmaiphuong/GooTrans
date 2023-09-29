using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Net;
using System.Web;
using System.Media;
using System.IO;

namespace GooTrans
{
    public partial class GooGoo : Form
    {
        public GooGoo()
        {
            InitializeComponent();
        }

        bool eng = false;
        int tmp = 0;
        SpeechSynthesizer voice;

        private void GooGoo_Load(object sender, EventArgs e)
        {
            voice = new SpeechSynthesizer();
        }

        string basetrans(char a)
        {
            string b;
            b = "";
            if (!eng)
            {
                switch (a)
                {
                    case '1':
                        b = "một";
                        break;
                    case '2':
                        b = "hai";
                        break;
                    case '3':
                        b = "ba";
                        break;
                    case '4':
                        b = "bốn";
                        break;
                    case '5':
                        b = "năm";
                        break;
                    case '6':
                        b = "sáu";
                        break;
                    case '7':
                        b = "bảy";
                        break;
                    case '8':
                        b = "tám";
                        break;
                    case '9':
                        b = "chín";
                        break;
                    case '0':
                        b = "không";
                        break;
                }
            }
            else
            {
                switch (a)
                {
                    case '1':
                        b = "one";
                        break;
                    case '2':
                        b = "two";
                        break;
                    case '3':
                        b = "three";
                            break;
                    case '4':
                        b = "four";
                        break;
                    case '5':
                        b = "five";
                        break;
                    case '6':
                        b = "six";
                        break;
                    case '7':
                        b = "seven";
                        break;
                    case '8':
                        b = "eight";
                        break;
                    case '9':
                        b = "nine";
                        break;
                    case '0':
                        b = "zero";
                        break;
                }
            }
            return b;
        }

        string Delo(string so)
        {
            while ((so.Length > 0) && (so[0] == '0'))
            {
                so = so.Remove(0, 1);
            }
            return so;
        }

        string befbase(char a)
        {
            string b;
            b = "";
            switch (a)
            {
                case '3':
                    b = "thir";
                    break;
                case '4':
                    b = "four";
                    break;
                case '5':
                    b = "fif";
                    break;
                case '6':
                    b = "six";
                    break;
                case '7':
                    b = "seven";
                    break;
                case '8':
                    b = "eigh";
                    break;
                case '9':
                    b = "nine";
                    break;
            }
            return b;
        }

        string BaseN(string x)
        {
            string y = "";
            x = Delo(x);
            int ll = x.Length;
            if (!eng)
            {
                if (ll == 3)
                {
                    y = basetrans(x[0]) + " trăm";
                    if ((x[1] == '0') && (x[2] != '0'))
                        y = y + " lẻ " + basetrans(x[2]);
                    else if (x[1] == '1')
                    {
                        y = y + " mười";
                        if (x[2] == '5') y = y + " lăm";
                        else if (x[2] != '0') y = y + " " + basetrans(x[2]);
                    }
                    else
                    {
                        if (x[1] != '0')
                        {
                            y = y + " " + basetrans(x[1]) + " mươi";
                            if (x[2] == '5') y = y + " lăm";
                            else if (x[2] == '1') y = y + " mốt";
                            else if (x[2] != '0') y = y + " " + basetrans(x[2]);
                        }
                        else
                        {
                            if (x[2] != '0') y = y + " lẻ " + basetrans(x[2]);
                        }
                    }
                }
                else if (ll == 2)
                {
                    if (x[0] == '1')
                    {
                        y = y + "mười";
                        if (x[1] == '5') y = y + " " + "lăm";
                        else if (x[1] != '0') y = y + " " + basetrans(x[1]);
                    }
                    else
                    {
                        if (x[0] != '0')
                        {
                            y = y + basetrans(x[0]) + " mươi";
                            if (x[1] == '5') y = y + " lăm";
                            else if (x[1] == '1') y = y + " mốt";
                            else if (x[1] != '0') y = y + " " + basetrans(x[1]);
                        }
                        else
                        {
                            if (x[1] != '0') y = y + " lẻ " + basetrans(x[1]);
                        }
                    }
                }
                else if (ll == 1) y = basetrans(x[0]);
            }
            else
            {
                y = "";
                x = Delo(x);
                ll = x.Length;
                if (ll == 3)
                {
                    y = basetrans(x[0]) + " hundred";
                    if ((x[1] == '0') && (x[2] != '0'))
                        y = y + " and " + basetrans(x[2]);
                    else if (x[1] == '1')
                    {
                        if (x[2] == '0') y = y + " ten";
                        else if (x[2] == '1') y = y + " eleven";
                        else if (x[2] == '2') y = y + " twelve";
                        else y = y + " " + befbase(x[2]) + "teen";
                    }
                    else
                    {
                        if (x[1] != '0')
                        {
                            if (x[1] == '2') y = y + " twenty";
                            else
                            {
                                if (x[0] != '0')
                                    y = y + " " + befbase(x[1]) + "ty";
                                else y = y + befbase(x[1]) + "ty";
                            }
                            if (x[2] != '0') y = y + " " + basetrans(x[2]);
                        }
                        else
                        {
                            if (x[2] != '0') y = y + " and " + basetrans(x[2]);
                        }
                    }
                }
                else if (ll == 2)
                {
                    if (x[0] == '1')
                    {
                        if (x[1] == '0') y = y + " ten";
                        else if (x[1] == '1') y = y + " eleven";
                        else if (x[1] == '2') y = y + " twelve";
                        else y = y + " " + befbase(x[1]) + "teen";
                    }
                    else
                    {
                        if (x[0] != '0')
                        {
                            if (x[0] == '2') y = y + " twenty";
                            else y = y + befbase(x[0]) + "ty";
                            if (x[0] != '0') y = y + " " + basetrans(x[1]);
                        }
                        else
                        {
                            if (x[1] != '0') y = y + " and " + basetrans(x[1]);
                        }
                    }
                }
                else if (ll == 1) y = basetrans(x[0]);
            }
            return y;
        }

        string Addo(string so)
        {
            int ll = so.Length;
            while (ll != 12)
            {
                so = "0" + so;
                ++ll;
            }
            return so;
        }

        void NtoVie(string t)
        {
            string t2 = "";
            string t3 = "";
            int l, t1; l = t.Length;
            int r = l / 3;
            if (!eng)
            {
                if (l >= 3)
                {
                    t = Addo(t);
                    l = t.Length;
                    t1 = l - 1;
                    t2 = t.Substring(t1 - 2, 3);

                    if ((t2[0] == '0') && (t2 != "000"))
                    {
                        t3 = "không trăm ";
                        if (t2[1] != '0')
                            t2 = t3 + BaseN(t2);
                        else
                        if (t2 != "0") t2 = t3 + "lẻ " + BaseN(t2);
                    }
                    else t2 = BaseN(t2);
                    t1 = t1 - 3;
                    if ((r >= 1))
                    {
                        t3 = t.Substring(t1 - 2, 3);
                        t3 = BaseN(t3);
                        if (t3 != "") t2 = t3 + " ngàn " + t2;
                        t1 = t1 - 3;
                    }
                    if ((r >= 2))
                    {
                        t3 = t.Substring(t1 - 2, 3);
                        t3 = BaseN(t3);
                        if (t3 != "") t2 = t3 + " triệu " + t2;
                        t1 = t1 - 3;
                    }
                    if ((r >= 3))
                    {
                        t3 = t.Substring(t1 - 2, 3);
                        t3 = BaseN(t3);
                        if (t3 != "") t2 = t3 + " tỉ " + t2;
                    }
                }
                else t2 = BaseN(t);
            }
            else
            {
                if (l >= 3)
                {
                    t = Addo(t);
                    l = t.Length;
                    t1 = l - 1;
                    t2 = t.Substring(t1 - 2, 3);

                    if ((t2[0] == '0') && (t2 != "000"))
                    {
                        if (t2[1] != '0')
                            t2 = t3 + BaseN(t2);
                        else
                        if (t2 != "0") t2 = t3 + "and " + BaseN(t2);
                    }
                    else t2 = BaseN(t2);
                    t1 = t1 - 3;
                    if ((r >= 1))
                    {
                        t3 = t.Substring(t1 - 2, 3);
                        t3 = BaseN(t3);
                        if (t3 != "") t2 = t3 + " thousand " + t2;
                        t1 = t1 - 3;
                    }
                    if ((r >= 2))
                    {
                        t3 = t.Substring(t1 - 2, 3);
                        t3 = BaseN(t3);
                        if (t3 != "") t2 = t3 + " million " + t2;
                        t1 = t1 - 3;
                    }
                    if ((r >= 3))
                    {
                        t3 = t.Substring(t1 - 2, 3);
                        t3 = BaseN(t3);
                        if (t3 != "") t2 = t3 + " billion " + t2;
                    }
                }
                else t2 = BaseN(t);
            }
            ReadNum.Text = t2;
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox n = (TextBox)sender;

            if (n.Text.Length >= 12)
            {
                if ((e.KeyChar == 8) || (e.KeyChar == 127) || (e.KeyChar == 13))
                    e.Handled = false;
                else e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                string k = Num.Text;
                NtoVie(k);
            }
            else
            if ((n.Text.Contains("1") || n.Text.Contains("2") ||
                 n.Text.Contains("3") || n.Text.Contains("4") ||
                 n.Text.Contains("5") || n.Text.Contains("6") ||
                 n.Text.Contains("7") || n.Text.Contains("8") ||
                 n.Text.Contains("9")) && (e.KeyChar == '0') &&
                 (n.Text.Length < 12))
                e.Handled = false;
            else
            if (((e.KeyChar >= 32) && (e.KeyChar < 49)) || (e.KeyChar > 57)) e.Handled = true;

            if (n.Text.Length != 0)
            {
                if ((n.Text.Length == 1) && (n.Text[0] == '0'))
                {
                    ReadNum.Text = "không";
                    n.Text = "";
                }
                else
                if ((n.Text[0] == '0') && (n.Text.Length > 1))
                {
                    n.Text = Delo(n.Text);
                }
            }
        }
    
        private void Eng_Click(object sender, EventArgs e)
        {
            eng = true;
            if (Num.Text != "") NtoVie(Num.Text);
            else ReadNum.Text = "";
        }

        private void Vie_Click(object sender, EventArgs e)
        {
            eng = false;
            if (Num.Text != "") NtoVie(Num.Text);
            else ReadNum.Text = "";
        }

        private void Audio_Click(object sender, EventArgs e)
        {
            string k = ReadNum.Text;
            tmp++;
            if (k != "")
            {
                if (eng) voice.SpeakAsync(k);
                else
                {
                    var url = "https://translate.google.com/translate_tts?ie=UTF-8&client=tw-ob&tl=" + "vi" + "&q=" + k + "&rd=";
                    url += HttpUtility.UrlEncode(k, Encoding.GetEncoding("utf-8"));
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(url,"speech" + tmp.ToString() + ".mp3");
                    }

                    WMPLib.WindowsMediaPlayer maspplayer = new WMPLib.WindowsMediaPlayer();
                    maspplayer.URL = "speech" + tmp.ToString() + ".mp3";
                    maspplayer.controls.play();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (eng) MessageBox.Show("See you next time!");
            else MessageBox.Show("Hẹn gặp lại bạn!");
            Application.Exit();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (!eng)
            {
                helpbox.Visible = true;
                var t = Task.Delay(2500);
                t.Wait();
                helpbox.Visible = false;
            }
            else
            {
                helpbox2.Visible = true;
                var t = Task.Delay(2500);
                t.Wait();
                helpbox2.Visible = false;
            }
        }
    }
}
