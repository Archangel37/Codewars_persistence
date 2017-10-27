using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codewars_persistence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        public int persistence(string num)
        {
            List<char> split = new List<char>();
            split = num.ToCharArray().ToList();
            int iter = 0;
            int Mult = 1;
            int multiplier;
            while (split.Count>1)
            {
                Mult = 1;
                for (int i = 0; i < split.Count; i++) 
                {
                    multiplier = Int32.Parse(Convert.ToString(split[i]));
                    Mult *= multiplier;
                } 
                iter++;
                split.Clear();
                split = Convert.ToString(Mult).ToCharArray().ToList(); 
            }
            return iter;
        }

        public void Tests()
        { 
        if (persistence("39") == 3) { MessageBox.Show("Test1 - OK", "Test", MessageBoxButtons.OK);}
        else MessageBox.Show("Test1 - Fail!!!", "Test", MessageBoxButtons.OK);
        if (persistence("999") == 4) { MessageBox.Show("Test2 - OK", "Test", MessageBoxButtons.OK); }
        else MessageBox.Show("Test2 - Fail!!!", "Test", MessageBoxButtons.OK);
        if (persistence("4") == 0) { MessageBox.Show("Test3 - OK", "Test", MessageBoxButtons.OK); }
        else MessageBox.Show("Test3 - Fail!!!", "Test", MessageBoxButtons.OK);
        
        }


        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            Tests();

            try
            {
                textBox_result.Text = Convert.ToString(persistence(textBox_input.Text));
            }
            catch (FormatException)
            { MessageBox.Show("Error input", "Wrong input", MessageBoxButtons.OK); }
            catch (OverflowException)
            { MessageBox.Show("Too Big number", "Wrong input", MessageBoxButtons.OK); }

           
        }
    }
}
