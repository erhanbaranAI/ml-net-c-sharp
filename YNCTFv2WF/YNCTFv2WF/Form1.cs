using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YNCTFv2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>
        {
            "AHatasi",
            "BHatasi",
            "CHatasi",
            "DHatasi"
        };
        public static string createClassName(string className)
        {
            string returnedName = className;
            returnedName = returnedName.Replace("ü", "u").Replace("Ü", "U").Replace("ö", "o")
            .Replace("Ö", "O").Replace("Ğ", "G").Replace("ğ", "g").Replace("İ", "I").Replace("ı", "i")
            .Replace("ç", "c").Replace("Ç", "C").Replace("Ş", "S").Replace("ş", "s").Replace(" ","");


            return returnedName;
        }
        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Images (*.PNG;*.JPG;)|*.PNG;*.JPG;|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "My Image Browser";
        }
        public void addClass(string className)
        {
            list.Add(className);
        }
       

        private void AHatasi_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
            DialogResult dr = this.openFileDialog1.ShowDialog();
            string dirA = imagePath + "//AHatasi";
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string[] folder = Directory.GetFiles(dirA);
                    foreach (string _file in folder)
                    {
                        File.Delete(_file);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                var a = openFileDialog1.FileNames.Length;
                label5.Text = a.ToString();
                var fileNames = this.openFileDialog1.FileNames;
                sayac = 0;
                foreach (var fileName in fileNames)
                {
                    sayac++;
                    File.Copy(fileName, dirA + @"\" + sayac.ToString() + ".png", false);
                }
            }
        }
        int Y = 60;
        int sayac = 0;
        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            string hata_sinifi = textBox1.Text.Trim();
            hata_sinifi = createClassName(hata_sinifi);
            string message = textBox1.Text.Trim();
            if (list.Exists(x => list.Contains(hata_sinifi)) == false)
            {
                if (hata_sinifi != null && hata_sinifi != " " && hata_sinifi != "")
                {
                    //buton
                    Button btn = new Button();
                    btn.Text = message;
                    btn.Name = hata_sinifi;
                    btn.Size = new Size(125, 40);
                    btn.Location = new Point(52, (220 + Y));
                    list.Add(hata_sinifi);


                    //eklenen veri sayısı label
                    Label lbl1 = new Label();
                    lbl1.Text = "Eklenen Veri Sayısı: ";
                    lbl1.Name = "lbl" + hata_sinifi;
                    lbl1.Size = new Size(135, 20);
                    lbl1.Location = new Point(198, (230 + Y));

                    //sayı label
                    Label lbl2 = new Label();
                    lbl2.Text = "0";
                    lbl2.Name = "lbl" + hata_sinifi + "count";
                    lbl2.Size = new Size(17, 25);
                    lbl2.Location = new Point(339, (230 + Y));
                    string dirClass = imagePath + hata_sinifi;
                    Directory.CreateDirectory(dirClass);

                    btn.Click += (s, e) =>
                    {
                        
                        InitializeOpenFileDialog();
                        DialogResult dr = this.openFileDialog1.ShowDialog();

                        if (dr == System.Windows.Forms.DialogResult.OK)
                        {
                           
                            try
                            {
                                string[] folder = Directory.GetFiles(dirClass);
                                foreach (string _file in folder)
                                {
                                    File.Delete(_file);
                                }
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                            int a = 0;
                            a = openFileDialog1.FileNames.Length;
                            MessageBox.Show("sayi: " + a);
                            
                            lbl2.Text = a.ToString();
                            var fileNames = this.openFileDialog1.FileNames;
                            sayac = 0;
                            foreach (var fileName in fileNames)
                            {
                                sayac++;
                                File.Copy(fileName, dirClass+@"\"+sayac.ToString()+".png",false);
                            }
                        }
                    };
                    Y = Y + 60;
                    Controls.Add(btn);
                    Controls.Add(lbl1);
                    Controls.Add(lbl2);
                    MessageBox.Show(hata_sinifi + " sınıfı başarıyla eklendi", "Başarılı");
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Hata Sınıfı Adı Giriniz!", "HATA");
                }
            }
            else
            {
                MessageBox.Show("Bu İsimde Bir Hata Sınıfı Zaten Mevcut!", "HATA");
            }

            textBox1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void BHatasi_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
            DialogResult dr = this.openFileDialog1.ShowDialog();

            string dirB = imagePath + "//BHatasi";
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string[] folder = Directory.GetFiles(dirB);
                    foreach (string _file in folder)
                    {
                        File.Delete(_file);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                var a = openFileDialog1.FileNames.Length;
                label6.Text = a.ToString();
                var fileNames = this.openFileDialog1.FileNames;
                sayac = 0;
                foreach (var fileName in fileNames)
                {
                    sayac++;
                    File.Copy(fileName, dirB + @"\" + sayac.ToString() + ".png", false);
                }
            }
        }

        private void CHatasi_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
            DialogResult dr = this.openFileDialog1.ShowDialog();
            string dirC = imagePath + "//CHatasi";
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string[] folder = Directory.GetFiles(dirC);
                    foreach (string _file in folder)
                    {
                        File.Delete(_file);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                var a = openFileDialog1.FileNames.Length;
                label7.Text = a.ToString();
                var fileNames = this.openFileDialog1.FileNames;
                sayac = 0;
                foreach (var fileName in fileNames)
                {
                    sayac++;
                    File.Copy(fileName, dirC + @"\" + sayac.ToString() + ".png", false);
                }
            }
        }

        private void DHatasi_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
            DialogResult dr = this.openFileDialog1.ShowDialog();

            string dirD = imagePath + "//DHatasi";
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string[] folder = Directory.GetFiles(dirD);
                    foreach (string _file in folder)
                    {
                        File.Delete(_file);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                var a = openFileDialog1.FileNames.Length;
                label8.Text = a.ToString();
                var fileNames = this.openFileDialog1.FileNames;
                sayac = 0;
                foreach (var fileName in fileNames)
                {
                    sayac++;
                    File.Copy(fileName, dirD + @"\" + sayac.ToString() + ".png", false);
                }
            }
        }

        string imagePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Images\\";
        string weightPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\SampleImageClassification";

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Directory.Exists(weightPath))
            {
                Directory.Delete(weightPath);
            }
            string dir = imagePath;
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MessageBox.Show("Image Class'ı Oluşturuldu! Temel Hata Sınıfları Oluşturuluyor..");
                string dirA = dir + "\\AHatasi";
                string dirB = dir + "\\BHatasi";
                string dirC = dir + "\\CHatasi";
                string dirD = dir + "\\DHatasi";
                Directory.CreateDirectory(dirA);
                Directory.CreateDirectory(dirB);
                Directory.CreateDirectory(dirC);
                Directory.CreateDirectory(dirD);
                MessageBox.Show("Her şey Hazır Uygulama Başlatılıyor..");
            }
            else
            {
                MessageBox.Show("Veri Seti Tespit Edildi! Temizleniyor..");
                Directory.Delete(dir, true);
                MessageBox.Show("Temizleme Başarılı! Yeniden Oluşturuluyor..");
                Directory.CreateDirectory(dir);
                MessageBox.Show("Image Class'ı Oluşturuldu! Temel Hata Sınıfları Oluşturuluyor..");
                string dirA = dir + "\\AHatasi";
                string dirB = dir + "\\BHatasi";
                string dirC = dir + "\\CHatasi";
                string dirD = dir + "\\DHatasi";
                Directory.CreateDirectory(dirA);
                Directory.CreateDirectory(dirB);
                Directory.CreateDirectory(dirC);
                Directory.CreateDirectory(dirD);
                MessageBox.Show("Her şey Hazır Uygulama Başlatılıyor..");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(imagePath))
            {
                MessageBox.Show("Her şey Temizleniyor..");
                Directory.Delete(imagePath, true);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists(imagePath))
            {
                Directory.Delete(imagePath, true);
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            //Process.Start("cmd.exe");

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //MessageBox.Show(path);
            Process.Start("cmd.exe", "/c" + "cd " + path + "&"+ "mlnet image-classification --dataset \"Images\" ");
            //Process.Start("cmd.exe", "/k" + "mlnet image-classification --dataset \"Images\" ");
            MessageBox.Show("Eğitim Tamamlandı --"+path+" içerisindeki SampleImageClassification içerisinden detaylara bakabilirsiniz!");

        }
    }
}
