namespace Train_Boocking
{
    public partial class login : Form
    {
        private Point lastLocation;

        public login()
        {
            InitializeComponent();
            txtEmail.SelectAll();
        }

        //buttons on click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "ali" && txtPassword.Text == "111")
            {
                launch form = new launch();
                form.Show();
                this.Hide();
                txtEmail.Text = "Enter your user name";
                txtPassword.Text = "Enter your password";
                txtPassword.UseSystemPasswordChar = false;
                lblInvalid.Visible = false;
                txtPassword.ForeColor = Color.DimGray;
                txtEmail.Select();
            }
            else
            {
                lblInvalid.Visible = true;
            }
        }

        //mouse down, up, move
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
            this.Opacity = 0.85;
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        //mouse enter, leave
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void lblForget_MouseEnter(object sender, EventArgs e)
        {
            lblForget.ForeColor = Color.FromArgb(92, 109, 156);
        }

        private void lblForget_MouseLeave(object sender, EventArgs e)
        {
            lblForget.ForeColor = Color.White;
        }

        //textbox enter, leave
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Enter your user name")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter your user name";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter your password";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Select();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            verify v = new verify();
            v.Show();
        }
    }
}