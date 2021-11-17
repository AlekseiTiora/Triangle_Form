using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Form
{
    public partial class Rabota : Form
    {
        public Rabota()
        {
            InitializeComponent();
        }
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a, b, c;
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
            {
                a = b = c = 0;
            }
            else
            {
                a = Convert.ToDouble(txtA.Text); // считываем значение стороны a 
                b = Convert.ToDouble(txtB.Text); // считываем значение стороны b
                c = Convert.ToDouble(txtC.Text); // считываем значение стороны c

            }
            Triangle triangle = new Triangle(a, b, c); // создаем объект класса Triangle с именем triangle
            listView1.Items.Add("Сторона a"); //добавляем соответсвующие ячейки в коллекцию item объекта
            listView1.Items.Add("Сторона b"); // (при клике на кнопку Запуск первый столбец заполнится этими нашими именами)
            listView1.Items.Add("Сторона c"); //
            listView1.Items.Add("Периметр"); //
            listView1.Items.Add("Площадь"); //
            listView1.Items.Add("Существует?");//
            listView1.Items.Add("Спецификатор: ");// 
            listView1.Items[0].SubItems.Add(triangle.outputA()); // методы по выводу сторон a, b ,c
            listView1.Items[1].SubItems.Add(triangle.outputB()); // (Item'у с индексом [i] присваиваем значение сабайтема, содержащегося во втором столбце
            listView1.Items[2].SubItems.Add(triangle.outputC()); //
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter())); //выводим периметр
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface())); // выводим значение площади
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); } // свойство Triangle.exist
            else listView1.Items[5].SubItems.Add("Не существует");
            listView1.Items[6].SubItems.Add(triangle.TriangleType);



            if (a == b && a ==c)
            {
                listView1.Items[6].SubItems.Add("равносторонний");
                pictureBox1.Image = Image.FromFile(@"..\..\Resources\ravnostoroni1.png");
            }
            else if (a == b || a == c || b == c)
            {
                listView1.Items[6].SubItems.Add("Равнобедренный");
                pictureBox1.Image = Image.FromFile(@"..\..\Resources\ravnobed1.png");
            }
            else
            {
                listView1.Items[6].SubItems.Add("Разносторонний");
                pictureBox1.Image = Image.FromFile(@"..\..\Resources\razno1.jpg");

            }
        }
        

        private void Rabota_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            my_form frm = new my_form();
            frm.Show();
            this.Hide();
        }
    }
}
