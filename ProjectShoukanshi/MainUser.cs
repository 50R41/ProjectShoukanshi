using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShoukanshi
{
    public partial class MainUser : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        
        public MainUser()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.Colorlist.Count);
            while (tempIndex == index)
            {
              index =  random.Next(ThemeColor.Colorlist.Count);
            }
            tempIndex = index;
            string color = ThemeColor.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }

        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void MainUser_Load(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lgn = new LoginForm();
            lgn.Show();
        }

        private void btnAnggota_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnLPR_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}
