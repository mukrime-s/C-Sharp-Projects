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
    public partial class hardLevelGame : Form
    {
        public hardLevelGame()
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

            for (int i = 0; i < 9; i += 3)// yatay kontrol saglandi.
            {
                if (values[i] == player && values[i + 1] == player && values[i + 2] == player)
                {
                    return true;
                }
            }


            for (int i = 0; i < 3; i++)// dikey kontrol saglandi.
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
            Reset();

            // X ve O resimlerini yükle
            Image xImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\images\x.png");
            Image oImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\images\o.png");

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
            if (values[index] == 0)
            {
                button.Image = Image.FromFile(Application.StartupPath + @"../../../images/x.png"); // butonun görüntüsünü X yap
                values[index] = 1;

                if (CheckWin(1))
                {
                    MessageBox.Show("Tebrikler, kazandın!");
                    Reset();
                    return;
                }


                List<int> emptyIndices = new List<int>();// Rastgele bir O yerleştirme işlemi
                for (int i = 0; i < 9; i++)
                {
                    if (values[i] == 0)
                    {
                        emptyIndices.Add(i);
                    }
                }
                if (emptyIndices.Count > 0)
                {
                    Random random = new Random();
                    int randomIndex = emptyIndices[random.Next(emptyIndices.Count)];
                    buttons[randomIndex].Image = Image.FromFile(Application.StartupPath + @"../../../images/o.png");
                    values[randomIndex] = 2;

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
