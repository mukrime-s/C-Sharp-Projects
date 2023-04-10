using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoxGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] buttons; // butonlar dizisi
        int[] values;     // butonların durumunu tutan dizi (0: boş, 1: X, 2: O)
        bool isNextX = false; // bir sonraki resmin X mi O mu olacağını tutan değişken

        private void Reset()//oyunu basa alan fonsiyon yazildi.
        {
            for (int i = 0; i < 9; i++)
            {
                values[i] = 0; // butonlarin değerlerini sifirla
                buttons[i].Image = null; // butonların resimlerini kaldir.
            }
        }
        private bool CheckWin(int player)
        {
            // yatay kontrol
            for (int i = 0; i < 9; i += 3)
            {
                if (values[i] == player && values[i + 1] == player && values[i + 2] == player)
                {
                    return true;
                }
            }

            // dikey kontrol
            for (int i = 0; i < 3; i++)
            {
                if (values[i] == player && values[i + 3] == player && values[i + 6] == player)
                {
                    return true;
                }
            }

            if (values[0] == player && values[4] == player && values[8] == player)
            {
                return true;
            }
            if (values[2] == player && values[4] == player && values[6] == player)
            {
                return true;
            }

            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            buttons = new Button[] { button1, button2, button3, button6, button5, button4, button9, button8, button7 };
            values = new int[9];
            for (int i = 0; i < 9; i++)
            {
                values[i] = 0; // butonlar boş başlar
                buttons[i].Image = null; // butonların resimlerini boşalt
            }

            // X ve O resimlerini yükle
            Image xImage = Image.FromFile(Application.StartupPath + @"../../../images/x.png");
            Image oImage = Image.FromFile(Application.StartupPath + @"../../../images/o.png");

            // Her butona sırayla X ve O resimlerini ata
            for (int i = 0; i < buttons.Length; i++)
            {
                if (isNextX)
                {
                    buttons[i].Image = xImage;
                    values[i] = 1;
                }
                else
                {
                    buttons[i].Image = oImage;
                    values[i] = 2;
                }

                isNextX = !isNextX; // bir sonraki resmin tersini belirle
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = Array.IndexOf(buttons, button); // butonun dizideki indeksi
            if (values[index] == 0) // boş ise
            {
                if (isNextX)
                {
                    button.Image = Image.FromFile(Application.StartupPath + @"../../../images/x.png"); // butonun görüntüsünü X yap
                    values[index] = 1; // butonun değerini 1 (X) yap

                    if (CheckWin(1))
                    {
                        MessageBox.Show("Tebrikler, kazandın!");
                        Reset();
                        return;
                    }
                }
                else
                {
                    button.Image = Image.FromFile(Application.StartupPath + @"../../../images/o.png"); // butonun görüntüsünü O yap
                    values[index] = 2; // butonun değerini 2 (O) yap

                    if (CheckWin(2))
                    {
                        MessageBox.Show("Maalesef kaybettin.");
                        Reset();
                        return;
                    }
                }

                isNextX = !isNextX; // bir sonraki resmin tersini belirle

                // Rastgele bir O yerleştirme işlemi
                List<int> emptyIndices = new List<int>();
                for (int i = 0; i < 9; i++)
                {
                    if (values[i] == 0)
                    {
                        emptyIndices.Add(i); // boş olan butonların indekslerini ekle
                    }
                }
                if (emptyIndices.Count > 0) // en az bir boş buton varsa
                {
                    Random random = new Random();
                    int randomIndex = emptyIndices[random.Next(emptyIndices.Count)]; // rastgele bir indeks seç
                    buttons[randomIndex].Image = Image.FromFile(Application.StartupPath + @"../../../images/o.png"); // seçilen butonun görüntüsünü O yap
                    values[randomIndex] = 2; // seçilen butonun değerini 2 (O) yap

                    if (CheckWin(2))
                    {
                        MessageBox.Show("Maalesef kaybettin.");
                        Reset();
                        return;
                    }
                }
                else // tüm butonlar dolu ise
                {
                    MessageBox.Show("Oyun berabere bitti.");
                    Reset();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
