using cinemaARM.Models;
using System.Text.Json;

namespace cinemaARM
{
    public partial class LoginForm : Form
    {
        private int _ruleLevel;
        private Person _person;

        public LoginForm(ref int ruleLevel, ref Person person)
        {
            InitializeComponent();
            _ruleLevel = ruleLevel;
            _person = person;
        }

        public void Login(ref int ruleLevel, ref Person person)
        {
            this.ShowDialog();
            ruleLevel = _ruleLevel;
            person = _person;
        }

        public void Login_event(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                label3.Text = "��������� ��� ����";
                label3.Visible = true;
                return;
            }

            password = ENV.getHash(password);

            string json = "";
            try
            {
                json = File.ReadAllText(ENV.DataFolder + "users.json");
            }
            catch (Exception ex)
            {
                label3.Text = "������ ������ �����";
                label3.Visible = true;
                return;
            }


            var users = JsonSerializer.Deserialize<List<Person>>(json);

            var user = users.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (user != null)
            {
                if (user.IsAdmin)
                {
                    _ruleLevel = 2;
                }
                else
                {
                    _ruleLevel = 1;
                }

                _person = user;

                this.Close();
            }
            else
            {
                textBox2.Text = "";
                label3.Text = "�������� ����� ��� ������";
                label3.Visible = true;
            }

        }
    }
}