using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] metinler = new string[3];
            //metinler[0] = "murat";

            //Random random = new Random();
            //Button btn = new Button();

            //ArrayList list1 = new ArrayList();
            //list1.Add("Murat");
            //list1.Add(10);
            //list1.Add(true);
            //list1.Add("başeren");

            //foreach (object item in list1)
            //{
            //    MessageBox.Show(item.ToString());
            //}

            //list1.Remove("başeren");

            //foreach (object item in list1)
            //{
            //    MessageBox.Show(item.ToString());
            //}


            //List<int> list2 = new List<int>();
            //list2.Add(5);
            //list2.Add(19);

            //List<string> list3 = new List<string>();
            //list3.Add("murat");

            //foreach (string item in list3)
            //{
            //    MessageBox.Show(item);
            //}
            


            //Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
            //dictionary1.Add("table", "masa");
            //dictionary1.Add("car", "araba");

            //string result1 = dictionary1["car"];    // "araba"
            //string result2 = dictionary1["table"];  // "masa"

            //MessageBox.Show(result1);
            //MessageBox.Show(result2);


            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
            dictionary2.Add("Elma", 10);
            dictionary2.Add("armut", 20);
            dictionary2.Add("Elma", 30);

            int appleCount = dictionary2["Elma"];
        }
    }
}
