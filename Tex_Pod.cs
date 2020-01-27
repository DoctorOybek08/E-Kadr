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
    public partial class Tex_Pod : Form
    {
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
        public Tex_Pod()
        {
            InitializeComponent();
            /*sql1.Connection();
            sql.Connection();
            sql2.Connection();
            sql3.Connection();
            sql4.Connection();
            sql5.Connection();
            sql6.Connection();
            sql7.Connection();
            sql8.Connection();
            sql9.Connection();
            sql10.Connection();*/
            this.stavka_comboBox.Items.Add("1.0");
            this.stavka_comboBox.Items.Add("0.5");
            this.stavka_comboBox.SelectedIndex = 0;
            this.zvanie_IV_comboBox.Items.Add((object)"сафдор");
            this.zvanie_IV_comboBox.Items.Add((object)"кичик сержант");
            this.zvanie_IV_comboBox.Items.Add((object)"сержант");
            this.zvanie_IV_comboBox.Items.Add((object)"катта сержант");
            //this.zvanie_IV_comboBox.Items.Add((object)"кичик лейтенант");
            this.zvanie_IV_comboBox.Items.Add((object)"лейтенант");
            this.zvanie_IV_comboBox.Items.Add((object)"катта лейтенант");
            this.zvanie_IV_comboBox.Items.Add((object)"капитан");
            this.zvanie_IV_comboBox.Items.Add((object)"майор");
            this.zvanie_IV_comboBox.Items.Add((object)"подполковник");
            this.zvanie_IV_comboBox.Items.Add((object)"полковник");
            this.zvanie_IV_comboBox.Items.Add((object)"генерал майор");
            this.zvanie_IV_comboBox.Items.Add((object)"генерал лейтенант");
            this.zvanie_IV_comboBox.Items.Add((object)"генерал полковник");
            //this.I_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            this.I_dataGridView.EnableHeadersVisualStyles = false;
            this.I_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.I_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
            //this.IV_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            this.IV_dataGridView.EnableHeadersVisualStyles = false;
            this.IV_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.IV_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
            this.I_dataGridView.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            V_main_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            V_main_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
            //V_main_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            V_main_dataGridView.EnableHeadersVisualStyles = false;
            V_main_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            V_main_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //VI_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            VI_dataGridView.EnableHeadersVisualStyles = false;
            this.VI_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.VI_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
        
            VI_dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            VI_dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            VI_dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("БЎШАТИЛСИН");
            comboBox1.Items.Add("ЭЪЛОН  ҚИЛИНСИН");
            comboBox1.Items.Add("ТАЪТИЛ");
            comboBox1.Items.Add("МЕҲНАТ ШАРТНОМАСИ БЕКОР ҚИЛИНСИН");
            comboBox1.Items.Add("Бошқарма номи");
            comboBox1.Items.Add("Бошлиқ Ф.И.Ш");
            comboBox1.Items.Add("Бошлиқ унвони");
            comboBox1.Items.Add("Жўнатувчининг манзили");
            comboBox1.Items.Add("Аҳоли пункти");
            comboBox1.Items.Add("Туман");
            comboBox1.Items.Add("Вилоят (республика, ўлка)");
            comboBox1.Items.Add("Идоранинг номи");
            comboBox1.Items.Add("Таътил ижрочиси лавозими, унвони");
            comboBox1.Items.Add("Таътил ижрочиси Ф.И.О");
            comboBox1.Items.Add("Туғилган жойи");
            comboBox1.Items.Add("Унвон");
            comboBox1.Items.Add("Тоифа");
            comboBox1.Items.Add("Нафақа инспектори Ф.И.О");
            comboBox1.Items.Add("Нафақа инспектори лавозими");
            comboBox1.Items.Add("Нафақа инспектори унвони");

            //Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT distinct t.type from (SELECT id, name, CASE type WHEN 'unvon' THEN 'Унвон' WHEN 'tugilgan_joyi' THEN 'Туғилган жойи' else type END as type FROM spravochnik) as t").ExecuteReader();
            //while(Main.sql.myReader.Read())
            //{
            //    comboBox1.Items.Add(Main.sql.myReader.GetString("type"));
            //}
            //Main.sql.myReader.Close();

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

        public void run_main()
        {
            try
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                string db_name = "";
                if (root != null)
                {
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    db_name = tags[index1];
                }
                else
                {
                    if (node != null)
                    {
                        int index1 = node.Index;
                        string[] tags = (string[])node.Tag;
                        db_name = tags[index1];
                    }
                }
                treeView.Nodes.Clear();
                this.run_treeview();

                //" + db_name + ".
                //this.run_treeview2();
                this.nameklatura_I_add_comboBox.Items.Clear();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select distinct nameklatura from " + db_name + ".work_place").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.nameklatura_I_add_comboBox.Items.Add(Main.sql.myReader["nameklatura"] != DBNull.Value ? (object)Main.sql.myReader.GetString("nameklatura") : (object)"");
                Main.sql.myReader.Close();
                if (nameklatura_I_add_comboBox.Items.Count > 0)
                {
                    nameklatura_I_add_comboBox.SelectedIndex = 0;
                }
                this.lavozimi_I_add_comboBox.Items.Clear();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select doljnost from " + db_name + ".work_place group by doljnost").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.lavozimi_I_add_comboBox.Items.Add(Main.sql.myReader["doljnost"] != DBNull.Value ? (object)Main.sql.myReader.GetString("doljnost") : (object)"");
                Main.sql.myReader.Close();
                this.darajasi_I_add_comboBox.Items.Clear();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select grade from " + db_name + ".work_place group by grade").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.darajasi_I_add_comboBox.Items.Add(Main.sql.myReader["grade"] != DBNull.Value ? (object)Main.sql.myReader.GetString("grade") : (object)"");
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Бошқарма номи' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.bowqarma_nomi_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Бошлиқ Ф.И.Ш' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.bowliq_fio_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Бошлиқ унвони' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.bowliq_unvoni_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Жўнатувчининг манзили' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.jonatuvcining_manzili_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Аҳоли пункти' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.aholi_punkti_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Туман' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.tuman_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Вилоят (республика, ўлка)' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.viloyat_respublica_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Идоранинг номи' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.idoraning_nomi_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Таътил ижрочиси лавозими, унвони' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.tatil_ijrocisi_lavozimi_unvoni_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name from " + db_name + ".spravochnik where type = 'Таътил ижрочиси Ф.И.О' order by id desc limit 1").ExecuteReader();
                while (Main.sql.myReader.Read())
                    this.tatil_ijrocisi_fio_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                Main.sql.myReader.Close();

                get_items_to_datagridview_V();
                get_items_for_VIII();
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("run_main() " + ex.Message);
            }
        }
        public void run_treeview2()
        {
            try
            {
                int db_count = 0;
                string db = System.IO.File.ReadAllText("docs\\access.txt");
                var sel = "SELECT COUNT(*) as cnt from (SELECT schema_name FROM information_schema.schemata where schema_name " + db + " order by schema_name) as t";
                Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    if (Main.sql.myReader.HasRows == true)
                    {
                        db_count = Int32.Parse(Main.sql.myReader.GetString("cnt"));
                    }
                }
                Main.sql.myReader.Close();
                string[] db_names = new string[db_count];
                int ind = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name " + db + " order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_names[ind] = Main.sql.myReader.GetString("schema_name");
                    ind++;
                }
                Main.sql.myReader.Close();

                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id, name from " + db_names[i] + ".vacant where type_num = '1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        treeNode = new TreeNode(Main.sql.myReader.GetString("name")); // rasmli    
                        treeNode.Tag = db_names;
                        treeNode.ImageIndex = 0;
                        treeNode.SelectedImageIndex = 1;
                    }
                    Main.sql.myReader.Close();


                    Main.sql1.myReader = Main.sql.return_MySqlCommand("select queue_2,name, id from " + db_names[i] + ".vacant where type_num = '2' and queue_1 = '1' ").ExecuteReader();
                    while (Main.sql1.myReader.Read())
                    {
                        treeNode1 = new TreeNode(Main.sql1.myReader.GetString("name"));
                        treeNode1.Tag = Main.sql1.myReader.GetString("id");
                        Main.sql2.myReader = Main.sql2.return_MySqlCommand(" select queue_3,name, id from " + db_names[i] + ".vacant where type_num = '3' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                        while (Main.sql2.myReader.Read())
                        {
                            treeNode2 = new TreeNode(Main.sql2.myReader.GetString("name"));
                            treeNode2.Tag = Main.sql2.myReader.GetString("id");
                            Main.sql3.myReader = Main.sql3.return_MySqlCommand("select queue_4,name, id from " + db_names[i] + ".vacant where type_num = '4' and queue_3 = '" + Main.sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' " +
                                " ").ExecuteReader();
                            while (Main.sql3.myReader.Read())
                            {
                                treeNode3 = new TreeNode(Main.sql3.myReader.GetString("name"));
                                treeNode3.Tag = Main.sql3.myReader.GetString("id");
                                Main.sql4.myReader = Main.sql4.return_MySqlCommand("select queue_5,name, id from " + db_names[i] + ".vacant where type_num = '5' and queue_4 = '" + Main.sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + Main.sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                while (Main.sql4.myReader.Read())
                                {
                                    treeNode4 = new TreeNode(Main.sql4.myReader.GetString("name"));
                                    treeNode4.Tag = Main.sql4.myReader.GetString("id");
                                    Main.sql5.myReader = Main.sql5.return_MySqlCommand("select queue_6,name, id from " + db_names[i] + ".vacant where type_num = '6' and queue_5 = '" + Main.sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + Main.sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + Main.sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                    while (Main.sql5.myReader.Read())
                                    {
                                        treeNode5 = new TreeNode(Main.sql5.myReader.GetString("name"));
                                        treeNode5.Tag = Main.sql5.myReader.GetString("id");
                                        Main.sql6.myReader = Main.sql6.return_MySqlCommand(" select queue_7,name, id from " + db_names[i] + ".vacant where type_num = '7' and queue_6 = '" + Main.sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + Main.sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + Main.sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + Main.sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                        while (Main.sql6.myReader.Read())
                                        {
                                            treeNode6 = new TreeNode(Main.sql6.myReader.GetString("name"));
                                            treeNode6.Tag = Main.sql6.myReader.GetString("id");
                                            Main.sql7.myReader = Main.sql7.return_MySqlCommand(" select queue_8,name, id from " + db_names[i] + ".vacant where type_num = '8' and queue_7 = '" + Main.sql6.myReader.GetInt32("queue_7") + "' " +
                                                " and queue_6 = '" + Main.sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + Main.sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + Main.sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + Main.sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                            while (Main.sql7.myReader.Read())
                                            {

                                                treeNode7 = new TreeNode(Main.sql7.myReader.GetString("name"));
                                                treeNode7.Tag = Main.sql7.myReader.GetString("id");
                                                Main.sql8.myReader = Main.sql8.return_MySqlCommand(" select queue_9,name, id from " + db_names[i] + ".vacant where type_num = '9' and queue_8 = '" + Main.sql7.myReader.GetInt32("queue_8") + "' " +
                                                    " and queue_7 = '" + Main.sql6.myReader.GetInt32("queue_7") + "' " +
                                                " and queue_6 = '" + Main.sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + Main.sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + Main.sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + Main.sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                                while (Main.sql8.myReader.Read())
                                                {

                                                    treeNode8 = new TreeNode(Main.sql8.myReader.GetString("name"));
                                                    treeNode8.Tag = Main.sql8.myReader.GetString("id");
                                                    Main.sql9.myReader = Main.sql9.return_MySqlCommand(" select queue_10,name from " + db_names[i] + ".vacant where type_num = '10' and queue_9 = '" + Main.sql8.myReader.GetInt32("queue_9") + "' " +
                                                        " and queue_8 = '" + Main.sql7.myReader.GetInt32("queue_8") + "' " +
                                                    " and queue_7 = '" + Main.sql6.myReader.GetInt32("queue_7") + "' " +
                                                " and queue_6 = '" + Main.sql5.myReader.GetInt32("queue_6") + "' " +
                                            " and queue_5 = '" + Main.sql4.myReader.GetInt32("queue_5") + "' " +
                                        " and queue_4 = '" + Main.sql3.myReader.GetInt32("queue_4") + "' " +
                                    " and queue_3 = '" + Main.sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + Main.sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                                    while (Main.sql9.myReader.Read())
                                                    {
                                                        treeNode8.Nodes.Add(Main.sql9.myReader.GetString("name"));
                                                    }
                                                    Main.sql9.myReader.Close();

                                                    treeNode7.Nodes.Add(treeNode8);
                                                }
                                                Main.sql8.myReader.Close();

                                                treeNode6.Nodes.Add(treeNode7);
                                            }
                                            Main.sql7.myReader.Close();

                                            treeNode5.Nodes.Add(treeNode6);
                                        }
                                        Main.sql6.myReader.Close();

                                        treeNode4.Nodes.Add(treeNode5);
                                    }
                                    Main.sql5.myReader.Close();

                                    treeNode3.Nodes.Add(treeNode4);
                                }
                                Main.sql4.myReader.Close();

                                treeNode2.Nodes.Add(treeNode3);
                            }
                            Main.sql3.myReader.Close();

                            treeNode1.Nodes.Add(treeNode2);
                        }
                        Main.sql2.myReader.Close();

                        treeNode.Nodes.Add(treeNode1);
                    }
                    Main.sql1.myReader.Close();
                    treeNode.Nodes.Add("Бошқарма ихтиёрида");
                    treeNode9 = treeNode;

                    //treeNode.Expand();
                    treeView.Nodes.Add(treeNode);
                    //global_treeNode[i] = (TreeNode)treeView.Nodes[i].Clone();

                }

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                Main.sql1.myReader.Close();
                Main.sql2.myReader.Close();
                Main.sql3.myReader.Close();
                Main.sql4.myReader.Close();
                Main.sql5.myReader.Close();
                Main.sql6.myReader.Close();
                Main.sql7.myReader.Close();
                Main.sql8.myReader.Close();
                Main.sql9.myReader.Close();
                MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
        public void get_items_for_VIII()
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            string db_name = "";
            if (root != null)
            {
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                db_name = tags[index1];
            }
            try
            {
                eski_lavozim_VIII_comboBox.Items.Clear();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select doljnost from " + db_name + ".work_place group by doljnost").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    eski_lavozim_VIII_comboBox.Items.Add(Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("treeView_AfterSelect " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        int counter = 1;
        string bowqarma_qismi_treeview = "";
        string glavka_string;
        TreeNode treeNode;
        string cavant;
        string id_string;
        /*
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
        DataTable dataTable_for_poisk_datagridview = new DataTable();
        public void run_treeview()
        {
            int db_count = 0;
            sql.myReader = sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
            while (sql.myReader.Read())
            {
                db_count = Int32.Parse(sql.myReader.GetString("cnt"));
            }
            sql.myReader.Close();
            string[] db_names = new string[db_count];
            int ind = 0;
            sql.myReader = sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
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
       /* public void run_treeview2()
        {

            try
            {
                sql.myReader = sql.return_MySqlCommand("select id, name from kadr_0_2.vacant where type_num = '1' ").ExecuteReader();
                while (sql.myReader.Read())
                {
                    treeNode = new TreeNode(sql.myReader.GetString("name")); // rasmli    
                    treeNode.Tag = sql.myReader.GetString("id");
                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 1;
                }
                sql.myReader.Close();


                sql1.myReader = sql.return_MySqlCommand("select queue_2,name, id from kadr_0_2.vacant where type_num = '2' and queue_1 = '1' ").ExecuteReader();
                while (sql1.myReader.Read())
                {
                    treeNode1 = new TreeNode(sql1.myReader.GetString("name"));
                    treeNode1.Tag = sql1.myReader.GetString("id");
                    sql2.myReader = sql2.return_MySqlCommand(" select queue_3,name, id from kadr_0_2.vacant where type_num = '3' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                    while (sql2.myReader.Read())
                    {
                        treeNode2 = new TreeNode(sql2.myReader.GetString("name"));
                        treeNode2.Tag = sql2.myReader.GetString("id");
                        sql3.myReader = sql3.return_MySqlCommand("select queue_4,name, id from kadr_0_2.vacant where type_num = '4' and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' " +
                            " ").ExecuteReader();
                        while (sql3.myReader.Read())
                        {
                            treeNode3 = new TreeNode(sql3.myReader.GetString("name"));
                            treeNode3.Tag = sql3.myReader.GetString("id");
                            sql4.myReader = sql4.return_MySqlCommand("select queue_5,name, id from kadr_0_2.vacant where type_num = '5' and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                            while (sql4.myReader.Read())
                            {
                                treeNode4 = new TreeNode(sql4.myReader.GetString("name"));
                                treeNode4.Tag = sql4.myReader.GetString("id");
                                sql5.myReader = sql5.return_MySqlCommand("select queue_6,name, id from kadr_0_2.vacant where type_num = '6' and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                while (sql5.myReader.Read())
                                {
                                    treeNode5 = new TreeNode(sql5.myReader.GetString("name"));
                                    treeNode5.Tag = sql5.myReader.GetString("id");
                                    sql6.myReader = sql6.return_MySqlCommand(" select queue_7,name, id from kadr_0_2.vacant where type_num = '7' and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                    while (sql6.myReader.Read())
                                    {
                                        treeNode6 = new TreeNode(sql6.myReader.GetString("name"));
                                        treeNode6.Tag = sql6.myReader.GetString("id");
                                        sql7.myReader = sql7.return_MySqlCommand(" select queue_8,name, id from kadr_0_2.vacant where type_num = '8' and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                        while (sql7.myReader.Read())
                                        {

                                            treeNode7 = new TreeNode(sql7.myReader.GetString("name"));
                                            treeNode7.Tag = sql7.myReader.GetString("id");
                                            sql8.myReader = sql8.return_MySqlCommand(" select queue_9,name, id from kadr_0_2.vacant where type_num = '9' and queue_8 = '" + sql7.myReader.GetInt32("queue_8") + "' " +
                                                " and queue_7 = '" + sql6.myReader.GetInt32("queue_7") + "' " +
                                            " and queue_6 = '" + sql5.myReader.GetInt32("queue_6") + "' " +
                                        " and queue_5 = '" + sql4.myReader.GetInt32("queue_5") + "' " +
                                    " and queue_4 = '" + sql3.myReader.GetInt32("queue_4") + "' " +
                                " and queue_3 = '" + sql2.myReader.GetInt32("queue_3") + "' and queue_2 = '" + sql1.myReader.GetInt32("queue_2") + "' ").ExecuteReader();
                                            while (sql8.myReader.Read())
                                            {

                                                treeNode8 = new TreeNode(sql8.myReader.GetString("name"));
                                                treeNode8.Tag = sql8.myReader.GetString("id");
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
        }
        */

        //public void run_treeview1()
        //{
        //    try
        //    {
        //        Main.sql.myReader = Main.sql.return_MySqlCommand("select name,present_num from vacant where present_num = '0' ").ExecuteReader();
        //        while (Main.sql.myReader.Read())
        //        {
        //            this.treeNode = new TreeNode(Main.sql.myReader.GetString("name"));
        //            this.glavka_string = this.treeNode.Text.ToString().Replace("\n", "");
        //            this.treeNode.ImageIndex = 0;
        //            this.treeNode.SelectedImageIndex = 1;
        //        }
        //        Main.sql.myReader.Close();
        //        this.treeView.Nodes.Add(this.treeNode);
        //        Main.sql.myReader = Main.sql.return_MySqlCommand("select name,present_num from vacant where parent_num = '0' order by queue").ExecuteReader();
        //        while (Main.sql.myReader.Read())
        //        {
        //            this.g = 0;
        //            Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select name from vacant where parent_num = '" + Main.sql.myReader.GetString("present_num") + "' ").ExecuteReader();
        //            while (Main.sql_2.myReader.Read())
        //                ++this.g;
        //            Main.sql_2.myReader.Close();
        //            if (this.g < 1)
        //            {
        //                this.treeNode = new TreeNode(Main.sql.myReader.GetString("name"));
        //                this.treeView.Nodes.Add(this.treeNode);
        //            }
        //            else
        //            {
        //                this.treeNode = new TreeNode(Main.sql.myReader.GetString("name"));
        //                this.treeView.Nodes.Add(this.treeNode);
        //            }
        //            Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select name from vacant where parent_num = '" + Main.sql.myReader.GetString("present_num") + "' order by queue").ExecuteReader();
        //            while (Main.sql_2.myReader.Read())
        //                this.treeNode.Nodes.Add(Main.sql_2.myReader.GetString("name"));
        //            Main.sql_2.myReader.Close();
        //        }
        //        Main.sql.myReader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        int num = (int)MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //    }
        //}

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
                //MessageBox.Show(e.Node.Index + " " + e.Node.Tag.ToString() +" " +e.Node.Text.ToString());
                this.bowqarma_qismi_treeview = e.Node.Text.Replace("\n", "");
                this.bowqarma_qismi_I_add_label.Text = e.Node.Text.Replace("\n", "");
                this.bowqarma_I_remove_label.Text = e.Node.Text.Replace("\n", "");
                this.get_items_to_datagridview_I(str);
                this.get_items_to_datagridview_IV();
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                if (e.Node.Text == root.Text)
                {
                    this.get_items_to_datagridview_V();
                }
                this.bowqarma_qismi_V_textBox.Text = this.bowqarma_qismi_treeview;
                this.bowqarma_qismi_V_label.Text = this.bowqarma_qismi_treeview;

               
                get_items_from_base_VI(str);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("treeView_AfterSelect " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_base_VI(string e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];

            try
            {
               // e = treeView.SelectedNode.Text;

                otdel_VI_label.Text = "● " + e.ToString();
                VI_dataGridView.Rows.Clear();

                string otpuska_m = "";
                string ornida_m = "";
                string orindosh_m = "";
                string vacant = "0";

                //Main.sql.myReader = Main.sql.return_MySqlCommand("select *,concat(surname,' ',name,' ',fath_name) as fio from " + db_name + ".work_place where otdel = '" + e.ToString().Replace("\n", "") + "' and type = '1' ").ExecuteReader();
                var sel____ = "SELECT id1, kod_num, surname, name, fath_name, concat(surname,' ',name,' ',fath_name) as fio, otd1, d1 FROM( " +
"SELECT * FROM(SELECT id as id1, otdel as otd1, doljnost as d1 FROM " + db_name + ".work_place where type = 1 and otdel != '' and doljnost != '' and otdel = '" + e.ToString().Replace("\n", "") + "') as t " +
"join " +
"(SELECT kod_num, surname, name, fath_name, otdel as otd2, doljnost as d2, work_place_id as id2 FROM " + db_name + ".main where otdel != '' and doljnost != '' and otdel = '" + e.ToString().Replace("\n", "") + "') as t2 on t.id1 = t2.id2) as all_table " +
"UNION " +
"SELECT id as id1, kod_num, surname, name, fath_name, concat(surname, ' ', name, ' ', fath_name) as fio, otdel as otd1, doljnost as d1 FROM " + db_name + ".work_place where type = 1 and otdel != '' and doljnost != '' and otdel = '" + e.ToString().Replace("\n", "") + "'" +
"and id not in (SELECT distinct work_place_id FROM " + db_name + ".main where date_finish is null  and otdel = '" + e.ToString().Replace("\n", "") + "' and otdel != '' and doljnost != '' and work_place_id is not null)";
                Main.sql.myReader = Main.sql.return_MySqlCommand(sel____).ExecuteReader();
                while (Main.sql.myReader.Read())
                {

                    //if ((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "").Equals("1"))
                    //{
                    //    otpuska_m = "Декретда";
                    //}
                    //else
                    //{
                    //    otpuska_m = "";
                    //}

                    vacant = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "0");


                    VI_dataGridView.Rows[VI_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id1"] != DBNull.Value ? Main.sql.myReader.GetString("id1") : "");

                    VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[1].Value = (vacant != "0" ? "|  " + Main.sql.myReader.GetString("fio") : "Вакант");
                    VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["d1"] != DBNull.Value ? Main.sql.myReader.GetString("d1") : "");
                    VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[3].Value = otpuska_m;
                    VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Value = "Асосий";
                    VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[5].Value = "1";
                    VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");

                    if (vacant == "0")
                    {
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    if (otpuska_m == "Декретда")
                    {
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Pink;
                    }
                    //------------------ Dekret hisobidan stavka 1

                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select *,concat(surname,' ',name,' ',fath_name) as fio from " + db_name + ".work_place where type = '2' and vacant = '1' and id_parent = '" + Main.sql.myReader.GetString("id1") + "' ").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        if ((Main.sql_2.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql_2.myReader.GetByte("otpuska")) : "").Equals("1"))
                        {
                            otpuska_m = "Декретда";
                        }
                        else
                        {
                            otpuska_m = "";
                        }

                        VI_dataGridView.Rows[VI_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql_2.myReader["id"] != DBNull.Value ? Main.sql_2.myReader.GetString("id") : "");

                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql_2.myReader["fio"] != DBNull.Value ? "|→            " + Main.sql_2.myReader.GetString("fio") : "");
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[2].Value = ("");
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[3].Value = otpuska_m;
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Value = "Декрет ҳисобидан";
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[5].Value = "1";
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql_2.myReader["kod_num"] != DBNull.Value ? Main.sql_2.myReader.GetString("kod_num") : "");

                        if (VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Value.ToString().Equals("Декрет ҳисобидан"))
                        {
                            VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Style.BackColor = Color.Pink;
                        }

                        if (otpuska_m == "Декретда")
                        {
                            VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Pink;
                        }
                    }
                    Main.sql_2.myReader.Close();
                    //------------------ Dekret hisobidan stavka 0.5
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select " + db_name + ".orindoshlar.*," + db_name + ".dobavit_med.yangi1_bowqarmadagi2 as counter from " + db_name + ".orindoshlar," + db_name + ".dobavit_med " +
                        " where " + db_name + ".orindoshlar.date_finish is null and " + db_name + ".orindoshlar.orindosh_work_place_id = '" + Main.sql.myReader.GetString("id1") + "' and " +
                        " " + db_name + ".orindoshlar.kod_num = " + db_name + ".dobavit_med.kod_num and " + db_name + ".dobavit_med.cheeck = '1' having max(" + db_name + ".dobavit_med.prikaz_date)").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {

                        VI_dataGridView.Rows[VI_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql_2.myReader["id"] != DBNull.Value ? Main.sql_2.myReader.GetString("id") : "");

                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql_2.myReader["surname"] != DBNull.Value ? "|→            " + (Main.sql_2.myReader.GetString("surname") + " " + Main.sql_2.myReader.GetString("name") + " " + Main.sql_2.myReader.GetString("fath_name")) : "");
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[2].Value = "";
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[3].Value = "";
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql_2.myReader.GetByte("counter") == 1 ? "Ташқи ўриндош" : "Ички ўриндош");
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql_2.myReader["stavka"] != DBNull.Value ? Main.sql_2.myReader.GetString("stavka") : "");
                        VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql_2.myReader["kod_num"] != DBNull.Value ? Main.sql_2.myReader.GetString("kod_num") : "");

                        if (VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Value.ToString().Equals("Ташқи ўриндош") ||
                            VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Value.ToString().Equals("Ички ўриндош"))
                        {
                            VI_dataGridView.Rows[VI_dataGridView.Rows.Count - 1].Cells[4].Style.BackColor = Color.Pink;
                        }

                        Console.WriteLine((Main.sql_2.myReader.GetString("surname") + " " + Main.sql_2.myReader.GetString("name") + " " + Main.sql_2.myReader.GetString("fath_name")) + " | " + Main.sql_2.myReader.GetByte("counter"));

                    }
                    Main.sql_2.myReader.Close();
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                Main.sql_2.myReader.Close();
                Main.sql.myReader.Close();
                MessageBox.Show("treeView1_AfterSelect " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_to_datagridview_V()
        {
            TreeNode node = treeView.SelectedNode;

            TreeNode root = FindRootNode(node);
            string db_name = "";
            if (root != null)
            {
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                 db_name = tags[index1];
            }
            V_main_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.V_main_dataGridView_CellValueChanged);
            V_main_dataGridView.Rows.Clear();
            if (db_name != "")
            {
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT * FROM " + db_name + ".vacant ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    this.V_main_dataGridView.Rows[this.V_main_dataGridView.Rows.Add()].Cells[0].Value = Main.sql.myReader["id"] != DBNull.Value ? (object)Main.sql.myReader.GetString("id") : (object)"";
                    this.V_main_dataGridView.Rows[this.V_main_dataGridView.Rows.Count - 1].Cells[1].Value = Main.sql.myReader["name"] != DBNull.Value ? (object)Main.sql.myReader.GetString("name") : (object)"";
                    this.V_main_dataGridView.Rows[this.V_main_dataGridView.Rows.Count - 1].Cells[2].Value = Main.sql.myReader["name_little"] != DBNull.Value ? (object)Main.sql.myReader.GetString("name_little") : (object)"";

                }
                Main.sql.myReader.Close();
            }
            V_main_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.V_main_dataGridView_CellValueChanged);

        }

        public void get_items_to_datagridview_I(string e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];

            this.I_dataGridView.SelectionChanged -= new EventHandler(this.I_dataGridView_SelectionChanged);
            this.I_dataGridView.Rows.Clear();
            this.counter = 1;

            var select = "SELECT t2.cnt2 - t.cnt1 as diff,t2.id, t2.otdel_doljnost, t2.surname, t2.name, t2.fath_name,t2.fio, t2.kod_num, t2.register_num, t2.zvanie, t2.otdel, t2.doljnost FROM " +
