using System.Data.SqlClient;

namespace FootyC_
{
    public partial class Form1 : Form
    {
        string connectionString = Environment.GetEnvironmentVariable("FOOTYAPP_DB_CONNECTION");
        SqlConnection con;
        public Form1()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set in the environment variables.");
            }

            con = new SqlConnection(connectionString);

            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    MessageBox.Show("Please enter both username and password.");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Player WHERE username = @Username AND password = @Password", con);
                    SqlCommand cmd2 = new SqlCommand("SELECT id FROM Player WHERE username = @Username AND password = @Password", con);
                    cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                    var result = cmd.ExecuteScalar();
                    var result2 = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Wrong username or password");
                    }
                    else
                    {
                        f3.userID = Convert.ToInt32(result2);
                        f3.userUsername = usernameTextBox.Text;
                        f3.ShowDialog();
                        usernameTextBox.Text = "";
                        passwordTextBox.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
