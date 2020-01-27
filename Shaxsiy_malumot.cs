using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Kadr
{
    public partial class Shaxsiy_malumot : Form
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
        public Shaxsiy_malumot()
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

            button4.BackgroundImage = Kadr.Properties.Resources.lock11;
            button4.BackgroundImage.Tag = "lock11";
            ///unlock all text boxes ////
            shxyj_textBox.Enabled = false;
            shaxsiy_raqam_harfi_comboBox.Enabled = false;
            shaxsiy_textBox.Enabled = false;
            lavozimi_ComboBox.Enabled = false;
            buyruq_sanasi_textBox.Enabled = false;
            qacondan_textBox.Enabled = false;
            buyruq_nomeri_textBox.Enabled = false;
            kim_tomonidan_textBox.Enabled = false;
            xisobidan_checkbox.Enabled = false;
            xisobidan_comboBox.Enabled = false;
            familiyasi_textBox.Enabled = false;
            ismi_textBox.Enabled = false;
            otasining_ismi_textBox.Enabled = false;
            qizining_ismi_textBox.Enabled = false;
            iio_da_qachondan_textBox.Enabled = false;
            qayta_qabul_checkBox.Enabled = false;
            qayta_qabul_date.Enabled = false;
            millati_textBox.Enabled = false;
            unvon_comboBox.Enabled = false;
            button1.Enabled = false;
            tugilgan_sanasi_textBox.Enabled = false;
            tugilgan_joyi_textBox.Enabled = false;
            groupBox1.Enabled = false;
            tillar_textBox.Enabled = false;
            ilmiy_unvoni_textBox.Enabled = false;
            ilmiy_darajasi_textBox.Enabled = false;
            deputatlik.Enabled = false;
            lavozimDarajaTextBox.Enabled = false;
            nomenklatura.Enabled = false;
            stavka_comboBox.Enabled = false;
            passport_finish_date.Enabled = false;
            passport_propiska.Enabled = false;
            passport_start_date.Enabled = false;
            passport_seria.Enabled = false;
            woman.Enabled = false;
            man.Enabled = false;
            tel_num.Enabled = false;
            this.prava_type_ComboBox.Items.Add("ЙЎҚ");
            this.prava_type_ComboBox.Items.Add("A");
            this.prava_type_ComboBox.Items.Add("B");
            this.prava_type_ComboBox.Items.Add("C");
            this.prava_type_ComboBox.Items.Add("D");
            this.prava_type_ComboBox.Items.Add("E");

            this.stavka_comboBox.Items.Add("1.0");
            this.stavka_comboBox.Items.Add("0.5");
            //poisk_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            poisk_dataGridView.EnableHeadersVisualStyles = false;
            this.poisk_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.poisk_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            this.xchk_datagridview.RowsDefaultCellStyle.BackColor = Color.White;
            this.xchk_datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

           // oila_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            oila_dataGridView.EnableHeadersVisualStyles = false;
            oila_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            oila_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.oila_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.oila_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

         //   unvon_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            unvon_dataGridView.EnableHeadersVisualStyles = false;
            this.unvon_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.unvon_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //mehnat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            mehnat_dataGridView.EnableHeadersVisualStyles = false;
            mehnat_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mehnat_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.mehnat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.mehnat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //malumoti_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            malumoti_dataGridView.EnableHeadersVisualStyles = false;
            malumoti_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            malumoti_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.malumoti_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.malumoti_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //tatil_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            tatil_dataGridView.EnableHeadersVisualStyles = false;
            tatil_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tatil_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.tatil_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.tatil_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

          //  attestatsiya_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            attestatsiya_dataGridView.EnableHeadersVisualStyles = false;
            attestatsiya_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            attestatsiya_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.attestatsiya_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.attestatsiya_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //intizomiy_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            intizomiy_dataGridView.EnableHeadersVisualStyles = false;
            intizomiy_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            intizomiy_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.intizomiy_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.intizomiy_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //ragbat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            ragbat_dataGridView.EnableHeadersVisualStyles = false;
            ragbat_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ragbat_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.ragbat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.ragbat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //davlat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            davlat_dataGridView.EnableHeadersVisualStyles = false;
            this.davlat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.davlat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

           // xarbiy_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            xarbiy_dataGridView.EnableHeadersVisualStyles = false;
            this.xarbiy_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.xarbiy_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //xizmat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            xizmat_dataGridView.EnableHeadersVisualStyles = false;
            xizmat_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            xizmat_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.xizmat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.xizmat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

          //  toifa_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            toifa_dataGridView.EnableHeadersVisualStyles = false;
            this.toifa_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.toifa_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //maxfiy_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            maxfiy_dataGridView.EnableHeadersVisualStyles = false;
            this.maxfiy_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.maxfiy_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            //guvohnoma_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            guvohnoma_dataGridView.EnableHeadersVisualStyles = false;
            this.guvohnoma_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.guvohnoma_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

           // mt_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            mt_dataGridView.EnableHeadersVisualStyles = false;
            this.mt_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.mt_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            lavozimi_ComboBox.Items.Clear();
            Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT distinct doljnost FROM work_place where doljnost!=''").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                lavozimi_ComboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
                xisobidan_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));
            }
            Main.sql.myReader.Close();

            /*otdel_ComboBox.Items.Clear();
            Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT distinct otdel FROM work_place where otdel!=''").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                otdel_ComboBox.Items.Add(Main.sql.myReader.GetString("otdel"));
            }
            Main.sql.myReader.Close();
            */
            boshatishBand_comboBox.Items.Clear();
            Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT name FROM spravochnik where type = 'БЎШАТИЛСИН' and name != ''").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                boshatishBand_comboBox.Items.Add(Main.sql.myReader.GetString("name"));
            }
            Main.sql.myReader.Close();

            Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT distinct t.lich_letter FROM (select SUBSTRING(lichniy_num, 1, 1) as lich_letter from main) as t where !isnull(t.lich_letter)").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                shaxsiy_raqam_harfi_comboBox.Items.Add(Main.sql.myReader.GetString("lich_letter"));
            }
            Main.sql.myReader.Close();

            unvon_comboBox.Items.Add("сафдор");
            unvon_comboBox.Items.Add("кичик сержант");
            unvon_comboBox.Items.Add("сержант");
            unvon_comboBox.Items.Add("катта сержант");
            //unvon_comboBox.Items.Add("кичик лейтенант");
            unvon_comboBox.Items.Add("лейтенант");
            unvon_comboBox.Items.Add("катта лейтенант");
            unvon_comboBox.Items.Add("капитан");
            unvon_comboBox.Items.Add("майор");
            unvon_comboBox.Items.Add("подполковник");
            unvon_comboBox.Items.Add("полковник");
            unvon_comboBox.Items.Add("генерал майор");
            unvon_comboBox.Items.Add("генерал лейтинант");
            unvon_comboBox.Items.Add("генерал полковник");

            Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT distinct LOWER(national) as national FROM main where national != '' and national != 'null'").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                millati_textBox.Items.Add(Main.sql.myReader.GetString("national"));
            }
            Main.sql.myReader.Close();
        }

        public void run_main()
        {
            treeView.Nodes.Clear();
            run_treeview();

            tatil_turi_tatil.Items.Clear();
            Main.sql.myReader = Main.sql.return_MySqlCommand("select name from spravochnik where type = 'ТАЪТИЛ' ").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                tatil_turi_tatil.Items.Add(Main.sql.myReader.GetString("name"));
            }
            Main.sql.myReader.Close();

            jazo_turi_intizomiy.Items.Clear();
            Main.sql.myReader = Main.sql.return_MySqlCommand("select name from spravochnik where type = 'ЭЪЛОН  ҚИЛИНСИН' ").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                jazo_turi_intizomiy.Items.Add(Main.sql.myReader.GetString("name"));
            }
            Main.sql.myReader.Close();
            viloyatlar_comboBox.Items.Clear();
            var sel = "SELECT schema_name FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name";
            Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                var sel_lav = "SELECT name FROM " + Main.sql.myReader.GetString("schema_name") + ".vacant where type_num = 1";
                Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(sel_lav).ExecuteReader();
                while (Main.sql_2.myReader.Read())
                {
                    viloyatlar_comboBox.Items.Add(Main.sql_2.myReader.GetString("name"));
                    viloyatlar_comboBox.ValueMember = Main.sql.myReader.GetString("schema_name");
                }
                Main.sql_2.myReader.Close();
            }
            Main.sql.myReader.Close();
        }


        /*TreeNode treeNode;
        TreeNode treeNode1;
        TreeNode treeNode2;
        TreeNode treeNode3;
        TreeNode treeNode4;
        TreeNode treeNode5;
        TreeNode treeNode6;
        TreeNode treeNode7;
        TreeNode treeNode8;
        TreeNode treeNode9;
        TreeNode treeNode10;*/
        int g = 0;
        DataTable dataTable_for_poisk_datagridview = new DataTable();
