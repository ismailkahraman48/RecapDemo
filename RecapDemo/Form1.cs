using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8]; //8 e 8 lik 2 boyutlu bir array tanımladım.
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++) // buttons.getupperBound 0. boyutun(Satırın) alabilceği değere kadar
                // [8,8] 0. ve 1. boyuttur, 0. boyutun alabilceği maksimum değer 7 dir. 8 e kadar.
            {
                for (int j = 0; j < buttons.GetUpperBound(1) ; j++) // 1. boyutun (Sütun) alabilceği değere kadar. 
                {
                    // ilk for dan 0. satır geldiğinde 2. for dan 0. sütun gelir bu şekilde sırayla buttonlar oluşturulur.
                    buttons[i, j] = new Button(); // her yeni buton için new button gerekli.

                    buttons[i, j].Width = 50;  
                    buttons[i, j].Height = 50;  // 50 ye 50 buton oluşturur.

                    buttons[i, j].Left = left; // değişkende belirtilen sol başlangıç değeri atanır.
                    left += 50; //Her buton koyduktan sonra 50 birim soldan uzaklığı

                    buttons[i, j].Top = top; // butonun yukardan uzaklığının başlangıcınu belirler.

                    


                    this.Controls.Add(buttons[i, j]);  // her bir buton için ekleme yapar

                    // butonu koyduktan sonra diğer butonu 50 birim ileriye diğerini koymam lazım
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    // şart bloğu ekleyerek satır ve sütunlara renk değeri atadık
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }


                }

                left = 0; // ilk satır bittiğinde diğerine geçmek için soldan uzaklık yine sıfırlanır
                
                top += 50;  // 2. satıra geçmek için yukardan uzaklık 50 birim artırılır.

            }

            Button button = new Button();
            button.Width = 50;    // enini ve boyunu ayarlar
            button.Height = 50;
            button.Text = "My button"; //butona isim verir.
            
        }
    }
}