"(SELECT count(*) as cnt1, id,concat(otdel, ' ', doljnost) as otdel_doljnost, '' as surname, '' as name, '' as fath_name, '' as fio, '' as kod_num, '' as register_num, '' as zvanie, otdel, doljnost from " + db_name + ".main where date_finish is null and otdel = '" + e + "' group by concat(otdel, ' ', doljnost)) as t " +
"JOIN " +
"(SELECT count(*) as cnt2, id,concat(otdel, ' ', doljnost) as otdel_doljnost, '' as surname, '' as name, '' as fath_name, '' as fio, '' as kod_num, '' as register_num, '' as zvanie, otdel, doljnost from " + db_name + ".work_place where type = 1 and otdel = '" + e + "' group by concat(otdel, ' ', doljnost)) as t2 on t.otdel_doljnost = t2.otdel_doljnost where t2.cnt2 - t.cnt1 > 0 " +
"UNION " +
"SELECT* FROM " +
"(SELECT count(*) as cnt3, id,concat(otdel, ' ', doljnost) as otdel_doljnost, '' as surname, '' as name, '' as fath_name, '' as fio, '' as kod_num, '' as register_num, '' as zvanie, otdel, doljnost from " + db_name + ".work_place where type = 1 and otdel = '" + e + "' group by concat(otdel, ' ', doljnost)) as t3 where t3.otdel_doljnost " +
"not in (SELECT concat(otdel, ' ', doljnost) as otdel_doljnost from " + db_name + ".main where date_finish is null and  otdel = '"+e+"'group by concat(otdel, ' ', doljnost)) " +
"UNION " +
"SELECT 'exist',id, concat(otdel, ' ', doljnost) as otdel_doljnost, surname, name, fath_name, concat(surname, ' ', name, ' ', fath_name) as fio, kod_num, register_num, zvanie, otdel, doljnost from " + db_name + ".main where date_finish is null and otdel = '" + e + "' order by otdel_doljnost ";

            //"SELECT *,concat(surname,' ',name,' ',fath_name) as fio FROM " + db_name + ".work_place WHERE otdel = '" + e + "'  and type = '1' "
            var sel____ = "SELECT id1, kod_num, surname, name, fath_name, concat(surname,' ',name,' ',fath_name) as fio, otd1, d1, z1,reg1 FROM( " +
