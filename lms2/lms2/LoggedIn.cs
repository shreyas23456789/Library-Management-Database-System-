using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms2
{
    public partial class LoggedIn : Form
    {
        public LoggedIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            Borrow borr = new Borrow();
            borr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            Return ret = new Return();
            ret.Show();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            AddStudent addStd = new AddStudent();
            addStd.Show();
        }

        private void publish_Click(object sender, EventArgs e)
        {
            Publish pub = new Publish();
            pub.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}