/*        public void run_treeview()
        {
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


                sql1.myReader = sql.return_MySqlCommand("select queue_2,name from vacant where type_num = '2' and queue_1 = '1' ").ExecuteReader();
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
        }
        */
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

        /*public void run_treeview1()
        {
            try
            {
                Main.sql.myReader = Main.sql.return_MySqlCommand("select name,present_num from vacant where present_num = '0' ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    treeNode = new TreeNode(Main.sql.myReader.GetString("name")); // rasmli


                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 1;
                }
                Main.sql.myReader.Close();

                treeView.Nodes.Add(treeNode);


                Main.sql.myReader = Main.sql.return_MySqlCommand("select name,present_num from vacant where parent_num = '0' order by queue").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    g = 0;

                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select name from vacant where parent_num = '" + Main.sql.myReader.GetString("present_num") + "' ").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        g++;
                    }
                    Main.sql_2.myReader.Close();

                    if (g < 1)
                    {
                        treeNode = new TreeNode(Main.sql.myReader.GetString("name"));

                        treeView.Nodes.Add(treeNode);
                    }
                    else
                    {
                        treeNode = new TreeNode(Main.sql.myReader.GetString("name")); // rasmli
                        treeView.Nodes.Add(treeNode);
                    }

                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select name from vacant where parent_num = '" + Main.sql.myReader.GetString("present_num") + "' order by queue").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        treeNode.Nodes.Add(Main.sql_2.myReader.GetString("name"));
                    }
                    Main.sql_2.myReader.Close();


                    //      Console.WriteLine(refresh_treeview_value(sql.myReader.GetString("name")));
                }
                Main.sql.myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        */
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

        private void Shaxsiy_malumot_Load(object sender, EventArgs e)
        {
            run_main();
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
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
            string otpuska_m = "";
            string ornida_m = "";
            string str = "";
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];

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

            poisk_dataGridView.Rows.Clear();

                tugilgan_joyi_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                tugilgan_joyi_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT name FROM "+db_name+ ".spravochnik where type = 'tugilgan_joyi' and name != '' and !isnull(name)").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    col.Add(Main.sql.myReader.GetString("name"));
                }
                Main.sql.myReader.Close();
                tugilgan_joyi_textBox.AutoCompleteCustomSource = col;
                tugilgan_joyi_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                tugilgan_joyi_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.poisk_dataGridView.SelectionChanged -= new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
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
                      else if(Main.sql.myReader.GetString("type") == "dikret_h")
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
            this.poisk_dataGridView.SelectionChanged += new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("treeView_AfterSelect " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        string kod_num_global = "";
        string otdel_global = "";
        string doljnost_global = "";
         public void get_items_to_shaxsiyMalumotlar()
        {
            TreeNode node = treeView.SelectedNode;
            TreeNode root = FindRootNode(node);
            int index1 = root.Index;
            string[] tags = (string[])root.Tag;
            string db_name = tags[index1];
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    man.Checked = false;
                    woman.Checked = false;
                    image_path = "";
                    string parent_kod_num = "";
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select *, SUBSTRING(lichniy_num, 1, 1) as lich_letter, SUBSTRING(lichniy_num,POSITION('-' in lichniy_num) + 1, char_length(lichniy_num) - POSITION('-' in lichniy_num)) as lich_num from " + db_name + ".main where kod_num = '" + dgvRow.Cells[1].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        kod_num_global = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "0");
                        shxyj_textBox.Text = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        shaxsiy_textBox.Text = (Main.sql.myReader["lich_num"] != DBNull.Value ? Main.sql.myReader.GetString("lich_num") : "");
                        shaxsiy_raqam_harfi_comboBox.Text = (Main.sql.myReader["lich_letter"] != DBNull.Value ? Main.sql.myReader.GetString("lich_letter") : "");
                        familiyasi_textBox.Text = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        ismi_textBox.Text = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        otasining_ismi_textBox.Text = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        qizining_ismi_textBox.Text = (Main.sql.myReader["old_surname"] != DBNull.Value ? Main.sql.myReader.GetString("old_surname") : "");
                        iio_da_qachondan_textBox.Text = (Main.sql.myReader["date_organ"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_organ")).ToString("dd.MM.yyyy")) : "");

                        //tel_raqami_textBox.Text = (Main.sql.myReader["tel"] != DBNull.Value ? Main.sql.myReader.GetString("tel") : "");
                        millati_textBox.Text = (Main.sql.myReader["national"] != DBNull.Value ? Main.sql.myReader.GetString("national") : "");
                        nomenklatura.Text = (Main.sql.myReader["nameklatura"] != DBNull.Value ? Main.sql.myReader.GetString("nameklatura") : "");
                        stavka_comboBox.Text = (Main.sql.myReader["stavka"] != DBNull.Value ? Main.sql.myReader.GetString("stavka") : "");
                        parent_kod_num = (Main.sql.myReader["parent_kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("parent_kod_num") : "");
                        //korxona_string.Text = (Main.sql.myReader["korxona_string"] != DBNull.Value ? Main.sql.myReader.GetString("korxona_string") : "");
                        //lavozimDarajaTextBox.Text = (Main.sql.myReader["grade"] != DBNull.Value ? Main.sql.myReader.GetString("grade") : "");
                        Console.WriteLine(Main.sql.myReader.GetByte("gender"));

                        if (Main.sql.myReader.GetByte("gender").Equals(1))
                        {
                            man.Checked = true;
                        }
                        else if (Main.sql.myReader.GetByte("gender").Equals(2))
                        {
                            woman.Checked = true;
                        }
                        doljnost_global = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        otdel_global = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        lavozimDarajaTextBox.Text = (Main.sql.myReader["doljnost_darajasi"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost_darajasi") : "");
                        tugilgan_sanasi_textBox.Text = (Main.sql.myReader["date_birth"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_birth")).ToString("dd.MM.yyyy")) : "");
                        tugilgan_joyi_textBox.Text = (Main.sql.myReader["place_birth"] != DBNull.Value ? Main.sql.myReader.GetString("place_birth") : "");
                        unvon_comboBox.Text = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        ilmiy_unvoni_textBox.Text = (Main.sql.myReader["ilmiy_u"] != DBNull.Value ? Main.sql.myReader.GetString("ilmiy_u") : "");
                        ilmiy_darajasi_textBox.Text = (Main.sql.myReader["ilmiy_d"] != DBNull.Value ? Main.sql.myReader.GetString("ilmiy_d") : "");
                        lavozimi_ComboBox.Text = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        //otdel_ComboBox.Text = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        buyruq_sanasi_textBox.Text = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("dd.MM.yyyy")) : "");
                        qacondan_textBox.Text = (Main.sql.myReader["date_start2"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("dd.MM.yyyy")) : "");
                        buyruq_nomeri_textBox.Text = (Main.sql.myReader["prikaz_start"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_start") : "");
                        kim_tomonidan_textBox.Text = (Main.sql.myReader["from_him_prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("from_him_prikaz") : "");
                        tillar_textBox.Text = (Main.sql.myReader["tillar"] != DBNull.Value ? Main.sql.myReader.GetString("tillar") : "");
                        passport_start_date.Text = (Main.sql.myReader["pasport_date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("pasport_date_start")).ToString("dd.MM.yyyy")) : "");
                        passport_finish_date.Text = (Main.sql.myReader["pasport_date_finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("pasport_date_finish")).ToString("dd.MM.yyyy")) : "");
                        passport_seria.Text = (Main.sql.myReader["pasport_serial"] != DBNull.Value ? Main.sql.myReader.GetString("pasport_serial") : "");
                        passport_propiska.Text = (Main.sql.myReader["pasport_live"] != DBNull.Value ? Main.sql.myReader.GetString("pasport_live") : "");
                        tel_num.Text = (Main.sql.myReader["tel"] != DBNull.Value ? Main.sql.myReader.GetString("tel") : "");
                    }
                    Main.sql.myReader.Close();
                    if (parent_kod_num != "")
                    {
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".main where kod_num = '" + parent_kod_num + "' ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            xisobidan_checkbox.Checked = true;
                            if (button4.BackgroundImage.Tag.ToString() == "lock11")
                            {
                                xisobidan_comboBox.Enabled = false;
                            }
                            else
                            {
                                xisobidan_comboBox.Enabled = true;
                            }

                            xisobidan_comboBox.Text = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                            
                        }
                        Main.sql.myReader.Close();
                    }
                    else
                    {
                        xisobidan_checkbox.Checked = false;
                        xisobidan_comboBox.Enabled = false;
                    }
                    Main.sql_2.mydataAdapter = new MySqlDataAdapter(Main.sql_2.return_MySqlCommand("select image from " + db_name + ".main where kod_num = '" + dgvRow.Cells[1].Value + "' "));
                    DataTable table = new DataTable();
                    Main.sql_2.mydataAdapter.Fill(table);

                    byte[] bits = null;

                    if (table.Rows.Count > 0)
                    {
                        if (!Convert.IsDBNull(table.Rows[0][0]))
                        {
                            bits = (byte[])table.Rows[0][0];
                        }
                    }
                    Console.WriteLine("Bits: " + bits);
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
                    Main.sql_2.mydataAdapter.Dispose();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("get_items_to_shaxsiyMalumotlar " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

         public void get_items_to_oila_azolari()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                 TreeNode node = treeView.SelectedNode;
                 TreeNode root = FindRootNode(node);
                 int index1 = root.Index;
                 string[] tags = (string[])root.Tag;
                 string db_name = tags[index1];
                     this.oila_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.oila_dataGridView_CellValueChanged);

                     oila_dataGridView.Rows.Clear();
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".family where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         oila_dataGridView.Rows[oila_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         oila_dataGridView.Rows[oila_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                         oila_dataGridView.Rows[oila_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date_birth"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_birth")).ToString("dd.MM.yyyy")) : null);
                         oila_dataGridView.Rows[oila_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["qarindosh_d"] != DBNull.Value ? Main.sql.myReader.GetString("qarindosh_d") : "");
                         oila_dataGridView.Rows[oila_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["place_birth"] != DBNull.Value ? Main.sql.myReader.GetString("place_birth") : "");
                         oila_dataGridView.Rows[oila_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["work_place"] != DBNull.Value ? Main.sql.myReader.GetString("work_place") : "");
                         oila_dataGridView.Rows[oila_dataGridView.Rows.Count - 2].Cells[6].Value = (Main.sql.myReader["address"] != DBNull.Value ? Main.sql.myReader.GetString("address") : "");
                     }
                     Main.sql.myReader.Close();

                     this.oila_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.oila_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_oila_azolari " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_oila_unvon()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.unvon_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.unvon_dataGridView_CellValueChanged);
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];
                     unvon_dataGridView.Rows.Clear();
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select id, LOWER(zvanie) as zvanie, date, soni, from_him from " + db_name + ".unvon where kod_num = '" + kod_num_global + "' order by date asc ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                        string zvanie = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie").Replace("-", " ") : "");
                        zvanie = Regex.Replace(zvanie, " +", " ");
                        if (zvanie[zvanie.Length - 1] == ' ')
                        {
                            zvanie = zvanie.Substring(0, zvanie.Length - 1);
                        }
                        if (zvanie[0] == ' ')
                        {
                            zvanie = zvanie.Substring(1, zvanie.Length - 1);
                        }
                        unvon_dataGridView.Rows[unvon_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         unvon_dataGridView.Rows[unvon_dataGridView.Rows.Count - 2].Cells[1].Value = zvanie;
                         unvon_dataGridView.Rows[unvon_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                         unvon_dataGridView.Rows[unvon_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["soni"] != DBNull.Value ? Main.sql.myReader.GetString("soni") : "");
                         unvon_dataGridView.Rows[unvon_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["from_him"] != DBNull.Value ? Main.sql.myReader.GetString("from_him") : "");
                     }
                     Main.sql.myReader.Close();

                     this.unvon_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.unvon_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_oila_unvon " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         int year = 0;
         int month = 0;
         int day = 0;
         public void get_items_to_mehnat()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.mehnat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mehnat_dataGridView_CellValueChanged);

                     mehnat_dataGridView.Rows.Clear();
                     year = 0;
                     month = 0;
                     day = 0;
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];

                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".trudovoy where kod_num = '" + kod_num_global + "' and prikaz_date is not null and date_start is not null and date_finish is not null order by date_start asc").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         DateDifference dateDifference = new DateDifference(Main.sql.myReader.GetDateTime("date_start"), Main.sql.myReader.GetDateTime("date_finish"));
                         
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("dd.MM.yyyy")) : null);
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date_finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_finish")).ToString("dd.MM.yyyy")) : null);
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[3].Value = (dateDifference.ToString());
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["work_place"] != DBNull.Value ? Main.sql.myReader.GetString("work_place") : "");
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[6].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[7].Value = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("dd.MM.yyyy")) : null);
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[8].Value = (Main.sql.myReader["from_him"] != DBNull.Value ? Main.sql.myReader.GetString("from_him") : "");
                         mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[9].Value = (Main.sql.myReader["for_cal"] != DBNull.Value ? Main.sql.myReader.GetString("for_cal") : "");
                        string for_cal = (Main.sql.myReader["for_cal"] != DBNull.Value ? Main.sql.myReader.GetString("for_cal") : "");
                        if (for_cal == "True")
                        {
                            year = year + dateDifference.Years;
                            month = month + dateDifference.Months;
                            day = day + dateDifference.Days;
                        }
                     }
                     Main.sql.myReader.Close();

                     Main.sql.myReader = Main.sql.return_MySqlCommand("select date_start,date_start2,kod_num,otdel,doljnost,otdel,prikaz_start,from_him_prikaz from " + db_name + ".main where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        DateDifference dateDifference = new DateDifference(Main.sql.myReader.GetDateTime("date_start2"), DateTime.Today);

                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Add()].Cells[0].Value = ("0");
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["date_start2"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("dd.MM.yyyy")) : null);
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[2].Value = ("ҳозиргача");
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[3].Value = (dateDifference.ToString());
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[6].Value = (Main.sql.myReader["prikaz_start"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_start") : "");
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[7].Value = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("dd.MM.yyyy")) : null);
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[8].Value = (Main.sql.myReader["from_him_prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("from_him_prikaz") : "");
                        mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[9].Value = (true);

                        year = year + dateDifference.Years;
                        month = month + dateDifference.Months;
                        day = day + dateDifference.Days;
                    }
                     Main.sql.myReader.Close();

                     year = year + (month / 12);
                    month = month % 12;
                    month = month + (day / 30);
                   

                    if (month >= 12)
                    {
                        year++;
                        month = month % 12;
                    }

                    umumiy_MF_label.Text = "Умумий м.ф. даври : " + Convert.ToString(year) + " йил " + Convert.ToString(month % 12) + " ой " + Convert.ToString(day % 30) + " кун.";
                    this.mehnat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mehnat_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_mehnat " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_malumoti()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                 TreeNode node = treeView.SelectedNode;
                 TreeNode root = FindRootNode(node);
                 int index1 = root.Index;
                 string[] tags = (string[])root.Tag;
                 string db_name = tags[index1];
                     this.malumoti_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.malumoti_dataGridView_CellValueChanged);

                     malumoti_dataGridView.Rows.Clear();
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".study where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         malumoti_dataGridView.Rows[malumoti_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         malumoti_dataGridView.Rows[malumoti_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["type_study"] != DBNull.Value ? Main.sql.myReader.GetString("type_study") : "");
                         malumoti_dataGridView.Rows[malumoti_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date_finish"] != DBNull.Value ? Main.sql.myReader.GetString("date_finish") : "");
                         malumoti_dataGridView.Rows[malumoti_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["place"] != DBNull.Value ? Main.sql.myReader.GetString("place") : "");
                         malumoti_dataGridView.Rows[malumoti_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["profeccional"] != DBNull.Value ? Main.sql.myReader.GetString("profeccional") : "");
                         malumoti_dataGridView.Rows[malumoti_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["dip_serial"] != DBNull.Value ? Main.sql.myReader.GetString("dip_serial") : "");
                     }
                     Main.sql.myReader.Close();

                     this.malumoti_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.malumoti_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_malumoti " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_tatil()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                 TreeNode node = treeView.SelectedNode;
                 TreeNode root = FindRootNode(node);
                 int index1 = root.Index;
                 string[] tags = (string[])root.Tag;
                 string db_name = tags[index1];
                     this.tatil_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.tatil_dataGridView_CellValueChanged);

                     tatil_dataGridView.Rows.Clear();
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".otpuska where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("dd.MM.yyyy")) : null);
                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date_finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_finish")).ToString("dd.MM.yyyy")) : null);
                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["type_otpusk"] != DBNull.Value ? Main.sql.myReader.GetString("type_otpusk") : "");
                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("dd.MM.yyyy")) : null);
                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 2].Cells[6].Value = (Main.sql.myReader["prikaz_from_him"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_from_him") : "");
                         tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 2].Cells[7].Value = (Main.sql.myReader["tashxis"] != DBNull.Value ? Main.sql.myReader.GetString("tashxis") : "");
                         
                     }
                     Main.sql.myReader.Close();

                     this.tatil_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tatil_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_tatil " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_attestatsiya()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                 TreeNode node = treeView.SelectedNode;
                 TreeNode root = FindRootNode(node);
                 int index1 = root.Index;
                 string[] tags = (string[])root.Tag;
                 string db_name = tags[index1];
                     this.attestatsiya_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.attestatsiya_dataGridView_CellValueChanged);

                     attestatsiya_dataGridView.Rows.Clear();
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".atestat where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         attestatsiya_dataGridView.Rows[attestatsiya_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         attestatsiya_dataGridView.Rows[attestatsiya_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                         attestatsiya_dataGridView.Rows[attestatsiya_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["protokol_num"] != DBNull.Value ? Main.sql.myReader.GetString("protokol_num") : "");
                         attestatsiya_dataGridView.Rows[attestatsiya_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz") : "");
                         
                     }
                     Main.sql.myReader.Close();

                     this.attestatsiya_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.attestatsiya_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_attestatsiya " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_mt()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.mt_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGridView_CellValueChanged);

                     mt_dataGridView.Rows.Clear();
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".mt where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         mt_dataGridView.Rows[mt_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         mt_dataGridView.Rows[mt_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                         mt_dataGridView.Rows[mt_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["da_net"] != DBNull.Value ? Main.sql.myReader.GetString("da_net") : "");
                         mt_dataGridView.Rows[mt_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["infor"] != DBNull.Value ? Main.sql.myReader.GetString("infor") : "");

                     }
                     Main.sql.myReader.Close();

                     this.mt_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_mt " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_intizomiy_jazo()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.intizomiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.intizomiy_dataGridView_CellValueChanged);

                     intizomiy_dataGridView.Rows.Clear();
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".intizomiy where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         intizomiy_dataGridView.Rows[intizomiy_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                         intizomiy_dataGridView.Rows[intizomiy_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                         intizomiy_dataGridView.Rows[intizomiy_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                         intizomiy_dataGridView.Rows[intizomiy_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["type_jazo"] != DBNull.Value ? Main.sql.myReader.GetString("type_jazo") : "");
                         intizomiy_dataGridView.Rows[intizomiy_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["malumot"] != DBNull.Value ? Main.sql.myReader.GetString("malumot") : "");
                     }
                     Main.sql.myReader.Close();

                     this.intizomiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.intizomiy_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_intizomiy_jazo " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_ragbat()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.ragbat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.ragbat_dataGridView_CellValueChanged);

                     ragbat_dataGridView.Rows.Clear();
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".nagrajdenie where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         ragbat_dataGridView.Rows[ragbat_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         ragbat_dataGridView.Rows[ragbat_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                         ragbat_dataGridView.Rows[ragbat_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                         ragbat_dataGridView.Rows[ragbat_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["status"] != DBNull.Value ? Main.sql.myReader.GetString("status") : "");
                     }
                     Main.sql.myReader.Close();

                     this.ragbat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ragbat_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_ragbat " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_davlat()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.davlat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);

                     davlat_dataGridView.Rows.Clear();
                 
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];

                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".davlat where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         davlat_dataGridView.Rows[davlat_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         davlat_dataGridView.Rows[davlat_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                         davlat_dataGridView.Rows[davlat_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
                        davlat_dataGridView.Rows[davlat_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["mukofot_nomi"] != DBNull.Value ? (Main.sql.myReader.GetString("mukofot_nomi")) : "");
                    }
                     Main.sql.myReader.Close();

                     this.davlat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_davlat " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_xarbiy()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.xarbiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);

                     xarbiy_dataGridView.Rows.Clear();
                 
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];

                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".xarbiy where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("start")).ToString("dd.MM.yyyy")) : null);
                         xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("finish")).ToString("dd.MM.yyyy")) : null);
                         xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["chast_num"] != DBNull.Value ? Main.sql.myReader.GetString("chast_num") : "");
                         xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                         xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["x_g_serial"] != DBNull.Value ? Main.sql.myReader.GetString("x_g_serial") : "");
                        xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[6].Value = (Main.sql.myReader["date_given"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_given")).ToString("dd.MM.yyyy")) : null);
                        xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[7].Value = (Main.sql.myReader["given_from"] != DBNull.Value ? Main.sql.myReader.GetString("given_from") : "");
                        xarbiy_dataGridView.Rows[xarbiy_dataGridView.Rows.Count - 2].Cells[8].Value = (Main.sql.myReader["maxsus"] != DBNull.Value ? Main.sql.myReader.GetString("maxsus") : "");

                     }
                     Main.sql.myReader.Close();

                     this.xarbiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_xarbiy " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_xizmat()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.xizmat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xizmat_dataGridView_CellValueChanged);

                     xizmat_dataGridView.Rows.Clear();

                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".xizmat where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         xizmat_dataGridView.Rows[xizmat_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         xizmat_dataGridView.Rows[xizmat_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("start")).ToString("dd.MM.yyyy")) : null);
                         xizmat_dataGridView.Rows[xizmat_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("finish")).ToString("dd.MM.yyyy")) : null);
                         xizmat_dataGridView.Rows[xizmat_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["sabab"] != DBNull.Value ? Main.sql.myReader.GetString("sabab") : "");
                         xizmat_dataGridView.Rows[xizmat_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["nima_maqsadda"] != DBNull.Value ? Main.sql.myReader.GetString("nima_maqsadda") : "");
                         xizmat_dataGridView.Rows[xizmat_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["qayerga"] != DBNull.Value ? Main.sql.myReader.GetString("qayerga") : "");

                     }
                     Main.sql.myReader.Close();

                     this.xizmat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xizmat_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_xizmat " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_toifa()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                 TreeNode node = treeView.SelectedNode;
                 TreeNode root = FindRootNode(node);
                 int index1 = root.Index;
                 string[] tags = (string[])root.Tag;
                 string db_name = tags[index1];
                     this.toifa_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);

                     toifa_dataGridView.Rows.Clear();
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".toifa where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         toifa_dataGridView.Rows[toifa_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         toifa_dataGridView.Rows[toifa_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                         toifa_dataGridView.Rows[toifa_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("dd.MM.yyyy")) : null);
                         toifa_dataGridView.Rows[toifa_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["type_toifa"] != DBNull.Value ? Main.sql.myReader.GetString("type_toifa") : "");
                        toifa_dataGridView.Rows[toifa_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["data_finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("data_finish")).ToString("dd.MM.yyyy")) : null);
                        toifa_dataGridView.Rows[toifa_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["prikaz_from"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_from") : "");
                    }
                     Main.sql.myReader.Close();

                     this.toifa_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_toifa " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

        public void get_items_to_xchk()
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    this.xchk_datagridview.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xchk_datagridview_CellValueChanged);

                    xchk_datagridview.Rows.Clear();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".xchk_malumot where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        xchk_datagridview.Rows[xchk_datagridview.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                        xchk_datagridview.Rows[xchk_datagridview.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        xchk_datagridview.Rows[xchk_datagridview.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        xchk_datagridview.Rows[xchk_datagridview.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["date_from"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_from")).ToString("dd.MM.yyyy")) : null);
                        xchk_datagridview.Rows[xchk_datagridview.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["date_to"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_to")).ToString("dd.MM.yyyy")) : null);
                        xchk_datagridview.Rows[xchk_datagridview.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["where_to"] != DBNull.Value ? Main.sql.myReader.GetString("where_to") : "");
                        xchk_datagridview.Rows[xchk_datagridview.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["for_what"] != DBNull.Value ? Main.sql.myReader.GetString("for_what") : "");
                    }
                    Main.sql.myReader.Close();

                    this.xchk_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xchk_datagridview_CellValueChanged);
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("get_items_to_xchk " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        public void get_items_to_maxfiy()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                 TreeNode node = treeView.SelectedNode;
                 TreeNode root = FindRootNode(node);
                 int index1 = root.Index;
                 string[] tags = (string[])root.Tag;
                 string db_name = tags[index1];
                     this.maxfiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.maxfiy_dataGridView_CellValueChanged);

                     maxfiy_dataGridView.Rows.Clear();
                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".ruxsatnoma where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         maxfiy_dataGridView.Rows[maxfiy_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         maxfiy_dataGridView.Rows[maxfiy_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                         maxfiy_dataGridView.Rows[maxfiy_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("dd.MM.yyyy")) : null);
                         maxfiy_dataGridView.Rows[maxfiy_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["type_ruxsat"] != DBNull.Value ? Main.sql.myReader.GetString("type_ruxsat") : "");
                     }
                     Main.sql.myReader.Close();

                     this.maxfiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.maxfiy_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_maxfiy " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }

         public void get_items_to_guvohnoma()
         {
             if (poisk_dataGridView.SelectedCells.Count > 0)
             {
                 try
                 {
                     this.guvohnoma_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guvohnoma_dataGridView_CellValueChanged);

                     guvohnoma_dataGridView.Rows.Clear();
                 
                     TreeNode node = treeView.SelectedNode;
                     TreeNode root = FindRootNode(node);
                     int index1 = root.Index;
                     string[] tags = (string[])root.Tag;
                     string db_name = tags[index1];

                     Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".xizmat_g where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         guvohnoma_dataGridView.Rows[guvohnoma_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                         guvohnoma_dataGridView.Rows[guvohnoma_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("start")).ToString("dd.MM.yyyy")) : null);
                         guvohnoma_dataGridView.Rows[guvohnoma_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("finish")).ToString("dd.MM.yyyy")) : null);
                         guvohnoma_dataGridView.Rows[guvohnoma_dataGridView.Rows.Count - 2].Cells[3].Value = (Main.sql.myReader["serial"] != DBNull.Value ? Main.sql.myReader.GetString("serial") : ""); 
                         
                     }
                     Main.sql.myReader.Close();

                     this.guvohnoma_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.guvohnoma_dataGridView_CellValueChanged);
                 }
                 catch (Exception ex)
                 {
                     Main.sql.myReader.Close();
                     MessageBox.Show("get_items_to_guvohnoma " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 }
             }
         }


        public void get_items_to_prava()
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    string prava_all = "";
                    prava_type_ComboBox.Text = "";
                    prava_type_ComboBox.CheckBoxItems.Clear();
                    string[] prava_labels = new string[] { "ЙЎҚ", "A", "B", "C", "D", "E" };
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select prava_type, prava_talon from " + db_name + ".main where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        prava_all = Main.sql.myReader["prava_type"] != DBNull.Value ? Main.sql.myReader.GetString("prava_type") : "";
                        talon_num.Text = Main.sql.myReader["prava_talon"] != DBNull.Value ? Main.sql.myReader.GetString("prava_talon") : "";

                    }
                    Main.sql.myReader.Close();
                    prava_all = prava_all.Replace("[", "").Replace("]", "");
                    if (prava_all != "")
                    {
                        string[] pravas = prava_all.Split(',').ToArray();
                        foreach (var item in pravas)
                        {
                            int index = item != null ? Int32.Parse(item) : 0;
                            string label_name = prava_labels[index];
                            prava_type_ComboBox.CheckBoxItems[label_name].CheckState = CheckState.Checked;
                        }
                    }
                  
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("get_items_to_prava " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void poisk_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                get_items_to_shaxsiyMalumotlar();
                get_items_to_oila_azolari();
                get_items_to_oila_unvon();
                get_items_to_mehnat();
                get_items_to_malumoti();
                get_items_to_tatil();
                get_items_to_attestatsiya();
                get_items_to_mt();
                get_items_to_intizomiy_jazo();
                get_items_to_ragbat();
                get_items_to_davlat();
                get_items_to_xarbiy();
                get_items_to_xizmat();
                get_items_to_toifa();
                get_items_to_maxfiy();
                get_items_to_guvohnoma();
                get_items_to_prava();
                get_items_to_xchk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("poisk_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        string image_path = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    image_path = open.FileName;
                    pictureBox1.Image = new Bitmap(open.FileName);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("button1_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

            popup.TitleText = "Обновлено";
            // popup.ContentText = fio;

            popup.TitleFont = new Font("Times New Roman", 12f);
            popup.Popup();
        }

        FileStream fs;
        BinaryReader br;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";
                if (man.Checked)
                {
                    gender = "1";
                }
                else if (woman.Checked)
                {
                    gender = "2";
                }
                else
                {
                    gender = "0";
                }
                DateTime data_qachondan;
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                if (DateTime.TryParse(qacondan_textBox.Text, out data_qachondan))
                {
                    if (doljnost_global != lavozimi_ComboBox.Text)
                    {
                        DialogResult dialogResult = MessageBox.Show("Эски лавозимни мехнат фаолиятига рўйҳатга олишги розимисиз?", "Янгилаш", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string data_fin = DateTime.Parse(qacondan_textBox.Text).ToString("yyyy-MM-dd");
                            var insert = "insert into " + db_name + ".trudovoy(register_num, kod_num, work_place, prikaz_date, prikaz_num, from_him, date_start, doljnost, date_finish) " +
                            "SELECT register_num, kod_num, otdel, date_start, prikaz_start, from_him_prikaz, date_start, doljnost, '" + data_fin + "' FROM " + db_name + ".main " +
                            "where " + db_name + ".main.kod_num = " + kod_num_global + "";
                            Main.sql.return_MySqlCommand(insert).ExecuteNonQuery();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                        
                    }
                    var update = "update " + db_name + ".main set " +
                        "register_num = '" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                        "lichniy_num = '" + (shaxsiy_raqam_harfi_comboBox.Text.ToString() != "" ? shaxsiy_raqam_harfi_comboBox.Text.ToString() : "") + "-" + (
                        shaxsiy_textBox.Text.ToString() != "" ? shaxsiy_textBox.Text.ToString() : "") + "', " +
                        "surname = '" + (familiyasi_textBox.Text.ToString() != "" ? familiyasi_textBox.Text.ToString() : "") + "', " +
                        "name = '" + (ismi_textBox.Text.ToString() != "" ? ismi_textBox.Text.ToString() : "") + "', " +
                        "fath_name = '" + (otasining_ismi_textBox.Text.ToString() != "" ? otasining_ismi_textBox.Text.ToString() : "") + "', " +
                        "old_surname = '" + (qizining_ismi_textBox.Text.ToString() != "" ? qizining_ismi_textBox.Text.ToString() : "") + "', " +
                        "date_organ = " + (iio_da_qachondan_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(iio_da_qachondan_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        "tel = '" + (tel_num.Text.ToString() != "" ? tel_num.Text.ToString() : "") + "', " +
                        "national = '" + (millati_textBox.Text.ToString() != "" ? millati_textBox.Text.ToString() : "") + "', " +
                        "gender = '" + (gender) + "', " +
                        "nameklatura = '" + (nomenklatura.Text.ToString() != "" ? nomenklatura.Text.ToString() : "") + "', " +
                        //"korxona_string = '" + (korxona_string.Text.ToString() != "" ? korxona_string.Text.ToString() : "") + "', " +
                        "stavka = '" + (stavka_comboBox.Text.ToString() != "" ? stavka_comboBox.Text.ToString() : "") + "', " +
                        //"grade = '" + (grade_comboBox.Text.ToString() != "" ? grade_comboBox.Text.ToString() : "") + "', " +
                        "doljnost_darajasi = '" + (lavozimDarajaTextBox.Text.ToString() != "" ? lavozimDarajaTextBox.Text.ToString() : "") + "', " +
                        "date_birth = " + (tugilgan_sanasi_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(tugilgan_sanasi_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        "place_birth = '" + (tugilgan_joyi_textBox.Text.ToString() != "" ? tugilgan_joyi_textBox.Text.ToString() : "") + "', " +
                        "zvanie = '" + (unvon_comboBox.Text.ToString() != "" ? unvon_comboBox.Text.ToString() : "") + "', " +
                        "ilmiy_u = '" + (ilmiy_unvoni_textBox.Text.ToString() != "" ? ilmiy_unvoni_textBox.Text.ToString() : "") + "', " +
                        "ilmiy_d = '" + (ilmiy_darajasi_textBox.Text.ToString() != "" ? ilmiy_darajasi_textBox.Text.ToString() : "") + "', " +
                        "doljnost = '" + (lavozimi_ComboBox.Text.ToString() != "" ? lavozimi_ComboBox.Text.ToString() : "") + "', " +
                        //"otdel = '" + (otdel_ComboBox.Text.ToString() != "" ? otdel_ComboBox.Text.ToString() : "") + "', " +
                        "date_start = " + (buyruq_sanasi_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(buyruq_sanasi_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        "date_start2 = " + (qacondan_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(qacondan_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        "prikaz_start = '" + (buyruq_nomeri_textBox.Text.ToString() != "" ? buyruq_nomeri_textBox.Text.ToString() : "") + "', " +
                        "from_him_prikaz = '" + (kim_tomonidan_textBox.Text.ToString() != "" ? kim_tomonidan_textBox.Text.ToString() : "") + "', " +
                        "tillar = '" + (tillar_textBox.Text.ToString() != "" ? tillar_textBox.Text.ToString() : "") + "', " +
                        "pasport_date_start = " + (passport_start_date.Text.ToString() != "" ? ("'" + DateTime.Parse(passport_start_date.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        "pasport_date_finish = " + (passport_finish_date.Text.ToString() != "" ? ("'" + DateTime.Parse(passport_finish_date.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                        "pasport_serial = '" + (passport_seria.Text.ToString() != "" ? passport_seria.Text.ToString() : "") + "', " +
                        "pasport_live = '" + (passport_propiska.Text.ToString() != "" ? passport_propiska.Text.ToString() : "") + "' " +

                        " where kod_num = '" + kod_num_global + "' ";
                    Main.sql.return_MySqlCommand(update).ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Қачондан дата хато");
                }
                if(image_path != "")
                {
                    string FileName = image_path;
                    byte[] ImageData;
                    fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    MySqlCommand cmd;
                    string CmdString = "";
                    CmdString = "update " + db_name + ".main set image = @Image where kod_num = '" + kod_num_global + "' ";
                    cmd = new MySqlCommand(CmdString,Main.sql.myConn);
                    cmd.Parameters.Add("@Image", MySqlDbType.LongBlob);
                    cmd.Parameters["@Image"].Value = ImageData;
                    cmd.ExecuteNonQuery();
                }

                /*Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Шахсий маьлумотлар','" + kod_num_global + " / " + 
                    (familiyasi_textBox.Text+" "+ismi_textBox.Text+" "+otasining_ismi_textBox.Text) + " нинг шахсий маълумотлари ўзгартирилди','" + db_name + "')").ExecuteNonQuery();
                    */
                run_alert(familiyasi_textBox.Text + " " + ismi_textBox.Text + " " + otasining_ismi_textBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("button2_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void iio_da_qachondan_textBox_Validated(object sender, EventArgs e)
        {
            convert_date_main_function((TextBox)sender);
        }

        public string convert_date_main_function_INDATAGRIDVIEW(string sample)
        {
            try
            {
                sample = Regex.Replace(sample, "[^0-9.]", "");
                string[] strArray = sample.Replace(',', '.').Split('.');
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
                    sample = s1 + "." + s2 + "." + s3;
                }
                else
                    sample = null;
            }
            catch (Exception ex)
            {
                sample = null;
                Console.WriteLine(ex.Message);
            }


            return sample;
        }

        private void oila_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (oila_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = oila_dataGridView.CurrentRow;

                    this.oila_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.oila_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }

                    this.oila_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.oila_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".family (register_num,kod_num,fio,date_birth,qarindosh_d,place_birth,work_place,address) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " "  + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            " '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                            " '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.oila_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.oila_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".family").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            oila_dataGridView.Rows[oila_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.oila_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.oila_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".family set " +
                            " register_num = '" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " fio = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " date_birth = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " qarindosh_d = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " place_birth = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            " work_place = '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                            " address = '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("oila_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void unvon_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (unvon_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                    DataGridViewRow dgvRow = unvon_dataGridView.CurrentRow;

                    this.unvon_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.unvon_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }

                    this.unvon_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.unvon_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".unvon (register_num,kod_num,zvanie,date,soni,from_him) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "' " +
                            " )").ExecuteNonQuery();

                        Main.sql.return_MySqlCommand("update " + db_name + ".main set zvanie = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "' where kod_num = '" + kod_num_global + "'").ExecuteNonQuery();
                        this.unvon_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.unvon_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".unvon").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            unvon_dataGridView.Rows[unvon_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.unvon_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.unvon_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".unvon set " +
                            " register_num = '" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " zvanie = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " soni = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " from_him = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("unvon_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void mehnat_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (mehnat_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = mehnat_dataGridView.CurrentRow;

                    this.mehnat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mehnat_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        dgvRow.Cells[7].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[7].Value.ToString());
                    }


                    this.mehnat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mehnat_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,date_start,date_finish,work_place,doljnost,prikaz_num,prikaz_date,from_him,for_cal) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            " '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                            " '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "', " +
                            " " + (dgvRow.Cells[7].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[7].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[8].Value != null ? dgvRow.Cells[8].Value : "") + "', " +
                            " '" + (dgvRow.Cells[9].Value != null ? "1" : "0") + "' " +

                            " )").ExecuteNonQuery();


                        this.mehnat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mehnat_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".trudovoy").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            mehnat_dataGridView.Rows[mehnat_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.mehnat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mehnat_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        DateTime start = DateTime.Now;
                        DateTime finish = DateTime.Now;
                        if (dgvRow.Cells[2].Value.ToString() != "ҳозиргача")
                        {
                            if (DateTime.TryParse(dgvRow.Cells[1].Value.ToString(), out start) && DateTime.TryParse(dgvRow.Cells[2].Value.ToString(), out finish))
                            {
                                Main.sql.return_MySqlCommand("update " + db_name + ".trudovoy set " +
                                    "date_start = " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                                    "date_finish = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                                    "work_place = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                                    "doljnost = '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                                    "prikaz_num = '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "', " +
                                    "prikaz_date = " + (dgvRow.Cells[7].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[7].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                                    "from_him = '" + (dgvRow.Cells[8].Value != null ? dgvRow.Cells[8].Value : "") + "', " +
                                    "for_cal = '" + (Convert.ToBoolean(dgvRow.Cells[9].Value) == true ? "1" : "0") + "' " +


                                    " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ҳозир иш жойи маълумотлари шахсий маълумот бандида ўзгатирилиши мумкин");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("mehnat_dataGridView " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void malumoti_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (malumoti_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = malumoti_dataGridView.CurrentRow;

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".study (register_num,kod_num,type_study,date_finish,place,profeccional,dip_serial) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            " '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.malumoti_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.malumoti_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".study").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            malumoti_dataGridView.Rows[malumoti_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.malumoti_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.malumoti_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".study set " +
                            "type_study = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            "date_finish = '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            "place = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            "profeccional = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            "dip_serial = '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("malumoti_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void tatil_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tatil_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = tatil_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.tatil_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.tatil_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }
                    else if (e.ColumnIndex == 5)
                    {
                        dgvRow.Cells[5].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[5].Value.ToString());
                    }

                    this.tatil_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tatil_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".otpuska (register_num,kod_num,date_start,date_finish,type_otpusk,prikaz_num,prikaz_date,prikaz_from_him,tashxis) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            " " + (dgvRow.Cells[5].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[5].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "', " +
                            " '" + (dgvRow.Cells[7].Value != null ? dgvRow.Cells[7].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.tatil_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.tatil_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".otpuska").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            tatil_dataGridView.Rows[tatil_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.tatil_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tatil_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".otpuska set " +
                            "date_start = " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "date_finish = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "type_otpusk = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            "prikaz_num = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            "prikaz_date = " + (dgvRow.Cells[5].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[5].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "prikaz_from_him = '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "', " +
                            "tashxis = '" + (dgvRow.Cells[7].Value != null ? dgvRow.Cells[7].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("tatil_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void attestatsiya_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (attestatsiya_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = attestatsiya_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.attestatsiya_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.attestatsiya_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }

                    this.attestatsiya_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.attestatsiya_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".atestat (register_num,kod_num,date,protokol_num,prikaz) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.attestatsiya_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.attestatsiya_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".atestat").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            attestatsiya_dataGridView.Rows[attestatsiya_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.attestatsiya_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.attestatsiya_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".atestat set " +
                            "date = " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "protokol_num = '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            "prikaz = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("attestatsiya_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void mt_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (mt_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = mt_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.mt_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }

                    this.mt_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".mt (register_num,kod_num,date,da_net,infor) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.mt_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".mt").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            mt_dataGridView.Rows[mt_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.mt_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".mt set " +
                            "date = " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "da_net = '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            "infor = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("mt_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void intizomiy_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (intizomiy_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = intizomiy_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.intizomiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.intizomiy_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }

                    this.intizomiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.intizomiy_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".intizomiy (register_num,kod_num,prikaz_num,date,type_jazo,malumot) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.intizomiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.intizomiy_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".intizomiy").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            intizomiy_dataGridView.Rows[intizomiy_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.intizomiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.intizomiy_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".intizomiy set " +
                            " prikaz_num = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " type_jazo = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " malumot = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "' " +
                            
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("intizomiy_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void ragbat_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ragbat_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = ragbat_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.ragbat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.ragbat_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }

                    this.ragbat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ragbat_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".nagrajdenie (register_num,kod_num,prikaz_num,date,status) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.ragbat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.ragbat_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".nagrajdenie").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            ragbat_dataGridView.Rows[ragbat_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.ragbat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ragbat_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".nagrajdenie set " +
                            "prikaz_num = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            "date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "status = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +

                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("ragbat_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void davlat_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (davlat_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = davlat_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.davlat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }

                    this.davlat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".davlat (register_num,kod_num,prikaz_num,date, mukofot_nomi) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.davlat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".davlat").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            davlat_dataGridView.Rows[davlat_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.davlat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".davlat set " +
                            "prikaz_num = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            "date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "mukofot_nomi = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("davlat_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void xarbiy_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (xarbiy_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = xarbiy_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.xarbiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }
                    else if (e.ColumnIndex == 6)
                    {
                        dgvRow.Cells[6].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[6].Value.ToString());
                    }

                    this.xarbiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".xarbiy (register_num,kod_num,start,finish,chast_num,doljnost,x_g_serial, date_given, given_from, maxsus) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            " '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                           " " + (dgvRow.Cells[6].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[6].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[7].Value != null ? dgvRow.Cells[7].Value : "") + "', " +                           
                            " '" + (dgvRow.Cells[8].Value != null ? "1" : "0") + "' " +

                            " )").ExecuteNonQuery();


                        this.xarbiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".xarbiy").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            xarbiy_dataGridView.Rows[xarbiy_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.xarbiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".xarbiy set " +
                            "start = " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "finish = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "chast_num = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            "doljnost = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            "x_g_serial = '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                             "date_given = " + (dgvRow.Cells[6].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[6].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "given_from = '" + (dgvRow.Cells[7].Value != null ? dgvRow.Cells[7].Value : "") + "', " +                           
                            "maxsus = '" + (Convert.ToBoolean(dgvRow.Cells[8].Value) == true ? "1" : "0") + "' " +


                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("xarbiy_dataGridView " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void xizmat_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (xizmat_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = xizmat_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.xizmat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xizmat_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }


                    this.xizmat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xizmat_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".xizmat (register_num,kod_num,start,finish,sabab,nima_maqsadda,qayerga) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            " '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            " '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "' " +

                            " )").ExecuteNonQuery();


                        this.xizmat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xizmat_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".xizmat").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            xizmat_dataGridView.Rows[xizmat_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.xizmat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xizmat_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".xizmat set " +
                            "start = " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "finish = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "sabab = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                            "nima_maqsadda = '" + (dgvRow.Cells[4].Value != null ? dgvRow.Cells[4].Value : "") + "', " +
                            "qayerga = '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "' " +

                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("xizmat_dataGridView " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void toifa_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (toifa_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = toifa_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.toifa_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }


                    this.toifa_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".toifa (kod_num,prikaz_num,prikaz_date,type_toifa, data_finish, prikaz_from) " +
                            " values('" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                             " " + (dgvRow.Cells[4].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[4].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "' " +

                            " )").ExecuteNonQuery();


                        this.toifa_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".toifa").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            toifa_dataGridView.Rows[toifa_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.toifa_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        var sel = "update " + db_name + ".toifa set " +
                              "prikaz_num = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                              "prikaz_date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                              "type_toifa = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "', " +
                              "data_finish = " + (dgvRow.Cells[4].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[4].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                              "prikaz_from = '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "' " +

                             " where id = '" + dgvRow.Cells[0].Value + "' ";
                        Main.sql.return_MySqlCommand(sel).ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("toifa_dataGridView " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void maxfiy_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (maxfiy_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = maxfiy_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.maxfiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.maxfiy_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }


                    this.maxfiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.maxfiy_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".ruxsatnoma (register_num,kod_num,prikaz_num,prikaz_date,type_ruxsat) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +

                            " )").ExecuteNonQuery();


                        this.maxfiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.maxfiy_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".ruxsatnoma").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            maxfiy_dataGridView.Rows[maxfiy_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.maxfiy_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.maxfiy_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".ruxsatnoma set " +
                             "prikaz_num = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                             "prikaz_date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                             "type_ruxsat = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +

                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("maxfiy_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void guvohnoma_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (guvohnoma_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = guvohnoma_dataGridView.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.guvohnoma_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guvohnoma_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }


                    this.guvohnoma_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.guvohnoma_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".xizmat_g (register_num,kod_num,start,finish,serial) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +

                            " )").ExecuteNonQuery();


                        this.guvohnoma_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guvohnoma_dataGridView_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".xizmat_g").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            guvohnoma_dataGridView.Rows[guvohnoma_dataGridView.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.guvohnoma_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.guvohnoma_dataGridView_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".xizmat_g set " +
                             "start = " + (dgvRow.Cells[1].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "finish = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "serial = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +

                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("guvohnoma_dataGridView_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void oila_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {

                if (oila_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in oila_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".family where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("oila_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void unvon_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (unvon_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow dgvRow = unvon_dataGridView.CurrentRow;
                        Main.sql.return_MySqlCommand("delete from " + db_name + ".unvon where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("unvon_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void mehnat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {

                if (mehnat_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in mehnat_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".trudovoy where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("oila_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void malumoti_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (malumoti_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in malumoti_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".study where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("malumoti_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void tatil_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (tatil_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in tatil_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".otpuska where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("tatil_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void attestatsiya_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (attestatsiya_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in attestatsiya_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".atestat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("attestatsiya_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void mt_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (mt_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in mt_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".mt where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("mt_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void intizomiy_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (intizomiy_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in intizomiy_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".intizomiy where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("intizomiy_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void ragbat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (ragbat_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in ragbat_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".nagrajdenie where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ragbat_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void davlat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (davlat_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in davlat_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".davlat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("davlat_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void xarbiy_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (xarbiy_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in xarbiy_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".xarbiy where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("xarbiy_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void xizmat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (xizmat_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in xizmat_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".xizmat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("xizmat_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void toifa_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (toifa_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in toifa_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".toifa where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("toifa_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void maxfiy_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (maxfiy_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in maxfiy_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".ruxsatnoma where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("maxfiy_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void guvohnoma_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (guvohnoma_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dgvRow in guvohnoma_dataGridView.SelectedRows)
                        {
                            Main.sql.return_MySqlCommand("delete from " + db_name + ".xizmat_g where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                        }
                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("guvohnoma_dataGridView_UserDeletingRow " + ex.Message);
            }
        }

        private void boshatish_Click(object sender, EventArgs e)
        {
            try
            {
                if (poisk_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    string data_fin = DateTime.Parse(boshatish_qachondan.Text).ToString("yyyy-MM-dd");
                    string prikaz_num = prikaz_num_text.Text;
                    string prikaz_date = DateTime.Parse(prikaz_date_text.Text).ToString("yyyy-MM-dd");
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    string boshatish_t = boshatishType_comboBox.Text;
                    string bandi = boshatishBand_comboBox.Text;
                    var insert = "insert into " + db_name + ".trudovoy(register_num, kod_num, work_place, prikaz_date, prikaz_num, date_start, doljnost, date_finish) " +
                               "SELECT register_num, kod_num, otdel, '" + prikaz_date + "', '" + prikaz_num + "', date_start2, doljnost, '" + data_fin + "' FROM " + db_name + ".main " +
                               "where " + db_name + ".main.kod_num = " + kod_num_global + "";
                    Main.sql.return_MySqlCommand(insert).ExecuteNonQuery();
                    var update = "update " + db_name + ".main set date_finish = '" + prikaz_date + "',date_finish2 = '" + data_fin + "', prikaz_finish = '" + prikaz_num + "' where " + db_name + ".main.kod_num = " + kod_num_global + "";
                    Main.sql.return_MySqlCommand(update).ExecuteNonQuery();
                    var insert_boshatish = "insert into " + db_name + ".boshatish(register_num, kod_num, name, surname, fath_name, zvanie, boshatish_t, bandi, otdel, doljnost, prikaz_num, prikaz_date) " +
                        "SELECT register_num, kod_num, name, surname, fath_name, zvanie, '" + boshatish_t + "', '" + bandi + "', otdel, doljnost, '" + prikaz_num + "', '" + prikaz_date + "' FROM " + db_name + ".main " +
                        "where " + db_name + ".main.kod_num = " + kod_num_global + "";
                    Main.sql.return_MySqlCommand(insert_boshatish).ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("boshatish_Click " + ex.Message);
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
                string db_name_org = tags[index1];
                string prikaz_date = DateTime.Parse(otkazish_buyruq_sanasi.Text).ToString("yyyy-MM-dd");
                string data_fin = DateTime.Parse(otkazish_qacondan.Text).ToString("yyyy-MM-dd");
                string prikaz_num = otkazish_buyruq_num.Text;
                int db_count = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_count = Int32.Parse(Main.sql.myReader.GetString("cnt"));
                }
                Main.sql.myReader.Close();
                string[] db_names = new string[db_count];
                int ind = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_names[ind] = Main.sql.myReader.GetString("schema_name");
                    ind++;
                }
                Main.sql.myReader.Close();
                int num = 0;
                string db_name = db_names[viloyatlar_comboBox.SelectedIndex];
                var insert = "insert into " + db_name_org + ".trudovoy(register_num, kod_num, work_place, prikaz_date, prikaz_num, date_start, doljnost, date_finish) " +
                       "SELECT register_num, kod_num, otdel, '" + prikaz_date + "', '" + prikaz_num + "', date_start2, doljnost, '" + data_fin + "' FROM " + db_name_org + ".main " +
                       "where " + db_name_org + ".main.kod_num = " + kod_num_global + "";
                Main.sql.return_MySqlCommand(insert).ExecuteNonQuery();

                Main.sql.myReader = Main.sql.return_MySqlCommand("select max(kod_num)+1 as max from " + db_name + ".main").ExecuteReader();
                while (Main.sql.myReader.Read())
                    num = Main.sql.myReader["max"] != DBNull.Value ? Main.sql.myReader.GetInt32("max") : 1;
                Main.sql.myReader.Close();
                var insert_new = "insert into " + db_name + ".main (register_num,kod_num,lichniy_num,surname,old_surname,name,fath_name,date_birth,place_birth,national,zvanie,tillar,otdel,date_start,date_start2,prikaz_start,doljnost," +
                    "doljnost_darajasi,grade,date_organ,ilmiy_d,ilmiy_u,xalq_a,gender,tel,image,from_him_prikaz,date_finish,date_finish2,prikaz_finish,pasport_date_start,pasport_date_finish,pasport_serial,pasport_live,prava_type," +
                    "prava_talon,dopusk,time,v_b,zaxira_work_place_id,stavka,orindosh_work_place_id,nameklatura,korxona_string) " +
                "SELECT register_num," + num + ",lichniy_num,surname,old_surname,name,fath_name,date_birth,place_birth,national,zvanie,tillar,'" + otdellar_comboBox.Text + "',date_start,date_start2,prikaz_start,'" + lavozim_comboBox.Text + "'," +
                    "doljnost_darajasi,grade,date_organ,ilmiy_d,ilmiy_u,xalq_a,gender,tel,image,from_him_prikaz,date_finish,date_finish2,prikaz_finish,pasport_date_start,pasport_date_finish,pasport_serial,pasport_live,prava_type," +
                    "prava_talon,dopusk,time,v_b,zaxira_work_place_id,stavka,orindosh_work_place_id,nameklatura,korxona_string FROM " + db_name_org + ".main where " + db_name_org + ".main.kod_num =" + kod_num_global + "";
                Main.sql.return_MySqlCommand(insert_new).ExecuteNonQuery();

                var inser_trudovoy = "insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal,time) " +
                    " SELECT register_num," + num + ",work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal,time FROM " + db_name_org + ".trudovoy where " + db_name_org + ".trudovoy.kod_num =" + kod_num_global + "";
                Main.sql.return_MySqlCommand(inser_trudovoy).ExecuteNonQuery();
                var inser_oilaviy = "insert into " + db_name + ".family (register_num,kod_num,fio,date_birth,qarindosh_d,place_birth,work_place,address,time) " +
        " SELECT register_num," + num + ",fio,date_birth,qarindosh_d,place_birth,work_place,address,time FROM " + db_name_org + ".family where " + db_name_org + ".family.kod_num =" + kod_num_global + "";
                Main.sql.return_MySqlCommand(inser_oilaviy).ExecuteNonQuery();
                var inser_unvon = "insert into " + db_name + ".unvon (register_num,kod_num,zvanie,soni,date,from_him) " +
    " SELECT register_num," + num + ",zvanie,soni,date,from_him FROM " + db_name_org + ".unvon where " + db_name_org + ".unvon.kod_num =" + kod_num_global + "";
                Main.sql.return_MySqlCommand(inser_unvon).ExecuteNonQuery();
                var inser_intizomiy = "insert into " + db_name + ".intizomiy (register_num,kod_num,date,prikaz_num,status,type_jazo,cheeck_jazo,from_him,malumot) " +
    " SELECT register_num," + num + ",date,prikaz_num,status,type_jazo,cheeck_jazo,from_him,malumot FROM " + db_name_org + ".intizomiy where " + db_name_org + ".intizomiy.kod_num =" + kod_num_global + "";
                Main.sql.return_MySqlCommand(inser_intizomiy).ExecuteNonQuery();
                var inser_nagrajdenie = "insert into " + db_name + ".nagrajdenie (register_num,kod_num,date,prikaz_num,status,foiz,type_mukofot,id_intizomiy) " +
    " SELECT register_num," + num + ",date,prikaz_num,status,foiz,type_mukofot,id_intizomiy FROM " + db_name_org + ".nagrajdenie where " + db_name_org + ".nagrajdenie.kod_num =" + kod_num_global + "";
                Main.sql.return_MySqlCommand(inser_nagrajdenie).ExecuteNonQuery();

                var update = "update " + db_name_org + ".main set date_finish = '" + prikaz_date + "',date_finish2 = '" + data_fin + "', prikaz_finish = '" + prikaz_num + "' where " + db_name_org + ".main.kod_num = " + kod_num_global + "";
                Main.sql.return_MySqlCommand(update).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("button3_Click " + ex.Message);
                Main.sql.myReader.Close();
            }
            //Main.sql.return_MySqlCommand("insert into "+db_name_org+".trudovoy (`id`,`register_num`,`kod_num`,`work_place`,`prikaz_date`,`prikaz_num`,`from_him`,`date_start`,`date_finish`,`doljnost`,`for_cal`,`time`)")
        }

        private void viloyatlar_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Console.WriteLine(viloyatlar_comboBox.SelectedValue);
                /// Console.WriteLine(viloyatlar_comboBox.SelectedText);
                /// 
                int db_count = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_count = Int32.Parse(Main.sql.myReader.GetString("cnt"));
                }
                Main.sql.myReader.Close();
                string[] db_names = new string[db_count];
                int ind = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_names[ind] = Main.sql.myReader.GetString("schema_name");
                    ind++;
                }
                Main.sql.myReader.Close();
                string db_name = db_names[viloyatlar_comboBox.SelectedIndex];
                var sel = "SELECT distinct otdel FROM " + db_name + ".work_place;";
                otdellar_comboBox.Items.Clear();
                otdellar_comboBox.Text = "";
                lavozim_comboBox.Text = "";
                Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    otdellar_comboBox.Items.Add(Main.sql.myReader.GetString("otdel"));

                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("viloyatlar_comboBox_SelectedIndexChanged " + ex.Message);
                Main.sql.myReader.Close();
            }
        }

        private void otdellar_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lavozim_comboBox.Items.Clear();
                lavozim_comboBox.Text = "";
                int db_count = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(*) as cnt FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_count = Int32.Parse(Main.sql.myReader.GetString("cnt"));
                }
                Main.sql.myReader.Close();
                string[] db_names = new string[db_count];
                int ind = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name LIKE 'kadr_0%' order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_names[ind] = Main.sql.myReader.GetString("schema_name");
                    ind++;
                }
                Main.sql.myReader.Close();
                string db_name = db_names[viloyatlar_comboBox.SelectedIndex];
                var sel = "SELECT distinct doljnost FROM " + db_name + ".work_place;";
                Main.sql.myReader = Main.sql.return_MySqlCommand(sel).ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    lavozim_comboBox.Items.Add(Main.sql.myReader.GetString("doljnost"));

                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("otdellar_comboBox_SelectedIndexChanged " + ex.Message);
                Main.sql.myReader.Close();
            }
        }

        private void poisk_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string otpuska_m = "";
                string ornida_m = "";
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
                            "lichniy_num, zvanie, concat(surname,' ', name,' ', fath_name) as fio, doljnost FROM " + db_name + ".main WHERE isnull(date_finish) and (kod_num like '" + poisk_textBox.Text + "%' or surname like '" + poisk_textBox.Text + "%' " +
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void shxyj_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(button4.BackgroundImage.Tag);

                if (button4.BackgroundImage.Tag.ToString() == "lock11")
                {
                    button4.BackgroundImage = Kadr.Properties.Resources.unlocked;
                    button4.BackgroundImage.Tag = "unlocked";
                    shxyj_textBox.Enabled = true;
                    shaxsiy_raqam_harfi_comboBox.Enabled = true;
                    shaxsiy_textBox.Enabled = true;
                    lavozimi_ComboBox.Enabled = true;
                    buyruq_sanasi_textBox.Enabled = true;
                    qacondan_textBox.Enabled = true;
                    buyruq_nomeri_textBox.Enabled = true;
                    kim_tomonidan_textBox.Enabled = true;
                    xisobidan_checkbox.Enabled = true;
                    if (xisobidan_checkbox.Checked == true)
                    {
                        xisobidan_comboBox.Enabled = true;
                    }
                    else
                    {
                        xisobidan_comboBox.Enabled = false;
                    }
                    familiyasi_textBox.Enabled = true;
                    ismi_textBox.Enabled = true;
                    otasining_ismi_textBox.Enabled = true;
                    qizining_ismi_textBox.Enabled = true;
                    iio_da_qachondan_textBox.Enabled = true;
                    qayta_qabul_checkBox.Enabled = true;
                    qayta_qabul_date.Enabled = true;
                    millati_textBox.Enabled = true;
                    unvon_comboBox.Enabled = true;
                    button1.Enabled = true;
                    tugilgan_sanasi_textBox.Enabled = true;
                    tugilgan_joyi_textBox.Enabled = true;
                    groupBox1.Enabled = true;
                    tillar_textBox.Enabled = true;
                    ilmiy_unvoni_textBox.Enabled = true;
                    ilmiy_darajasi_textBox.Enabled = true;
                    deputatlik.Enabled = true;
                    lavozimDarajaTextBox.Enabled = true;
                    nomenklatura.Enabled = true;
                    stavka_comboBox.Enabled = true;
                    passport_finish_date.Enabled = true;
                    passport_propiska.Enabled = true;
                    passport_start_date.Enabled = true;
                    passport_seria.Enabled = true;
                    woman.Enabled = true;
                    man.Enabled = true;
                    tel_num.Enabled = true;
                    ///lock all text boxes ////
                }
                else if (button4.BackgroundImage.Tag.ToString() == "unlocked")
                {
                    button4.BackgroundImage = Kadr.Properties.Resources.lock11;
                    button4.BackgroundImage.Tag = "lock11";
                    ///unlock all text boxes ////
                    shxyj_textBox.Enabled = false;
                    shaxsiy_raqam_harfi_comboBox.Enabled = false;
                    shaxsiy_textBox.Enabled = false;
                    lavozimi_ComboBox.Enabled = false;
                    buyruq_sanasi_textBox.Enabled = false;
                    qacondan_textBox.Enabled = false;
                    buyruq_nomeri_textBox.Enabled = false;
                    kim_tomonidan_textBox.Enabled = false;
                    xisobidan_checkbox.Enabled = false;
                    xisobidan_comboBox.Enabled = false;
                    familiyasi_textBox.Enabled = false;
                    ismi_textBox.Enabled = false;
                    otasining_ismi_textBox.Enabled = false;
                    qizining_ismi_textBox.Enabled = false;
                    iio_da_qachondan_textBox.Enabled = false;
                    qayta_qabul_checkBox.Enabled = false;
                    qayta_qabul_date.Enabled = false;
                    millati_textBox.Enabled = false;
                    unvon_comboBox.Enabled = false;
                    button1.Enabled = false;
                    tugilgan_sanasi_textBox.Enabled = false;
                    tugilgan_joyi_textBox.Enabled = false;
                    groupBox1.Enabled = false;
                    tillar_textBox.Enabled = false;
                    ilmiy_unvoni_textBox.Enabled = false;
                    ilmiy_darajasi_textBox.Enabled = false;
                    deputatlik.Enabled = false;
                    lavozimDarajaTextBox.Enabled = false;
                    nomenklatura.Enabled = false;
                    stavka_comboBox.Enabled = false;
                    passport_finish_date.Enabled = false;
                    passport_propiska.Enabled = false;
                    passport_start_date.Enabled = false;
                    passport_seria.Enabled = false;
                    woman.Enabled = false;
                    man.Enabled = false;
                    tel_num.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("button4_Click " + ex.Message, "Error");
            }
        }

        private void xisobidan_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (xisobidan_checkbox.Checked == true)
                {
                    xisobidan_comboBox.Enabled = true;
                }
                if (xisobidan_checkbox.Checked == false)
                {
                    xisobidan_comboBox.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("xisobidan_checkbox_CheckedChanged " + ex.Message, "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    Main.sql.return_MySqlCommand("update "+ db_name +".main set "+
                        " date_finish = '" + DateTime.Today.ToString("yyyy-MM-dd") + "', " +
                        " date_finish2 = '" + DateTime.Today.ToString("yyyy-MM-dd") + "', " +
                        " prikaz_finish = 'xatolik, shaxsiy malumotdan ochirilgan' " +
                        " where kod_num = '" +kod_num_global+"' ").ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("button5_Click " + ex.Message, "Error");
            }
        }

        private void ilmiy_darajasi_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void man_CheckedChanged(object sender, EventArgs e)
        {
            if (man.Checked == true)
            {
                woman.Checked = false;
            }
            else if (man.Checked == false)
            {
                woman.Checked = true;
            }
        }

        private void woman_CheckedChanged(object sender, EventArgs e)
        {
            if (woman.Checked == true)
            {
                man.Checked = false;
            }
            else if (woman.Checked == false)
            {
                man.Checked = true;
            }
        }

        private void mehnat_dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void poisk_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                get_items_to_shaxsiyMalumotlar();
                get_items_to_oila_azolari();
                get_items_to_oila_unvon();
                get_items_to_mehnat();
                get_items_to_malumoti();
                get_items_to_tatil();
                get_items_to_attestatsiya();
                get_items_to_mt();
                get_items_to_intizomiy_jazo();
                get_items_to_ragbat();
                get_items_to_davlat();
                get_items_to_xarbiy();
                get_items_to_xizmat();
                get_items_to_toifa();
                get_items_to_maxfiy();
                get_items_to_guvohnoma();
                get_items_to_prava();
                get_items_to_xchk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("poisk_dataGridView_CellContentClick " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];
                string prava_string = "[";
                foreach (var item in prava_type_ComboBox.CheckBoxItems)
                {
                    if (item.Checked == true)
                    {
                        prava_string = prava_string + (item.TabIndex - 5).ToString().Replace("-", "") + ", ";
                    }
                }
                prava_string = prava_string.Substring(0, prava_string.Length - 2);
                prava_string = prava_string + "]";
                Console.WriteLine(prava_string);
                Main.sql.return_MySqlCommand("update "+db_name+ ".main set prava_type = '"+ prava_string+ "', prava_talon = '"+talon_num.Text+"' where kod_num = " + kod_num_global + "" ).ExecuteNonQuery();
                run_alert("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("button6_Click " + ex.Message, "Error");
            }
        }

        private void xchk_datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (xchk_datagridview.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = xchk_datagridview.CurrentRow;

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.xchk_datagridview.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xchk_datagridview_CellValueChanged);

                    if (e.ColumnIndex == 3)
                    {
                        dgvRow.Cells[3].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[3].Value.ToString());
                    }
                    else if (e.ColumnIndex == 4)
                    {
                        dgvRow.Cells[4].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[4].Value.ToString());
                    }

                    this.xchk_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xchk_datagridview_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".xchk_malumot (kod_num,fio,date_from,date_to,where_to,for_what) " +
                            " values('" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            " " + (dgvRow.Cells[3].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[3].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " " + (dgvRow.Cells[4].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[4].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                            " '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "' " +
                            " )").ExecuteNonQuery();


                        this.xchk_datagridview.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xchk_datagridview_CellValueChanged);

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".xchk_malumot").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {
                            xchk_datagridview.Rows[xchk_datagridview.CurrentRow.Index].Cells[0].Value = Main.sql_2.myReader.GetString("id");
                        }
                        Main.sql_2.myReader.Close();

                        this.xchk_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.xchk_datagridview_CellValueChanged);
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".xchk_malumot set " +
                            "kod_num = '" + kod_num_global + "', " +
                            "fio = '" + (dgvRow.Cells[2].Value != null ? dgvRow.Cells[2].Value : "") + "', " +
                            "date_from = " + (dgvRow.Cells[3].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[3].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "date_to = " + (dgvRow.Cells[4].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[4].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            "where_to = '" + (dgvRow.Cells[5].Value != null ? dgvRow.Cells[5].Value : "") + "', " +
                            "for_what = '" + (dgvRow.Cells[6].Value != null ? dgvRow.Cells[6].Value : "") + "' " +
                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("xchk_datagridview_CellValueChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void xchk_datagridview_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (xchk_datagridview.CurrentRow.Cells[0].Value != DBNull.Value)
                {
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow dgvRow = xchk_datagridview.CurrentRow;
                        Main.sql.return_MySqlCommand("delete from " + db_name + ".xchk_malumot where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                        /////////////////////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("xchk_datagridview_UserDeletingRow " + ex.Message);
            }
        }
    }
}
