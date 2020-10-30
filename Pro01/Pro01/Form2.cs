using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01
{
    public partial class Form2 : Form
    {
        public string as1, as2, as3, as4, as5;   
        public int cn1, cn2, cn3, cn4, cn5;
        
        public Form2() 
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = cn1;
            comboBox2.SelectedIndex = cn2;
            comboBox3.SelectedIndex = cn3;
            comboBox4.SelectedIndex = cn4;
            comboBox5.SelectedIndex = cn5;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            as1 = comboBox1.Text;    // 결과값 가져다 쓰려고 위에서 선언한 public 변수에 갖다 넣기!
            as2 = comboBox2.Text;
            as3 = comboBox3.Text;
            as4 = comboBox4.Text;
            as5 = comboBox5.Text;

            cn1 = comboBox1.SelectedIndex;
            cn2 = comboBox2.SelectedIndex;
            cn3 = comboBox3.SelectedIndex;
            cn4 = comboBox4.SelectedIndex;
            cn5 = comboBox5.SelectedIndex;

        }
    }
}
