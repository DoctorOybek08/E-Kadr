using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Kadr
{
    public partial class Buyruq : Form
    {
        private string organ_name = "";
        public string[] db_names;
        /*Connect sql = new Connect();
        Connect sql1 = new Connect();
        Connect sql2 = new Connect();
        Connect sql3 = new Connect();
        Connect sql4 = new Connect();
        Connect sql5 = new Connect();
        Connect sql6 = new Connect();
        Connect sql7 = new Connect();
        Connect sql8 = new Connect();
        Connect sql9 = new Connect();
        Connect sql10 = new Connect();*/
        public Buyruq()
        {
            InitializeComponent();
           
            
            /*sql.Connection();
            sql1.Connection();
            sql2.Connection();
            sql3.Connection();
            sql4.Connection();
            sql5.Connection();
            sql6.Connection();
            sql7.Connection();
            sql8.Connection();
            sql9.Connection();
            sql10.Connection();
             */
            
            this.poisk_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.poisk_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
            
            zvanie_tay_yan_comboBox.Items.Add("сафдор");
            zvanie_tay_yan_comboBox.Items.Add("кичик сержант");
            zvanie_tay_yan_comboBox.Items.Add("сержант");
            zvanie_tay_yan_comboBox.Items.Add("катта сержант");
            zvanie_tay_yan_comboBox.Items.Add("кичик лейтенант");
            zvanie_tay_yan_comboBox.Items.Add("лейтенант");
            zvanie_tay_yan_comboBox.Items.Add("катта лейтенант");
            zvanie_tay_yan_comboBox.Items.Add("капитан");
            zvanie_tay_yan_comboBox.Items.Add("майор");
            zvanie_tay_yan_comboBox.Items.Add("подполковник");
            zvanie_tay_yan_comboBox.Items.Add("полковник");
            zvanie_tay_yan_comboBox.Items.Add("генерал майор");

            unvon_berilsin_comboBox.Items.Add("сафдор");
            unvon_berilsin_comboBox.Items.Add("кичик сержант");
            unvon_berilsin_comboBox.Items.Add("сержант");
            unvon_berilsin_comboBox.Items.Add("катта сержант");
            unvon_berilsin_comboBox.Items.Add("кичик лейтенант");
            unvon_berilsin_comboBox.Items.Add("лейтенант");
            unvon_berilsin_comboBox.Items.Add("катта лейтенант");
            unvon_berilsin_comboBox.Items.Add("капитан");
            unvon_berilsin_comboBox.Items.Add("майор");
            unvon_berilsin_comboBox.Items.Add("подполковник");
            unvon_berilsin_comboBox.Items.Add("полковник");
            unvon_berilsin_comboBox.Items.Add("генерал майор");

            otash_joyi_tatil_comboBox.Items.Add("Тошкент шаҳар, вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Андижон вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Фарғона вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Наманган вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Сирдарё вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Жиззах вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Сурхондарё вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Қашқадарё вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Самарқанд вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Бухоро вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Навоий вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Хоразм вилояти");
            otash_joyi_tatil_comboBox.Items.Add("Қорақалпоғистон Республикаси");

            stavka_orindow_olish_comboBox.Items.Add("0.1");
            stavka_orindow_olish_comboBox.Items.Add("0.2");
            stavka_orindow_olish_comboBox.Items.Add("0.3");
            stavka_orindow_olish_comboBox.Items.Add("0.4");
            stavka_orindow_olish_comboBox.Items.Add("0.5");
            stavka_orindow_olish_comboBox.Items.Add("0.6");
            stavka_orindow_olish_comboBox.Items.Add("0.7");
            stavka_orindow_olish_comboBox.Items.Add("0.8");
            stavka_orindow_olish_comboBox.Items.Add("0.9");
            stavka_orindow_olish_comboBox.Items.Add("1.0");
            stavka_orindow_olish_comboBox.Items.Add("1.1");
            stavka_orindow_olish_comboBox.Items.Add("1.2");
            stavka_orindow_olish_comboBox.Items.Add("1.3");
            stavka_orindow_olish_comboBox.Items.Add("1.4");
            stavka_orindow_olish_comboBox.Items.Add("1.5");


            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.1");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.2");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.3");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.4");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.5");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.6");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.7");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.8");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("0.9");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("1.0");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("1.1");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("1.2");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("1.3");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("1.4");
            stavka_bolnicniy_dobavit_comboBox.Items.Add("1.5");
        }

        private void IterateTreeNodes(TreeNode originalNode, TreeNode rootNode)
        {
            foreach (TreeNode childNode in originalNode.Nodes)
            {

                TreeNode newNode = new TreeNode(childNode.Text);
                newNode.Tag = childNode.Tag;
                this.treeView.SelectedNode = rootNode;
                this.treeView.SelectedNode.Nodes.Add(newNode);
                IterateTreeNodes(childNode, newNode);
            }
        }

        public void run_treeview()
        {
            try
            {
                for (int i = 0; i < Main.global_treeNode.Length; i++)
                {
                    if (Main.global_treeNode[i] != null)
                    {
                        TreeNode node = (TreeNode)Main.global_treeNode[i].Clone();
                        treeView.Nodes.Add(node);
                    }
                }
                treeView.SelectedNode = treeView.Nodes[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview " + ex.Message);
            }
 
        }
       /* public void run_treeview()
        {
            int db_count = 0;
            sql.myReader = sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name "+ db +" order by schema_name").ExecuteReader();
            while (sql.myReader.Read())
            {
                db_count = Int32.Parse(sql.myReader.GetString("cnt"));
            }
            sql.myReader.Close();
            string[] db_names = new string[db_count];
            int ind = 0;
            sql.myReader = sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name "+ db +" order by schema_name").ExecuteReader();
            while (sql.myReader.Read())
            {
                db_names[ind] = sql.myReader.GetString("schema_name");
                ind++;
            }
            sql.myReader.Close();
            try
            {
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

                    treeNode.Expand();
                    treeView.Nodes.Add(treeNode);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        */
        public void run_main()
        {
            treeView.Nodes.Clear();
            run_treeview();
            //run_treeview();

            try
            {
                string str = "";
                poisk_dataGridView.Rows.Clear();


                TreeNode node = treeView.SelectedNode;
                if (node != null)
                {
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    otdel_tay_per_comboBox.Items.Clear();
                    otdel_zaxiraga_comboBox.Items.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select otdel FROM " + db_name + ".work_place group by otdel order by otdel").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        otdel_tay_per_comboBox.Items.Add(Main.sql.myReader.GetString("otdel"));
                        otdel_zaxiraga_comboBox.Items.Add(Main.sql.myReader.GetString("otdel"));
                        otdel_orindow_olish_comboBox.Items.Add(Main.sql.myReader.GetString("otdel"));
                        otdel_bolnicniy_dobavit_comboBox.Items.Add(Main.sql.myReader.GetString("otdel"));
                    }
                    Main.sql.myReader.Close();

                    Console.WriteLine("nizomning bandi");

                }


                nizomning_bandi_boshatilsin_comboBox.Items.Clear();
                jazolar_elonQilinsin_comboBox.Items.Clear();
                tatil_turi_tatil_comboBox.Items.Clear();
                mw_moddasi_mwbekor_comboBox.Items.Clear();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select name FROM spravochnik where type = 'БЎШАТИЛСИН' ").ExecuteReader();//" + db_name + ".
                while (Main.sql.myReader.Read())
                {
                    nizomning_bandi_boshatilsin_comboBox.Items.Add(Main.sql.myReader.GetString("name"));
                }
                Main.sql.myReader.Close();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select name FROM spravochnik where type = 'ЭЪЛОН  ҚИЛИНСИН' ").ExecuteReader(); //" + db_name + ".
                while (Main.sql.myReader.Read())
                {
                    jazolar_elonQilinsin_comboBox.Items.Add(Main.sql.myReader.GetString("name"));
                }
                Main.sql.myReader.Close();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select name FROM spravochnik where type = 'ТАЪТИЛ' ").ExecuteReader(); //" + db_name + ".
                while (Main.sql.myReader.Read())
                {
                    tatil_turi_tatil_comboBox.Items.Add(Main.sql.myReader.GetString("name"));
                }
                Main.sql.myReader.Close();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select name FROM spravochnik where type = 'МЕҲНАТ ШАРТНОМАСИ БЕКОР ҚИЛИНСИН' ").ExecuteReader();//" + db_name + ".
                while (Main.sql.myReader.Read())
                {
                    mw_moddasi_mwbekor_comboBox.Items.Add(Main.sql.myReader.GetString("name"));
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("run_main " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
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
        private void Buyruq_Load(object sender, EventArgs e)
        {
            try
            {

                string db = System.IO.File.ReadAllText("docs\\access.txt");
                viloyatlar_comboBox.Items.Clear();
                var sel = "SELECT schema_name FROM information_schema.schemata where schema_name " + db + " order by schema_name";
                Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    var sel_lav = "SELECT name FROM " + Main.sql.myReader.GetString("schema_name") + ".vacant where type_num = 1";
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(sel_lav).ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        organ_name = Main.sql_2.myReader.GetString("name");
                    }
                    Main.sql_2.myReader.Close();

                }
                Main.sql.myReader.Close();

                int db_count = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name " + db + "order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_count = Int32.Parse(Main.sql.myReader.GetString("cnt"));
                }
                Main.sql.myReader.Close();
                db_names = new string[db_count];
                int ind = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name " + db + " order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_names[ind] = Main.sql.myReader.GetString("schema_name");
                    ind++;
                }
                Main.sql.myReader.Close();
                viloyatlar_comboBox.Items.Clear();
                foreach (var d_b in db_names)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT name from " + d_b + ".vacant where type_num  = '1'").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        viloyatlar_comboBox.Items.Add(Main.sql.myReader.GetString("name"));
                        ind++;
                    }
                    Main.sql.myReader.Close();
                }
                run_main();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Buyruq_Load ", ex.Message);
                Main.sql.myReader.Close();
                Main.sql_2.myReader.Close();
            }
        }

        string otdel_string_global = "";
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

                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                viloyatlar_comboBox.SelectedIndex = index1;
                string otpuska_m = "";
                string ornida_m = "";
                string orindosh_m = "";

                poisk_dataGridView.Rows.Clear();

                this.poisk_dataGridView.SelectionChanged -= new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
                if (node.Text == "Бошқарма ихтиёрида")
                {
                    var query = "SELECT rezerv.kod_num,rezerv.id," +
                   "rezerv.lichniy_num,rezerv.zvanie, fio_full as fio, rezerv.otdel, rezerv.doljnost FROM " + db_name + ".rezerv WHERE rezerv.cheeck = 0"
                                                    + " order by rezerv.id asc";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(query).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = otpuska_m;
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = ornida_m;
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[8].Value = "";
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value = "-";

                        if (otpuska_m != "")
                        {
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Style.BackColor = Color.GreenYellow;
                        }
                        if (ornida_m != "")
                        {
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Style.BackColor = Color.GreenYellow;
                        }
                    }
                    Main.sql.myReader.Close();
                }
                else
                {

                            var sel1 = "SELECT distinct doljnost FROM " + db_name + ".work_place;";
                    var select = "SELECT * FROM (SELECT distinct main.id, main.zvanie, main.kod_num, concat(main.surname,' ',main.name,' ', main.fath_name) as fio, "
  + "main.doljnost, otpuska.date_finish as dt, 'tatil' as type, main.otdel FROM main, otpuska where main.kod_num = otpuska.kod_num and otpuska.date_finish > now() "
  + "and otpuska.type_otpusk = 'Берилсин (Шаҳодатланганлар учун)'and main.date_finish is null and parent_kod_num is null "
  + "UNION "
  + "SELECT distinct main.id, main.zvanie, main.kod_num,concat(main.surname, ' ', main.name, ' ', main.fath_name) as fio, main.doljnost, otpuska.date_finish as dt, "
   + "'dikret' as type, main.otdel FROM main, otpuska where main.kod_num = otpuska.kod_num and otpuska.date_finish > now() "
  + "and otpuska.type_otpusk LIKE 'Фарзанди %' or otpuska.type_otpusk LIKE 'Туғруқ% 'and main.date_finish is null and parent_kod_num is null UNION "
  + "SELECT distinct main.id, main.zvanie, main.kod_num,concat(main.surname, ' ', main.name, ' ', main.fath_name) as fio, main.doljnost, "
  + " '' as dt, '' as type, main.otdel FROM main where main.kod_num not in (select kod_num from otpuska where date_finish > now()) and main.date_finish is null and parent_kod_num is null UNION "
  + "SELECT distinct main.id, main.zvanie, main.kod_num,concat(main.surname, ' ', main.name, ' ', main.fath_name) as fio, main.doljnost, "
   + "'' as dt, 'dikret_h' as type, main.otdel from  main where parent_kod_num != 0 && parent_kod_num is not null and date_finish is null UNION "
   + "SELECT distinct main.id, main.zvanie, main.kod_num,concat(main.surname, ' ', main.name, ' ', main.fath_name) as fio, main.doljnost, "
   + "'' as dt, 'orindosh' as type, main.otdel from  main where parent_kod_num = 0 and date_finish is null) as t where t.otdel = '" + str + "' group by kod_num order by t.kod_num asc";

                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {

                        if (Main.sql.myReader.GetString("type") == "tatil")
                        {
                            otpuska_m = "Таътилда";
                        }
                        else if (Main.sql.myReader.GetString("type") == "dikret")
                        {
                            otpuska_m = "Декретда";
                        }
                        else if (Main.sql.myReader.GetString("type") == "dikret_h")
                        {
                            ornida_m = "Декрет ҳисобидан";
                        }
                        else if (Main.sql.myReader.GetString("type") == "orindosh")
                        {
                            ornida_m = "Ўриндош";
                        }
                        else
                        {
                            ornida_m = "";
                        }
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = otpuska_m;
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = ornida_m;
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[8].Value = "";
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value = "-";

                        if (otpuska_m != "")
                                {
                                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Style.BackColor = Color.GreenYellow;
                                }
                                if (ornida_m != "")
                                {
                                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Style.BackColor = Color.GreenYellow;
                                }
                                otpuska_m = "";
                                ornida_m = "";

                            }
                            Main.sql.myReader.Close();
                        }
                        poisk_dataGridView.ClearSelection();

                        //---

                        /*Main.sql.myReader = Main.sql.return_MySqlCommand("select * FROM " + db_name + ".rezerv where cheeck = '0' ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio_full"] != DBNull.Value ? Main.sql.myReader.GetString("fio_full") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["type_otpuska"] != DBNull.Value ? Main.sql.myReader.GetString("type_otpuska") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["vacant_type"] != DBNull.Value ? Main.sql.myReader.GetString("vacant_type") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[8].Value = "0";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value = ("Л.и бўшатиб олинган");

                            if (poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value.ToString().Equals("Л.и бўшатиб олинган"))
                            {
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Style.BackColor = Color.GreenYellow;
                            }
                        }
                        Main.sql.myReader.Close();
                        */
                        //---
                        /*
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select main.kod_num,main.id,orindoshlar.id as orindosh_id,concat(main.surname,' ',main.name,' ',main.fath_name) as fio,main.zvanie,main.doljnost,main.otdel " +
                            " FROM " + db_name + ".main,orindoshlar where orindoshlar.date_finish is null and main.kod_num = orindoshlar.kod_num ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {

                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["orindosh_id"] != DBNull.Value ? Main.sql.myReader.GetString("orindosh_id") : "");

                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = "-";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = "-";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[8].Value = "-";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value = ("Ўриндош");

                            if (poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value.ToString().Equals("Ўриндош"))
                            {
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Style.BackColor = Color.GreenYellow;
                            }
                        }
                        Main.sql.myReader.Close();
                        */
                        //----
                        /*
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select main.kod_num,bolnichniylar_orniga.id,concat(main.surname,' ',main.name,' ',main.fath_name) as fio,main.zvanie,main.doljnost,main.otdel " +
                            " FROM " + db_name + ".main,bolnichniylar_orniga where bolnichniylar_orniga.date_finish is null and main.kod_num = bolnichniylar_orniga.kod_num ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {

                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = "-";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = "-";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[8].Value = "-";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value = ("Больничный ўрнига");

                            if (poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value.ToString().Equals("Больничный ўрнига"))
                            {
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Style.BackColor = Color.GreenYellow;
                            }
                        }
                        Main.sql.myReader.Close();
                        */
                        //----

                        //----
                kod_num_global = "";
                otdel_string_global = str;
                otdel_tay_yan_label.Text = str;

                doljnost_tay_yan_comboBox.Items.Clear();
                doljnost_mwt_comboBox.Items.Clear();
                doljnost_orindow_olish_comboBox.Items.Clear();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select doljnost FROM " + db_name + ".work_place where otdel = '" + str + "' group by doljnost order by id ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    doljnost_tay_yan_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                    doljnost_mwt_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                    doljnost_orindow_olish_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                }
                Main.sql.myReader.Close();
                poisk_dataGridView.ClearSelection();

                this.poisk_dataGridView.SelectionChanged += new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("treeView_AfterSelect " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Main.sql.myReader.Close();
            }
        }

        string kod_num_global;
        private void poisk_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    start_tatil_dateTimePicker.Value = DateTime.Today;
                    finish_tatil_dateTimePicker.Value = DateTime.Today;
                    period_tatil_label.Text = "...";

                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    otdel_string_global = dgvRow.Cells["otdel_poisk"].Value.ToString();
                    fio_tay_per_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_tay_per_label.Text = otdel_string_global;

                    fio_boshatilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_boshatilsin_label.Text = otdel_string_global;

                    fio_yuborilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_yuborilsin_label.Text = otdel_string_global;

                    fio_qoldirilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_qoldirilsin_label.Text = otdel_string_global;

                    fio_berilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_berilsin_label.Text = otdel_string_global;

                    fio_elonQilinsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_elonQilinsin_label.Text = otdel_string_global;

                    fio_olib_tashlansin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_olib_tashlansin_label.Text = otdel_string_global;

                    fio_tasdiqlansin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_tasdiqlansin_label.Text = otdel_string_global;

                    fio_tatil_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_tatil_label.Text = otdel_string_global;

                    fio_mwt_label.Text = dgvRow.Cells[3].Value.ToString() + "нинг ўрнига ";
                    otdel_mwt_label.Text = otdel_string_global;

                    fio_mwbekor_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_mwbekor_label.Text = otdel_string_global;

                    fio_lavozimni_bowatish_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_lavozimni_bowatish_label.Text = otdel_string_global;

                    fio_zaxiraga_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_zaxiraga_label.Text = otdel_string_global;

                    otdel_orindow_olish_label.Text = otdel_string_global;

                    fio_orindow_toxtatilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_orindow_toxtatilsin_label.Text = otdel_string_global;

                    fio_bolnicniy_udalit_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_bolnicniy_udalit_label.Text = otdel_string_global;

                    kod_num_global = dgvRow.Cells[1].Value.ToString();

                    //-
                    olib_tawlansin_dataGridView.Rows.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * FROM " + db_name + ".intizomiy where cheeck_jazo = '0' and kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["type_jazo"] != DBNull.Value ? Main.sql.myReader.GetString("type_jazo") : "");
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["from_him"] != DBNull.Value ? Main.sql.myReader.GetString("from_him") : "");
                    }
                    Main.sql.myReader.Close();

                    String[] arr;
                    arr = dgvRow.Cells[3].Value.ToString().Split(' ');


                    familiyasi_orindow_olish_textBox.Text = arr[0];
                    ismi_orindow_olish_textBox.Text = arr[1];

                    Console.WriteLine(arr.Length);
                    otasining_ismi_orindow_olish_textBox.Text = arr[2] + " " + (arr.Length == 4 ? arr[3] : "");

                    fio_bolnicniy_dobavit_label.Text = dgvRow.Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("poisk_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Main.sql.myReader.Close();
                }
            }
        }

        //private DataTable BindComboBox()
        //{
        //    //DataTable allNames = new DataTable();
        //    //allNames.Columns.Add(new DataColumn("Name"));

        //    //Main.sql.myReader = Main.sql.return_MySqlCommand("select otdel FROM " + db_name + ".work_place group by otdel order by otdel").ExecuteReader();
        //    //while (Main.sql.myReader.Read())
        //    //{
        //    //    allNames.Rows.Add(Main.sql.myReader.GetString("otdel"));
        //    //  //  otdel_tay_per_comboBox.Items.Add(Main.sql.myReader.GetString("otdel"));
        //    //}
        //    //Main.sql.myReader.Close();

        //    //return allNames;
        //}

        private void otdel_tay_per_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
                if (node != null)
                {
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    doljnost_tay_per_comboBox.Text = "";
                    doljnost_tay_per_comboBox.Items.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select doljnost FROM " + db_name + ".work_place where otdel = '" + otdel_tay_per_comboBox.Text + "' group by doljnost order by id ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        doljnost_tay_per_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                    }
                    Main.sql.myReader.Close();
                }
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("otdel_tay_per_comboBox_SelectedValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void otdel_tay_per_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataTable table = BindComboBox();
            //string name = string.Format("{0}{1}", otdel_tay_per_comboBox.Text, e.KeyChar.ToString()); //join previous text and new pressed char
            //DataRow[] rows = table.Select(string.Format("Name LIKE '%{0}%'", name));
            //DataTable filteredTable = table.Clone();
            //foreach (DataRow r in rows)
            //    filteredTable.ImportRow(r);
            //otdel_tay_per_comboBox.DataSource = null;
            //otdel_tay_per_comboBox.DataSource = filteredTable.DefaultView;
            //otdel_tay_per_comboBox.DisplayMember = "Name";
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
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

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                //otdel_tay_per_comboBox.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show("treeView_DoubleClick " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void poisk_dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    start_tatil_dateTimePicker.Value = DateTime.Today;
                    finish_tatil_dateTimePicker.Value = DateTime.Today;
                    period_tatil_label.Text = "...";

                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;

                    fio_tay_per_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_tay_per_label.Text = otdel_string_global;

                    fio_boshatilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_boshatilsin_label.Text = otdel_string_global;

                    fio_yuborilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_yuborilsin_label.Text = otdel_string_global;

                    fio_qoldirilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_qoldirilsin_label.Text = otdel_string_global;

                    fio_berilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_berilsin_label.Text = otdel_string_global;

                    fio_elonQilinsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_elonQilinsin_label.Text = otdel_string_global;

                    fio_olib_tashlansin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_olib_tashlansin_label.Text = otdel_string_global;

                    fio_tasdiqlansin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_tasdiqlansin_label.Text = otdel_string_global;

                    fio_tatil_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_tatil_label.Text = otdel_string_global;

                    fio_mwt_label.Text = dgvRow.Cells[3].Value.ToString() + "нинг ўрнига ";
                    otdel_mwt_label.Text = otdel_string_global;

                    fio_mwbekor_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_mwbekor_label.Text = otdel_string_global;

                    fio_lavozimni_bowatish_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_lavozimni_bowatish_label.Text = otdel_string_global;

                    fio_zaxiraga_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_zaxiraga_label.Text = otdel_string_global;

                    otdel_orindow_olish_label.Text = otdel_string_global;

                    fio_orindow_toxtatilsin_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_orindow_toxtatilsin_label.Text = otdel_string_global;

                    fio_bolnicniy_udalit_label.Text = dgvRow.Cells[3].Value.ToString();
                    otdel_bolnicniy_udalit_label.Text = otdel_string_global;

                    kod_num_global = dgvRow.Cells[1].Value.ToString();

                    //-
                    olib_tawlansin_dataGridView.Rows.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * FROM " + db_name + ".intizomiy where cheeck_jazo = '0' and kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["type_jazo"] != DBNull.Value ? Main.sql.myReader.GetString("type_jazo") : "");
                        olib_tawlansin_dataGridView.Rows[olib_tawlansin_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["from_him"] != DBNull.Value ? Main.sql.myReader.GetString("from_him") : "");
                    }
                    Main.sql.myReader.Close();

                    String[] arr;
                    arr = dgvRow.Cells[3].Value.ToString().Split(' ');


                    familiyasi_orindow_olish_textBox.Text = arr[0];
                    ismi_orindow_olish_textBox.Text = arr[1];

                    Console.WriteLine(arr.Length);

                    otasining_ismi_orindow_olish_textBox.Text = arr[2] + " " + (arr.Length == 4 ? arr[3] : "");

                    fio_bolnicniy_dobavit_label.Text = dgvRow.Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("poisk_dataGridView_MouseClick " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void poisk_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string str = "";
                TreeNode node = treeView.SelectedNode;
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

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                if (e.Button == MouseButtons.Right)
                {

                    //int rowIndex = e.RowIndex;
                    //poisk_dataGridView.ClearSelection();
                    //poisk_dataGridView.Rows[rowIndex].Selected = true;

                    fio_oz2_label.Text = poisk_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    otdel_oz2_label.Text = poisk_dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    kod_num_oz2 = Convert.ToInt32(poisk_dataGridView.Rows[e.RowIndex].Cells[1].Value);

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id FROM " + db_name + ".work_place where kod_num = '" + kod_num_oz2 + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        id_work_place_oz2 = Main.sql.myReader.GetInt32("id");
                    }
                    Main.sql.myReader.Close();
                }
                else if (e.Button == MouseButtons.Left)
                {
                    fio_oz1_label.Text = poisk_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    otdel_oz1_label.Text = poisk_dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    kod_num_oz1 = Convert.ToInt32(poisk_dataGridView.Rows[e.RowIndex].Cells[1].Value);


                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id FROM " + db_name + ".work_place where kod_num = '" + kod_num_oz1 + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        id_work_place_oz1 = Main.sql.myReader.GetInt32("id");
                    }
                    Main.sql.myReader.Close();
                }
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("poisk_dataGridView_CellMouseClick ", ex.Message);
            }
        }

        private void nizomning_bandi_boshatilsin_comboBox_Validated(object sender, EventArgs e)
        {
            try
            {
                if (nizomning_bandi_boshatilsin_comboBox.Text == "144-бандининг «б» кичик бандига мувофиқ (хизматда бўлишнинг белгиланган чегара ёшига тўлганлиги)")
                {
                    title_boshatilsin_label.Text = "Истеъфога";
                }
                else
                {
                    title_boshatilsin_label.Text = "Қуролли кучлар резервига";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("nizomning_bandi_boshatilsin_comboBox_Validated " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void otdel_zaxiraga_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
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

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                doljnost_zaxiraga_comboBox.Text = "";
                doljnost_zaxiraga_comboBox.Items.Clear();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select doljnost FROM " + db_name + ".work_place where otdel = '" + otdel_zaxiraga_comboBox.Text + "' group by doljnost order by id ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    doljnost_zaxiraga_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("otdel_zaxiraga_comboBox_SelectedValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        PopupNotifier popup = new PopupNotifier();
        public void run_alert(string fio)
        {
            popup.BodyColor = Color.FromArgb(116, 209, 106);
            // popup.BorderColor = Color.White;
            popup.ContentHoverColor = Color.Black;
            popup.TitleColor = Color.White;
            popup.ContentColor = Color.White;

            popup.TitleText = "Успешно";
            // popup.ContentText = fio;

            popup.TitleFont = new Font("Times New Roman", 12f);
            popup.Popup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (familiyasi_tay_yan_textBox.Text != "" && ismi_tay_yan_textBox.Text != "" && otasining_ismi_tay_yan_textBox.Text != ""
                && doljnost_tay_yan_comboBox.SelectedIndex != -1)
            {
                try
                {
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".dobavit (kod_num,surname,name,fath_name,zvanie,from_where,otdel,doljnost,date,asos,noow,v_b) values(" +
                        " '0', " +
                        " '" + (familiyasi_tay_yan_textBox.Text) + "', " +
                        " '" + (ismi_tay_yan_textBox.Text) + "', " +
                        " '" + (otasining_ismi_tay_yan_textBox.Text) + "', " +
                        " '" + (zvanie_tay_yan_comboBox.Text) + "', " +
                        " '" + (qayerdan_tay_yan_textBox.Text) + "', " +
                        " '" + (otdel_string_global) + "', " +
                        " '" + (doljnost_tay_yan_comboBox.Text) + "', " +
                        " " + (ogovorka_tay_yan_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_tay_yan_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        " '" + (asos_tay_yan_textBox.Text) + "', " +
                        " CURDATE(), " +
                        " '" + (vazifasini_bajaruvci_tay_yan_checkBox.Checked ? "1" : "0") + "' " +
                        ")").ExecuteNonQuery();

                 /*   Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (familiyasi_tay_yan_textBox.Text + " " + ismi_tay_yan_textBox.Text + " " + otasining_ismi_tay_yan_textBox.Text) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_tay_yan_function();
                    run_alert(familiyasi_tay_yan_textBox.Text + " " + ismi_tay_yan_textBox.Text + " " + otasining_ismi_tay_yan_textBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button1_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void converting_date(object sender, EventArgs e)
        {
            convert_date_main_function((TextBox)sender);
        }


        public void convert_date_main_function(TextBox sample)
        {
            try
            {
                string[] strArray = sample.Text.ToString().Replace(',', '.').Split('.');
                string s1 = strArray[0].Trim();
                string s2 = strArray[1].Trim();
                string s3 = strArray[2].Trim();
                if (int.Parse(s1) <= 31 && int.Parse(s2) <= 12 && int.Parse(s3) < 3000)
                {
                    if (s1.Length == 1)
                        s1 = "0" + s1;
                    if (s2.Length == 1)
                        s2 = "0" + s2;
                    if (s3.Length == 2)
                        s3 = "20" + s3;
                    sample.Text = s1 + "." + s2 + "." + s3;
                }
                else
                    sample.Text = "";
            }
            catch (Exception ex)
            {
                sample.Text = "";
                Console.WriteLine(ex.Message);
            }
        }

        public void clear_textbox_tay_yan_function()
        {
            familiyasi_tay_yan_textBox.Text = "";
            ismi_tay_yan_textBox.Text = "";
            otasining_ismi_tay_yan_textBox.Text = "";
            vazifasini_bajaruvci_tay_yan_checkBox.Checked = false;
            otdel_tay_yan_label.Text = "-";
            ogovorka_tay_yan_textBox.Text = "";
            zvanie_tay_yan_comboBox.SelectedIndex = -1;
            doljnost_tay_yan_comboBox.SelectedIndex = -1;
            qayerdan_tay_yan_textBox.Text = "";
            asos_tay_yan_textBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string db = System.IO.File.ReadAllText("docs\\access.txt");
            if (poisk_dataGridView.SelectedCells.Count > 0 && kod_num_global != "" && otdel_tay_per_comboBox.Text != "" && doljnost_tay_per_comboBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    int db_count = 0;
                    string boshqarma_nomi = "";
                   
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name "+ db +" order by schema_name").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        db_count = Int32.Parse(Main.sql.myReader.GetString("cnt"));
                    }
                    Main.sql.myReader.Close();
                    string db_name = tags[index1];
                    string[] db_names = new string[db_count];
                    int ind = 0;
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name "+ db +" order by schema_name").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        db_names[ind] = Main.sql.myReader.GetString("schema_name");
                        ind++;
                    }
                    Main.sql.myReader.Close();
                    string db_name_new = db_names[viloyatlar_comboBox.SelectedIndex];
                    Main.sql.myReader = Main.sql.return_MySqlCommand("Select name from " + db_name + ".vacant where type_num = 1 limit 1").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        boshqarma_nomi = Main.sql.myReader.GetString("name");
                    }
                    Main.sql.myReader.Close();

                   // string db_name_new = db_names[viloyatlar_comboBox.SelectedIndex];
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select register_num,date_start,prikaz_start,from_him_prikaz,otdel,doljnost,date_start2,zvanie,date_start FROM " + db_name + ".main where kod_num = '" + kod_num_global + "'").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".perevod (register_num,kod_num,fio,zvanie,old_prikaz_num,old_prikaz_date,old_prikaz_date1,old_otdel,old_doljnost," +
                            "old_from_him,otdel,doljnost,date_start,asos,noow,v_b, organ_from, organ_to) values(" +
                            " '" + (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "") + "', " +
                            " '" + (kod_num_global) + "', " +
                            " '" + (dgvRow.Cells[3].Value) + "', " +
                            " '" + (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "") + "', " +
                            " '" + (Main.sql.myReader["prikaz_start"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_start") : "") + "', " +
                            " " + (Main.sql.myReader["date_start2"] != DBNull.Value ? ("'" + DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                            " " + (Main.sql.myReader["date_start"] != DBNull.Value ? ("'" + DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                            " '" + (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "") + "', " +
                            " '" + (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "") + "', " +
                            " '" + (Main.sql.myReader["from_him_prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("from_him_prikaz") : "") + "', " +
                            " '" + boshqarma_nomi + (otdel_tay_per_comboBox.Text) + "', " +
                            " '" + (doljnost_tay_per_comboBox.Text) + "', " +
                            " " + (ogovorka_tay_per_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_tay_per_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                            " '" + (asos_tay_per_textBox.Text) + "', " +
                            " CURDATE(), " +
                            " '" + (vazifasini_baj_tay_per_checkBox.Checked ? "1" : "0") + "', " +
                            " '" + db_name + "'," +
                            " '" + db_name_new + "'" +
                            ")").ExecuteNonQuery();

                        if (dgvRow.Cells[8].Value.ToString().Equals("0"))
                        {
                            Main.sql_2.return_MySqlCommand("update " + db_name + ".rezerv set cheeck = '1' where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();
                        }
                    }
                    Main.sql.myReader.Close();

                   /* Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_tay_per_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button2_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Main.sql.myReader.Close();
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        public void clear_textbox_tay_per_function()
        {
            fio_tay_per_label.Text = "-";
            otdel_tay_per_label.Text = "-";
            otdel_tay_per_comboBox.SelectedIndex = -1;
            ogovorka_tay_per_textBox.Text = "";
            doljnost_tay_per_comboBox.SelectedIndex = -1;
            vazifasini_baj_tay_per_checkBox.Checked = false;
            asos_tay_per_textBox.Text = "";
        }

        int kod_num_oz1;
        int kod_num_oz2;
        int id_work_place_oz1;
        int id_work_place_oz2;

        private void button3_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && ogovorka_oz1_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select register_num,concat(surname,' ',name,' ',fath_name) as fio,date_start,prikaz_start,from_him_prikaz,otdel,doljnost,date_start2,zvanie,date_start FROM " + db_name + ".main where kod_num = '" + kod_num_oz1 + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".perevod_oz "
                        + "(register_num1,kod_num1,id_work_place1,fio1,zvanie1,"
                        + "old_prikaz_num1,old_prikaz_date11,old_prikaz_date1,old_otdel1,old_doljnost1,"
                        + "old_prikaz_from_him1,otdel1,doljnost1,date_start1,asos1,"
                        + "register_num2,kod_num2,id_work_place2,fio2,zvanie2,"
                        + "old_prikaz_num2,old_prikaz_date12,old_prikaz_date2,old_otdel2,old_doljnost2,"
                        + "old_prikaz_from_him2,otdel2,doljnost2,date_start2,asos2,noow,v_b1,v_b2) " +
                        " select " +
                        " '" + (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "") + "', " +
                        " '" + kod_num_oz1 + "', " +
                        " '" + id_work_place_oz1 + "', " +
                        " '" + (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "") + "', " +
                        " '" + (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "") + "', " +
                        " '" + (Main.sql.myReader["prikaz_start"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_start") : "") + "', " +
                        " " + (Main.sql.myReader["date_start"] != DBNull.Value ? ("'" + DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        " " + (Main.sql.myReader["date_start2"] != DBNull.Value ? ("'" + DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        " '" + (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "") + "', " +
                        " '" + (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "") + "', " +
                        " '" + (Main.sql.myReader["from_him_prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("from_him_prikaz") : "") + "', " +
                        "otdel," +
                        "doljnost," +
                        " " + (ogovorka_oz1_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_oz1_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        " '" + asos_oz1_textBox.Text + "', " +
                        "register_num," +
                        " '" + kod_num_oz2 + "', " +
                        " '" + id_work_place_oz2 + "', " +
                        "concat(surname,' ',name,' ',fath_name)," +
                        "zvanie," +
                        "prikaz_start," +
                        "date_start," +
                        "date_start2," +
                        "otdel," +
                        "doljnost," +
                        "from_him_prikaz," +
                        " '" + (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "") + "', " +
                        " '" + (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "") + "', " +
                        " " + (ogovorka_oz1_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_oz1_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        " '" + asos_oz2_textBox.Text + "', " +
                        "CURDATE()," +
                        " '" + (vazifasini_bajaruvci_oz1_checkBox.Checked ? "1" : "0") + "', " +
                        " '" + (vazifasini_bajaruvci_oz2_checkBox.Checked ? "1" : "0") + "' " +

                        " FROM " + db_name + ".main where kod_num = '" + kod_num_oz2 + "'  ").ExecuteNonQuery();
                    }
                    Main.sql.myReader.Close();

                    clear_textbox_tay_ozaro_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button3_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Main.sql.myReader.Close();
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_tay_ozaro_function()
        {
            fio_oz1_label.Text = "-";
            fio_oz2_label.Text = "-";
            otdel_oz1_label.Text = "-";
            otdel_oz2_label.Text = "-";
            vazifasini_bajaruvci_oz1_checkBox.Checked = false;
            vazifasini_bajaruvci_oz2_checkBox.Checked = false;
            asos_oz1_textBox.Text = "";
            asos_oz2_textBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && nizomning_bandi_boshatilsin_comboBox.Text != "")
            {
                try
                {
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".boshatish (kod_num,name,zvanie,date,boshatish_t,"
                                               + "bandi,asos,otdel,doljnost,noow) values( " +
                                               " '" + kod_num_global + "', " +
                                               " '" + (dgvRow.Cells[3].Value) + "', " +
                                               " '" + (dgvRow.Cells[2].Value) + "', " +
                                               " " + (date_boshatilsin_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(date_boshatilsin_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                                               " '" + (title_boshatilsin_label.Text) + "', " +
                                               " '" + (nizomning_bandi_boshatilsin_comboBox.Text) + "', " +
                                               " '" + (asos_boshatilsin_textBox.Text) + "', " +
                                               " '" + (dgvRow.Cells[7].Value) + "', " +
                                               " '" + (dgvRow.Cells[4].Value) + "', " +
                                               "CURDATE()" +
                                               ")").ExecuteNonQuery();

                    /*Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_boshatish_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button4_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_boshatish_function()
        {
            fio_boshatilsin_label.Text = "-";
            otdel_boshatilsin_label.Text = "-";
            nizomning_bandi_boshatilsin_comboBox.SelectedIndex = -1;
            date_boshatilsin_textBox.Text = "";
            title_boshatilsin_label.Text = "-";
            asos_boshatilsin_textBox.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && boshqa_davlat_organidan_yuborilsin_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".yuborish (kod_num,fio,zvanie,date," +
                         " otdel,doljnost,other_organ,asos,noow) values( " +
                         " '" + kod_num_global + "', " +
                         " '" + (dgvRow.Cells[3].Value) + "', " +
                         " '" + (dgvRow.Cells[2].Value) + "', " +
                         " " + (ogovorka_yuborilsin_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_yuborilsin_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                         " '" + (dgvRow.Cells[7].Value) + "', " +
                         " '" + (dgvRow.Cells[4].Value) + "', " +
                         " '" + (boshqa_davlat_organidan_yuborilsin_textBox.Text) + "', " +
                         " '" + (asos_yuborilsin_textBox.Text) + "', " +
                         "CURDATE() " +
                         ")").ExecuteNonQuery();

                    /*Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_yuborilsin_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button5_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_yuborilsin_function()
        {
            fio_yuborilsin_label.Text = "-";
            otdel_yuborilsin_label.Text = "-";
            ogovorka_yuborilsin_textBox.Text = "";
            boshqa_davlat_organidan_yuborilsin_textBox.Text = "-";
            asos_yuborilsin_textBox.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && asos_qoldirilsin_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".qoldirilsin (kod_num,fio,zvanie,date," +
                         " otdel,doljnost,asos,noow) values( " +
                         " '" + kod_num_global + "', " +
                         " '" + (dgvRow.Cells[3].Value) + "', " +
                         " '" + (dgvRow.Cells[2].Value) + "', " +
                         " " + (ogovorka_qoldirilsin_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_qoldirilsin_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                         " '" + (dgvRow.Cells[7].Value) + "', " +
                         " '" + (dgvRow.Cells[4].Value) + "', " +
                         " '" + (asos_qoldirilsin_textBox.Text) + "', " +
                         "CURDATE() " +
                         ")").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".rezerv(kod_num,zvanie,fio_full,otdel,doljnost,id_work_place,surname,type_otpuska,vacant_type)" +
                                  "values( " +
                                  " '" + kod_num_global + "', " +
                                  " '" + (dgvRow.Cells[2].Value) + "', " +
                                  " '" + (dgvRow.Cells[3].Value) + "', " +
                                  " '" + (dgvRow.Cells[7].Value) + "', " +
                                  " '" + (dgvRow.Cells[4].Value) + "', " +
                                  " '" + (dgvRow.Cells[0].Value) + "', " +
                                  " '" + (dgvRow.Cells[3].Value) + "', " +
                                  " '" + (dgvRow.Cells[5].Value) + "', " +
                                  " '" + (dgvRow.Cells[6].Value) + "' " +
                                  ")").ExecuteNonQuery();

                    /*Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_qoldirilsin_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button5_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_qoldirilsin_function()
        {
            fio_qoldirilsin_label.Text = "-";
            otdel_qoldirilsin_label.Text = "-";
            ogovorka_qoldirilsin_textBox.Text = "";
            asos_qoldirilsin_textBox.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && asos_tasdiqlansin_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    int w = 0;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select v_b FROM " + db_name + ".main where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        w = Main.sql.myReader.GetInt32("v_b");
                    }
                    Main.sql.myReader.Close();

                    if (w != 0)
                    {
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select register_num,date_start,prikaz_start,from_him_prikaz,otdel,doljnost,date_start2,zvanie,date_start " +
                            "FROM " + db_name + ".main where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            Main.sql_2.return_MySqlCommand("insert into " + db_name + ".tasdiqlansin (register_num,kod_num,fio,zvanie,old_prikaz_num,old_prikaz_date,old_prikaz_date1,old_otdel,old_doljnost," +
                                "old_from_him,otdel,doljnost,asos,noow) values( " +
                                " '" + (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "") + "', " +
                                " '" + (kod_num_global) + "', " +
                                " '" + (dgvRow.Cells[3].Value) + "', " +
                                " '" + (dgvRow.Cells[2].Value) + "', " +
                                " '" + (Main.sql.myReader["prikaz_start"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_start") : "") + "', " +
                                " " + (Main.sql.myReader["date_start2"] != DBNull.Value ? ("'" + DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                                " " + (Main.sql.myReader["date_start"] != DBNull.Value ? ("'" + DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                                " '" + (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "") + "', " +
                                " '" + (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "") + "', " +
                                " '" + (Main.sql.myReader["from_him_prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("from_him_prikaz") : "") + "', " +
                                " '" + (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "") + "', " +
                                " '" + (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost").ToString().Replace(" вазифасини бажарувчи", "") : "") + "', " +
                                " '" + (asos_tasdiqlansin_textBox.Text) + "', " +
                                " CURDATE() " +

                                ")").ExecuteNonQuery();

                            if (dgvRow.Cells[8].Value.ToString().Equals("0"))
                            {
                                Main.sql_2.return_MySqlCommand("update " + db_name + ".rezerv set cheeck = '1' where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();
                            }
                        }
                        Main.sql.myReader.Close();

                       /* Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                        (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                        */
                        clear_textbox_tasdiqlansin_function();
                        run_alert("");
                    }
                    else
                    {
                        MessageBox.Show("Ҳодим лавозими вазифасини бажарувчи эмас.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("button5_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Main.sql.myReader.Close();
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_tasdiqlansin_function()
        {
            fio_tasdiqlansin_label.Text = "-";
            otdel_tasdiqlansin_label.Text = "-";
            asos_tasdiqlansin_textBox.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && unvon_berilsin_comboBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".berilsin (kod_num,surname," +
                         " otdel,doljnost,old_zvanie,zvanie,noow) values( " +
                         " '" + kod_num_global + "', " +
                         " '" + (dgvRow.Cells[3].Value) + "', " +
                         " '" + (dgvRow.Cells[7].Value) + "', " +
                         " '" + (dgvRow.Cells[4].Value) + "', " +
                         " '" + (dgvRow.Cells[2].Value) + "', " +
                         " '" + (unvon_berilsin_comboBox.Text) + "', " +
                         "CURDATE() " +
                         ")").ExecuteNonQuery();

                    /*Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_berilsin_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_berilsin_function()
        {
            fio_berilsin_label.Text = "-";
            otdel_berilsin_label.Text = "-";
            unvon_berilsin_comboBox.SelectedIndex = -1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && sababi_elonQilinsin_textBox.Text != "" && jazolar_elonQilinsin_comboBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".elon_q (kod_num,surname," +
                         " zvanie,otdel,doljnost,malumot,asos,type_jazo,noow) values( " +
                         " '" + kod_num_global + "', " +
                         " '" + (dgvRow.Cells[3].Value) + "', " +
                         " '" + (dgvRow.Cells[2].Value) + "', " +
                         " '" + (dgvRow.Cells[7].Value) + "', " +
                         " '" + (dgvRow.Cells[4].Value) + "', " +
                         " '" + (sababi_elonQilinsin_textBox.Text) + "', " +
                         " '" + (asos_elonQilinsin_textBox.Text) + "', " +
                         " '" + (jazolar_elonQilinsin_comboBox.Text) + "', " +
                         "CURDATE() " +

                         ")").ExecuteNonQuery();

                   /* Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_elon_qilinsin_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_elon_qilinsin_function()
        {
            fio_elonQilinsin_label.Text = "-";
            otdel_elonQilinsin_label.Text = "-";
            jazolar_elonQilinsin_comboBox.SelectedIndex = -1;
            asos_elonQilinsin_textBox.Text = "";
            sababi_elonQilinsin_textBox.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && asos_olib_tashlansin_textBox.Text != "" && olib_tawlansin_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_ijtimoiy = olib_tawlansin_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".olib_t (kod_num,fio,zvanie," +
                         " otdel,doljnost,ij_prikaz_num,ij_prikaz_date,ij_prikaz_from_him,asos,type_jazo,noow) values( " +
                         " '" + kod_num_global + "', " +
                         " '" + (dgvRow.Cells[3].Value) + "', " +
                         " '" + (dgvRow.Cells[2].Value) + "', " +
                         " '" + (dgvRow.Cells[7].Value) + "', " +
                         " '" + (dgvRow.Cells[4].Value) + "', " +

                         " '" + (dgvRow_ijtimoiy.Cells[1].Value) + "', " +
                         " '" + DateTime.Parse(dgvRow_ijtimoiy.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "', " +
                         " '" + (dgvRow_ijtimoiy.Cells[4].Value) + "', " +
                         " '" + (asos_olib_tashlansin_textBox.Text) + "', " +
                         " '" + (dgvRow_ijtimoiy.Cells[3].Value) + "', " +
                         "CURDATE() " +

                         ")").ExecuteNonQuery();

                    /*Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                    clear_textbox_olib_tashlansin_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_olib_tashlansin_function()
        {
            fio_olib_tashlansin_label.Text = "-";
            otdel_olib_tashlansin_label.Text = "-";
            asos_olib_tashlansin_textBox.Text = "";
            olib_tawlansin_dataGridView.Rows.Clear();
        }

        private void start_tatil_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("start_tatil_dateTimePicker_ValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        string day_for_print_string_tatil = "";
        DateTime date_finish_calculaton_tatil;
        private void start_tatil_dateTimePicker_Validated(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
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

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                if (tatil_turi_tatil_comboBox.Text == "")
                {
                    add_days_tatil_label.Text = "+ 0 кун";
                    otash_joyi_tatil_comboBox.SelectedIndex = 1;
                    period_tatil_label.Text = ". . .";
                }
                else if (tatil_turi_tatil_comboBox.Text == "Берилсин")
                {
                    period_tatil_label.Text = ". . .";
                    finish_tatil_dateTimePicker.Value = add_days_function(start_tatil_dateTimePicker.Value, 23);
                }
                else if (tatil_turi_tatil_comboBox.Text == "Берилсин (Шаҳодатланганлар учун)")
                {
                    int year = 0;
                    int month = 0;
                    int day = 0;

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * FROM " + db_name + ".trudovoy where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        DateDifference dateDifference = new DateDifference(Main.sql.myReader.GetDateTime("date_start"), Main.sql.myReader.GetDateTime("date_finish"));

                        year = year + dateDifference.Years;
                        month = month + dateDifference.Months;
                        day = day + dateDifference.Days;
                    }
                    Main.sql.myReader.Close();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select date_start2,kod_num,otdel,doljnost FROM " + db_name + ".main where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        DateDifference dateDifference = new DateDifference(Main.sql.myReader.GetDateTime("date_start2"), DateTime.Today);

                        year = year + dateDifference.Years;
                        month = month + dateDifference.Months;
                        day = day + dateDifference.Days;
                    }
                    Main.sql.myReader.Close();

                    year = year + (month / 12);
                    month = month + (day / 30);

                    period_tatil_label.Text = "Умумий м.ф. даври : " + Convert.ToString(year) + " йил " + Convert.ToString(month % 12) + " ой " + Convert.ToString(day % 30) + " кун.";

                    if (year < 10)
                    {
                        finish_tatil_dateTimePicker.Value = start_tatil_dateTimePicker.Value.AddDays(29);
                        day_for_print_string_tatil = "30";
                    }
                    else if (year >= 10 && year < 15)
                    {
                        finish_tatil_dateTimePicker.Value = start_tatil_dateTimePicker.Value.AddDays(34);
                        day_for_print_string_tatil = "35";
                    }
                    else if (year >= 15 && year < 20)
                    {
                        finish_tatil_dateTimePicker.Value = start_tatil_dateTimePicker.Value.AddDays(39);
                        day_for_print_string_tatil = "40";
                    }
                    else if (year >= 20)
                    {
                        finish_tatil_dateTimePicker.Value = start_tatil_dateTimePicker.Value.AddDays(44);
                        day_for_print_string_tatil = "45";
                    }

                    date_finish_calculaton_tatil = finish_tatil_dateTimePicker.Value;
                }
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("start_tatil_dateTimePicker_Validated " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void add_days_via_viloyat(object sender, EventArgs e)
        {
            try
            {
                if (tatil_turi_tatil_comboBox.Text == "Берилсин (Шаҳодатланганлар учун)")
                {
                    switch (otash_joyi_tatil_comboBox.Text)
                    {
                        case "Тошкент шаҳар, вилояти":
                            {
                                add_days_tatil_label.Text = "+ 0 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil;
                                break;
                            }
                        case "Андижон вилояти":
                            {
                                add_days_tatil_label.Text = "+ 1 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(1);
                                break;
                            }
                        case "Фарғона вилояти":
                            {
                                add_days_tatil_label.Text = "+ 1 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(1);
                                break;
                            }
                        case "Наманган вилояти":
                            {
                                add_days_tatil_label.Text = "+ 1 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(1);
                                break;
                            }
                        case "Сирдарё вилояти":
                            {
                                add_days_tatil_label.Text = "+ 0 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil;
                                break;
                            }
                        case "Жиззах вилояти":
                            {
                                add_days_tatil_label.Text = "+ 0 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil;
                                break;
                            }
                        case "Сурхондарё вилояти":
                            {
                                add_days_tatil_label.Text = "+ 2 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(2);
                                break;
                            }
                        case "Қашқадарё вилояти":
                            {
                                add_days_tatil_label.Text = "+ 2 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(2);
                                break;
                            }
                        case "Самарқанд вилояти":
                            {
                                add_days_tatil_label.Text = "+ 1 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(1);
                                break;
                            }
                        case "Бухоро вилояти":
                            {
                                add_days_tatil_label.Text = "+ 1 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(1);
                                break;
                            }
                        case "Навоий вилояти":
                            {
                                add_days_tatil_label.Text = "+ 1 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(1);
                                break;
                            }
                        case "Хоразм вилояти":
                            {
                                add_days_tatil_label.Text = "+ 3 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(3);
                                break;
                            }
                        case "Қорақалпоғистон Республикаси":
                            {
                                add_days_tatil_label.Text = "+ 3 кун";
                                finish_tatil_dateTimePicker.Value = date_finish_calculaton_tatil.AddDays(3);
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("add_days_via_viloyat " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public DateTime add_days_function(DateTime date, int workdays)
        {
            if (workdays < 1)
            {
                return date;
            }
            DateTime result = date;
            int addedDays = 0;
            while (addedDays < workdays)
            {
                result = result.AddDays(1);
                if (!(result.DayOfWeek == DayOfWeek.Sunday))
                {
                    ++addedDays;
                }
            }

            return result;
        }


        private void tatil_turi_tatil_comboBox_Validated(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
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

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                if (tatil_turi_tatil_comboBox.Text == "Ўз хизмат вазифасига киришди")
                {
                    finish_tatil_dateTimePicker.Visible = false;
                }
                else
                {
                    finish_tatil_dateTimePicker.Visible = true;
                }

                if (tatil_turi_tatil_comboBox.Text == "Берилсин (Шаҳодатланганлар учун)")
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select max(blank_num) as blank FROM " + db_name + ".otpuska where type_otpusk = 'Берилсин (Шаҳодатланганлар учун)' and extract(year FROM date_start)=extract(year FROM now()) ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        blanka_nomer_tatil_textBox.Text = Convert.ToString((Main.sql.myReader["blank"] != DBNull.Value ? Main.sql.myReader.GetInt32("blank") : 0) + 1);
                    }
                    Main.sql.myReader.Close();
                }
                else if (tatil_turi_tatil_comboBox.Text == "Хизмат сафари")
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select max(blank_num) as blank FROM " + db_name + ".otpuska where type_otpusk = 'Хизмат сафари' and extract(year FROM date_start)=extract(year FROM now()) ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        blanka_nomer_tatil_textBox.Text = Convert.ToString((Main.sql.myReader["blank"] != DBNull.Value ? Main.sql.myReader.GetInt32("blank") : 0) + 1);
                    }
                    Main.sql.myReader.Close();
                }
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("tatil_turi_tatil_comboBox_Validated " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_finish_date()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("tatil_turi_tatil_comboBox_Validated " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && tatil_turi_tatil_comboBox.SelectedIndex != -1)
            {
                try
                {
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;

                    if (tatil_turi_tatil_comboBox.Text == "Ўз хизмат вазифасига киришди")
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".otpuska_p (kod_num,surname,zvanie," +
                            "otdel,doljnost,tashxis,type_otpusk,asos,date_start,noow) values( " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[3].Value) + "', " +
                            " '" + (dgvRow.Cells[2].Value) + "', " +
                            " '" + (dgvRow.Cells[7].Value) + "', " +
                            " '" + (dgvRow.Cells[4].Value) + "', " +
                            " '" + (tashxis_tatil_textBox.Text) + "', " +
                            " '" + (tatil_turi_tatil_comboBox.Text) + "', " +
                            " '" + (asos_tatil_textBox.Text) + "', " +
                            " '" + (start_tatil_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                            "CURDATE() " +
                            ")").ExecuteNonQuery();

                        clear_textbox_tatil_function();
                        run_alert("");
                    }
                    else if (tatil_turi_tatil_comboBox.Text == "Берилсин (Шаҳодатланганлар учун)")
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".otpuska (kod_num,date_start,date_finish,surname," +
                            "otdel,doljnost,zvanie,type_otpusk,blank_num,where_adress,asos) values( " +
                            " '" + kod_num_global + "'," +
                            " '" + (start_tatil_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                            " '" + (finish_tatil_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                            " '" + (dgvRow.Cells[3].Value) + "', " +
                            " '" + (dgvRow.Cells[7].Value) + "', " +
                            " '" + (dgvRow.Cells[4].Value) + "', " +
                            " '" + (dgvRow.Cells[2].Value) + "', " +
                            " '" + (tatil_turi_tatil_comboBox.Text) + "', " +
                            " '" + (blanka_nomer_tatil_textBox.Text) + "', " +
                            " '" + (otash_joyi_tatil_comboBox.Text) + "', " +
                            " '" + (asos_tatil_textBox.Text) + "' " +
                            ")").ExecuteNonQuery();

                        clear_textbox_tatil_function();
                        run_alert("");
                    }
                    else if (tatil_turi_tatil_comboBox.Text == "Хизмат сафари")
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".otpuska (kod_num,date_start,date_finish,surname," +
                           "otdel,doljnost,zvanie,type_otpusk,blank_num,where_adress,asos,tashxis) values( " +
                           " '" + kod_num_global + "'," +
                           " '" + (start_tatil_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                           " '" + (finish_tatil_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                           " '" + (dgvRow.Cells[3].Value) + "', " +
                           " '" + (dgvRow.Cells[7].Value) + "', " +
                           " '" + (dgvRow.Cells[4].Value) + "', " +
                           " '" + (dgvRow.Cells[2].Value) + "', " +
                           " '" + (tatil_turi_tatil_comboBox.Text) + "', " +
                           " '" + (blanka_nomer_tatil_textBox.Text) + "', " +
                           " '" + (otash_joyi_tatil_comboBox.Text) + "', " +
                           " '" + (asos_tatil_textBox.Text) + "', " +
                           " '" + (tashxis_tatil_textBox.Text) + "' " +
                           ")").ExecuteNonQuery();

                        clear_textbox_tatil_function();
                        run_alert("");
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".otpuska_p (kod_num,surname,zvanie," +
                               "otdel,doljnost,tashxis,type_otpusk,asos,date_start,date_finish,noow) values( " +
                               " '" + kod_num_global + "'," +
                               " '" + (dgvRow.Cells[3].Value) + "', " +
                               " '" + (dgvRow.Cells[2].Value) + "', " +
                               " '" + (dgvRow.Cells[7].Value) + "', " +
                               " '" + (dgvRow.Cells[4].Value) + "', " +
                               " '" + (tashxis_tatil_textBox.Text) + "', " +
                               " '" + (tatil_turi_tatil_comboBox.Text) + "', " +
                               " '" + (asos_tatil_textBox.Text) + "', " +
                               " '" + (start_tatil_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                               " '" + (finish_tatil_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                               "CURDATE() " +
                               ")").ExecuteNonQuery();

                        clear_textbox_tatil_function();
                        run_alert("");
                    }

                    /*Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Буйруқлар','" + kod_num_global + " / " +
                    (poisk_dataGridView.CurrentRow.Cells[3].Value) + " га буйруқ тайорланди','" + db_name + "')").ExecuteNonQuery();
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button11_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_tatil_function()
        {
            fio_tatil_label.Text = "-";
            otdel_tatil_label.Text = "-";
            tatil_turi_tatil_comboBox.SelectedIndex = -1;
            tashxis_tatil_textBox.Text = "";
            asos_tatil_textBox.Text = "";
            blanka_nomer_tatil_textBox.Text = "";
            otash_joyi_tatil_comboBox.SelectedIndex = -1;
            add_days_tatil_label.Text = "+ 0 кун";
            period_tatil_label.Text = "...";
            finish_tatil_dateTimePicker.Visible = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (familiyasi_mwt_textBox.Text != "" && ismi_mwt_textBox.Text != "" && otasining_ismi_mwt_textBox.Text != "" &&
                poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".mehnat (surname,name," +
                                   "fath_name,otdel,doljnost,asos,date,old_kod_num,old_fio,id_parent,noow) values( " +
                                   " '" + (familiyasi_mwt_textBox.Text) + "', " +
                                   " '" + (ismi_mwt_textBox.Text) + "', " +
                                   " '" + (otasining_ismi_mwt_textBox.Text) + "', " +
                                   " '" + (dgvRow.Cells[7].Value) + "', " +
                                   " '" + (dgvRow.Cells[4].Value) + "', " +
                                   " '" + (asos_mwt_textBox.Text) + "', " +
                                   "  " + (ogovorka_mwt_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_mwt_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                                   " '" + kod_num_global + "', " +
                                   " '" + (dgvRow.Cells[3].Value) + "', " +
                                   " '" + (dgvRow.Cells[0].Value) + "', " +
                                   "CURDATE() " +
                                   ")").ExecuteNonQuery();

                    clear_textbox_mwt_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button12_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_mwt_function()
        {
            familiyasi_mwt_textBox.Text = "";
            ismi_mwt_textBox.Text = "";
            otasining_ismi_mwt_textBox.Text = "";
            otdel_mwt_label.Text = "-";
            fio_mwt_label.Text = "-";
            ogovorka_mwt_textBox.Text = "";
            doljnost_mwt_comboBox.SelectedIndex = -1;
            asos_mwt_textBox.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (familiyasi_mwt_textBox.Text != "" && ismi_mwt_textBox.Text != "" && otasining_ismi_mwt_textBox.Text != "" && doljnost_mwt_comboBox.Text != "")
            {
                try
                {
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".mehnat (surname,name," +
                                   "fath_name,otdel,doljnost,asos,date,old_kod_num,noow) values( " +
                                   " '" + (familiyasi_mwt_textBox.Text) + "', " +
                                   " '" + (ismi_mwt_textBox.Text) + "', " +
                                   " '" + (otasining_ismi_mwt_textBox.Text) + "', " +
                                   " '" + (otdel_string_global) + "', " +
                                   " '" + (doljnost_mwt_comboBox.Text) + "', " +
                                   " '" + (asos_mwt_textBox.Text) + "', " +
                                   "  " + (ogovorka_mwt_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_mwt_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                                   " '0', " +
                                   "CURDATE() " +
                                   ")").ExecuteNonQuery();

                    clear_textbox_mwt_function();
                    run_alert("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("button13_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && mw_moddasi_mwbekor_comboBox.Text != "")
            {
                try
                {

                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".mehnat_b (kod_num,surname," +
                                   "zvanie,otdel,doljnost,bandi,date,asos,noow) values( " +
                                   " '" + kod_num_global + "', " +
                                   " '" + (dgvRow.Cells[3].Value) + "', " +
                                   " '" + (dgvRow.Cells[2].Value) + "', " +
                                   " '" + (dgvRow.Cells[7].Value) + "', " +
                                   " '" + (dgvRow.Cells[4].Value) + "', " +
                                   " '" + (mw_moddasi_mwbekor_comboBox.Text) + "', " +
                                   "  " + (ogovorka_mwbekor_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(ogovorka_mwbekor_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                                   " '" + (asos_mwbekor_textBox.Text) + "', " +
                                   "CURDATE() " +
                                   ")").ExecuteNonQuery();

                    clear_textbox_mwt_bekor_function();
                    run_alert("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("button14_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_mwt_bekor_function()
        {
            fio_mwbekor_label.Text = "-";
            otdel_mwbekor_label.Text = "-";
            mw_moddasi_mwbekor_comboBox.SelectedIndex = -1;
            ogovorka_mwbekor_textBox.Text = "";
            asos_mwbekor_textBox.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                        string str = "";

                        TreeNode node = treeView.SelectedNode;
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

                        TreeNode root = FindRootNode(node);
                        int index1 = root.Index;
                        string[] tags = (string[])root.Tag;
                        string db_name = tags[index1];
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".rezerv(kod_num,zvanie,fio_full,otdel,doljnost,id_work_place,surname,type_otpuska,vacant_type)" +
                                       "values( " +
                                       " '" + kod_num_global + "', " +
                                       " '" + (dgvRow.Cells[2].Value) + "', " +
                                       " '" + (dgvRow.Cells[3].Value) + "', " +
                                       " '" + (dgvRow.Cells[7].Value) + "', " +
                                       " '" + (dgvRow.Cells[4].Value) + "', " +
                                       " '" + (dgvRow.Cells[0].Value) + "', " +
                                       " '" + (dgvRow.Cells[3].Value) + "', " +
                                       " '" + (dgvRow.Cells[5].Value) + "', " +
                                       " '" + (dgvRow.Cells[6].Value) + "' " +
                                       ")").ExecuteNonQuery();

                        Main.sql.return_MySqlCommand("update " + db_name + ".work_place set register_num='',kod_num='0',surname='',name='',fath_name='',zvanie=''," +
                            "vacant='0',lichniy_num='' where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                        clear_textbox_rezerv_bekor_function();
                        run_alert("");
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button15_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_rezerv_bekor_function()
        {
            fio_lavozimni_bowatish_label.Text = "-";
            otdel_lavozimni_bowatish_label.Text = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".zaxira_boshliq(kod_num,fio,otdel,doljnost,date) values (" +
                                   " '" + kod_num_global + "', " +
                                   " '" + (dgvRow.Cells[3].Value) + "', " +
                                   " '" + (otdel_zaxiraga_comboBox.Text) + "', " +
                                   " '" + (doljnost_zaxiraga_comboBox.Text) + "', " +
                                   "now() " +
                                   ")").ExecuteNonQuery();


                    clear_textbox_zaxiraga_bowliq_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button16_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_zaxiraga_bowliq_function()
        {
            otdel_zaxiraga_comboBox.SelectedIndex = -1;
            doljnost_zaxiraga_comboBox.SelectedIndex = -1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (familiyasi_orindow_olish_textBox.Text != "" && ismi_orindow_olish_textBox.Text != "" &&
                    otasining_ismi_orindow_olish_textBox.Text != "" && stavka_orindow_olish_comboBox.Text != "" &&
                    doljnost_orindow_olish_comboBox.Text != "" && asos_orindow_olish_textBox.Text != "")
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (kocadan_orindow_olish_checkBox.Checked == true)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".dobavit_med (kod_num,surname,name,fath_name,otdel,doljnost,stavka,asos,noow,yangi1_bowqarmadagi2) values(" +
                                            " '0', " +
                                            " '" + (familiyasi_orindow_olish_textBox.Text) + "', " +
                                            " '" + (ismi_orindow_olish_textBox.Text) + "', " +
                                            " '" + (otasining_ismi_orindow_olish_textBox.Text) + "', " +
                                            " '" + (otdel_orindow_olish_comboBox.Text) + "', " +
                                            " '" + (doljnost_orindow_olish_comboBox.Text) + "', " +
                                            " '" + (stavka_orindow_olish_comboBox.Text) + "', " +
                                            " '" + (asos_orindow_olish_textBox.Text) + "', " +
                                            "now()," +
                                            " '1' " +
                                            ")").ExecuteNonQuery();

                        clear_textbox_orindow_olish_function();
                        run_alert("");
                    }
                    else if (bowqarmadagi_hodimlardan_orindow_olish_checkBox.Checked == true)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".dobavit_med (kod_num,surname,name,fath_name,otdel,doljnost,stavka,asos,noow,yangi1_bowqarmadagi2) values(" +
                                            " '" + dgvRow.Cells[1].Value + "', " +
                                            " '" + dgvRow.Cells[3].Value + "', " +
                                            " '', " +
                                            " '', " +
                                            " '" + (otdel_orindow_olish_comboBox.Text) + "', " +
                                            " '" + (doljnost_orindow_olish_comboBox.Text) + "', " +
                                            " '" + (stavka_orindow_olish_comboBox.Text) + "', " +
                                            " '" + (asos_orindow_olish_textBox.Text) + "', " +
                                            "now()," +
                                            " '2' " +
                                            ")").ExecuteNonQuery();

                        clear_textbox_orindow_olish_function();
                        run_alert("");
                    }

                }
                else
                {
                    MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        public void clear_textbox_orindow_olish_function()
        {

            otdel_orindow_olish_comboBox.SelectedIndex = -1;
            doljnost_orindow_olish_comboBox.SelectedIndex = -1;
            stavka_orindow_olish_comboBox.SelectedIndex = -1;
            familiyasi_orindow_olish_textBox.Text = "";
            ismi_orindow_olish_textBox.Text = "";
            otasining_ismi_orindow_olish_textBox.Text = "";
            asos_orindow_olish_textBox.Text = "";
            kocadan_orindow_olish_checkBox.Checked = false;
            bowqarmadagi_hodimlardan_orindow_olish_checkBox.Checked = false;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(poisk_dataGridView.CurrentRow.Cells[2].Value.ToString());

                if (poisk_dataGridView.SelectedCells.Count > 0 && asos_orindow_toxtatilsin_textBox.Text != "" &&
                    poisk_dataGridView.CurrentRow.Cells[9].Value.ToString().Equals("Ўриндош"))
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".boshatish_med (kod_num,surname,otdel,doljnost,asos,date) values(" +
                                        " '" + kod_num_global + "', " +
                                        " '" + (dgvRow.Cells[3].Value) + "', " +
                                        " '" + (dgvRow.Cells[7].Value) + "', " +
                                        " '" + (dgvRow.Cells[4].Value) + "', " +
                                        " '" + (asos_orindow_toxtatilsin_textBox.Text) + "', " +
                                        " '" + date_orindow_toxtatilsin_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                                        ")").ExecuteNonQuery();

                    if (poisk_dataGridView.CurrentRow.Cells[2].Value.ToString().Equals("ўриндош"))
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".main set date_finish = '" + date_orindow_toxtatilsin_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                            " date_finish2 = '" + date_orindow_toxtatilsin_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where kod_num = '" + dgvRow.Cells[1].Value.ToString() + "' " +
                            " ").ExecuteNonQuery();
                    }

                    Main.sql.return_MySqlCommand("update " + db_name + ".orindoshlar set date_finish = '" + date_orindow_toxtatilsin_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                        " where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                    clear_textbox_orindow_toxtatilsin_function();
                    run_alert("");


                }
                else
                {
                    MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        public void clear_textbox_orindow_toxtatilsin_function()
        {
            fio_orindow_toxtatilsin_label.Text = "-";
            otdel_orindow_toxtatilsin_label.Text = "-";
            asos_orindow_toxtatilsin_textBox.Text = "";
        }

        private void otdel_orindow_olish_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
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

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                doljnost_orindow_olish_comboBox.Text = "";
                doljnost_orindow_olish_comboBox.Items.Clear();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select doljnost FROM " + db_name + ".work_place where otdel = '" + otdel_orindow_olish_comboBox.Text + "' group by doljnost order by id ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    doljnost_orindow_olish_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("otdel_zaxiraga_comboBox_SelectedValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void otdel_bolnicniy_dobavit_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
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

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                doljnost_bolnicniy_dobavit_comboBox.Text = "";
                doljnost_bolnicniy_dobavit_comboBox.Items.Clear();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select doljnost FROM " + db_name + ".work_place where otdel = '" + otdel_bolnicniy_dobavit_comboBox.Text + "' group by doljnost order by id ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    doljnost_bolnicniy_dobavit_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("otdel_zaxiraga_comboBox_SelectedValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (poisk_dataGridView.SelectedCells.Count > 0 && asos_bolnicniy_dobavit_textBox.Text != "")
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".bolnicniy_dobavit (kod_num,surname,name,fath_name,otdel,doljnost,stavka,asos) values(" +
                                        " '" + (dgvRow.Cells[1].Value) + "', " +
                                        " '" + (dgvRow.Cells[3].Value) + "', " +
                                        " '', " +
                                        " '', " +
                                        " '" + (otdel_bolnicniy_dobavit_comboBox.Text) + "', " +
                                        " '" + (doljnost_bolnicniy_dobavit_comboBox.Text) + "', " +
                                        " '" + (stavka_bolnicniy_dobavit_comboBox.Text) + "', " +
                                        " '" + (asos_bolnicniy_dobavit_textBox.Text) + "' " +
                                        ")").ExecuteNonQuery();

                    clear_textbox_bolnicniy_dobavit_function();
                    run_alert("");


                }
                else
                {
                    MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        public void clear_textbox_bolnicniy_dobavit_function()
        {

            otdel_bolnicniy_dobavit_comboBox.SelectedIndex = -1;
            doljnost_bolnicniy_dobavit_comboBox.SelectedIndex = -1;
            stavka_bolnicniy_dobavit_comboBox.SelectedIndex = -1;
            fio_bolnicniy_dobavit_label.Text = "-";
            asos_bolnicniy_dobavit_textBox.Text = "";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (poisk_dataGridView.SelectedCells.Count > 0 && asos_bolnicniy_udalit_textBox.Text != "" &&
                poisk_dataGridView.CurrentRow.Cells[9].Value.ToString().Equals("Больничный ўрнига"))
            {
                DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;

                try
                {
                    string str = "";

                    TreeNode node = treeView.SelectedNode;
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

                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".bolnichniy_boshatish (kod_num,fio,otdel,doljnost,asos,date) values(" +
                                        " '" + kod_num_global + "', " +
                                        " '" + (dgvRow.Cells[3].Value) + "', " +
                                        " '" + (dgvRow.Cells[7].Value) + "', " +
                                        " '" + (dgvRow.Cells[4].Value) + "', " +
                                        " '" + (asos_bolnicniy_udalit_textBox.Text) + "', " +
                                        " '" + date_bolnicniy_udalit_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                                        ")").ExecuteNonQuery();


                    Main.sql.return_MySqlCommand("update " + db_name + ".bolnichniylar_orniga set date_finish = '" + date_bolnicniy_udalit_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                        " where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                    clear_textbox_bolnicniy_udalit_function();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void clear_textbox_bolnicniy_udalit_function()
        {

            fio_bolnicniy_udalit_label.Text = "-";
            otdel_bolnicniy_udalit_label.Text = "-";
            asos_bolnicniy_udalit_textBox.Text = "";

        }

        private void viloyatlar_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            string db_name_new = db_names[viloyatlar_comboBox.SelectedIndex];
            var sel_lav = "SELECT name FROM " + db_name_new + ".vacant where type_num = 2";
            bolimn_comboBox.Items.Clear();
            bolimn_comboBox.Text = "";
            Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(sel_lav).ExecuteReader();
                while (Main.sql_2.myReader.Read())
                {
                    bolimn_comboBox.Items.Add(Main.sql_2.myReader.GetString("name"));
                    bolimn_comboBox.ValueMember = Main.sql_2.myReader.GetString("name");
                }
                Main.sql_2.myReader.Close();
            //}
            //catch (Exception ex)
            //{
            //    Main.sql.myReader.Close();
            //    MessageBox.Show("viloyatlar_comboBox_SelectedIndexChanged " + ex.Message);
            //}
        }

        private void otdel_tay_per_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                string db = System.IO.File.ReadAllText("docs\\access.txt");
                TreeNode node = treeView.SelectedNode;
                if (node != null)
                {
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

                    TreeNode root = FindRootNode(node);
                    int db_count = 0;
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name "+ db +" order by schema_name").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        db_count = Int32.Parse(Main.sql.myReader.GetString("cnt"));
                    }
                    Main.sql.myReader.Close();
                    string[] db_names = new string[db_count];
                    int ind = 0;
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name "+ db +" order by schema_name").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        db_names[ind] = Main.sql.myReader.GetString("schema_name");
                        ind++;
                    }
                    Main.sql.myReader.Close();
                    //string db_name = db_names[viloyatlar_comboBox.SelectedIndex];

                    doljnost_tay_per_comboBox.Text = "";
                    doljnost_tay_per_comboBox.Items.Clear();
                    var select = "select doljnost FROM work_place where otdel = '" + organ_name + "" + otdel_tay_per_comboBox.Text + "' group by doljnost order by id ";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        doljnost_tay_per_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                    }
                    Main.sql.myReader.Close();
                }
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("otdel_tay_per_comboBox_SelectedIndexChanged " + ex.Message);
            }
        }

        private void poisk_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string otpuska_m = "";
                string ornida_m = "";
                string orindosh_m = "";
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
                            "lichniy_num, zvanie, concat(surname,' ', name,' ', fath_name) as fio, doljnost, otdel FROM " + db_name + ".main WHERE isnull(date_finish) and (kod_num like '" + poisk_textBox.Text + "%' or surname like '" + poisk_textBox.Text + "%' " +
                            " or name like '" + poisk_textBox.Text + "%' or concat(surname,' ', name,' ', fath_name) like '" + poisk_textBox.Text + "%') " +
                            " order by id asc";
                        Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = otpuska_m;
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = ornida_m;
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[8].Value = "";
                            poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[9].Value = "-";

                            if (otpuska_m != "")
                            {
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Style.BackColor = Color.GreenYellow;
                            }
                            if (ornida_m != "")
                            {
                                poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Style.BackColor = Color.GreenYellow;
                            }
                        }
                        Main.sql.myReader.Close();
                        poisk_dataGridView.ClearSelection();
                        this.poisk_dataGridView.SelectionChanged += new System.EventHandler(this.poisk_dataGridView_SelectionChanged);


                    }
                }
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("poisk_textBox_TextChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void чопЭтишToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\buyruqlar.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("label8_Click" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void bolimn_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string db_name_new = db_names[viloyatlar_comboBox.SelectedIndex];
            var sel = "SELECT distinct otdel FROM "+ db_name_new + ".work_place where otdel like '%" + bolimn_comboBox.Text + "%'";
            otdel_tay_per_comboBox.Items.Clear();
            otdel_tay_per_comboBox.Text = "";
            doljnost_tay_per_comboBox.Text = "";
            Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                otdel_tay_per_comboBox.Items.Add(Main.sql.myReader.GetString("otdel").Replace(organ_name, ""));

            }
            Main.sql.myReader.Close();
        }
    }
}
