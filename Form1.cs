using System.Data.SQLite;
using Fitnes;
using Microsoft.Data.Sqlite;
using Rndmgenerator;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;
namespace Fitnes
{
    public partial class Form1 : Form
    {
        string? newValue;
        string? ID;
        private string path = "Viking.db";
        string? Data2;
        public Form1()
        {

            InitializeComponent();
            DataView.Columns.Add("FirstName", "�������");
            DataView.Columns.Add("Name", "���");
            DataView.Columns.Add("Otchestvo", "��������");
            DataView.Columns.Add("Data", "���� ��������");
            DataView.Columns.Add("Number", "����� ��������");
            DataView.Columns.Add("Age", "�������");
            DataView.Columns.Add("Status", "������");
            DataView.Columns.Add("Subscription", "��������");
            DataView.Columns.Add("ID", "ID");
            DataView.Columns.Add("DateReg", "���� �����������");
            OtchestvoBox.TextChanged += OtchestvoBox_TextChanged;
            familiyaBox.TextChanged += familiyaBox_TextChanged_1;
            phoneNumBox.TextChanged += phoneNumBox_TextChanged_1;
            nameBox.TextChanged += nameBox_TextChanged_1;
            buttonFirstName.Visible = false;
            buttonName.Visible = false;
            buttonPatronymic.Visible = false;
            buttonPhoneNumber.Visible = false;
            buttonBirthDate.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;
            label20.Visible = false;
            {
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Enabled = true;
                timer.Tick += new EventHandler(timer1_Tick);
            }
        }
        private void nameBox_TextChanged_1(object sender, EventArgs e)
        {
            // ���������, ������ �� ��������� ����
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                // ���� ��������� ���� ������, ������ ����� �������
                nameRedStar.Visible = true;
            }
            else
            {
                // ���� � ��������� ���� ���-�� ����, �������� �����
                nameRedStar.Visible = false;
            }
        }

        private void OtchestvoBox_TextChanged(object sender, EventArgs e)
        {
            // ���������, ������ �� ��������� ����
            if (string.IsNullOrEmpty(OtchestvoBox.Text))
            {
                // ���� ��������� ���� ������, ������ ����� �������
                otchestvoRedStar.Visible = true;
            }
            else
            {
                // ���� � ��������� ���� ���-�� ����, �������� �����
                otchestvoRedStar.Visible = false;
            }
        }
        private void phoneNumBox_TextChanged_1(object sender, EventArgs e)
        {
            // ���������, ������ �� ��������� ����
            if (string.IsNullOrEmpty(phoneNumBox.Text))
            {
                // ���� ��������� ���� ������, ������ ����� �������
                phoneRedStar.Visible = true;
            }
            else
            {
                // ���� � ��������� ���� ���-�� ����, �������� �����
                phoneRedStar.Visible = false;
            }
        }
        private void Otchestvo_TextChanged(object sender, EventArgs e)
        {
            // ���������, ������ �� ��������� ����
            if (string.IsNullOrEmpty(familiyaBox.Text))
            {
                // ���� ��������� ���� ������, ������ ����� �������
                famRedStar.Visible = true;
            }
            else
            {
                // ���� � ��������� ���� ���-�� ����, �������� �����
                famRedStar.Visible = false;
            }
        }


        private void PhoneNumBox_TextChanged(object sender, EventArgs e)
        {
            // ���������, ������ �� ��������� ����
            if (string.IsNullOrEmpty(OtchestvoBox.Text))
            {
                // ���� ��������� ���� ������, ������ ����� �������
                otchestvoRedStar.Visible = true;
            }
            else
            {
                // ���� � ��������� ���� ���-�� ����, �������� �����
                otchestvoRedStar.Visible = false;
            }
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            // ���������, ������ �� ��������� ����
            if (string.IsNullOrEmpty(phoneNumBox.Text))
            {
                // ���� ��������� ���� ������, ������ ����� �������
                phoneRedStar.Visible = true;
            }
            else
            {
                // ���� � ��������� ���� ���-�� ����, �������� �����
                phoneRedStar.Visible = false;
            }
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString($"      ���� � �����:\nyyyy.MM.dd, HH:mm:ss");
        }
        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            // ��������� ���� ������ ���� � ����������� ��������
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            // ��������� ���� ������ ���� � ������� '+'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        private void OnlyDateTime(object sender, KeyPressEventArgs e)
        {
            // ��������� ���� ������ ���� � ������� '/'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //dataRoszhdBox.Text = theDate;
        }

