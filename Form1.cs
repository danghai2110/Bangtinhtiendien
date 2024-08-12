using System.Diagnostics.Eventing.Reader;

namespace Bangtinhtiendien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtskwtt.Enabled = false;
            txttongtien.Enabled = false;
            txttdm.Enabled = false;
            txtvdm.Enabled = false;

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            Int32 n1, n2, n3;
            n1 = Convert.ToInt32(txtcsm.Text);
            n2 = Convert.ToInt32(txtcsc.Text);
            n3 = n1 - n2;
            if (n3 > 50)
            {
                txtskwtt.Text = Convert.ToString(n1 - n2);
                txttdm.Text = " 50 ";
                txtvdm.Text = Convert.ToString(n3 - 50);
                txttongtien.Text = Convert.ToString(50 * 500 + (n3 - 50) * 1000);
            }
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

            

         

        
        
        
        
    