"SELECT * FROM(SELECT id as id1, otdel as otd1, doljnost as d1 FROM " + db_name + ".work_place where type = 1 and otdel != '' and doljnost != '' and otdel = '" + e.ToString().Replace("\n", "") + "') as t " +
"join " +
"(SELECT kod_num, surname, name, fath_name, otdel as otd2, doljnost as d2, work_place_id as id2, zvanie as z1, register_num as reg1 FROM " + db_name + ".main where otdel != '' and doljnost != '' and otdel = '" + e.ToString().Replace("\n", "") + "') as t2 on t.id1 = t2.id2) as all_table " +
"UNION " +
"SELECT id as id1, kod_num, surname, name, fath_name, concat(surname, ' ', name, ' ', fath_name) as fio, otdel as otd1, doljnost as d1,'' as z1, register_num as reg1 FROM " + db_name + ".work_place where type = 1 and otdel != '' and doljnost != '' and otdel = '" + e.ToString().Replace("\n", "") + "'" +
"and id not in (SELECT distinct work_place_id FROM " + db_name + ".main where date_finish is null  and otdel = '" + e.ToString().Replace("\n", "") + "' and otdel != '' and doljnost != '' and work_place_id is not null)";
            Main.sql.myReader = Main.sql.return_MySqlCommand(sel____).ExecuteReader();
            while (Main.sql.myReader.Read())
            {
               string vacant = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "0");
                if (vacant != "0")
                {
                    this.cavant = "Б А Н Д";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Add()].Cells[0].Value = Main.sql.myReader["id1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("id1") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[1].Value = (object)Convert.ToString(this.counter);
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[2].Value = Main.sql.myReader["reg1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("reg1") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[3].Value = Main.sql.myReader["kod_num"] != DBNull.Value ? (object)Main.sql.myReader.GetString("kod_num") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[4].Value = Main.sql.myReader["surname"] != DBNull.Value ? (object)Main.sql.myReader.GetString("surname") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[5].Value = Main.sql.myReader["name"] != DBNull.Value ? (object)Main.sql.myReader.GetString("name") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[6].Value = Main.sql.myReader["fath_name"] != DBNull.Value ? (object)Main.sql.myReader.GetString("fath_name") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[7].Value = Main.sql.myReader["fio"] != DBNull.Value ? (object)Main.sql.myReader.GetString("fio") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[8].Value = Main.sql.myReader["otd1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("otd1") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[9].Value = Main.sql.myReader["d1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("d1") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[10].Value = Main.sql.myReader["z1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("z1") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[11].Value = (object)this.cavant;
                    if (this.cavant == "Б Ў Ш")
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                    ++this.counter;
                }
                else
                {
                        this.cavant = "Б Ў Ш";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Add()].Cells[0].Value = Main.sql.myReader["id1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("id1") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[1].Value = (object)Convert.ToString(this.counter);
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[2].Value = Main.sql.myReader["reg1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("reg1") : (object)"";
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[3].Value = "";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[4].Value = Main.sql.myReader["surname"] != DBNull.Value ? (object)Main.sql.myReader.GetString("surname") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[5].Value = Main.sql.myReader["name"] != DBNull.Value ? (object)Main.sql.myReader.GetString("name") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[6].Value = Main.sql.myReader["fath_name"] != DBNull.Value ? (object)Main.sql.myReader.GetString("fath_name") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[7].Value = Main.sql.myReader["fio"] != DBNull.Value ? (object)Main.sql.myReader.GetString("fio") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[8].Value = Main.sql.myReader["otd1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("otd1") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[9].Value = Main.sql.myReader["d1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("d1") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[10].Value = Main.sql.myReader["z1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("z1") : (object)"";
                        this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[11].Value = (object)this.cavant;
                        if (this.cavant == "Б Ў Ш")
                            this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                        ++this.counter;
                }
              
            }
            Main.sql.myReader.Close();
            this.I_dataGridView.SelectionChanged += new EventHandler(this.I_dataGridView_SelectionChanged);
            /*
            Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT *,concat(surname,' ',name,' ',fath_name) as fio FROM " + db_name + ".work_place WHERE otdel = '" + e + "'  and type = '1' ").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                this.cavant = !(Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "").Equals("1") ? "Б Ў Ш" : "Б А Н Д";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Add()].Cells[0].Value = Main.sql.myReader["id"] != DBNull.Value ? (object)Main.sql.myReader.GetString("id") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[1].Value = (object)Convert.ToString(this.counter);
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[2].Value = Main.sql.myReader["register_num"] != DBNull.Value ? (object)Main.sql.myReader.GetString("register_num") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[3].Value = Main.sql.myReader["kod_num"] != DBNull.Value ? (object)Main.sql.myReader.GetString("kod_num") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[4].Value = Main.sql.myReader["surname"] != DBNull.Value ? (object)Main.sql.myReader.GetString("surname") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[5].Value = Main.sql.myReader["name"] != DBNull.Value ? (object)Main.sql.myReader.GetString("name") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[6].Value = Main.sql.myReader["fath_name"] != DBNull.Value ? (object)Main.sql.myReader.GetString("fath_name") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[7].Value = Main.sql.myReader["fio"] != DBNull.Value ? (object)Main.sql.myReader.GetString("fio") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[8].Value = Main.sql.myReader["otdel"] != DBNull.Value ? (object)Main.sql.myReader.GetString("otdel") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[9].Value = Main.sql.myReader["doljnost"] != DBNull.Value ? (object)Main.sql.myReader.GetString("doljnost") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[10].Value = Main.sql.myReader["zvanie"] != DBNull.Value ? (object)Main.sql.myReader.GetString("zvanie") : (object)"";
                this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[11].Value = (object)this.cavant;
                if (this.cavant == "Б Ў Ш")
                    this.I_dataGridView.Rows[this.I_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                ++this.counter;
            }
            Main.sql.myReader.Close();
            this.I_dataGridView.SelectionChanged += new EventHandler(this.I_dataGridView_SelectionChanged);
            */
        }

        public void get_items_to_datagridview_IV()
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];

            this.IV_dataGridView.SelectionChanged -= new EventHandler(this.IV_dataGridView_SelectionChanged);
            this.IV_dataGridView.Rows.Clear();
            this.counter = 1;
            var sel____ = "SELECT id1, kod_num, surname, name, fath_name, concat(surname,' ',name,' ',fath_name) as fio, otd1, d1, z1,reg1 FROM( " +
"SELECT * FROM(SELECT id as id1, otdel as otd1, doljnost as d1 FROM " + db_name + ".work_place where type = 1 and otdel != '' and doljnost != '' and otdel = '" + wholeText(node) + "') as t " +
"join " +
"(SELECT kod_num, surname, name, fath_name, otdel as otd2, doljnost as d2, work_place_id as id2, zvanie as z1, register_num as reg1 FROM " + db_name + ".main where otdel != '' and date_finish is null  and doljnost != '' and otdel = '" + wholeText(node) + "') as t2 on t.id1 = t2.id2) as all_table " +
"UNION " +
"SELECT id as id1, kod_num, surname, name, fath_name, concat(surname, ' ', name, ' ', fath_name) as fio, otdel as otd1, doljnost as d1,'' as z1, register_num as reg1 FROM " + db_name + ".work_place where type = 1 and otdel != '' and doljnost != '' and otdel = '" + wholeText(node) + "'" +
"and id not in (SELECT distinct work_place_id FROM " + db_name + ".main where date_finish is null  and otdel = '" + wholeText(node) + "' and otdel != '' and doljnost != '' and work_place_id is not null)";
            //"select *,concat(surname,' ',name,' ',fath_name) as fio from " + db_name + ".work_place where otdel = '" + wholeText(node) + "'  and type = '1' "
            Main.sql.myReader = Main.sql.return_MySqlCommand(sel____).ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                this.IV_dataGridView.Rows[this.IV_dataGridView.Rows.Add()].Cells[0].Value = Main.sql.myReader["id1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("id1") : (object)"";
                this.IV_dataGridView.Rows[this.IV_dataGridView.Rows.Count - 1].Cells[1].Value = (object)Convert.ToString(this.counter);
                this.IV_dataGridView.Rows[this.IV_dataGridView.Rows.Count - 1].Cells[2].Value = Main.sql.myReader["fio"] != DBNull.Value ? (object)Main.sql.myReader.GetString("fio") : (object)"";
                this.IV_dataGridView.Rows[this.IV_dataGridView.Rows.Count - 1].Cells[3].Value = Main.sql.myReader["otd1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("otd1") : (object)"";
                this.IV_dataGridView.Rows[this.IV_dataGridView.Rows.Count - 1].Cells[4].Value = Main.sql.myReader["d1"] != DBNull.Value ? (object)Main.sql.myReader.GetString("d1") : (object)"";
                ++this.counter;
            }
            Main.sql.myReader.Close();
            IV_dataGridView.ClearSelection();
            foreach (DataGridViewRow row in IV_dataGridView.Rows)
            {
                if (row.Cells[2].ToString() == "")
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    IV_dataGridView.Rows[0].Selected = true;
                }
            }
            this.IV_dataGridView.SelectionChanged += new EventHandler(this.IV_dataGridView_SelectionChanged);
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is NumericUpDown)
                        (control as NumericUpDown).Value = 1;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void IV_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void I_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];

            try
            {
                DataGridViewRow currentRow = this.I_dataGridView.CurrentRow;
                this.lavozimi_I_remove_label.Text = currentRow.Cells[9].Value.ToString();
                Main.sql.myReader = Main.sql.return_MySqlCommand("select count(*) as count from " + db_name + ".work_place where id_parent = '" + currentRow.Cells[0].Value.ToString() + "' and  type = '2' and vacant = '1' ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    if (Main.sql.myReader.GetInt32("count") == 0)
                        this.dekret_I_remove_label.Text = "Й Ў Қ";
                    else
                        this.dekret_I_remove_label.Text = "Б О Р";
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                int num = (int)MessageBox.Show("I_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];

            if (this.I_dataGridView.SelectedCells.Count > 0 && this.I_dataGridView.CurrentRow.Cells[11].Value.ToString().Equals("Б Ў Ш") && this.dekret_I_remove_label.Text.ToString().Equals("Й Ў Қ"))
            {
                try
                {
                    DataGridViewRow currentRow = this.I_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".work_place where id = '" + currentRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".work_place where id_parent = '" + currentRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();
                    this.bowqarma_I_remove_label.Text = "-";
                    this.lavozimi_I_remove_label.Text = "-";
                    this.dekret_I_remove_label.Text = "-";
                    this.run_alert("");
                    this.get_items_to_datagridview_I("");
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Лавозим банд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
        private string DB(string db)
        {
            string database = "";
            //if()
            return database;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];
            if (this.glavka_string != "" && this.lavozimi_I_add_comboBox.Text != "" && this.darajasi_I_add_comboBox.Text != "" && this.dona_I_add_numericUpDown.Text != "")
            {
                try
                {
                    Convert.ToInt32(this.dona_I_add_numericUpDown.Text);
                    for (int index = 0; index < Convert.ToInt32(this.dona_I_add_numericUpDown.Text); ++index)
                    {
                        var ins = "insert into "+db_name+".work_place (otdel,doljnost,grade,vacant,type,nameklatura,korxona, korxona_string, stavka) values(  '" + wholeText(node) + "',  '" + this.lavozimi_I_add_comboBox.Text + "',  '" + this.darajasi_I_add_comboBox.Text + "',  '0',  '1',  '" + this.nameklatura_I_add_comboBox.Text + "',  '" + (this.korxona_I_add_checkBox.Checked ? "1" : "0") + "', '" + this.korxona_string_comboBox.Text + "', '" + this.stavka_comboBox.Text + "' )";
                        Main.sql.return_MySqlCommand(ins).ExecuteNonQuery();
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select max(id) as id from " + db_name + ".work_place ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                            this.id_string = Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "";
                        Main.sql.myReader.Close();
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".work_place (otdel,doljnost,grade,vacant,type,id_parent,nameklatura,korxona, korxona_string, stavka) values(  '" + wholeText(node) + "',  '" + this.lavozimi_I_add_comboBox.Text + "',  '" + this.darajasi_I_add_comboBox.Text + "',  '0',  '2',  '" + this.id_string + "',  '" + this.nameklatura_I_add_comboBox.Text + "',  '" + (this.korxona_I_add_checkBox.Checked ? "1" : "0") + "', '" + this.korxona_string_comboBox.Text + "', '" + this.stavka_comboBox.Text + "' ) ").ExecuteNonQuery();
                        //Main.sql.return_MySqlCommand("insert into " + db_name + ".main (otdel,doljnost,grade, stavka, nameklatura, korxona_string) values(  '" + wholeText(node) + "',  '" + this.lavozimi_I_add_comboBox.Text + "',  '" + this.darajasi_I_add_comboBox.Text + "',  '" + this.stavka_comboBox.Text + "',  '" + nameklatura_I_add_comboBox.Text + "',  '" + this.korxona_string_comboBox.Text + "')  ").ExecuteNonQuery();
                    }
                    this.lavozimi_I_add_comboBox.SelectedIndex = -1;
                    this.darajasi_I_add_comboBox.SelectedIndex = -1;
                    this.nameklatura_I_add_comboBox.SelectedIndex = -1;
                    this.korxona_I_add_checkBox.Checked = false;
                    this.run_alert("");
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
                    //MessageBox.Show(e.Node.Index + " " + e.Node.Tag.ToString() +" " +e.Node.Text.ToString());
                    this.get_items_to_datagridview_I(str);
                    
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    int num = (int)MessageBox.Show("button2_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Пустое место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                if (this.IV_dataGridView.SelectedCells.Count <= 0)
                    return;
                int num = 0;
                DataGridViewRow currentRow = this.IV_dataGridView.CurrentRow;
                if (currentRow.Cells[2].Value.ToString().Replace(" ", "") == "")
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select max(kod_num)+1 as max from " + db_name + ".main").ExecuteReader();
                    while (Main.sql.myReader.Read())
                        num = Main.sql.myReader["max"] != DBNull.Value ? Main.sql.myReader.GetInt32("max") : 1;
                    Main.sql.myReader.Close();
                    var inser = "insert into " + db_name + ".main (kod_num,register_num, lichniy_num,surname,name,fath_name,otdel,doljnost,zvanie,date_start,date_start2,prikaz_start,from_him_prikaz, vacant_id, work_place_id) " +
                        "values(  '" + (object)num + "',  '" + this.shxyj_IV_textBox.Text + "',  '" + this.shaxsiy_IV_textBox.Text + "',  '" + this.familiyasi_IV_textBox.Text + "',  '" + this.ismi_IV_textBox.Text + "',  '" + this.otasining_ismi_IV_textBox.Text + "',  '" + currentRow.Cells[3].Value.ToString() + "',  '" + currentRow.Cells[4].Value.ToString() + "',  '" + this.zvanie_IV_comboBox.Text + "',  '" + this.buyruq_sanasi_IV_dateTimePicker.Value.ToString("yyyy-MM-dd") + "',  '" + this.qacondan_IV_dateTimePicker.Value.ToString("yyyy-MM-dd") + "',  '" + this.buyruq_nomer_IV_textBox.Text + "',  '" + this.kim_tomonidan_IV_textBox.Text + "', '" + node.Tag + "', '" + currentRow.Cells[0].Value.ToString() + "') ";
                    Main.sql.return_MySqlCommand(inser).ExecuteNonQuery();
                    Main.sql.return_MySqlCommand("update " + db_name + ".work_place set kod_num = '" + (object)num + "',  register_num = '" + this.shxyj_IV_textBox.Text + "', lichniy_num= '" + this.shaxsiy_IV_textBox.Text + "', surname = '" + this.familiyasi_IV_textBox.Text + "',  name = '" + this.ismi_IV_textBox.Text + "',  fath_name = '" + this.otasining_ismi_IV_textBox.Text + "',  zvanie = '" + this.zvanie_IV_comboBox.Text + "',  vacant = '1'  where id = '" + currentRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();
                    var upt = "update " + db_name + ".main, " + db_name + ".work_place set main.grade = work_place.grade, main.nameklatura= work_place.nameklatura, main.korxona_string = work_place.korxona_string, main.stavka = work_place.stavka  where work_place.kod_num = main.kod_num and main.kod_num = '" + (object)num + "'";
                    Main.sql.return_MySqlCommand(upt).ExecuteNonQuery();
                    this.get_items_to_datagridview_IV();
                }
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("button3_Click " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                if (this.bowqarma_nomi_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.bowqarma_nomi_textBox.Text + "',  'Бошқарма номи' ) ").ExecuteNonQuery();
                if (this.bowliq_fio_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.bowliq_fio_textBox.Text + "',  'Бошлиқ Ф.И.Ш' ) ").ExecuteNonQuery();
                if (this.bowliq_unvoni_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.bowliq_unvoni_textBox.Text + "',  'Бошлиқ унвони' ) ").ExecuteNonQuery();
                if (this.tatil_ijrocisi_lavozimi_unvoni_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.tatil_ijrocisi_lavozimi_unvoni_textBox.Text + "',  'Таътил ижрочиси лавозими, унвони' ) ").ExecuteNonQuery();
                if (!(this.tatil_ijrocisi_fio_textBox.Text != ""))
                    return;
                Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.tatil_ijrocisi_fio_textBox.Text + "',  'Таътил ижрочиси Ф.И.О' ) ").ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("button4_Click " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                if (this.jonatuvcining_manzili_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.jonatuvcining_manzili_textBox.Text + "',  'Жўнатувчининг манзили' ) ").ExecuteNonQuery();
                if (this.aholi_punkti_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.aholi_punkti_textBox.Text + "',  'Аҳоли пункти' ) ").ExecuteNonQuery();
                if (this.tuman_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.tuman_textBox.Text + "',  'Туман' ) ").ExecuteNonQuery();
                if (this.viloyat_respublica_textBox.Text != "")
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.viloyat_respublica_textBox.Text + "',  'Вилоят (республика, ўлка)' ) ").ExecuteNonQuery();
                if (!(this.idoraning_nomi_textBox.Text != ""))
                    return;
                Main.sql.return_MySqlCommand("insert into " + db_name + ".spravochnik(name,type) values(  '" + this.idoraning_nomi_textBox.Text + "',  'Идоранинг номи' ) ").ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("button5_Click " + ex.Message);
            }
        }

        int present_num = 0;
        double present_num_double = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];
            if (bowqarma_qismi_V_textBox.Text != "")
            {
                try
                {
                    int type_num = 0;
                    int checker_existing = 0;
                    int max_id = 0;
                    int present_num = 0;
                    double present_num_double = 0;

                    //        Main.sql.sql_select("select count(*) as count from vacant where name = '"+bowqarma_qismi_V_textBox.Text+"' ");
                    //        while(Main.sql.myReader..next())
                    //        {
                    //            checker_existing = Main.sql.myReader.GetInt32("count");
                    //        }

                    int queue_1 = 0, queue_2 = 0, queue_3 = 0, queue_4 = 0, queue_5 = 0, queue_6 = 0, queue_7 = 0, queue_8 = 0, queue_9 = 0, queue_10 = 0;
                    if (treeView.SelectedNode.Index != -1 && checker_existing == 0)//
                    {
                        Type valueType = treeView.SelectedNode.Tag.GetType();
                        string search = "";
                        if (valueType.IsArray)
                        {
                            search = "1";
                        }
                        else if (treeView.SelectedNode.Tag == null)
                        {
                            search = "";
                        }
                        else
                        {
                            search = treeView.SelectedNode.Tag.ToString();
                        }
                        var sel = "select * from " + db_name + ".vacant where id = '" + search+ "' ";
                        Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            type_num = Main.sql.myReader.GetInt32("type_num");

                            queue_1 = Main.sql.myReader.GetInt32("queue_1");
                            queue_2 = Main.sql.myReader.GetInt32("queue_2");
                            queue_3 = Main.sql.myReader.GetInt32("queue_3");
                            queue_4 = Main.sql.myReader.GetInt32("queue_4");
                            queue_5 = Main.sql.myReader.GetInt32("queue_5");
                            queue_6 = Main.sql.myReader.GetInt32("queue_6");
                            queue_7 = Main.sql.myReader.GetInt32("queue_7");
                            queue_8 = Main.sql.myReader.GetInt32("queue_8");
                            queue_9 = Main.sql.myReader.GetInt32("queue_9");
                            queue_10 = Main.sql.myReader.GetInt32("queue_10");


                            Console.WriteLine("TYPE : " + type_num);
                            Console.WriteLine("QUEUE : " + queue_1);
                            Console.WriteLine("QUEUE : " + queue_2);
                            Console.WriteLine("QUEUE : " + queue_3);
                            Console.WriteLine("QUEUE : " + queue_4);
                            Console.WriteLine("QUEUE : " + queue_5);
                            Console.WriteLine("QUEUE : " + queue_6);
                            Console.WriteLine("QUEUE : " + queue_7);
                            Console.WriteLine("QUEUE : " + queue_8);
                            Console.WriteLine("QUEUE : " + queue_9);
                            Console.WriteLine("QUEUE : " + queue_10);
                        }
                       Main.sql.myReader.Close();
                        String select = "";
                        if (type_num == 1)
                        {
                            select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_1 = " + queue_1;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                var ins = "insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ";
                                        Main.sql_2.return_MySqlCommand(ins).ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                                    }
                                    Main.sql.myReader.Close();
                        }
                        else if (type_num == 2){
                            select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_2 = " + queue_2;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");

                            }
                                    Main.sql.myReader.Close();
                        }
                        if (type_num == 3){
                            select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_3 = " + queue_3;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {


                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                            }
                                    Main.sql.myReader.Close();
                        }
                            if (type_num == 4)
                            {
                                select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_4 = " + queue_4;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                            }
                                    Main.sql.myReader.Close();
                            }
                            if (type_num == 5)
                            {
                                select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_5 = " + queue_5;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                            }
                                    Main.sql.myReader.Close();
                            }

                            if (type_num == 6){
                                select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_6 = " + queue_6;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                            }
                                    Main.sql.myReader.Close();
                            }
                            if (type_num == 7){
                                select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_7 = " + queue_7;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                            }
                                    Main.sql.myReader.Close();
                            }
                            if (type_num == 8){
                                select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_8 = " + queue_8;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "',"
                                                + " '" + queue_10 + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                            }
                                    Main.sql.myReader.Close();
                            }
                            if (type_num == 9){
                                select = "select max(queue_" + (type_num + 1) + ")+1 as max from " + db_name + ".vacant where queue_9 = " + queue_9;
                                    Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
                                    while (Main.sql.myReader.Read())
                                    {
                                        Main.sql_2.return_MySqlCommand("insert into " + db_name + ".vacant(name,type_num,queue_1,queue_2,queue_3,queue_4,queue_5,queue_6,queue_7,queue_8,queue_9,queue_10) values("
                                                + " '" + bowqarma_qismi_V_textBox.Text + "', "
                                                + " '" + (type_num + 1) + "', "
                                                + " '" + queue_1 + "',"
                                                + " '" + queue_2 + "',"
                                                + " '" + queue_3 + "',"
                                                + " '" + queue_4 + "',"
                                                + " '" + queue_5 + "',"
                                                + " '" + queue_6 + "',"
                                                + " '" + queue_7 + "',"
                                                + " '" + queue_8 + "',"
                                                + " '" + queue_9 + "',"
                                                + " '" + Main.sql.myReader.GetInt32("max") + "' "
                                                + " ) ").ExecuteNonQuery();
                                max_id = Main.sql.myReader.GetInt32("max");
                            }
                                    Main.sql.myReader.Close();
                            }
                            if (type_num == 10)
                            {

                            }
                    }
                    else
                    {
                        //alert_error.setHeaderText(" -- Ïîâòîðåíèå --");
                        //.showAndWait();
                    }
                    TreeNode NewNode = node.Nodes.Add(bowqarma_qismi_V_textBox.Text);
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT max(id) as max_id FROM " + db_name + ".vacant").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        max_id = Main.sql.myReader.GetInt32("max_id");
                    }
                    Main.sql.myReader.Close();


                    NewNode.Tag = max_id;
                    //treeView.Nodes.Clear();

                    //run_treeview2();
                    bowqarma_qismi_V_textBox.Text = "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Main.sql.myReader.Close();
                }

            }
        }
        private void Tex_Pod_Load(object sender, EventArgs e)
        {
            this.run_main();
            ClearTextBoxes();            
        }
        public string wholeText(TreeNode e)
        {
            string str = "";

            var ancestorsAndSelf = e.FullPath.Split(treeView.PathSeparator.ToCharArray());

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
            return str;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];
           
                int type_num = 0;
                int checker_existing = 0;

                int present_num = 0;
                double present_num_double = 0;
                TreeNode tree_m = treeView.SelectedNode;
               //MessageBox.Show(wholeText(tree_m));
                if (treeView.SelectedNode.Index != -1 && checker_existing == 0)// && )
                {

                    if (tree_m.Nodes.Count != 0)
                    {
                        int count = 0;
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select count(*) as count from " + db_name + ".vacant where name = '" + wholeText(tree_m) + "' ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            count = Main.sql.myReader.GetInt32("count");
                        }
                        Main.sql.myReader.Close();
                        if (count == 1)
                        {
                            var update = "update " + db_name + ".work_place set otdel = REPLACE(otdel, '" + tree_m.Text + "','" + bowqarma_qismi_V_textBox.Text + "') where "
                                   + " otdel like '" + wholeText(tree_m) + "%' ";
                            Main.sql_2.return_MySqlCommand(update).ExecuteNonQuery();
                            //        
                            var update1 = "update " + db_name + ".main set otdel = REPLACE(otdel, '" + tree_m.Text + "','" + bowqarma_qismi_V_textBox.Text + "') where "
                                   + " otdel like '" + wholeText(tree_m) + "%' ";
                            Main.sql_2.return_MySqlCommand(update1).ExecuteNonQuery();
                        }
                        tree_m.Text = bowqarma_qismi_V_textBox.Text;
                        Console.WriteLine(count + "update " + db_name + ".main set otdel = REPLACE(otdel, '" + tree_m.Text + "','" + bowqarma_qismi_V_textBox.Text + "') where "
                                 + " otdel like '" + wholeText(tree_m) + "%' ");
                    }
                    else
                    {
                        
                        var update_work = "update " + db_name + ".work_place set otdel = REPLACE(otdel, '" + tree_m.Text + "','" + bowqarma_qismi_V_textBox.Text + "') where "
                              + " otdel = '" + wholeText(tree_m) + "' ";
                        Main.sql_2.return_MySqlCommand(update_work).ExecuteNonQuery();
                        //        
                        var update_main = "update " + db_name + ".main set otdel = REPLACE(otdel, '" + tree_m.Text + "','" + bowqarma_qismi_V_textBox.Text + "') where "
                              + " otdel = '" + wholeText(tree_m) + "' ";
                        Main.sql_2.return_MySqlCommand(update_main).ExecuteNonQuery(); ;
                        tree_m.Text = bowqarma_qismi_V_textBox.Text;
                    }
                    var vacant = "update " + db_name + ".vacant set name = '" + bowqarma_qismi_V_textBox.Text + "' where id = '" + tree_m.Tag + "' ";
                    Main.sql_2.return_MySqlCommand(vacant).ExecuteNonQuery();


                    //Console.WriteLine(treeView.getSelectionModel().getSelectedItem().getValue().getId());
                   // treeView.Nodes.Clear();
                    //run_treeview2();
                    bowqarma_qismi_V_textBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обнавить Error: ", ex.Message);
                Main.sql.myReader.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];
            TreeNode tree_m = treeView.SelectedNode;
          
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tree_m.Nodes.Count == 0)
                    {
                        Main.sql.return_MySqlCommand("delete from " + db_name + ".vacant where id = '" + tree_m.Tag + "' ").ExecuteNonQuery();

                        Main.sql.return_MySqlCommand("delete from " + db_name + ".work_place where "
                                   + " otdel = '" + wholeText(tree_m)+ "' ").ExecuteNonQuery();
                    }
                    //treeView.Nodes.Clear();
                    treeView.SelectedNode.Remove();
                    //run_treeview2();
                }
                else
                {
                   // e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void V_main_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            if (root != null)
            {
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                if (V_main_dataGridView.SelectedCells.Count > 0)
                {
                    try
                    {
                        DataGridViewRow dgvRow = V_main_dataGridView.CurrentRow;

                        Main.sql.return_MySqlCommand("update " + db_name + ".vacant set name_little = '" + dgvRow.Cells[2].Value + "' where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "V_main_dataGridView_CellValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];
            if (VI_dataGridView.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow dgvRow = VI_dataGridView.CurrentRow;

                        if (dgvRow.Cells[4].Value.ToString().Equals("Асосий"))
                        {
                            Main.sql.return_MySqlCommand("update " + db_name + ".work_place set register_num='',kod_num='0',surname='',name='',fath_name='',zvanie='',vacant='0',lichniy_num='' " +
                            " where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                            Main.sql.return_MySqlCommand("delete from " + db_name + ".main where kod_num = '" + dgvRow.Cells[6].Value.ToString() + "' ").ExecuteNonQuery();
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".trudovoy where kod_num = '" + dgvRow.Cells[6].Value.ToString() + "' ").ExecuteNonQuery();
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".family where kod_num = '" + dgvRow.Cells[6].Value.ToString() + "' ").ExecuteNonQuery();
                        }
                        else if (dgvRow.Cells[4].Value.ToString().Equals("Декрет ҳисобидан"))
                        {
                            Main.sql.return_MySqlCommand("update " + db_name + ".work_place set register_num='',kod_num='0',surname='',name='',fath_name='',zvanie='',vacant='0',lichniy_num='' " +
                            " where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                            Main.sql.return_MySqlCommand("delete from " + db_name + ".main where kod_num = '" + dgvRow.Cells[6].Value.ToString() + "' ").ExecuteNonQuery();
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".trudovoy where kod_num = '" + dgvRow.Cells[6].Value.ToString() + "' ").ExecuteNonQuery();
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".family where kod_num = '" + dgvRow.Cells[6].Value.ToString() + "' ").ExecuteNonQuery();
                        }
                        else if (dgvRow.Cells[4].Value.ToString().Equals("Ташқи ўриндош"))
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".orindoshlar where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();
                        }
                        else if (dgvRow.Cells[4].Value.ToString().Equals("Ички ўриндош"))
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".orindoshlar where id = '" + dgvRow.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();
                        }

                        get_items_from_base_VI(treeView.SelectedNode.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, " button9_Click ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];
            if (yangi_lavozim_VIII_comboBox.Text != "" && eski_lavozim_VIII_comboBox.Text != "")
            {
                try
                {
                    Main.sql.return_MySqlCommand("update " + db_name + ".work_place set doljnost = '" + yangi_lavozim_VIII_comboBox.Text + "' where doljnost = '" + eski_lavozim_VIII_comboBox.Text + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set doljnost = '" + yangi_lavozim_VIII_comboBox.Text + "' where doljnost = '" + eski_lavozim_VIII_comboBox.Text + "' ").ExecuteNonQuery();

                    get_items_for_VIII();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " button10_Click ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void lavozimi_I_add_comboBox_TextChanged(object sender, EventArgs e)
        {
            //if (lavozimi_I_add_comboBox.SelectedIndex < 0)
            //{
            //    lavozimi_I_add_comboBox.Text = "Лавозим";
            //}
            //else
            //{
            //    lavozimi_I_add_comboBox.Text = lavozimi_I_add_comboBox.SelectedText;
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            sprovochnik.Rows.Clear();
            this.sprovochnik.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.sprovochnik_CellValueChanged);
            var select = "SELECT * FROM (SELECT id, name, CASE type WHEN 'unvon' THEN 'Унвон' WHEN 'tugilgan_joyi' THEN 'Туғилган жойи' else type END as mytype FROM spravochnik) as t where t.mytype = '" + comboBox1.Text + "'";
            Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                int index = sprovochnik.Rows.Add();
                sprovochnik.Rows[index].Cells[0].Value = Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "";
                sprovochnik.Rows[index].Cells[1].Value = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
                sprovochnik.Rows[index].Cells[2].Value = Main.sql.myReader["mytype"] != DBNull.Value ? Main.sql.myReader.GetString("mytype") : "";
            }
            Main.sql.myReader.Close();
            this.sprovochnik.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.sprovochnik_CellValueChanged);
        }

        private void sprovochnik_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                // this.dataGridView2.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
                DataGridViewRow dgvRow = sprovochnik.CurrentRow;


                if (dgvRow != null)
                {
                    if (dgvRow.Cells[0].Value == null)
                    {

                        if (sprovochnik.CurrentRow.Cells[1].Value != null && sprovochnik.CurrentRow.Cells[1].Value.ToString() != "")
                        {
                            Main.sql.return_MySqlCommand("insert into spravochnik (name, type) values" +
                                                "('" + (sprovochnik.CurrentRow.Cells[1].Value != null ? sprovochnik.CurrentRow.Cells[1].Value : 0) + "', " +
                                                "'" + comboBox1.Text + "'" +
                                                ") ").ExecuteNonQuery();
                        }
                        this.sprovochnik.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.sprovochnik_CellValueChanged);

                        Main.sql.myReader = Main.sql.return_MySqlCommand("select max(id) as id from spravochnik").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            sprovochnik.Rows[sprovochnik.CurrentRow.Index].Cells[0].Value = Main.sql.myReader["id"] != null ? Main.sql.myReader.GetString("id") : "1";
                        }
                        Main.sql.myReader.Close();


                        this.sprovochnik.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.sprovochnik_CellValueChanged);
                    }
                    else
                    {

                        Main.sql.return_MySqlCommand("update spravochnik set " +
                           "name = '" + (sprovochnik.CurrentRow.Cells[1].Value != null ? sprovochnik.CurrentRow.Cells[1].Value : "") + "' " +
                           " where id = '" + (sprovochnik.CurrentRow.Cells[0].Value != null ? sprovochnik.CurrentRow.Cells[0].Value : "") + "'").ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("dataGridView3_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void sprovochnik_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DialogResult response = MessageBox.Show("Вы уверены? Удалить строку?", "Удалить",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button2);

                if (response == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    var delete = "DELETE FROM spravochnik WHERE id =" + e.Row.Cells[0].Value + "";

                    Main.sql.return_MySqlCommand(delete).ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sprovochnik_UserDeletingRow : " + ex.Message);
            }
        }

        private void shxyj_IV_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    string database = System.IO.File.ReadAllText("docs\\data_base_from.txt");
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        var select = "select surname, name, fath_name, zvanie from " + database + ".main where register_num = '" + shxyj_IV_textBox.Text + "'";
            //        familiyasi_IV_textBox.Text = "";
            //        ismi_IV_textBox.Text = "";
            //        otasining_ismi_IV_textBox.Text = "";
            //        zvanie_IV_comboBox.Text = "";


            //        Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
            //        while (Main.sql.myReader.Read())
            //        {
            //            familiyasi_IV_textBox.Text = Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "";
            //            ismi_IV_textBox.Text = Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "";
            //            otasining_ismi_IV_textBox.Text = Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "";
            //            zvanie_IV_comboBox.Text = Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "";

            //        }
            //        Main.sql.myReader.Close();
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("shxyj_IV_textBox_KeyUp " + ex.Message);
            //}
        }
    }
}