        private void familiyaBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                // ���������, ������ �� ��������� ����
                if (string.IsNullOrEmpty(familiyaBox.Text))
                {
                    // ���� ��������� ���� ������, ������ ����� �������
                    famRedStar.Visible = true;
                }
                else
                {
                    // ���� � ��������� ���� ���-�� ����, �������� �����
                    famRedStar.Visible = false;
                }
            }
        }

        private void SaveClient_button(object sender, EventArgs e)
        {
            if (OtchestvoBox.Text != "" && phoneNumBox.Text != "" && nameBox.Text != "" && familiyaBox.Text != "")
            {
                if (phoneNumBox.Text.Length == 11 || phoneNumBox.Text.Length == 12)
                {
                    string[] Statuses = { "������", "������-�����", "���-������" };

                    Random random = new Random();
                    int randomNumber = random.Next(0, 3);
                    int randomDay = random.Next(1, 365);
                    string FirstName1 = familiyaBox.Text;
                    string Name = nameBox.Text;
                    string OtName = OtchestvoBox.Text;
                    string Data2 = dateTimePicker1.Text;
                    string Number = phoneNumBox.Text;
                    DateTime birthDate = DateTime.Parse(dateTimePicker1.Text);

                    // �������� ������� ����
                    DateTime currentDate = DateTime.Today;

                    // ������������ ������� ����� ������� ����� � ����� �������� � �����
                    int age = currentDate.Year - birthDate.Year;

                    // ���������, ����� �� ��������������� ������� �� ������ ������ � ��� ��������
                    if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                    {
                        age--;
                    }
                    using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                    {
                        connection.Open();

                        // ���������, ���������� �� ����� �������� � ���� ������
                        string checkPhoneNumberQuery = "SELECT COUNT(*) FROM clients WHERE Number = @Number";
                        using (SqliteCommand checkPhoneNumberCommand = new SqliteCommand(checkPhoneNumberQuery, connection))
                        {
                            checkPhoneNumberCommand.Parameters.AddWithValue("@Number", Number);
                            int count = Convert.ToInt32(checkPhoneNumberCommand.ExecuteScalar());

                            // ���� ����� �������� ��� ����������, ���������� ��������� �� ������
                            if (count > 0)
                            {
                                MessageBox.Show("����� �������� ��� ���������� � ���� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // ���������� ���������� �������� ����������
                            }
                        }
                        string sqlExpression = "INSERT INTO clients (FirstName, Name, Otchestvo, Data, Number, Age,Status,Subscription,ID,DateReg) VALUES (@FirstName, @Name, @OtName, @Data2, @Number, @age,@Statuses, @Days, @GuidID,@DateReg)";
                        using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", FirstName1);
                            command.Parameters.AddWithValue("@Name", Name);
                            command.Parameters.AddWithValue("@OtName", OtName);
                            command.Parameters.AddWithValue("@Data2", Data2);
                            command.Parameters.AddWithValue("@Number", Number);
                            command.Parameters.AddWithValue("@age", age);
                            command.Parameters.AddWithValue("@Statuses", Statuses[randomNumber]);
                            command.Parameters.AddWithValue("@Days", randomDay);
                            command.Parameters.AddWithValue("@GuidID", Guid.NewGuid());
                            command.Parameters.AddWithValue("@DateReg", Convert.ToString(DateTime.Now));
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("������������ ��������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OtchestvoBox.Text = null;
                    nameBox.Text = null;
                    familiyaBox.Text = null;
                    phoneNumBox.Text = null;
                    dateTimePicker1.Text = null;
                }
                else
                {
                    MessageBox.Show("!�� ����� ������ 11 ����� ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("!�� �������� �� ��� ������� ����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelchangeclient_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Check(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;

            try
            {
                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        // ����� ������� �� ������� � �����
                        command.CommandText = "SELECT ID FROM clients WHERE FirstName = @firstName AND Name = @Name";
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@Name", lastName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ������ ������, ���������� ������ ��� �������������� ������
                                ID = reader["ID"].ToString();
                                buttonFirstName.Visible = true;
                                buttonName.Visible = true;
                                buttonPatronymic.Visible = true;
                                buttonPhoneNumber.Visible = true;
                                buttonBirthDate.Visible = true;

                                // ������� ��������� ���� ��� ����� ������� � �����
                                textBox1.Visible = false;
                                textBox2.Visible = false;
                                button3.Visible = false;
                                label13.Visible = false;
                                label14.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTextBoxAndUpdate(string columnName)
        {
            textBox3.Visible = true;
            button2.Visible = true;
            newValue = columnName;
            if (columnName == "Data")
            {
                textBox3.KeyPress += OnlyDateTime;
                textBox3.KeyPress -= OnlyNumber;
                textBox3.KeyPress -= OnlyLetters;
            }
            else if (columnName == "Number")
            {
                textBox3.KeyPress += OnlyNumber;
                textBox3.KeyPress -= OnlyLetters;
                textBox3.KeyPress -= OnlyDateTime;
            }
            else
            {
                textBox3.KeyPress += OnlyLetters;
                textBox3.KeyPress -= OnlyNumber;
                textBox3.KeyPress -= OnlyDateTime;
            }
        }
        private void UpdateClientData(string columnName, string newValue)
        {
            try
            {
                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        if (columnName == "Data")
                        {
                            textBox3.KeyPress += OnlyDateTime;
                            command.CommandText = $"UPDATE Clients SET {columnName} = @newValue, Age = @newAge WHERE ID = @id";
                            //DateTime dateTime = DateTime.ParseExact(newValue, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            DateTime dateTime = DateTime.ParseExact(newValue, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                            //DateTime numericDate = DateTime.Parse(dateTime.ToString("MM/dd/yyyy"));
                            string[] Data2 = Convert.ToString(dateTime).Split(" ");
                            command.Parameters.AddWithValue("@newValue", Data2[0]);
                            //string formattedDate = dateTime.ToString("MM/dd/yyyy");
                            DateTime birthDate = DateTime.Parse(newValue);
                            // �������� ������� ����
                            DateTime currentDate = DateTime.Today;
                            // ������������ ������� ����� ������� ����� � ����� �������� � �����
                            int age = currentDate.Year - birthDate.Year;
                            // ���������, ����� �� ��������������� ������� �� ������ ������ � ��� ��������
                            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                            {
                                age--;
                            }
                            //command.CommandText = $"UPDATE Clients SET  = @newValue WHERE ID = @id";

                            command.Parameters.AddWithValue("@newAge", age);
                            command.Parameters.AddWithValue("@id", ID);
                        }
                        else if (columnName == "Number")
                        {
                            if (textBox3.Text.Length == 11 || textBox3.Text.Length == 12)
                            {
                                // �����������, ��� � ��� ���� ������� Id ��� ������������� �������
                                command.CommandText = $"UPDATE Clients SET {columnName} = @newValue WHERE ID = @id";
                                command.Parameters.AddWithValue("@newValue", newValue);
                                command.Parameters.AddWithValue("@id", ID);
                            }
                            else
                            {
                                MessageBox.Show("�� ����� ���� ���� ��� ������", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            // �����������, ��� � ��� ���� ������� Id ��� ������������� �������
                            command.CommandText = $"UPDATE Clients SET {columnName} = @newValue WHERE ID = @id";
                            command.Parameters.AddWithValue("@newValue", newValue);
                            command.Parameters.AddWithValue("@id", ID);
                        }


                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateClientDateBrt()
        {
            try
            {

                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        // �����������, ��� � ��� ���� ������� Id ��� ������������� �������
                        command.CommandText = $"UPDATE Clients SET Data = @newValue WHERE ID = @id";
                        command.Parameters.AddWithValue("@newValue", Data2);
                        command.Parameters.AddWithValue("@id", ID);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFirstName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("FirstName");
            textBox3.KeyPress -= OnlyDateTime;
            textBox3.KeyPress -= OnlyNumber;
            label20.Visible = false;
        }
        private void buttonName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Name");
            textBox3.KeyPress -= OnlyDateTime;
            textBox3.KeyPress -= OnlyNumber;
            label20.Visible = false;
        }
        private void buttonOtName_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Otchestvo");
            textBox3.KeyPress -= OnlyDateTime;
            textBox3.KeyPress -= OnlyNumber;
            label20.Visible = false;
        }
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            ShowTextBoxAndUpdate("Number");
            textBox3.KeyPress -= OnlyDateTime;
            textBox3.KeyPress -= OnlyLetters;
            label20.Visible = false;
        }
        private void buttonDateBirt_Click(object sender, EventArgs e)
        {
            label20.Visible = true;
            ShowTextBoxAndUpdate("Data");
            textBox3.KeyPress -= OnlyLetters;
            textBox3.KeyPress -= OnlyNumber;

        }

        private void SaveChanges(object sender, EventArgs e)
        {
            UpdateClientData(newValue, textBox3.Text);
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            buttonFirstName.Visible = false;
            buttonName.Visible = false;
            buttonPatronymic.Visible = false;
            buttonPhoneNumber.Visible = false;
            buttonBirthDate.Visible = false;
            label20.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            textBox3.KeyPress -= OnlyDateTime;
            textBox3.KeyPress -= OnlyLetters;
            textBox3.KeyPress -= OnlyNumber;
        }

        private void buttonDateBirt_Click_1(object sender, EventArgs e)
        {
            UpdateClientDateBrt();
        }

        private void DeleteClients(object sender, EventArgs e)
        {
            string firstName = textBox7.Text;
            string lastName = textBox6.Text;
            using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    // ����� ������������ �� ������� � �����
                    command.CommandText = "SELECT Id FROM Clients WHERE FirstName = @firstName AND Name = @lastName";
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);

                    // ��������� Id ������������
                    string clientId;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientId = reader["Id"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // �������� ������������ �� ���� ������
                    command.CommandText = "DELETE FROM Clients WHERE Id = @id";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id", clientId);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Client deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox7.Text = null;
            textBox6.Text = null;

        }

        private void ButtonAbonement(object sender, EventArgs e)
        {
            string firstName = textBox5.Text;
            string Name = textBox4.Text;


            using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    // ����� ������� �� ������� � �����
                    command.CommandText = "SELECT ID,DateReg,Subscription FROM clients WHERE FirstName = @firstName AND Name = @Name";
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@Name", Name);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // ������ ������, ���������� ������ ��� �������������� ������
                            string TimeAb = reader["Subscription"].ToString();
                            DateTime dateTime = DateTime.Parse(reader["DateReg"].ToString());
                            // ���������� ���������� ���������� ���� � ���� �����������
                            DateTime expirationDate = dateTime.AddDays(Convert.ToInt32(TimeAb));

                            // ���������� �������, ����������� �� ��������� ����� ��������
                            TimeSpan timeRemaining = expirationDate - DateTime.Now;
                            if (timeRemaining > TimeSpan.Zero)
                            {
                                string[] DataAb = timeRemaining.ToString().Split('.');
                                MessageBox.Show($"��������:\n����: {DataAb[0]}\n�������: {DataAb[1]}");
                                textBox5.Text = null;
                                textBox4.Text = null;
                            }
                            else
                            {
                                MessageBox.Show("��������� ����");
                                textBox5.Text = null;
                                textBox4.Text = null;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
        Point lastpoint2;
        private void panelMouseMove(object sender, MouseEventArgs e)
        {       
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint2.X;
                this.Top += e.Y - lastpoint2.Y;
            }
        }
        
        private void panel1MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint2 = new Point(e.X, e.Y);
        }
        private void CloseWindows(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeWindows(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PanelRegClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = true;
            paneldeleteclient.Visible = false;
            abonementpanel.Visible = false;
            panelchangeclient.Visible = false;
        }

        private void PanelShowClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = true;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = false;
            abonementpanel.Visible = false;
            btReadAll_Click(sender, e);
        }
        private void PanelShowAbonement(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = false;
            abonementpanel.Visible = true;
        }

        private void PanelChangeClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = true;
            abonementpanel.Visible = false;
        }

        private void PanelDeleteclient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = true;
            panelchangeclient.Visible = false;
            abonementpanel.Visible = false;
        }
        private void RandomGenerator(object sender, EventArgs e)
        {
            string connectionString = $"Data Source={path};Cache=Default;Mode=ReadWrite;";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = $"DELETE FROM Clients;"; // ������ �� �������� ���� ������� �� ��������� �������

                using (SqliteCommand command = new SqliteCommand(sqlQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            RndmDBGenerator.GenerateRandomData(path);
        }


    }
}