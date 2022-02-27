namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string First_Name = TextBoxName.Text;
            string Last_Name = TextBoxSurname.Text;
            int Age = 0;
            bool x=true;
            try
            {
                Age = Convert.ToInt32(TextBoxAge.Text);
            }
            catch (Exception exc)
            {
                ErrorForm errorBox = new ErrorForm(exc.Message);
                errorBox.Show();
                this.Hide();
                x= false;
            }
            Person person = new Person(First_Name, Last_Name, Age);
            if (x == true)
            {
                MessageBox.Show(person.ToString() + "\n" + "You Regitered Successfully!");
            }
            else
            {
                MessageBox.Show(person.ToString() + "\n" + "Registration Failed!" + "\n" + "Please Try Again");
            }
            FileStream fileStream = new FileStream("Data1.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(person.ToString());
            fileStream.Seek(0, SeekOrigin.End);

            TextBoxName.ResetText();
            TextBoxSurname.ResetText();
            TextBoxAge.ResetText();

            streamWriter.Close();
            fileStream.Close();
        }
    }
}