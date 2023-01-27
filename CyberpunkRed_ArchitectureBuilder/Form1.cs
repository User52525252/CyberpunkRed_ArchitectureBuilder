using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace CyberpunkRed_ArchitectureBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string Architecture = "    "+"|Lobby|";
        int BranchCount = 0;
        int Floors = 1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string FloorType = comboBox1.Text;
            string DV = numericUpDown1.Text;
            if (numericUpDown1.Text.Length<2)
            {
                DV = "|DV:0" + DV;
            }
            else if (numericUpDown1.Text.Length > 2)
            {
                DV = "|DV:" + DV.Remove(DV.Length-1);
            }
            else
            {
                DV = "|DV:" + DV;
            }
            if (Floors == 3) {
              Architecture = Architecture + Environment.NewLine + "   ||   " + Environment.NewLine + "    " + "|/Lobby|";
            }

            switch (FloorType)
            {
                case "File":
                    Architecture = Architecture + Environment.NewLine + "   ||   "  + Environment.NewLine+"|"+ Floors+"|" +DV+ "|         File          |";           
                    
                    break;
                case "Password":
                    Architecture = Architecture  + Environment.NewLine + "   ||   " + Environment.NewLine + "|" + Floors + "|" + DV + "|    Password    |";
                    break;
                case "Control Node":
                    Architecture = Architecture  + Environment.NewLine + "   ||   " + Environment.NewLine + "|" + Floors + "|" + DV + "|Control_Node|";
                    break;
                case "Black ICE":
                    Architecture = Architecture  + Environment.NewLine + "   ||   " + Environment.NewLine + "|" + Floors + "|" + DV + "|    Black_ICE    |";
                    break;
                case "Other":
                    Architecture = Architecture  + Environment.NewLine + "   ||   " + Environment.NewLine + "|" + Floors + "|" + DV + "|       Other        |";
                    break;
                default:
                    Architecture = Architecture  + Environment.NewLine + "   ||   " + Environment.NewLine + "|" + Floors + "|" + DV + "|       Other        |";
                    break;


                
            }
            Floors++;
            richTextBox1.Text = Architecture;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FloorType = comboBox1.Text;
            string DV = numericUpDown1.Text;
            if (numericUpDown1.Text.Length < 2)
            {
                DV = "|DV:0" + DV;
            }
            else if (numericUpDown1.Text.Length > 2)
            {
                DV = "|DV:" + DV.Remove(DV.Length - 1);
            }
            else
            {
                DV = "|DV:" + DV;
            }

            switch (FloorType)
            {
                case "File":
                    Architecture = Architecture + "---" + DV + "|          File          |";
                    BranchCount++;
                    break;
                case "Password":
                    Architecture = Architecture + "---" + DV + "|    Password    |";
                    BranchCount++;
                    break;
                case "Control Node":
                    Architecture = Architecture + "---" + DV + "|Control_Node|";
                    BranchCount++;
                    break;
                case "Black ICE":
                    Architecture = Architecture + "---" + DV + "|    Black_ICE    |";
                    BranchCount++;
                    break;
                case "Other":
                    Architecture = Architecture + "---" + DV + "|       Other        |";
                    BranchCount++;
                    break;
                default:
                    Architecture = Architecture + "---" + DV + "|       Other        |";
                    BranchCount++;
                    break;
            }        
            

            richTextBox1.Text = Architecture;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Architecture = "|Lobby|";
            BranchCount = 0;
            richTextBox1.Text = "";
            Floors = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "DefaultOutputName.txt";

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());

                
                

                    writer.WriteLine(richTextBox1.Text);

                

                writer.Dispose();

                writer.Close();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://cybernationuncensored.com/netarchitecture-generator/", UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        Process.Start(new ProcessStartInfo { FileName = @"https://github.com/User52525252/CyberpunkRed_ArchitectureBuilder", UseShellExecute = true });
        
        }
    }
}