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
    public partial class my_form : Form
    {
        public my_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            double a, h;
            if (textA.Text == "" || txtH.Text == "")
            {
                a = h = 0;
            }
            else
            {
                a = Convert.ToDouble(textA.Text); // считываем значение стороны a 
                h = Convert.ToDouble(txtH.Text); // считываем значение высоту h
            }

            Triangle triangle = new Triangle(a,h); // создаем объект класса Triangle с именем triangle
            listView3.Items.Add("Сторона a"); //добавляем соответсвующие ячейки в коллекцию item объекта
            listView3.Items.Add("высота h"); // (при клике на кнопку Запуск первый столбец заполнится этими нашими именами)
            listView3.Items.Add("Средняя линия");
            listView3.Items.Add("Площадь"); //

            listView3.Items[0].SubItems.Add(triangle.outputA()); // методы по выводу сторон a, h
            listView3.Items[1].SubItems.Add(triangle.outputH());
            listView3.Items[2].SubItems.Add(Convert.ToString(triangle.Sredn()));
            listView3.Items[3].SubItems.Add(Convert.ToString(triangle.Surface_ploshad()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rabota form1 = new Rabota();
            form1.Show();
            this.Hide();
        }


    }
}
