using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadr
{
    public partial class Main : Form
    {
      public static Connect sql = new Connect();
      public static Connect sql_2 = new Connect();
      public static Connect sql_3 = new Connect();
      public static Connect sql_4 = new Connect();
      public string global_user = "";
      public static TreeNode treeNode;
      public static TreeNode[] global_treeNode = new TreeNode[15];

        public static TreeView tree = new TreeView();
        public static Connect sql1 = new Connect();
        public static Connect sql2 = new Connect();
        public static Connect sql3 = new Connect();
        public static Connect sql4 = new Connect();
        public static Connect sql5 = new Connect();
        public static Connect sql6 = new Connect();
        public static Connect sql7 = new Connect();
        public static Connect sql8 = new Connect();
        public static Connect sql9 = new Connect();
      //Connect sql10 = new Connect();
      public Main(string user)
        {
            InitializeComponent();
            sql.Connection();
            sql_2.Connection();
            sql_3.Connection();
            sql_4.Connection();
            sql.Connection();   
            sql1.Connection();
            sql2.Connection();
            sql3.Connection();
            sql4.Connection();
            sql5.Connection();
            sql6.Connection();
            sql7.Connection();
            sql8.Connection();
            sql9.Connection();
            //sql10.Connection();
            global_user = user;
            treeView.Nodes.Clear();
            run_treeview();
            //if (user == "admin")
            //{
            //    button2.Visible = true;
            //}
            //else
            //{
            //    button2.Visible = false;
            //}
            //run_treeview2();
            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile("folder.png"), Color.Transparent);
            treeView.ImageList = imageList;
            foreach (TreeNode n1 in treeView.Nodes)
            {
                if (n1.Nodes.Count > 1)
                {

                }
                else
                {
                    n1.ImageIndex = 100;
                }
                foreach (TreeNode n2 in n1.Nodes)
                {
                    if (n2.Nodes.Count > 1)
                    {

                    }
                    else
                    {
                        n2.ImageIndex = 100;
                    }

                    foreach (TreeNode n3 in n2.Nodes)
                    {
                        if (n3.Nodes.Count > 1)
                        {

                        }
                        else
                        {
                            n3.ImageIndex = 100;
                        }
                        foreach (TreeNode n4 in n3.Nodes)
                        {
                            if (n4.Nodes.Count > 1)
                            {

                            }
                            else
                            {
                                n4.ImageIndex = 100;
                            }
                            foreach (TreeNode n5 in n4.Nodes)
                            {
                                if (n5.Nodes.Count > 1)
                                {

                                }
                                else
                                {
                                    n5.ImageIndex = 100;
                                }
                            }
                        }
                    }
                }
            }
            poisk_dataGridView.EnableHeadersVisualStyles = false;

            this.poisk_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.poisk_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

        }

        TreeNode treeNode1;
        TreeNode treeNode2;
        TreeNode treeNode3;
        TreeNode treeNode4;
        TreeNode treeNode5;
        TreeNode treeNode6;
        TreeNode treeNode7;
        TreeNode treeNode8;
        TreeNode treeNode9;
        TreeNode treeNode10;
        int g = 0;

        public void getUser(string user)
        {
            global_user = user;
        }
        DataTable dataTable_for_poisk_datagridview = new DataTable();

        public void run_treeview()
        {
            try
            {
                int db_count = 0;
                string db = System.IO.File.ReadAllText("docs\\access.txt");
                var sel = "SELECT COUNT(*) as cnt from (SELECT schema_name FROM information_schema.schemata where schema_name "+db+" order by schema_name) as t";
                sql.myReader = sql.return_MySqlCommand(sel).ExecuteReader();
                while (sql.myReader.Read())
                {
                    if (sql.myReader.HasRows == true)
                    {
                        db_count = Int32.Parse(sql.myReader.GetString("cnt"));
                    }
                }
                sql.myReader.Close();
                string[] db_names = new string[db_count];
                int ind = 0;
                sql.myReader = sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name "+db+" order by schema_name").ExecuteReader();
                while (sql.myReader.Read())
                {
                    db_names[ind] = sql.myReader.GetString("schema_name");
                    ind++;
                }
                sql.myReader.Close();

                for (int i = 0; i < db_names.Length; i++)
                {
                    sql.myReader = sql.return_MySqlCommand("select id, name from " + db_names[i] + ".vacant where type_num = '1' ").ExecuteReader();
                    while (sql.myReader.Read())
                    {
                        treeNode = new TreeNode(sql.myReader.GetString("name")); // rasmli    
                        treeNode.Tag = db_names;
                        treeNode.ImageIndex = 0;
                        treeNode.SelectedImageIndex = 1;
                    }
                    sql.myReader.Close();


                    sql1.myReader = sql.return_MySqlCommand("select queue_2,name, id from " + db_names[i] + ".vacant where type_num = '2' and queue_1 = '1' ").ExecuteReader();
                    while (sql1.myReader.Read())
                    {
                        treeNode1 = new TreeNode(sql1.myReader.GetString("name"));
                        treeNode1.Tag = sql1.myReader.GetString("id");
                        sql2.myReader = sql2.return_MySqlCommand(" select queue_3,name, id from " + db_names[i] + ".vacant where type_num = '3' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                        while (sql2.myReader.Read())
                        {
                            treeNode2 = new TreeNode(sql2.myReader.GetString("name"));
                            treeNode2.Tag = sql2.myReader.GetString("id");
                            sql3.myReader = sql3.return_MySqlCommand("select queue_4,name, id from " + db_names[i] + ".vacant where type_num = '4' and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' " +
                                " ").ExecuteReader();
                            while (sql3.myReader.Read())
                            {
                                treeNode3 = new TreeNode(sql3.myReader.GetString("name"));
                                treeNode3.Tag = sql3.myReader.GetString("id");
                                sql4.myReader = sql4.return_MySqlCommand("select queue_5,name, id from " + db_names[i] + ".vacant where type_num = '5' and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                while (sql4.myReader.Read())
                                {
                                    treeNode4 = new TreeNode(sql4.myReader.GetString("name"));
                                    treeNode4.Tag = sql4.myReader.GetString("id");
                                    sql5.myReader = sql5.return_MySqlCommand("select queue_6,name, id from " + db_names[i] + ".vacant where type_num = '6' and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                    while (sql5.myReader.Read())
                                    {
                                        treeNode5 = new TreeNode(sql5.myReader.GetString("name"));
                                        treeNode5.Tag = sql5.myReader.GetString("id");
                                        sql6.myReader = sql6.return_MySqlCommand(" select queue_7,name, id from " + db_names[i] + ".vacant where type_num = '7' and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                        while (sql6.myReader.Read())
                                        {
                                            treeNode6 = new TreeNode(sql6.myReader.GetString("name"));
                                            treeNode6.Tag = sql6.myReader.GetString("id");
                                            sql7.myReader = sql7.return_MySqlCommand(" select queue_8,name, id from " + db_names[i] + ".vacant where type_num = '8' and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                                " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                            while (sql7.myReader.Read())
                                            {

                                                treeNode7 = new TreeNode(sql7.myReader.GetString("name"));
                                                treeNode7.Tag = sql7.myReader.GetString("id");
                                                sql8.myReader = sql8.return_MySqlCommand(" select queue_9,name, id from " + db_names[i] + ".vacant where type_num = '9' and queue_8 = '" + sql7.myReader.GetInt32("queue_8") + "' " +
                                                    " and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                                " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                                while (sql8.myReader.Read())
                                                {

                                                    treeNode8 = new TreeNode(sql8.myReader.GetString("name"));
                                                    treeNode8.Tag = sql8.myReader.GetString("id");
                                                    sql9.myReader = sql9.return_MySqlCommand(" select queue_10,name from " + db_names[i] + ".vacant where type_num = '10' and queue_9 = '" + sql8.myReader.GetInt32("queue_9") + "' " +
                                                        " and queue_8 = '" + sql7.myReader.GetInt32("queue_8") + "' " +
                                                    " and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                                " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                                    while (sql9.myReader.Read())
                                                    {
                                                        treeNode8.Nodes.Add(sql9.myReader.GetString("name"));
                                                    }
                                                    sql9.myReader.Close();

                                                    treeNode7.Nodes.Add(treeNode8);
                                                }
                                                sql8.myReader.Close();

                                                treeNode6.Nodes.Add(treeNode7);
                                            }
                                            sql7.myReader.Close();

                                            treeNode5.Nodes.Add(treeNode6);
                                        }
                                        sql6.myReader.Close();

                                        treeNode4.Nodes.Add(treeNode5);
                                    }
                                    sql5.myReader.Close();

                                    treeNode3.Nodes.Add(treeNode4);
                                }
                                sql4.myReader.Close();

                                treeNode2.Nodes.Add(treeNode3);
                            }
                            sql3.myReader.Close();

                            treeNode1.Nodes.Add(treeNode2);
                        }
                        sql2.myReader.Close();

                        treeNode.Nodes.Add(treeNode1);
                    }
                    sql1.myReader.Close();
                    treeNode.Nodes.Add("Бошқарма ихтиёрида");
                    treeNode9 = treeNode;

                    //treeNode.Expand();
                    treeView.Nodes.Add(treeNode);
                    treeView.SelectedNode = treeNode;
                    global_treeNode[i] = (TreeNode)treeView.Nodes[i].Clone();

                }

            }
            catch (Exception ex)
            {
                sql.myReader.Close();
                sql1.myReader.Close();
                sql2.myReader.Close();
                sql3.myReader.Close();
                sql4.myReader.Close();
                sql5.myReader.Close();
                sql6.myReader.Close();
                sql7.myReader.Close();
                sql8.myReader.Close();
                sql9.myReader.Close();
                MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        /*public void run_treeview()
        {
         
            string add_queue2 = "";
            if (global_user == "admin" || global_user =="test")
            {
                add_queue2 = "";
            }
            else
            {
                add_queue2 = " and user = '" + global_user + "' ";
            }
            try
            {
                sql.myReader = sql.return_MySqlCommand("select name from vacant where type_num = '1' ").ExecuteReader();
                while (sql.myReader.Read())
                {
                    treeNode = new TreeNode(sql.myReader.GetString("name")); // rasmli

                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 1;
                }
                sql.myReader.Close();


                sql1.myReader = sql.return_MySqlCommand("select queue_2,name from vacant where type_num = '2' and queue_1 = '1' " +add_queue2 + "").ExecuteReader();
                while (sql1.myReader.Read())
                {
                    treeNode1 = new TreeNode(sql1.myReader.GetString("name"));

                    sql2.myReader = sql2.return_MySqlCommand(" select queue_3,name from vacant where type_num = '3' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                    while (sql2.myReader.Read())
                    {
                        treeNode2 = new TreeNode(sql2.myReader.GetString("name"));

                        sql3.myReader = sql3.return_MySqlCommand("select queue_4,name from vacant where type_num = '4' and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' " +
                            " ").ExecuteReader();
                        while (sql3.myReader.Read())
                        {
                            treeNode3 = new TreeNode(sql3.myReader.GetString("name"));

                            sql4.myReader = sql4.return_MySqlCommand("select queue_5,name from vacant where type_num = '5' and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                            while (sql4.myReader.Read())
                            {
                                treeNode4 = new TreeNode(sql4.myReader.GetString("name"));

                                sql5.myReader = sql5.return_MySqlCommand("select queue_6,name from vacant where type_num = '6' and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                while (sql5.myReader.Read())
                                {
                                    treeNode5 = new TreeNode(sql5.myReader.GetString("name"));

                                    sql6.myReader = sql6.return_MySqlCommand(" select queue_7,name from vacant where type_num = '7' and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                    while (sql6.myReader.Read())
                                    {
                                        treeNode6 = new TreeNode(sql6.myReader.GetString("name"));

                                        sql7.myReader = sql7.return_MySqlCommand(" select queue_8,name from vacant where type_num = '8' and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                        while (sql7.myReader.Read())
                                        {

                                            treeNode7 = new TreeNode(sql7.myReader.GetString("name"));

                                            sql8.myReader = sql8.return_MySqlCommand(" select queue_9,name from vacant where type_num = '9' and queue_8 = '" + sql7.myReader.GetInt32("queue_8") + "' " +
                                                " and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                            while (sql8.myReader.Read())
                                            {

                                                treeNode8 = new TreeNode(sql8.myReader.GetString("name"));

                                                sql9.myReader = sql9.return_MySqlCommand(" select queue_10,name from vacant where type_num = '10' and queue_9 = '" + sql8.myReader.GetInt32("queue_9") + "' " +
                                                    " and queue_8 = '" + sql7.myReader.GetInt32("queue_8") + "' " +
                                                " and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                                while (sql9.myReader.Read())
                                                {
                                                    treeNode8.Nodes.Add(sql9.myReader.GetString("name"));
                                                }
                                                sql9.myReader.Close();

                                                treeNode7.Nodes.Add(treeNode8);
                                            }
                                            sql8.myReader.Close();

                                            treeNode6.Nodes.Add(treeNode7);
                                        }
                                        sql7.myReader.Close();

                                        treeNode5.Nodes.Add(treeNode6);
                                    }
                                    sql6.myReader.Close();

                                    treeNode4.Nodes.Add(treeNode5);
                                }
                                sql5.myReader.Close();

                                treeNode3.Nodes.Add(treeNode4);
                            }
                            sql4.myReader.Close();

                            treeNode2.Nodes.Add(treeNode3);
                        }
                        sql3.myReader.Close();

                        treeNode1.Nodes.Add(treeNode2);
                    }
                    sql2.myReader.Close();

                    treeNode.Nodes.Add(treeNode1);
                }
                sql1.myReader.Close();

                treeNode9 = treeNode;

                treeNode.Expand();
                treeView.Nodes.Add(treeNode);



            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }*/

       /* public void run_treeview2()
        {

            string add_queue2 = "";
            if (global_user == "admin" || global_user == "test")
            {
                add_queue2 = "";
            }
            else
            {
                add_queue2 = " and user = '" + global_user + "' ";
            }
            try
            {
                sql.myReader = sql.return_MySqlCommand("select name from kadr_0_2.vacant where type_num = '1' ").ExecuteReader();
                while (sql.myReader.Read())
                {
                    treeNode = new TreeNode(sql.myReader.GetString("name")); // rasmli

                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 1;
                }
                sql.myReader.Close();


                sql1.myReader = sql.return_MySqlCommand("select queue_2,name from kadr_0_2.vacant where type_num = '2' and queue_1 = '1' " + add_queue2 + "").ExecuteReader();
                while (sql1.myReader.Read())
                {
                    treeNode1 = new TreeNode(sql1.myReader.GetString("name"));

                    sql2.myReader = sql2.return_MySqlCommand(" select queue_3,name from kadr_0_2.vacant where type_num = '3' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                    while (sql2.myReader.Read())
                    {
                        treeNode2 = new TreeNode(sql2.myReader.GetString("name"));

                        sql3.myReader = sql3.return_MySqlCommand("select queue_4,name from kadr_0_2.vacant where type_num = '4' and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' " +
                            " ").ExecuteReader();
                        while (sql3.myReader.Read())
                        {
                            treeNode3 = new TreeNode(sql3.myReader.GetString("name"));

                            sql4.myReader = sql4.return_MySqlCommand("select queue_5,name from kadr_0_2.vacant where type_num = '5' and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                            while (sql4.myReader.Read())
                            {
                                treeNode4 = new TreeNode(sql4.myReader.GetString("name"));

                                sql5.myReader = sql5.return_MySqlCommand("select queue_6,name from kadr_0_2.vacant where type_num = '6' and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                while (sql5.myReader.Read())
                                {
                                    treeNode5 = new TreeNode(sql5.myReader.GetString("name"));

                                    sql6.myReader = sql6.return_MySqlCommand(" select queue_7,name from kadr_0_2.vacant where type_num = '7' and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                    while (sql6.myReader.Read())
                                    {
                                        treeNode6 = new TreeNode(sql6.myReader.GetString("name"));

                                        sql7.myReader = sql7.return_MySqlCommand(" select queue_8,name from kadr_0_2.vacant where type_num = '8' and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                        while (sql7.myReader.Read())
                                        {

                                            treeNode7 = new TreeNode(sql7.myReader.GetString("name"));

                                            sql8.myReader = sql8.return_MySqlCommand(" select queue_9,name from kadr_0_2.vacant where type_num = '9' and queue_8 = '" + sql7.myReader.GetInt32("queue_8") + "' " +
                                                " and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                            while (sql8.myReader.Read())
                                            {

                                                treeNode8 = new TreeNode(sql8.myReader.GetString("name"));

                                                sql9.myReader = sql9.return_MySqlCommand(" select queue_10,name from kadr_0_2.vacant where type_num = '10' and queue_9 = '" + sql8.myReader.GetInt32("queue_9") + "' " +
                                                    " and queue_8 = '" + sql7.myReader.GetInt32("queue_8") + "' " +
                                                " and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                                while (sql9.myReader.Read())
                                                {
                                                    treeNode8.Nodes.Add(sql9.myReader.GetString("name"));
                                                }
                                                sql9.myReader.Close();

                                                treeNode7.Nodes.Add(treeNode8);
                                            }
                                            sql8.myReader.Close();

                                            treeNode6.Nodes.Add(treeNode7);
                                        }
                                        sql7.myReader.Close();

                                        treeNode5.Nodes.Add(treeNode6);
                                    }
                                    sql6.myReader.Close();

                                    treeNode4.Nodes.Add(treeNode5);
                                }
                                sql5.myReader.Close();

                                treeNode3.Nodes.Add(treeNode4);
                            }
                            sql4.myReader.Close();

                            treeNode2.Nodes.Add(treeNode3);
                        }
                        sql3.myReader.Close();

                        treeNode1.Nodes.Add(treeNode2);
                    }
                    sql2.myReader.Close();

                    treeNode.Nodes.Add(treeNode1);
                }
                sql1.myReader.Close();

                treeNode9 = treeNode;

                treeNode.Expand();
                treeView.Nodes.Add(treeNode);



            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }*/

        /*public void run_treeview1()
        {
            try
            {
                sql.myReader = sql.return_MySqlCommand("select name,present_num from vacant where present_num = '0' ").ExecuteReader();
                while (sql.myReader.Read())
                {
                    treeNode = new TreeNode(sql.myReader.GetString("name")); // rasmli


                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 1;
                }
                sql.myReader.Close();

                treeView.Nodes.Add(treeNode);


                sql.myReader = sql.return_MySqlCommand("select name,present_num from vacant where parent_num = '0' order by queue").ExecuteReader();
                while (sql.myReader.Read())
                {
                    g = 0;

                    sql_2.myReader = sql_2.return_MySqlCommand("select name from vacant where parent_num = '" + sql.myReader.GetString("present_num") + "' ").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        g++;
                    }
                    sql_2.myReader.Close();

                    if (g < 1)
                    {
                        treeNode = new TreeNode(sql.myReader.GetString("name"));

                        treeView.Nodes.Add(treeNode);
                    }
                    else
                    {
                        treeNode = new TreeNode(sql.myReader.GetString("name")); // rasmli
                        treeView.Nodes.Add(treeNode);
                    }

                    sql_2.myReader = sql_2.return_MySqlCommand("select name from vacant where parent_num = '" + sql.myReader.GetString("present_num") + "' order by queue").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        treeNode.Nodes.Add(sql_2.myReader.GetString("name"));
                    }
                    sql_2.myReader.Close();


                    //      Console.WriteLine(refresh_treeview_value(sql.myReader.GetString("name")));
                }
                sql.myReader.Close();

                //sql.mydataAdapter = new MySqlDataAdapter();
                //dataTable_for_poisk_datagridview.Clear();
                //sql.mydataAdapter.SelectCommand = sql.return_MySqlCommand("select main.id,main.kod_num,concat(main.surname,' ',main.name,' ',main.fath_name ) as full_name, main.zvanie from main,work_place " +
                //    " where work_place.kod_num = main.kod_num order by work_place.id asc");
                //sql.mydataAdapter.Fill(dataTable_for_poisk_datagridview);
                //poisk_dataGridView.DataSource = dataTable_for_poisk_datagridview;
                //dataTable_for_poisk_datagridview.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        */
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(2, 14, 35);
        }
        
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            
            label6.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            //label8.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
           // label8.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            //label9.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
           // label9.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            //label10.BackColor = Color.FromArgb(2, 14, 35);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
           // label10.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.BackColor = Color.FromArgb(2, 14, 35);
        }
        private TreeNode FindRootNode(TreeNode treeNode)
        {
            if (treeNode != null)
            {
                while (treeNode.Parent != null)
                {
                    treeNode = treeNode.Parent;
                }
            }
            return treeNode;
        }
        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.BackColor = Color.FromArgb(0, 30, 45);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string str = "";


                var ancestorsAndSelf = e.Node.FullPath.Split(treeView.PathSeparator.ToCharArray());

                foreach (string item in ancestorsAndSelf)
                {
                    if (item.Equals("Бошқарма"))
                    {

                    }
                    else
                    {
                        str = str + " " + item.Replace("\n", "");
                    }

                }
                str = str.Remove(0, 1);
                clear_label_text();
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                poisk_dataGridView.Rows.Clear();

                Console.WriteLine(str);

                this.poisk_dataGridView.SelectionChanged -= new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
                if (node.Text == "Бошқарма ихтиёрида")
                {
                    var query = "SELECT rezerv.kod_num,rezerv.id," +
                   "rezerv.lichniy_num,rezerv.zvanie, fio_full as fio, rezerv.doljnost FROM "+db_name+".rezerv WHERE rezerv.cheeck = 0"
                                                    + " order by rezerv.id asc";
                    sql.myReader = sql.return_MySqlCommand(query).ExecuteReader();
                    while (sql.myReader.Read())
                    {
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (sql.myReader["id"] != DBNull.Value ? sql.myReader.GetString("id") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (sql.myReader["kod_num"] != DBNull.Value ? sql.myReader.GetString("kod_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (sql.myReader["register_num"] != DBNull.Value ? sql.myReader.GetString("register_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (sql.myReader["lichniy_num"] != DBNull.Value ? sql.myReader.GetString("lichniy_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (sql.myReader["zvanie"] != DBNull.Value ? sql.myReader.GetString("zvanie") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = (sql.myReader["fio"] != DBNull.Value ? sql.myReader.GetString("fio") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = (sql.myReader["doljnost"] != DBNull.Value ? sql.myReader.GetString("doljnost") : "");
                    }
                    sql.myReader.Close();
                }
                else
                {
                    var query = "SELECT main.kod_num,extract(year from main.date_organ) as year,extract(month from main.date_organ) as month,extract(day from main.date_organ) as day,main.id," +
                   "main.lichniy_num,main.zvanie, register_num, concat(main.surname,' ',main.name,' ',main.fath_name) as fio, main.doljnost FROM " + db_name+".main WHERE main.kod_num and isnull(main.date_finish) and main.otdel = '" + str + "' "
                                                    + " order by main.id asc";
                    sql.myReader = sql.return_MySqlCommand(query).ExecuteReader();
                    while (sql.myReader.Read())
                    {
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (sql.myReader["id"] != DBNull.Value ? sql.myReader.GetString("id") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (sql.myReader["kod_num"] != DBNull.Value ? sql.myReader.GetString("kod_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (sql.myReader["register_num"] != DBNull.Value ? sql.myReader.GetString("register_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (sql.myReader["lichniy_num"] != DBNull.Value ? sql.myReader.GetString("lichniy_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (sql.myReader["zvanie"] != DBNull.Value ? sql.myReader.GetString("zvanie") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = (sql.myReader["fio"] != DBNull.Value ? sql.myReader.GetString("fio") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = (sql.myReader["doljnost"] != DBNull.Value ? sql.myReader.GetString("doljnost") : "");
                    }
                    sql.myReader.Close();
                }               
                poisk_dataGridView.ClearSelection();
                this.poisk_dataGridView.SelectionChanged += new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
            }
            catch (Exception ex)
            {
                sql.myReader.Close();
                MessageBox.Show("treeView_AfterSelect " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public void clear_label_text()
        {
            try
            {
                zvanie_label.Text = "";
                fio_label.Text = "";
                u_label1.Text = "";
                u_label.Text = "";
                otdel_label.Text = "";
                tugilgan_sanasi_label.Text = "Туғилган санаси: ";
                millati_label.Text = "Миллати: ";
                iioda_qacondan_label.Text = "ИИОда қачондан: ";
                umumiy_davri_label.Text = "Умумий м.ф. даври: ";

                tugilgan_joyi_label.Text = "Туғилган жойи: ";
                otdel_label.Text = "Бошқарма қисми :";
                Image img = Properties.Resources.policeman;//Image.FromFile("images\\policeman.png");
                this.pictureBox1.Image = img;
                malumoti_label.Text = "Маълумоти: ";

                malumoti_buyica_label.Text = "Маълумоти бўйича мутахассислиги: ";
                //pictureBox1.Image
            }
            catch (Exception ex)
            {
                MessageBox.Show("clear_label_text" + ex.Message);
            }
                        
        }
        private void poisk_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    int year = 0;
                    int month = 0;
                    int day = 0;
                    
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    clear_label_text();
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    sql_3.myReader = sql_3.return_MySqlCommand("select *,concat(surname,' ',name,' ',fath_name) as fio,extract(year from date_start2) as year,from_him_prikaz, prikaz_start,extract(month from date_start2) as month,extract(day from date_start2) as day from " + db_name + ".main where kod_num = '" + dgvRow.Cells[1].Value + "' ").ExecuteReader();
                    while (sql_3.myReader.Read())
                    {
                        zvanie_label.Text = (sql_3.myReader["zvanie"] != DBNull.Value ? sql_3.myReader.GetString("zvanie") : "");
                        fio_label.Text = (sql_3.myReader["fio"] != DBNull.Value ? sql_3.myReader.GetString("fio") : "") + " ( "+
                            (sql_3.myReader["lichniy_num"] != DBNull.Value ? sql_3.myReader.GetString("lichniy_num") : "") + " ) ";
                        u_label1.Text = "" + (sql_3.myReader["from_him_prikaz"] != DBNull.Value ? sql_3.myReader.GetString("from_him_prikaz") + "нинг " : "")+ (sql_3.myReader["prikaz_start"] != DBNull.Value ? sql_3.myReader.GetString("prikaz_start") + " буйруғи билан " : "")+
                            (sql_3.myReader["year"] != DBNull.Value ? sql_3.myReader.GetString("year") + " йил " : "") +
                            (sql_3.myReader["day"] != DBNull.Value ? sql_3.myReader.GetString("day") + " " : "")+
                            set_month_name2(sql_3.myReader.GetInt32("month")).Replace("ь", "") + "идан буён: ";
                        otdel_label.Text = "Бошқарма қисми : " + (sql_3.myReader["otdel"] != DBNull.Value ? sql_3.myReader.GetString("otdel") : "") + "\n< "+
                            (sql_3.myReader["doljnost"] != DBNull.Value ? sql_3.myReader.GetString("doljnost") : "") + " > лавозимида хизмат қилмоқда";
                        tugilgan_sanasi_label.Text = "Туғилган санаси :  " +
                            (sql_3.myReader["date_birth"] != DBNull.Value ? (DateTime.Parse(sql_3.myReader.GetString("date_birth")).ToString("dd.MM.yyyy") + " йил.") : null);
                        tugilgan_joyi_label.Text = "Туғилган жойи: " +
                            (sql_3.myReader["place_birth"] != DBNull.Value ? sql_3.myReader.GetString("place_birth") : "");
                        millati_label.Text = "Миллати :   " + (sql_3.myReader["national"] != DBNull.Value ? sql_3.myReader.GetString("national") : "");
                        iioda_qacondan_label.Text = "ИИОда қачондан:   " +
                            (sql_3.myReader["date_organ"] != DBNull.Value ? (DateTime.Parse(sql_3.myReader.GetString("date_organ")).ToString("dd.MM.yyyy") + " йил.") : null);

                        sql_2.myReader = sql_2.return_MySqlCommand("select * from trudovoy where kod_num = '" + dgvRow.Cells[1].Value + "' and prikaz_date is not null and date_start is not null and date_finish is not null order by date_start").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            DateDifference dateDifference = new DateDifference(sql_2.myReader.GetDateTime("date_start"), sql_2.myReader.GetDateTime("date_finish"));

                            year = year + dateDifference.Years;
                            month = month + dateDifference.Months;
                            day = day + dateDifference.Days;
                        }
                        sql_2.myReader.Close();

                        sql_2.myReader = sql_2.return_MySqlCommand("select date_start2,kod_num,otdel,doljnost from " + db_name + ".main where kod_num = '" + dgvRow.Cells[1].Value + "' ").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            DateDifference dateDifference = new DateDifference(sql_2.myReader.GetDateTime("date_start2"), DateTime.Today);

                            year = year + dateDifference.Years;
                            month = month + dateDifference.Months;
                            day = day + dateDifference.Days;
                        }
                        sql_2.myReader.Close();


                        year = year + (month / 12);
                        if (month == 12)
                        {
                            year++;
                        }
                        month = month + (day / 30);

                        umumiy_davri_label.Text = "Умумий м.ф. даври : " + Convert.ToString(year) + " йил " + Convert.ToString(month % 12) + " ой " + Convert.ToString(day % 30) + " кун.";

                        tugilgan_joyi_label.Text = "Туғилган жойи: " + (sql_3.myReader["place_birth"] != DBNull.Value ? sql_3.myReader.GetString("place_birth") : "");


                        sql_2.myReader = sql_2.return_MySqlCommand("select type_study,place,profeccional from " + db_name + ".study where kod_num = '" + dgvRow.Cells[1].Value + "' ").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            malumoti_label.Text = "Маълумоти: " + (sql_2.myReader["type_study"] != DBNull.Value ? sql_2.myReader.GetString("type_study") : " ") + ", " +
                                                                    (sql_2.myReader["place"] != DBNull.Value ? sql_2.myReader.GetString("place") : " ");

                            malumoti_buyica_label.Text = "Маълумоти бўйича мутахассислиги: " + (sql_2.myReader["profeccional"] != DBNull.Value ? sql_2.myReader.GetString("profeccional") : " ");
                        }
                        sql_2.myReader.Close();
                    }
                    sql_3.myReader.Close();

                    //byte[] bits = (table.Rows[0][0] != null ? (byte[])table.Rows[0][0] : null);

                    sql_2.mydataAdapter = new MySqlDataAdapter(sql_2.return_MySqlCommand("select image from " + db_name + ".main where kod_num = '" + dgvRow.Cells[1].Value + "' "));
                    DataTable table = new DataTable();
                    sql_2.mydataAdapter.Fill(table);
                    byte[] bits = null;
                    if (table.Rows.Count > 0)
                    {
                        Console.WriteLine((table.Rows[0][0] != null ? (table.Rows[0][0] + " true") : "false"));

                        if (!Convert.IsDBNull(table.Rows[0][0]))
                        {
                            bits = (byte[])table.Rows[0][0];
                        }
                    }
                    if (bits != null)
                    {
                        MemoryStream ms = new MemoryStream(bits);
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        Image img = Properties.Resources.policeman;//Image.FromFile("images\\policeman.png");
                        this.pictureBox1.Image = img;
                    }
                    sql_2.mydataAdapter.Dispose();

                    Console.WriteLine("poisk_dataGridView_SelectionChanged ");
                }
                catch (Exception ex)
                {
                    sql_2.myReader.Close();
                    sql_3.myReader.Close();
                    MessageBox.Show("poisk_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        //---------------------------------------------------------------------
        String getmonth_String2;
        public string set_month_name2(int getmonth)
        {
            switch (getmonth)
            {
                case 1:
                    {
                        getmonth_String2 = "январь";
                        break;
                    }
                case 2:
                    {
                        getmonth_String2 = "февраль";
                        break;
                    }
                case 3:
                    {
                        getmonth_String2 = "март";
                        break;
                    }
                case 4:
                    {
                        getmonth_String2 = "апрель";
                        break;
                    }
                case 5:
                    {
                        getmonth_String2 = "май";
                        break;
                    }
                case 6:
                    {
                        getmonth_String2 = "июнь";
                        break;
                    }
                case 7:
                    {
                        getmonth_String2 = "июль";
                        break;
                    }
                case 8:
                    {
                        getmonth_String2 = "августь";
                        break;
                    }
                case 9:
                    {
                        getmonth_String2 = "сентябрь";
                        break;
                    }
                case 10:
                    {
                        getmonth_String2 = "октябрь";
                        break;
                    }
                case 11:
                    {
                        getmonth_String2 = "ноябрь";
                        break;
                    }
                case 12:
                    {
                        getmonth_String2 = "декабрь";
                        break;
                    }
            }
            return getmonth_String2;
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Shaxsiy_malumot shxsiy_malumot = new Shaxsiy_malumot();
                shxsiy_malumot.WindowState = FormWindowState.Maximized;
                shxsiy_malumot.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("label1_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        
        public void Copy(TreeView treeview1, TreeView treeview2)
        {
            TreeNode newTn;
            foreach (TreeNode tn in treeview1.Nodes)
            {
                newTn = new TreeNode(tn.Text);
                CopyChilds(newTn, tn);
                treeview2.Nodes.Add(newTn);
            }
        }

        public void CopyChilds(TreeNode parent, TreeNode willCopied)
        {
            TreeNode newTn;
            foreach (TreeNode tn in willCopied.Nodes)
            {
                newTn = new TreeNode(tn.Text);
                parent.Nodes.Add(newTn);
            }
        } 
        private void label2_Click(object sender, EventArgs e)
        {


            try
            {
                Buyruq buyruqlar = new Buyruq();
             //   buyruqlar.WindowState = FormWindowState.Maximized;
                buyruqlar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("label2_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                Spiska_buyruqlar spiska_buyruqlar = new Spiska_buyruqlar();
                spiska_buyruqlar.WindowState = FormWindowState.Maximized;
                spiska_buyruqlar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("label3_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\spire\\Xisobot.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("label5_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (poisk_dataGridView.SelectedRows.Count == 1)
            {
                try
                {                    

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    int kod_num = Int32.Parse(poisk_dataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    Spire.Doc.Document doc = new Spire.Doc.Document();
                    
                    Spire.Doc.Section s = doc.AddSection();
                    Spire.Doc.Section oilaviy = doc.AddSection();
                    doc.Sections[0].PageSetup.Margins.Top = 40.69f;
                    doc.Sections[0].PageSetup.Margins.Bottom = 37.79f;
                    doc.Sections[0].PageSetup.Margins.Left = 75.48f;
                    doc.Sections[0].PageSetup.Margins.Right = 37.79f;

                    doc.Sections[1].PageSetup.Margins.Top = 37.7f;
                    doc.Sections[1].PageSetup.Margins.Bottom = 30.7f;
                    doc.Sections[1].PageSetup.Margins.Left = 25.7f;
                    doc.Sections[1].PageSetup.Margins.Right = 33.7f;

                Spire.Doc.Table xodim_malumot1 = s.AddTable(true);

                    xodim_malumot1.ResetCells(1, 2);
                    xodim_malumot1.Rows[0].Cells[0].Width = 400;
                    xodim_malumot1.Rows[0].Cells[1].Width = 130;

                    Spire.Doc.Documents.Paragraph p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                    Spire.Doc.Fields.TextRange TR2  = p.AppendText("");
                    p.Format.BeforeSpacing = 5;
                    Spire.Doc.Fields.TextRange TR = p.AppendText("М А Ъ Л У М О Т Н О М А");
                    TR.CharacterFormat.Bold = true;
                    TR.CharacterFormat.FontSize = 14;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                    //
                    string zvanie = "";
                    string fio = "";
                    string dob = "";
                    string date_organ = "";
                    string place_birth = "";
                    string nation = "";
                    string tillar = "";
                    string buyruq_num = "";
                    string unvon_date = "";
                    string organ = "";
                    string malumoti = "";
                    string study_place = "";
                    string daraja = "";
                    string mutahassislik = "";
                    string data_finish = "";
                    sql_2.myReader = sql_2.return_MySqlCommand("SELECT CONCAT(surname, ' ', name, ' ',  fath_name) as fio, date_birth, place_birth, date_organ, national, tillar, image FROM " + db_name + ".main where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        fio = sql_2.myReader["fio"] != DBNull.Value ? sql_2.myReader.GetString("fio") : "" + " ";
                        dob = sql_2.myReader["date_birth"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_birth")).ToString("dd.MM.yyyy") : "";
                        place_birth = sql_2.myReader["place_birth"] != DBNull.Value ? sql_2.myReader.GetString("place_birth") : "";
                        date_organ = sql_2.myReader["date_organ"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_organ")).ToString("dd.MM.yyyy") : "";
                        nation = sql_2.myReader["national"] != DBNull.Value ? sql_2.myReader.GetString("national") : "";
                        tillar = sql_2.myReader["tillar"] != DBNull.Value ? sql_2.myReader.GetString("tillar") : "";
                    }
                    sql_2.myReader.Close();
                    var select = "select type_study, profeccional, place, date_finish from " + db_name + ".study where kod_num = '" + kod_num + "'";
                    sql_2.myReader = sql_2.return_MySqlCommand(select).ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        daraja = sql_2.myReader["type_study"] != DBNull.Value ? sql_2.myReader.GetString("type_study") : "";
                        mutahassislik = sql_2.myReader["profeccional"] != DBNull.Value ? sql_2.myReader.GetString("profeccional") : "";
                        study_place = sql_2.myReader["place"] != DBNull.Value ? sql_2.myReader.GetString("place") : "";
                        data_finish = sql_2.myReader["date_finish"] != DBNull.Value ? sql_2.myReader.GetString("date_finish") : "";
                        malumoti = malumoti + data_finish + " йилда " + study_place + ", ";
                    }
                    sql_2.myReader.Close();
                    string[] months = { "январ", "феврал", "март", "апрел", "май", "июн", "июл", "август", "сентябр", "октябр", "ноябр", "декабр" };
                    sql_2.myReader = sql_2.return_MySqlCommand("SELECT zvanie, soni, date, from_him FROM " + db_name + ".unvon where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        zvanie = sql_2.myReader["zvanie"] != DBNull.Value ? sql_2.myReader.GetString("zvanie") : "" + " ";
                        buyruq_num = sql_2.myReader["soni"] != DBNull.Value ? sql_2.myReader.GetString("soni") : "" + " ";
                        string year = sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date")).ToString("yyyy") : "";
                        string day = sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date")).ToString("dd") : "";
                        int month_num = Int32.Parse(sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date")).ToString("MM") : "");
                        string month = "";
                        if (month_num > 0 && month_num < 13)
                        {
                            month = set_month_name2(month_num);
                        }
                        unvon_date = year + " йил " + day + " " + month.Replace("ь", "");
                        organ = sql_2.myReader["from_him"] != DBNull.Value ? sql_2.myReader.GetString("from_him") : "" + " ";
                    }
                    sql_2.myReader.Close();

                    sql_2.mydataAdapter = new MySqlDataAdapter(sql_2.return_MySqlCommand("select image from " + db_name + ".main where kod_num = '" + kod_num + "' "));
                    DataTable table1 = new DataTable();
                    sql_2.mydataAdapter.Fill(table1);
                    byte[] bits = null;

                    Console.WriteLine((table1.Rows[0][0] != null ? (table1.Rows[0][0] + " true") : "false"));

                    if (!Convert.IsDBNull(table1.Rows[0][0]))
                    {
                        bits = (byte[])table1.Rows[0][0];
                    }


                    sql_2.mydataAdapter.Dispose();
                    p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                    TR = p.AppendText("\n" + zvanie.ToUpper());
                    TR.CharacterFormat.Bold = true;
                    TR.CharacterFormat.FontSize = 14;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                    TR = p.AppendText(fio.ToUpper());
                    TR.CharacterFormat.Bold = true;
                    TR.CharacterFormat.FontSize = 14;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                    xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                    p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                    string otdel_plus_doljnost = "";
                    sql_2.myReader = sql_2.return_MySqlCommand("select otdel, doljnost, extract(year from " + db_name + ".main.date_start2) as year,extract(month from " + db_name + ".main.date_start2) as month,extract(day from " + db_name + ".main.date_start2) as day from " + db_name + ".main where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        string year = sql_2.myReader["year"] != DBNull.Value ? sql_2.myReader.GetString("year") : "";
                        int month = sql_2.myReader["month"] != DBNull.Value ? Int32.Parse(sql_2.myReader.GetString("month")) : 1;
                        string day = sql_2.myReader["day"] != DBNull.Value ? sql_2.myReader.GetString("day") : "";
                        string month_name = set_month_name2(month);
                        string otdel = sql_2.myReader["otdel"] != DBNull.Value ? sql_2.myReader.GetString("otdel") : "";
                        string doljnost = sql_2.myReader["doljnost"] != DBNull.Value ? sql_2.myReader.GetString("doljnost") : "";
                        otdel_plus_doljnost = otdel + " " + doljnost + "";
                        TR = p.AppendText("" + year + " йил " + day + " " + month_name.Replace("ь", "") + "дан ");
                    }
                    sql_2.myReader.Close();
                    TR.CharacterFormat.Bold = true;
                    TR.CharacterFormat.FontSize = 12;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;

                    Spire.Doc.Documents.Paragraph par_otdel = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                    TR = par_otdel.AppendText(otdel_plus_doljnost);
                    par_otdel.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                    TR.CharacterFormat.FontSize = 12;
                    par_otdel.Format.AfterSpacing = 5;
                    xodim_malumot1.Rows[0].Cells[1].AddParagraph();
                    Spire.Doc.Fields.DocPicture picture = null;
                    if (bits != null)
                    {
                        MemoryStream ms = new MemoryStream(bits);
                        picture = xodim_malumot1.Rows[0].Cells[1].Paragraphs[0].AppendPicture(Image.FromStream(ms));
                    }
                    else
                    {
                        picture = xodim_malumot1.Rows[0].Cells[1].Paragraphs[0].AppendPicture(Kadr.Properties.Resources.policeman);
                    }
                    xodim_malumot1.Rows[0].Cells[1].Paragraphs[0].Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                    xodim_malumot1.Rows[0].Cells[1].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                    xodim_malumot1.TableFormat.Paddings.Right = 0f;
                    picture.Width = 96.15f;
                    picture.Height = 115.1f;
                    Spire.Doc.Table xodim_malumot2 = s.AddTable(true);
                    xodim_malumot2.ResetCells(1, 3);
                    xodim_malumot2.Rows[0].Cells[0].Width = 265;
                    xodim_malumot2.Rows[0].Cells[1].Width = 105;
                    xodim_malumot2.Rows[0].Cells[2].Width = 160;
                    Spire.Doc.Documents.Paragraph p2 = xodim_malumot2.Rows[0].Cells[0].AddParagraph();
                    Spire.Doc.Fields.TextRange TR1 = null;
                    TR1 = p2.AppendText("Туғилган йили: ");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText(dob);
                    p2 = xodim_malumot2.Rows[0].Cells[1].AddParagraph();
                    TR1 = p2.AppendText("Туғилган жойи: ");
                    TR1.CharacterFormat.Bold = true;
                    p2 = xodim_malumot2.Rows[0].Cells[2].AddParagraph();
                if (place_birth.Length > 0 && place_birth.Replace(" ", "").Length > 0)
                {
                    if (place_birth[0] == ' ')
                    {
                        place_birth = place_birth.Substring(1, place_birth.Length - 2);
                    }
                    string _spaceof_ten = new string(Enumerable.Range(1, 30).Select(i => ' ').ToArray());
                    if (place_birth.IndexOf(',') > 0)
                    {
                        string[] places = place_birth.Split(',');
                        string tum_vil = places[0] + " " + _spaceof_ten + places[1];
                        TR2 = p2.AppendText(tum_vil);
                    }
                    else
                    {
                        string tum_vil = place_birth;
                        TR2 = p2.AppendText(tum_vil);
                    }
                }
                    Spire.Doc.Table xodim_malumot = s.AddTable(true);
                    xodim_malumot.ResetCells(1, 2);
                    xodim_malumot.Rows[0].Cells[0].Width = 265;
                    xodim_malumot.Rows[0].Cells[1].Width = 265;
                   
                    TR2 = null;
                   

                    xodim_malumot.Rows[0].Cells[0].Width = 265;
                    xodim_malumot.Rows[0].Cells[1].Width = 265;
                    p2 = xodim_malumot.Rows[0].Cells[0].AddParagraph();
                    TR1 = p2.AppendText("Миллати: \n");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText(nation.ToLower());
                    p2 = xodim_malumot.Rows[0].Cells[1].AddParagraph();
                    p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                    TR1 = p2.AppendText("Маълумоти: ");
                    TR1.CharacterFormat.Bold = true;
                    if (malumoti.Length > 0)
                    {
                        malumoti = malumoti.Substring(0, malumoti.Length - 2).Replace("тамомлаган", "");
                        TR2 = p2.AppendText(daraja + ", " + malumoti + " тамомлаган");
                    }
                    else
                    {
                        TR2 = p2.AppendText("");
                    }
                    xodim_malumot.AddRow();
                    xodim_malumot.Rows[1].Cells[0].Width = 265;
                    xodim_malumot.Rows[1].Cells[1].Width = 265;
                    p2 = xodim_malumot.Rows[1].Cells[0].AddParagraph();
                    TR1 = p2.AppendText("ИИОда қачондан: ");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText(date_organ + " йилдан");
                    p2 = xodim_malumot.Rows[1].Cells[1].AddParagraph();
                    TR1 = p2.AppendText("");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText("");

                    Spire.Doc.Table xodim_malumot111 = s.AddTable(true);
                    xodim_malumot111.ResetCells(1, 3);
                    xodim_malumot111.Rows[0].Cells[0].Width = 255;
                    xodim_malumot111.Rows[0].Cells[1].Width = 10;
                    xodim_malumot111.Rows[0].Cells[2].Width = 265;
                    p2 = xodim_malumot111.Rows[0].Cells[0].AddParagraph();
                    TR1 = p2.AppendText("Охирги унвони қачон берилган: ");
                p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText(organ + "нинг " + unvon_date + "идаги шахсий таркиб бўйича " + buyruq_num + "-сонли буйруғига асосан");
                    p2 = xodim_malumot111.Rows[0].Cells[2].AddParagraph();
                    TR1 = p2.AppendText("Маълумоти бўйича мутахассислиги: ");
                p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText(mutahassislik);

                    Spire.Doc.Table xodim_malumot222 = s.AddTable(true);
                    xodim_malumot222.ResetCells(1, 2);
                xodim_malumot222.Rows[0].Cells[0].Width = 265;
                xodim_malumot222.Rows[0].Cells[1].Width = 265;
                    p2 = xodim_malumot222.Rows[0].Cells[0].AddParagraph();
                    TR1 = p2.AppendText("Илмий даражаси: ");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText("йўқ");
                    p2 = xodim_malumot222.Rows[0].Cells[1].AddParagraph();
                    TR1 = p2.AppendText("Илмий унвони: ");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText("йўқ");

                xodim_malumot222.AddRow();
                xodim_malumot222.ApplyHorizontalMerge(1, 0, 1);
                    p2 = xodim_malumot222.Rows[1].Cells[0].AddParagraph();
                    TR1 = p2.AppendText("Қайси чет тилларни билади: ");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText(tillar);

                xodim_malumot222.AddRow();
                xodim_malumot222.ApplyHorizontalMerge(2, 0, 1);
                    p2 = xodim_malumot222.Rows[2].Cells[0].AddParagraph();
                    TR1 = p2.AppendText("Давлат мукофотлари билан тақдирланганми: ");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText("йўқ");


                xodim_malumot222.AddRow();
                xodim_malumot222.ApplyHorizontalMerge(3, 0, 1);
                    p2 = xodim_malumot222.Rows[3].Cells[0].AddParagraph();
                    TR1 = p2.AppendText("Ҳалқ депутатлари республика, вилоят, шаҳар ва туман кенгаши депутатими ёки бошқа сайланадиган органларнинг аъзосими: ");
                    TR1.CharacterFormat.Bold = true;
                    TR2 = p2.AppendText("йўқ");

                    Spire.Doc.Documents.Paragraph par = s.AddParagraph();
                    TR1 = par.AppendText("\n");
                    TR1.CharacterFormat.FontSize = 12;
                    Spire.Doc.Fields.TextRange TR100 = par.AppendText("М Е Ҳ Н А Т   Ф А О Л И Я Т И");
                    TR100.CharacterFormat.Bold = true;
                    TR100.CharacterFormat.FontSize = 14;
                    par.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                xodim_malumot111.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                xodim_malumot222.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                xodim_malumot2.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                xodim_malumot1.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                xodim_malumot.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                s.Paragraphs[0].AppendBreak(Spire.Doc.Documents.BreakType.LineBreak);
                    Spire.Doc.Table mehnat_faoliyati = s.AddTable(true);
                    mehnat_faoliyati.ResetCells(1, 2);
                    Spire.Doc.TableRow row = null;
                    int k = 0;
                    sql_2.myReader = sql_2.return_MySqlCommand("SELECT date_start, date_finish, work_place, doljnost FROM " + db_name + ".trudovoy where kod_num = '" + kod_num + "' order by date_start asc ").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        mehnat_faoliyati.AddRow();
                        string period = "";
                        string month = "";
                        string data_start_per = sql_2.myReader["date_start"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_start")).ToString("MM.yyyy") : "";
                        string data_finish_per = sql_2.myReader["date_finish"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_finish")).ToString("MM.yyyy") : "";
                        DateTime start;
                        DateTime finish;
                        DateTime.TryParse(data_start_per, out start);
                        DateTime.TryParse(data_finish_per, out finish);
                        Spire.Doc.Documents.Paragraph par_m = mehnat_faoliyati.Rows[k].Cells[0].AddParagraph();
                    mehnat_faoliyati.Rows[k].Cells[0].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                    mehnat_faoliyati.Rows[k].Cells[1].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                    if (start.Year == finish.Year)
                    {
                        period = start.Year + " – " + start.Year + " йй. \n";
                        month = set_month_name2(start.Month) + "  " + set_month_name2(finish.Month);
                        Spire.Doc.Fields.TextRange TR10 = par_m.AppendText(period);
                        TR10.CharacterFormat.FontSize = 11;
                        Spire.Doc.Fields.TextRange TR11 = par_m.AppendText(month);
                        TR11.CharacterFormat.FontSize = 10;
                    }
                    else
                    {
                        period = start.Year + " – " + finish.Year + " йй.";
                        Spire.Doc.Fields.TextRange TR10 = par_m.AppendText(period);
                        TR10.CharacterFormat.FontSize = 11;
                    }
                        string work_place = (sql_2.myReader["work_place"] != DBNull.Value ? sql_2.myReader.GetString("work_place") : "") + " " + (sql_2.myReader["doljnost"] != DBNull.Value ? sql_2.myReader.GetString("doljnost") : "");

                        //mehnat_faoliyati.TableFormat.Paddings.Top = 3.5f;
                        //mehnat_faoliyati.TableFormat.Paddings.Bottom = 3.5f;
                       
                        Spire.Doc.Documents.Paragraph par_work_place = mehnat_faoliyati.Rows[k].Cells[1].AddParagraph();
                        par_work_place.AppendText(work_place);
                        par_m.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        par_work_place.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                        mehnat_faoliyati.Rows[k].Cells[0].Width = 90;
                        mehnat_faoliyati.Rows[k].Cells[1].Width = 397;

                        k++;
                    }
                    sql_2.myReader.Close();
                    var h_q = "SELECT date_start2, CONCAT(otdel,' ', doljnost) as work_place_last FROM " + db_name + ".main where kod_num = '" + kod_num + "'";
                    sql_2.myReader = sql_2.return_MySqlCommand(h_q).ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        mehnat_faoliyati.AddRow();
                        string data_start_per_last = sql_2.myReader["date_start2"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_start2")).ToString("yyyy") : "";
                        string data_finish_per_last = "ҳ.қ.";
                        string work_place_last = sql_2.myReader["work_place_last"] != DBNull.Value ? sql_2.myReader.GetString("work_place_last") : "";
                        Spire.Doc.Documents.Paragraph par_last_work_place0 = mehnat_faoliyati.Rows[k].Cells[0].AddParagraph();
                        Spire.Doc.Fields.TextRange TR10 = par_last_work_place0.AppendText(data_start_per_last + " – " + data_finish_per_last);
                        TR10.CharacterFormat.FontSize = 11;
                        Spire.Doc.Documents.Paragraph par_last_work_place1 = mehnat_faoliyati.Rows[k].Cells[1].AddParagraph();
                        TR10 = par_last_work_place1.AppendText(work_place_last);
                        par_last_work_place0.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        par_last_work_place1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                        TR10.CharacterFormat.FontSize = 12;
                        mehnat_faoliyati.Rows[k].Cells[0].Width = 90;
                        mehnat_faoliyati.Rows[k].Cells[1].Width = 397;
                    }
                    sql_2.myReader.Close();
                    mehnat_faoliyati.Rows.RemoveAt(mehnat_faoliyati.Rows.Count - 1);
                    Spire.Doc.Documents.Paragraph par4 = s.AddParagraph();
                    mehnat_faoliyati.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                    string jazo = "";
                    string ragbat = "";
                    string xarakatdagi = "";
                    sql_2.myReader = sql_2.return_MySqlCommand("select count(*) as count from " + db_name + ".nagrajdenie where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        ragbat = sql_2.myReader["count"] != DBNull.Value ? sql_2.myReader.GetString("count") : "0";
                    }
                    sql_2.myReader.Close();
                    sql_2.myReader = sql_2.return_MySqlCommand("select count(*) as count from " + db_name + ".intizomiy where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        jazo = sql_2.myReader["count"] != DBNull.Value ? sql_2.myReader.GetString("count") : "0";
                    }
                    sql_2.myReader.Close();

                    sql_2.myReader = sql_2.return_MySqlCommand("select *,extract(year from intizomiy.date) as year,extract(month from intizomiy.date) as month," +
                        " extract(day from intizomiy.date) as day from " + db_name + ".intizomiy where kod_num='" + kod_num + "' and cheeck_jazo='0' ").ExecuteReader();
                    if (sql_2.myReader.Read())
                    {
                        xarakatdagi = "Ҳаракатдаги интизомий жазоси бор. " + (sql_2.myReader["from_him"] != DBNull.Value ? sql_2.myReader.GetString("from_him") : "") + " " +
                            (sql_2.myReader["year"] != DBNull.Value ? (sql_2.myReader.GetString("year") + " йил ") : "") + " " +
                            (sql_2.myReader["day"] != DBNull.Value ? (sql_2.myReader.GetString("day") + "") : "") + " " +
                            (sql_2.myReader["month"] != DBNull.Value ? (set_month_name2(sql_2.myReader.GetInt32("month")) + "даги ") : "") + " " +
                            (sql_2.myReader["prikaz_num"] != DBNull.Value ? (sql_2.myReader.GetString("prikaz_num") + "-сонли буйруғи билан, ") : "") + " " +
                            (sql_2.myReader["malumot"] != DBNull.Value ? (sql_2.myReader.GetString("malumot")) : "") + " " +
                            (sql_2.myReader["type_jazo"] != DBNull.Value ? ("«" + sql_2.myReader.GetString("type_jazo") + "»") : "") + "  интизомий жазоси эълон қилинган.";

                    }
                    else
                    {
                        xarakatdagi = " Ҳаракатдаги интизомий жазоси йўқ. ";
                    }
                    sql_2.myReader.Close();

                   /* TR1 = par4.AppendText("\n\tХизмат фаолияти давомида ");
                    TR2 = par4.AppendText(" " + (ragbat.Equals("0") ? "рағбатлантирилмаган, " : (ragbat + " маротаба рағбатлантирилган, ")) +
                       " интизомий тартибда " + (jazo.Equals("0") ? "жазоланмаган." : (jazo + " маротаба жазоланган.")) + xarakatdagi);
                       */

                    par4.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;

                    s.Paragraphs[1].AppendBreak(Spire.Doc.Documents.BreakType.PageBreak);
                    Spire.Doc.Documents.Paragraph par3 = oilaviy.AddParagraph();
                    TextInfo textInfo = new CultureInfo("ru-RU", false).TextInfo;
                    fio = textInfo.ToTitleCase(fio);
                    TR1 = par3.AppendText(fio + "нинг яқин қариндошлари тўғрисида\n");
                    TR1.CharacterFormat.Bold = true;
                    TR1.CharacterFormat.FontSize = 12;
                    par3.Format.BeforeSpacing = 5;
                    Spire.Doc.Fields.TextRange TR103 = par3.AppendText("М А Ъ Л У М О Т");
                    par3.Format.AfterSpacing = 5;
                    TR103.CharacterFormat.FontSize = 12;
                    TR103.CharacterFormat.Bold = true;
                    par3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Table table = oilaviy.AddTable(true);

                    //Create Header and Data
                    String[] Header = { "№", "Фамилияси, исми \nва отасининг исми", "Қариндош-лиги", 
                                  "Туғилган \nйили ва жойи", "Иш жойи ва лавозими", "Турар жойи"};

                    //Add Cells
                    table.ResetCells(1, Header.Length);

                    //Header Row
                    Spire.Doc.TableRow FRow = table.Rows[0];
                    FRow.Cells[0].Width = 38f;
                    FRow.Cells[1].Width = 160.6f;
                    FRow.Cells[2].Width = 91.0f;
                    FRow.Cells[3].Width = 165.0f;
                    FRow.Cells[4].Width = 225.0f;
                    FRow.Cells[5].Width = 180.7f;
                    FRow.IsHeader = true;
                    //Row Height
                    FRow.Height = 23;
                    //Header Format
                    for (int j = 0; j < Header.Length; j++)
                    {
                        //Cell Alignment
                        Spire.Doc.Documents.Paragraph p6 = FRow.Cells[j].AddParagraph();
                        FRow.Cells[j].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Middle;
                        p6.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        //Data Format
                        Spire.Doc.Fields.TextRange TR6 = p6.AppendText(Header[j]);
                        TR6.CharacterFormat.FontName = "Times New Roman";
                        TR6.CharacterFormat.FontSize = 12;
                        TR6.CharacterFormat.Bold = true;
                    }
                    int cnt = 1;
                    row = null;
                    string empty_rows = "";
                    table.TableFormat.Paddings.Left = 0f;
                    table.TableFormat.Paddings.Right = 0f;
                    var oila_select = "SELECT fio, qarindosh_d, date_birth, place_birth, address, work_place FROM " + db_name + ".family where kod_num = '" + kod_num + "' and qarindosh_d != 'Қайнукаси' and qarindosh_d != 'Қайнопаси' and qarindosh_d != 'Қайнсинглиси' and qarindosh_d != 'Қайнакаси' order by  qarindosh_d  <> 'Отаси','Онаси','Акаси','Опаси','Укаси','Синглиси','Турмуш ўртоғи','Ўғли','Қизи','Қайнотаси','Қайнонаси'";
                    sql_2.myReader = sql_2.return_MySqlCommand(oila_select).ExecuteReader();
                    while (sql_2.myReader.Read())
                    {
                        row = table.AddRow();
                        
                        string fio_ = sql_2.myReader["fio"] != DBNull.Value ? sql_2.myReader.GetString("fio") : "";
                        string qarindoshlik = sql_2.myReader["qarindosh_d"] != DBNull.Value ? sql_2.myReader.GetString("qarindosh_d") : "";
                        string date_b = sql_2.myReader["date_birth"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_birth")).ToString("yyyy") : "";
                        string place_b = sql_2.myReader["place_birth"] != DBNull.Value ? sql_2.myReader.GetString("place_birth") : "";
                        string address = sql_2.myReader["address"] != DBNull.Value ? sql_2.myReader.GetString("address") : "";
                        string work_place = sql_2.myReader["work_place"] != DBNull.Value ? sql_2.myReader.GetString("work_place") : "";
                        Spire.Doc.Documents.Paragraph row_par1 = row.Cells[0].AddParagraph();
                        Spire.Doc.Fields.TextRange TR6 = row_par1.AppendText(cnt.ToString() + ".");
                        row_par1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TR6.CharacterFormat.FontName = "Times New Roman";
                        TR6.CharacterFormat.FontSize = 11;
                        TR6.CharacterFormat.Bold = true;

                        row_par1 = row.Cells[1].AddParagraph();
                        TR6 = row_par1.AppendText(fio_);
                        row_par1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TR6.CharacterFormat.FontName = "Times New Roman";
                        TR6.CharacterFormat.FontSize = 11;

                        row_par1 = row.Cells[2].AddParagraph();
                        TR6 = row_par1.AppendText(qarindoshlik);
                        row_par1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TR6.CharacterFormat.FontName = "Times New Roman";
                        TR6.CharacterFormat.FontSize = 11;

                        row_par1 = row.Cells[3].AddParagraph();
                        row_par1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TR6 = row_par1.AppendText(date_b + " йил, \n" + place_b);
                        TR6.CharacterFormat.FontName = "Times New Roman";
                        TR6.CharacterFormat.FontSize = 11;

                        row_par1 = row.Cells[4].AddParagraph();
                        if (work_place.IndexOf("(") != -1)
                        {
                            work_place = work_place.Substring(0, work_place.IndexOf("(")) + "\n" + work_place.Substring(work_place.IndexOf("("), work_place.Length - work_place.IndexOf("("));
                        }
                        TR6 = row_par1.AppendText(work_place);
                        row_par1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TR6.CharacterFormat.FontName = "Times New Roman";
                        TR6.CharacterFormat.FontSize = 11;

                        row_par1 = row.Cells[5].AddParagraph();
                        TR6 = row_par1.AppendText(address);
                        row_par1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TR6.CharacterFormat.FontName = "Times New Roman";
                        TR6.CharacterFormat.FontSize = 11;
                        if (address == "")
                        {
                            empty_rows = empty_rows + row.GetRowIndex() + " ";
                        }
                        row.Cells[0].Width = 31.3f;
                    row.Cells[1].Width = 160.6f;
                    row.Cells[2].Width = 91.0f;
                    row.Cells[3].Width = 140.0f;
                    row.Cells[4].Width = 150.5f;
                    row.Cells[5].Width = 141.7f;
                    cnt++;
                    }
                    sql_2.myReader.Close();
                    string[] empt_rows = empty_rows.Split(' ').ToArray();
                    foreach (var a in empt_rows)
                    {
                        if (a != "")
                        {
                            table.ApplyHorizontalMerge(Int32.Parse(a), 4, 5);
                        }
                    }
                    //Save and Launch
                    //sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Чоп этиш','"+ kod_num + " / "+ fio + " нинг шахсий маълумотлари чоп этилди','"+db_name+"')").ExecuteNonQuery();

                    doc.SaveToFile("docs\\" + fio + ".docx", Spire.Doc.FileFormat.Docx);
                    System.Diagnostics.Process.Start("docs\\" + fio + ".docx");
                }
                catch (Exception ex)
                {
                    sql_2.myReader.Close();
                    MessageBox.Show("Error: " + ex.Source + " " + ex.Message);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //sql.myReader = sql.return_MySqlCommand("select id,user,ip from control where user != '' ").ExecuteReader();
            //while (sql.myReader.Read())
            //{
            //    Console.WriteLine("True : "+sql.myReader.GetString("id"));

            //    sql2.return_MySqlCommand("update control set user = '"+sql.myReader.GetString("user")+"' where user = '' and ip = '"+sql.myReader.GetString("ip")+"' ").ExecuteNonQuery();

            //    //if (sql.myReader.GetString("user").Equals(""))
            //    //{
            //    //    sql2.return_MySqlCommand("update user = '' ").ExecuteNonQuery();
            //    //}
            //}
            //sql.myReader.Close();
            
        }

        
        private void label12_Click(object sender, EventArgs e)
        {
            try
            {
                Tex_Pod tex_pod = new Tex_Pod();
                tex_pod.ShowDialog();
                //run_treeview2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("label12_Click ", ex.Message);
            }
        }

      
        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                Arxiv arxiv = new Arxiv();
                arxiv.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("label6_Click ", ex.Message);
            }
        }
        
        private void poisk_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                if (root != null)
                {
                    int index1 = root.Index;

                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (poisk_textBox.Text != "")
                    {

                        Console.WriteLine("Changed");
                        poisk_dataGridView.Rows.Clear();
                        //" + db_name + ".
                        this.poisk_dataGridView.SelectionChanged -= new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
                        var sel = "SELECT kod_num,extract(year from date_organ) as year,extract(month from date_organ) as month,extract(day from date_organ) as day,id," +
                            "lichniy_num, zvanie,register_num, concat(surname,' ', name,' ', fath_name) as fio, doljnost FROM " + db_name + ".main WHERE isnull(date_finish) and (kod_num like '" + poisk_textBox.Text + "%' or zvanie like '" + poisk_textBox.Text + "%' or doljnost like '" + poisk_textBox.Text + "%' or register_num like '" + poisk_textBox.Text + "%' or lichniy_num like '" + poisk_textBox.Text + "%' or surname like '" + poisk_textBox.Text + "%' " +
                            " or name like '" + poisk_textBox.Text + "%' or concat(surname,' ', name,' ', fath_name) like '" + poisk_textBox.Text + "%') " +
                            " order by id asc";
                        sql.myReader = sql.return_MySqlCommand(sel).ExecuteReader();
                        while (sql.myReader.Read())
                        {
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (sql.myReader["id"] != DBNull.Value ? sql.myReader.GetString("id") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (sql.myReader["kod_num"] != DBNull.Value ? sql.myReader.GetString("kod_num") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (sql.myReader["register_num"] != DBNull.Value ? sql.myReader.GetString("register_num") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (sql.myReader["lichniy_num"] != DBNull.Value ? sql.myReader.GetString("lichniy_num") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (sql.myReader["zvanie"] != DBNull.Value ? sql.myReader.GetString("zvanie") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = (sql.myReader["fio"] != DBNull.Value ? sql.myReader.GetString("fio") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = (sql.myReader["doljnost"] != DBNull.Value ? sql.myReader.GetString("doljnost") : "");
                        }
                        sql.myReader.Close();
                        poisk_dataGridView.ClearSelection();
                        this.poisk_dataGridView.SelectionChanged += new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
                    }
                }
            }
            catch (Exception ex)
            {
                sql.myReader.Close();
                MessageBox.Show("poisk_textBox_TextChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
        private void poisk_dataGridView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\spire\\Statistics.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("label9_Click" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\TimePeriod.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("label9_Click" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Convertnumbertotext.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("label8_Click" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                try
                {

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    string str = "";


                    var ancestorsAndSelf = node.FullPath.Split(treeView.PathSeparator.ToCharArray());

                    foreach (string item in ancestorsAndSelf)
                    {
                        if (item.Equals("Бошқарма"))
                        {

                        }
                        else
                        {
                            str = str + " " + item.Replace("\n", "");
                        }

                    }
                    str = str.Remove(0, 1);
                    Spire.Doc.Document doc = new Spire.Doc.Document();
                    int count = 0;
                    sql.myReader = sql.return_MySqlCommand("select distinct kod_num from " + db_name + ".main where date_finish is null and otdel = '"+str+"'").ExecuteReader();
                    while (sql.myReader.Read())
                    {
                        string kod_num = sql.myReader["kod_num"] != DBNull.Value ? sql.myReader.GetString("kod_num") : "0";
                       

                        Spire.Doc.Section s = doc.AddSection();
                        //Spire.Doc.Section oilaviy = doc.AddSection();
                        doc.Sections[count].PageSetup.Margins.Top = 40.69f;
                        doc.Sections[count].PageSetup.Margins.Bottom = 37.79f;
                        doc.Sections[count].PageSetup.Margins.Left = 75.48f;
                        doc.Sections[count].PageSetup.Margins.Right = 37.79f;
                        count++;
                        //doc.Sections[1].PageSetup.Margins.Top = 37.7f;
                        //doc.Sections[1].PageSetup.Margins.Bottom = 30.7f;
                        //doc.Sections[1].PageSetup.Margins.Left = 25.7f;
                        //doc.Sections[1].PageSetup.Margins.Right = 33.7f;

                        Spire.Doc.Table xodim_malumot1 = s.AddTable(true);

                        xodim_malumot1.ResetCells(1, 2);
                        xodim_malumot1.Rows[0].Cells[0].Width = 400;
                        xodim_malumot1.Rows[0].Cells[1].Width = 130;

                        Spire.Doc.Documents.Paragraph p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                        Spire.Doc.Fields.TextRange TR2 = p.AppendText("");
                        p.Format.BeforeSpacing = 5;
                        Spire.Doc.Fields.TextRange TR = p.AppendText("М А Ъ Л У М О Т Н О М А");
                        TR.CharacterFormat.Bold = true;
                        TR.CharacterFormat.FontSize = 14;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        //
                        string zvanie = "";
                        string fio = "";
                        string dob = "";
                        string date_organ = "";
                        string place_birth = "";
                        string nation = "";
                        string tillar = "";
                        string buyruq_num = "";
                        string unvon_date = "";
                        string organ = "";
                        string malumoti = "";
                        string study_place = "";
                        string daraja = "";
                        string mutahassislik = "";
                        string data_finish = "";
                        sql_2.myReader = sql_2.return_MySqlCommand("SELECT CONCAT(surname, ' ', name, ' ',  fath_name) as fio, date_birth, place_birth, date_organ, national, tillar, image FROM " + db_name + ".main where kod_num = '" + kod_num + "'").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            fio = sql_2.myReader["fio"] != DBNull.Value ? sql_2.myReader.GetString("fio") : "" + " ";
                            dob = sql_2.myReader["date_birth"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_birth")).ToString("dd.MM.yyyy") : "";
                            place_birth = sql_2.myReader["place_birth"] != DBNull.Value ? sql_2.myReader.GetString("place_birth") : "";
                            date_organ = sql_2.myReader["date_organ"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_organ")).ToString("dd.MM.yyyy") : "";
                            nation = sql_2.myReader["national"] != DBNull.Value ? sql_2.myReader.GetString("national") : "";
                            tillar = sql_2.myReader["tillar"] != DBNull.Value ? sql_2.myReader.GetString("tillar") : "";
                        }
                        sql_2.myReader.Close();
                        var select = "select type_study, profeccional, place, date_finish from " + db_name + ".study where kod_num = '" + kod_num + "'";
                        sql_2.myReader = sql_2.return_MySqlCommand(select).ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            daraja = sql_2.myReader["type_study"] != DBNull.Value ? sql_2.myReader.GetString("type_study") : "";
                            mutahassislik = sql_2.myReader["profeccional"] != DBNull.Value ? sql_2.myReader.GetString("profeccional") : "";
                            study_place = sql_2.myReader["place"] != DBNull.Value ? sql_2.myReader.GetString("place") : "";
                            data_finish = sql_2.myReader["date_finish"] != DBNull.Value ? sql_2.myReader.GetString("date_finish") : "";
                            malumoti = malumoti + data_finish + " йилда " + study_place + ", ";
                        }
                        sql_2.myReader.Close();
                        string[] months = { "январ", "феврал", "март", "апрел", "май", "июн", "июл", "август", "сентябр", "октябр", "ноябр", "декабр" };
                        sql_2.myReader = sql_2.return_MySqlCommand("SELECT zvanie, soni, date, from_him FROM " + db_name + ".unvon where kod_num = '" + kod_num + "'").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            zvanie = sql_2.myReader["zvanie"] != DBNull.Value ? sql_2.myReader.GetString("zvanie") : "" + " ";
                            buyruq_num = sql_2.myReader["soni"] != DBNull.Value ? sql_2.myReader.GetString("soni") : "" + " ";
                            string year = sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date")).ToString("yyyy") : "";
                            string day = sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date")).ToString("dd") : "";
                            int month_num = Int32.Parse(sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date")).ToString("MM") : "");
                            string month = "";
                            if (month_num > 0 && month_num < 13)
                            {
                                month = set_month_name2(month_num);
                            }
                            unvon_date = year + " йил " + day + " " + month.Replace("ь", "");
                            organ = sql_2.myReader["from_him"] != DBNull.Value ? sql_2.myReader.GetString("from_him") : "" + " ";
                        }
                        sql_2.myReader.Close();

                        sql_2.mydataAdapter = new MySqlDataAdapter(sql_2.return_MySqlCommand("select image from " + db_name + ".main where kod_num = '" + kod_num + "' "));
                        DataTable table1 = new DataTable();
                        sql_2.mydataAdapter.Fill(table1);
                        byte[] bits = null;

                        Console.WriteLine((table1.Rows[0][0] != null ? (table1.Rows[0][0] + " true") : "false"));

                        if (!Convert.IsDBNull(table1.Rows[0][0]))
                        {
                            bits = (byte[])table1.Rows[0][0];
                        }


                        sql_2.mydataAdapter.Dispose();
                        p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                        TR = p.AppendText("\n" + zvanie.ToUpper());
                        TR.CharacterFormat.Bold = true;
                        TR.CharacterFormat.FontSize = 14;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                        p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                        TR = p.AppendText(fio.ToUpper());
                        TR.CharacterFormat.Bold = true;
                        TR.CharacterFormat.FontSize = 14;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                        p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                        string otdel_plus_doljnost = "";
                        sql_2.myReader = sql_2.return_MySqlCommand("select otdel, doljnost, extract(year from " + db_name + ".main.date_start2) as year,extract(month from " + db_name + ".main.date_start2) as month,extract(day from " + db_name + ".main.date_start2) as day from " + db_name + ".main where kod_num = '" + kod_num + "'").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            string year = sql_2.myReader["year"] != DBNull.Value ? sql_2.myReader.GetString("year") : "";
                            int month = sql_2.myReader["month"] != DBNull.Value ? Int32.Parse(sql_2.myReader.GetString("month")) : 1;
                            string day = sql_2.myReader["day"] != DBNull.Value ? sql_2.myReader.GetString("day") : "";
                            string month_name = set_month_name2(month);
                            string otdel = sql_2.myReader["otdel"] != DBNull.Value ? sql_2.myReader.GetString("otdel") : "";
                            string doljnost = sql_2.myReader["doljnost"] != DBNull.Value ? sql_2.myReader.GetString("doljnost") : "";
                            otdel_plus_doljnost = otdel + " " + doljnost + "";
                            TR = p.AppendText("" + year + " йил " + day + " " + month_name.Replace("ь", "") + "дан ");
                        }
                        sql_2.myReader.Close();
                        TR.CharacterFormat.Bold = true;
                        TR.CharacterFormat.FontSize = 12;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;

                        Spire.Doc.Documents.Paragraph par_otdel = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                        TR = par_otdel.AppendText(otdel_plus_doljnost);
                        par_otdel.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                        TR.CharacterFormat.FontSize = 12;
                        par_otdel.Format.AfterSpacing = 5;
                        xodim_malumot1.Rows[0].Cells[1].AddParagraph();
                        Spire.Doc.Fields.DocPicture picture = null;
                        if (bits != null)
                        {
                            MemoryStream ms = new MemoryStream(bits);
                            picture = xodim_malumot1.Rows[0].Cells[1].Paragraphs[0].AppendPicture(Image.FromStream(ms));
                        }
                        else
                        {
                            picture = xodim_malumot1.Rows[0].Cells[1].Paragraphs[0].AppendPicture(Kadr.Properties.Resources.policeman);
                        }
                        xodim_malumot1.Rows[0].Cells[1].Paragraphs[0].Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
                        xodim_malumot1.Rows[0].Cells[1].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                        xodim_malumot1.TableFormat.Paddings.Right = 0f;
                        picture.Width = 96.15f;
                        picture.Height = 115.1f;
                        Spire.Doc.Table xodim_malumot2 = s.AddTable(true);
                        xodim_malumot2.ResetCells(1, 3);
                        xodim_malumot2.Rows[0].Cells[0].Width = 265;
                        xodim_malumot2.Rows[0].Cells[1].Width = 105;
                        xodim_malumot2.Rows[0].Cells[2].Width = 160;
                        Spire.Doc.Documents.Paragraph p2 = xodim_malumot2.Rows[0].Cells[0].AddParagraph();
                        Spire.Doc.Fields.TextRange TR1 = null;
                        TR1 = p2.AppendText("Туғилган йили: ");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText(dob);
                        p2 = xodim_malumot2.Rows[0].Cells[1].AddParagraph();
                        TR1 = p2.AppendText("Туғилган жойи: ");
                        TR1.CharacterFormat.Bold = true;
                        p2 = xodim_malumot2.Rows[0].Cells[2].AddParagraph();
                        if (place_birth.Length > 0 && place_birth.Replace(" ", "").Length > 0)
                        {
                            if (place_birth[0] == ' ')
                            {
                                place_birth = place_birth.Substring(1, place_birth.Length - 2);
                            }
                            string _spaceof_ten = new string(Enumerable.Range(1, 30).Select(i => ' ').ToArray());
                            if (place_birth.IndexOf(',') > 0)
                            {
                                string[] places = place_birth.Split(',');
                                string tum_vil = places[0] + " " + _spaceof_ten + places[1];
                                TR2 = p2.AppendText(tum_vil);
                            }
                            else
                            {
                                string tum_vil = place_birth;
                                TR2 = p2.AppendText(tum_vil);
                            }
                        }
                        Spire.Doc.Table xodim_malumot = s.AddTable(true);
                        xodim_malumot.ResetCells(1, 2);
                        xodim_malumot.Rows[0].Cells[0].Width = 265;
                        xodim_malumot.Rows[0].Cells[1].Width = 265;

                        TR2 = null;


                        xodim_malumot.Rows[0].Cells[0].Width = 265;
                        xodim_malumot.Rows[0].Cells[1].Width = 265;
                        p2 = xodim_malumot.Rows[0].Cells[0].AddParagraph();
                        TR1 = p2.AppendText("Миллати: \n");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText(nation.ToLower());
                        p2 = xodim_malumot.Rows[0].Cells[1].AddParagraph();
                        p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                        TR1 = p2.AppendText("Маълумоти: ");
                        TR1.CharacterFormat.Bold = true;
                        if (malumoti.Length > 0)
                        {
                            malumoti = malumoti.Substring(0, malumoti.Length - 2).Replace("тамомлаган", "");
                            TR2 = p2.AppendText(daraja + ", " + malumoti + " тамомлаган");
                        }
                        else
                        {
                            TR2 = p2.AppendText("");
                        }
                        xodim_malumot.AddRow();
                        xodim_malumot.Rows[1].Cells[0].Width = 265;
                        xodim_malumot.Rows[1].Cells[1].Width = 265;
                        p2 = xodim_malumot.Rows[1].Cells[0].AddParagraph();
                        TR1 = p2.AppendText("ИИОда қачондан: ");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText(date_organ + " йилдан");
                        p2 = xodim_malumot.Rows[1].Cells[1].AddParagraph();
                        TR1 = p2.AppendText("");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText("");

                        Spire.Doc.Table xodim_malumot111 = s.AddTable(true);
                        xodim_malumot111.ResetCells(1, 3);
                        xodim_malumot111.Rows[0].Cells[0].Width = 255;
                        xodim_malumot111.Rows[0].Cells[1].Width = 10;
                        xodim_malumot111.Rows[0].Cells[2].Width = 265;
                        p2 = xodim_malumot111.Rows[0].Cells[0].AddParagraph();
                        TR1 = p2.AppendText("Охирги унвони қачон берилган: ");
                        p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText(organ + "нинг " + unvon_date + "идаги шахсий таркиб бўйича " + buyruq_num + "-сонли буйруғига асосан");
                        p2 = xodim_malumot111.Rows[0].Cells[2].AddParagraph();
                        TR1 = p2.AppendText("Маълумоти бўйича мутахассислиги: ");
                        p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText(mutahassislik);

                        Spire.Doc.Table xodim_malumot222 = s.AddTable(true);
                        xodim_malumot222.ResetCells(1, 2);
                        xodim_malumot222.Rows[0].Cells[0].Width = 265;
                        xodim_malumot222.Rows[0].Cells[1].Width = 265;
                        p2 = xodim_malumot222.Rows[0].Cells[0].AddParagraph();
                        TR1 = p2.AppendText("Илмий даражаси: ");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText("йўқ");
                        p2 = xodim_malumot222.Rows[0].Cells[1].AddParagraph();
                        TR1 = p2.AppendText("Илмий унвони: ");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText("йўқ");

                        xodim_malumot222.AddRow();
                        xodim_malumot222.ApplyHorizontalMerge(1, 0, 1);
                        p2 = xodim_malumot222.Rows[1].Cells[0].AddParagraph();
                        TR1 = p2.AppendText("Қайси чет тилларни билади: ");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText(tillar);

                        xodim_malumot222.AddRow();
                        xodim_malumot222.ApplyHorizontalMerge(2, 0, 1);
                        p2 = xodim_malumot222.Rows[2].Cells[0].AddParagraph();
                        TR1 = p2.AppendText("Давлат мукофотлари билан тақдирланганми: ");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText("йўқ");


                        xodim_malumot222.AddRow();
                        xodim_malumot222.ApplyHorizontalMerge(3, 0, 1);
                        p2 = xodim_malumot222.Rows[3].Cells[0].AddParagraph();
                        TR1 = p2.AppendText("Ҳалқ депутатлари республика, вилоят, шаҳар ва туман кенгаши депутатими ёки бошқа сайланадиган органларнинг аъзосими: ");
                        TR1.CharacterFormat.Bold = true;
                        TR2 = p2.AppendText("йўқ");

                        Spire.Doc.Documents.Paragraph par = s.AddParagraph();
                        TR1 = par.AppendText("\n");
                        TR1.CharacterFormat.FontSize = 12;
                        Spire.Doc.Fields.TextRange TR100 = par.AppendText("М Е Ҳ Н А Т   Ф А О Л И Я Т И");
                        TR100.CharacterFormat.Bold = true;
                        TR100.CharacterFormat.FontSize = 14;
                        par.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        xodim_malumot111.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                        xodim_malumot222.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                        xodim_malumot2.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                        xodim_malumot1.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                        xodim_malumot.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                        s.Paragraphs[0].AppendBreak(Spire.Doc.Documents.BreakType.LineBreak);
                        Spire.Doc.Table mehnat_faoliyati = s.AddTable(true);
                        mehnat_faoliyati.ResetCells(1, 2);
                        Spire.Doc.TableRow row = null;
                        int k = 0;
                        sql_2.myReader = sql_2.return_MySqlCommand("SELECT date_start, date_finish, work_place, doljnost FROM " + db_name + ".trudovoy where kod_num = '" + kod_num + "' order by date_start asc ").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            mehnat_faoliyati.AddRow();
                            string period = "";
                            string month = "";
                            string data_start_per = sql_2.myReader["date_start"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_start")).ToString("MM.yyyy") : "";
                            string data_finish_per = sql_2.myReader["date_finish"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_finish")).ToString("MM.yyyy") : "";
                            DateTime start;
                            DateTime finish;
                            DateTime.TryParse(data_start_per, out start);
                            DateTime.TryParse(data_finish_per, out finish);
                            Spire.Doc.Documents.Paragraph par_m = mehnat_faoliyati.Rows[k].Cells[0].AddParagraph();
                            mehnat_faoliyati.Rows[k].Cells[0].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                            mehnat_faoliyati.Rows[k].Cells[1].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                            if (start.Year == finish.Year)
                            {
                                period = start.Year + " – " + start.Year + " йй. \n";
                                month = set_month_name2(start.Month) + "  " + set_month_name2(finish.Month);
                                Spire.Doc.Fields.TextRange TR10 = par_m.AppendText(period);
                                TR10.CharacterFormat.FontSize = 11;
                                Spire.Doc.Fields.TextRange TR11 = par_m.AppendText(month);
                                TR11.CharacterFormat.FontSize = 10;
                            }
                            else
                            {
                                period = start.Year + " – " + finish.Year + " йй.";
                                Spire.Doc.Fields.TextRange TR10 = par_m.AppendText(period);
                                TR10.CharacterFormat.FontSize = 11;
                            }
                            string work_place = (sql_2.myReader["work_place"] != DBNull.Value ? sql_2.myReader.GetString("work_place") : "") + " " + (sql_2.myReader["doljnost"] != DBNull.Value ? sql_2.myReader.GetString("doljnost") : "");

                            //mehnat_faoliyati.TableFormat.Paddings.Top = 3.5f;
                            //mehnat_faoliyati.TableFormat.Paddings.Bottom = 3.5f;

                            Spire.Doc.Documents.Paragraph par_work_place = mehnat_faoliyati.Rows[k].Cells[1].AddParagraph();
                            par_work_place.AppendText(work_place);
                            par_m.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                            par_work_place.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                            mehnat_faoliyati.Rows[k].Cells[0].Width = 90;
                            mehnat_faoliyati.Rows[k].Cells[1].Width = 397;

                            k++;
                        }
                        sql_2.myReader.Close();
                        var h_q = "SELECT date_start2, CONCAT(otdel,' ', doljnost) as work_place_last FROM " + db_name + ".main where kod_num = '" + kod_num + "'";
                        sql_2.myReader = sql_2.return_MySqlCommand(h_q).ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            mehnat_faoliyati.AddRow();
                            string data_start_per_last = sql_2.myReader["date_start2"] != DBNull.Value ? DateTime.Parse(sql_2.myReader.GetString("date_start2")).ToString("yyyy") : "";
                            string data_finish_per_last = "ҳ.қ.";
                            string work_place_last = sql_2.myReader["work_place_last"] != DBNull.Value ? sql_2.myReader.GetString("work_place_last") : "";
                            Spire.Doc.Documents.Paragraph par_last_work_place0 = mehnat_faoliyati.Rows[k].Cells[0].AddParagraph();
                            Spire.Doc.Fields.TextRange TR10 = par_last_work_place0.AppendText(data_start_per_last + " – " + data_finish_per_last);
                            TR10.CharacterFormat.FontSize = 11;
                            Spire.Doc.Documents.Paragraph par_last_work_place1 = mehnat_faoliyati.Rows[k].Cells[1].AddParagraph();
                            TR10 = par_last_work_place1.AppendText(work_place_last);
                            par_last_work_place0.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                            par_last_work_place1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                            TR10.CharacterFormat.FontSize = 12;
                            mehnat_faoliyati.Rows[k].Cells[0].Width = 90;
                            mehnat_faoliyati.Rows[k].Cells[1].Width = 397;
                        }
                        sql_2.myReader.Close();
                        mehnat_faoliyati.Rows.RemoveAt(mehnat_faoliyati.Rows.Count - 1);
                        Spire.Doc.Documents.Paragraph par4 = s.AddParagraph();
                        mehnat_faoliyati.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                        string jazo = "";
                        string ragbat = "";
                        string xarakatdagi = "";
                        sql_2.myReader = sql_2.return_MySqlCommand("select count(*) as count from " + db_name + ".nagrajdenie where kod_num = '" + kod_num + "'").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            ragbat = sql_2.myReader["count"] != DBNull.Value ? sql_2.myReader.GetString("count") : "0";
                        }
                        sql_2.myReader.Close();
                        sql_2.myReader = sql_2.return_MySqlCommand("select count(*) as count from " + db_name + ".intizomiy where kod_num = '" + kod_num + "'").ExecuteReader();
                        while (sql_2.myReader.Read())
                        {
                            jazo = sql_2.myReader["count"] != DBNull.Value ? sql_2.myReader.GetString("count") : "0";
                        }
                        sql_2.myReader.Close();

                        sql_2.myReader = sql_2.return_MySqlCommand("select *,extract(year from intizomiy.date) as year,extract(month from intizomiy.date) as month," +
                            " extract(day from intizomiy.date) as day from " + db_name + ".intizomiy where kod_num='" + kod_num + "' and cheeck_jazo='0' ").ExecuteReader();
                        if (sql_2.myReader.Read())
                        {
                            xarakatdagi = "Ҳаракатдаги интизомий жазоси бор. " + (sql_2.myReader["from_him"] != DBNull.Value ? sql_2.myReader.GetString("from_him") : "") + " " +
                                (sql_2.myReader["year"] != DBNull.Value ? (sql_2.myReader.GetString("year") + " йил ") : "") + " " +
                                (sql_2.myReader["day"] != DBNull.Value ? (sql_2.myReader.GetString("day") + "") : "") + " " +
                                (sql_2.myReader["month"] != DBNull.Value ? (set_month_name2(sql_2.myReader.GetInt32("month")) + "даги ") : "") + " " +
                                (sql_2.myReader["prikaz_num"] != DBNull.Value ? (sql_2.myReader.GetString("prikaz_num") + "-сонли буйруғи билан, ") : "") + " " +
                                (sql_2.myReader["malumot"] != DBNull.Value ? (sql_2.myReader.GetString("malumot")) : "") + " " +
                                (sql_2.myReader["type_jazo"] != DBNull.Value ? ("«" + sql_2.myReader.GetString("type_jazo") + "»") : "") + "  интизомий жазоси эълон қилинган.";

                        }
                        else
                        {
                            xarakatdagi = " Ҳаракатдаги интизомий жазоси йўқ. ";
                        }
                        sql_2.myReader.Close();
                    }
                    sql.myReader.Close();
                    /* TR1 = par4.AppendText("\n\tХизмат фаолияти давомида ");
                     TR2 = par4.AppendText(" " + (ragbat.Equals("0") ? "рағбатлантирилмаган, " : (ragbat + " маротаба рағбатлантирилган, ")) +
                        " интизомий тартибда " + (jazo.Equals("0") ? "жазоланмаган." : (jazo + " маротаба жазоланган.")) + xarakatdagi);
                        */

                   
                    //Save and Launch
                    //sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Чоп этиш','"+ kod_num + " / "+ fio + " нинг шахсий маълумотлари чоп этилди','"+db_name+"')").ExecuteNonQuery();

                    doc.SaveToFile("docs\\all.docx", Spire.Doc.FileFormat.Docx);
                    System.Diagnostics.Process.Start("docs\\all.docx");
                }
                catch (Exception ex)
                {
                    sql_2.myReader.Close();
                    MessageBox.Show("Error: " + ex.Source + " " + ex.Message);
                }
        }
    }
}
