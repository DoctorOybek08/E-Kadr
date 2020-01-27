using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Threading;

namespace Kadr
{
    public partial class Form1 : Form
    {
        public static ZagruzkaPage splashForm = null;
        public static Connect sql = new Connect();
        public static Connect sql1 = new Connect();
        private Main main;
        public string user;

        public static string user_global;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Sets the timer interval to 5 seconds.
            timer1.Interval = 5000;
            timer1.Start();
            run_main();
        }

        public void run_main()
        {
            sql.Connection();
            sql1.Connection();

            sql.myReader = sql.return_MySqlCommand("select user from users").ExecuteReader();
            while (sql.myReader.Read())
            {
                user_comboBox.Items.Add(sql.myReader.GetString("user"));
            }
            sql.myReader.Close();
        }



        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string key = System.IO.File.ReadAllText("docs\\key.txt");
                user = user_comboBox.Text;

                user_global = user_comboBox.Text;

                if (key == "yoq")
                {
                    timer1.Stop();
                    sql.myReader = sql.return_MySqlCommand("select password from users where user = '" + user_comboBox.Text + "' ").ExecuteReader();
                    while (sql.myReader.Read())
                    {
                        if (pasword_textBox.Text.ToString().Equals(sql.myReader.GetString("password")))
                        {
                            this.Hide();
                            splashForm = new ZagruzkaPage();
                            ////splashForm.WindowState = FormWindowState.Maximized;
                            splashForm.Show();
                            ////Thread thread = new Thread(CreateLoading);
                            ////thread.Start();
                            await Task.Run(() =>
                            {
                                main = new Main(user);
                            });
                            splashForm.Close();
                            splashForm.Dispose();
                            splashForm = null;

                            //thread.Abort();
                            main.ShowDialog();
                        }
                    }
                    sql.myReader.Close();
                    this.Show();
                }
                else if (key == "bor")
                {
                    ManagementObjectSearcher theSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE caption='eKalit'");
                    if (theSearcher.Get().Count > 0)
                    {

                    }
                    else
                    {
                        errorLabel.Text = "Калит мавжут эмас!!!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Кириш " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public void CreateLoading()
        {
            
        }
        static void MainFormLoad(object sender, EventArgs e)
        {
            CloseSplashScreen();
        }
        static void CloseSplashScreen()
        {
            try
            {
                if (splashForm == null)
                {
                    return;
                }

                splashForm.Invoke(new Action(splashForm.Close));
                splashForm.Dispose();
                splashForm = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Program 2: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("HELLO");
            ManagementObjectSearcher theSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE caption='eKalit'");
            if (theSearcher.Get().Count > 0)
            {
                foreach (ManagementObject currentObject in theSearcher.Get())
                {
                    string device_id = currentObject.GetPropertyValue("DeviceID").ToString();
                    string caption = currentObject.GetPropertyValue("Caption").ToString();
                    string name = currentObject.GetPropertyValue("Name").ToString();
                    string guid = currentObject.GetPropertyValue("ClassGuid").ToString();
                    Console.WriteLine("DeviceID: '{0}', Caption: '{1}', Name: '{2}', ClassGuid: '{3}'", device_id, caption, name, guid);
                    count = 1;
                }
            }
            else
            {
                if (main != null)
                {
                    if (count == 1)
                    {
                        MessageBox.Show("Калит мавжут эмас!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        count  = 0;
                    }
                    main.Hide();
                    DisposeAllButThis();
                    main.Dispose();
                    main.Close();
                    try
                    {
                        foreach (Process proc in Process.GetProcessesByName("Xisobot"))
                        {
                            proc.Kill();
                        }
                        foreach (Process proc in Process.GetProcessesByName("MT"))
                        {
                            proc.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.Show();
                }
            }

        }
        public void DisposeAllButThis()
        {
            for (int i1 = 0; i1 < Application.OpenForms.Count; i1++)
            {
                Form f = Application.OpenForms[i1];
                if (f.Name != this.Name)
                {
                    f.Dispose();
                    f.Close();
                }
            }
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
