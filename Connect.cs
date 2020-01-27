﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Kadr
{
    public class Connect
    {
        public MySqlCommand SelectCommand;
        public MySqlDataReader myReader;
        public MySqlConnection myConn;
        public MySqlDataAdapter mydataAdapter;

        public void Connection()
        {
            try
            {
                string ip = System.IO.File.ReadAllText("docs\\ip.txt");
                string database = System.IO.File.ReadAllText("docs\\data_base.txt");

                string myConnection = "datasource=" + ip + ";port=3306;username=Jamshid7323;password=Jamshid_Askarov7323;database=" + database + ";charset=utf8";
                myConn = new MySqlConnection(myConnection);
                myConn.Open();
                Console.WriteLine("Connection opened");
                //MySqlCommand SelectCommand = new MySqlCommand("select * from shetchik where otdel = '" + this.user_name.Text + "' and quantity = '" + this.password.Text + "' ;", myConn);
                //MySqlDataReader mysqlreader;
                ////MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);

                //mysqlreader = SelectCommand.ExecuteReader();
                //int count = 0;
                //while (mysqlreader.Read())
                //{
                //    count = count + 1;
                //    // MessageBox.Show(mysqlreader.GetString("date"));
                //}

                //myConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public MySqlCommand return_MySqlCommand(string mysqlcommand)
        {
            SelectCommand = new MySqlCommand(mysqlcommand, myConn);
            return SelectCommand;
        }

        public MySqlDataReader select_return_MySqlDataReader()
        {
            //myReader = SelectCommand.ExecuteReader();
            return myReader;
        }
        public void insert_MySqlDataReader()
        {
            myReader = SelectCommand.ExecuteReader();
        }
    }
}
