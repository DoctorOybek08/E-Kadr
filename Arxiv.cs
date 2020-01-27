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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Kadr
{
    public partial class Arxiv : Form
    {


        public Arxiv()
        {
            InitializeComponent();

            poisk_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            poisk_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            poisk_dataGridView.EnableHeadersVisualStyles = false;
            this.poisk_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.poisk_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            oila_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            oila_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            oila_dataGridView.EnableHeadersVisualStyles = false;
            oila_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            oila_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.oila_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.oila_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            unvon_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            unvon_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            unvon_dataGridView.EnableHeadersVisualStyles = false;
            this.unvon_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.unvon_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            mehnat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            mehnat_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            mehnat_dataGridView.EnableHeadersVisualStyles = false;
            mehnat_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mehnat_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.mehnat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.mehnat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            malumoti_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            malumoti_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            malumoti_dataGridView.EnableHeadersVisualStyles = false;
            malumoti_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            malumoti_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.malumoti_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.malumoti_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            tatil_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            tatil_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tatil_dataGridView.EnableHeadersVisualStyles = false;
            tatil_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tatil_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.tatil_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.tatil_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            attestatsiya_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            attestatsiya_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            attestatsiya_dataGridView.EnableHeadersVisualStyles = false;
            attestatsiya_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            attestatsiya_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.attestatsiya_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.attestatsiya_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            intizomiy_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            intizomiy_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            intizomiy_dataGridView.EnableHeadersVisualStyles = false;
            intizomiy_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            intizomiy_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.intizomiy_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.intizomiy_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            ragbat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            ragbat_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ragbat_dataGridView.EnableHeadersVisualStyles = false;
            ragbat_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ragbat_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.ragbat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.ragbat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            davlat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            davlat_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            davlat_dataGridView.EnableHeadersVisualStyles = false;
            this.davlat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.davlat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            xarbiy_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            xarbiy_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            xarbiy_dataGridView.EnableHeadersVisualStyles = false;
            this.xarbiy_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.xarbiy_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            xizmat_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            xizmat_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            xizmat_dataGridView.EnableHeadersVisualStyles = false;
            xizmat_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            xizmat_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.xizmat_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.xizmat_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            toifa_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            toifa_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            toifa_dataGridView.EnableHeadersVisualStyles = false;
            this.toifa_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.toifa_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            maxfiy_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            maxfiy_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            maxfiy_dataGridView.EnableHeadersVisualStyles = false;
            this.maxfiy_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.maxfiy_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            guvohnoma_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            guvohnoma_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            guvohnoma_dataGridView.EnableHeadersVisualStyles = false;
            this.guvohnoma_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.guvohnoma_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            mt_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 30, 45);
            mt_dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            mt_dataGridView.EnableHeadersVisualStyles = false;
            this.mt_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.mt_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

            unvon_comboBox.Items.Add("сафдор");
            unvon_comboBox.Items.Add("кичик сержант");
            unvon_comboBox.Items.Add("сержант");
            unvon_comboBox.Items.Add("катта сержант");
            unvon_comboBox.Items.Add("кичик лейтенант");
            unvon_comboBox.Items.Add("лейтенант");
            unvon_comboBox.Items.Add("катта лейтенант");
            unvon_comboBox.Items.Add("капитан");
            unvon_comboBox.Items.Add("майор");
            unvon_comboBox.Items.Add("подполковник");
            unvon_comboBox.Items.Add("полковник");
            unvon_comboBox.Items.Add("генерал майор");

        }

        public void run_main()
        {
            treeView.Nodes.Clear();
            run_treeview_upload();

            Main.sql.myReader = Main.sql.return_MySqlCommand("select name from spravochnik where type = 'ТАЪТИЛ' ").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                tatil_turi_tatil.Items.Add(Main.sql.myReader.GetString("name"));
            }
            Main.sql.myReader.Close();

            Main.sql.myReader = Main.sql.return_MySqlCommand("select name from spravochnik where type = 'ЭЪЛОН  ҚИЛИНСИН' ").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                jazo_turi_intizomiy.Items.Add(Main.sql.myReader.GetString("name"));
            }
            Main.sql.myReader.Close();

            Main.sql.myReader = Main.sql.return_MySqlCommand("select name from spravochnik where type = 'БЎШАТИЛСИН' ").ExecuteReader();
            while (Main.sql.myReader.Read())
            {
                nizomning_bandi_ketish_comboBox.Items.Add(Main.sql.myReader.GetString("name"));
            }
            Main.sql.myReader.Close();
        }
        TreeNode treeNode1;
        public void run_treeview_upload()
        {
            try
            {
               
                //for (int i = 0; i < Main.global_treeNode.Length; i++)
                //{
                //    if (Main.global_treeNode[i] != null)
                //    {
                //        TreeNode node = (TreeNode)Main.global_treeNode[i].Clone();
                //        treeView.Nodes.Add(node);
                //    }
                //}
                int db_count = 0;
                TreeNode treeNode = null;
                
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
                    var query = "SELECT distinct YEAR(df2) as year FROM (SELECT * FROM (SELECT count(*) as cnt1, id, kod_num, lichniy_num, zvanie, concat(main.surname,' ',main.name,' ',main.fath_name) as fio, "+
"date_finish as df1,doljnost, register_num as reg1 FROM "+ db_names[i] + ".main group by register_num) as t "+
"JOIN "+
"(SELECT count(*) as cnt2, register_num as reg2, max(kod_num), " +
"date_finish as df2 FROM "+ db_names[i] + ".main where date_finish is not null group by register_num) as t2 where t.reg1 = t2.reg2 and t.cnt1 = t2.cnt2) as t3 order by YEAR(df2) asc ";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(query).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        treeNode1 = new TreeNode(Main.sql.myReader.GetString("year")); // rasmli    
                        treeNode1.Tag = db_names;
                        treeNode1.ImageIndex = 0;
                        treeNode1.SelectedImageIndex = 1;
                        treeNode.Nodes.Add(treeNode1);
                    }
                    Main.sql.myReader.Close();
                   
                }
                
                treeView.Nodes.Add(treeNode);
                treeView.SelectedNode = treeNode;
                // treeView.SelectedNode = treeNode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview_upload " + ex.Message);
            }

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

                poisk_dataGridView.Rows.Clear();

                Console.WriteLine(str);

                this.poisk_dataGridView.SelectionChanged -= new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
                if (node.Text != "Бошқарма ихтиёрида")
                {
                    /*var query = "SELECT * FROM (select count(*) as cnt, register_num, max(main.kod_num) as kod_num,extract(year from main.date_organ) as year,extract(month from main.date_organ) as month,extract(day from main.date_organ) as day,max(main.id) as max_id," +
                    "main.lichniy_num,main.zvanie, concat(main.surname,' ',main.name,' ',main.fath_name) as fio, main.doljnost, date_finish  FROM " + db_name + ".main WHERE  register_num != '' and register_num != 'null' and main.otdel = '" + str + "' group by register_num) as t "
                                                     + " where t.cnt > 0 and t.date_finish is not null order by t.max_id asc";*/
                    string result = Regex.Replace(node.Text, @"[^\d]", "");
                    var query = "select * from (select count(*), id, register_num, kod_num,surname, name, lichniy_num, fath_name, zvanie, doljnost, concat(main.surname,' ',main.name,' ',main.fath_name) as fio, date_finish from " + 
 ""+db_name+".main where date_finish is not null and register_num is not null and concat(main.surname, ' ', main.name, ' ', main.fath_name, ' ', main.register_num) in "+
 "(select concat(main.surname, ' ', main.name, ' ', main.fath_name, ' ', main.register_num) as fio from " + db_name + ".main where date_finish is not null) group by surname, name, fath_name, register_num) as t where YEAR(t.date_finish) = '" + result + "'";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(query).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["lichniy_num"] != DBNull.Value ? Main.sql.myReader.GetString("lichniy_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
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
        public void get_items_to_shaxsiyMalumotlar()
        {
            if (poisk_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                    erkak_checkBox.Checked = false;
                    ayol_checkBox.Checked = false;
                    image_path = "";

                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];
                    string boshqarma = "";
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id, name from " + db_name + ".vacant where type_num = '1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        boshqarma = Main.sql.myReader.GetString("name"); // rasmli    
                    }
                    Main.sql.myReader.Close();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".main where kod_num = '" + dgvRow.Cells[1].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        kod_num_global = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "0");
                        shxyj_textBox.Text = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        shaxsiy_textBox.Text = (Main.sql.myReader["lichniy_num"] != DBNull.Value ? Main.sql.myReader.GetString("lichniy_num") : "");
                        familiyasi_textBox.Text = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        ismi_textBox.Text = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        otasining_ismi_textBox.Text = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        qizining_ismi_textBox.Text = (Main.sql.myReader["old_surname"] != DBNull.Value ? Main.sql.myReader.GetString("old_surname") : "");
                        iio_da_qachondan_textBox.Text = (Main.sql.myReader["date_organ"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_organ")).ToString("dd.MM.yyyy")) : "");
                        tel_raqami_textBox.Text = (Main.sql.myReader["tel"] != DBNull.Value ? Main.sql.myReader.GetString("tel") : "");
                        millati_textBox.Text = (Main.sql.myReader["national"] != DBNull.Value ? Main.sql.myReader.GetString("national") : "");

                        Console.WriteLine(Main.sql.myReader.GetByte("gender"));

                        if (Main.sql.myReader.GetByte("gender").Equals(1))
                        {
                            erkak_checkBox.Checked = true;
                        }
                        else if (Main.sql.myReader.GetByte("gender").Equals(2))
                        {
                            ayol_checkBox.Checked = true;
                        }

                        tugilgan_sanasi_textBox.Text = (Main.sql.myReader["date_birth"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_birth")).ToString("dd.MM.yyyy")) : "");
                        tugilgan_joyi_textBox.Text = (Main.sql.myReader["place_birth"] != DBNull.Value ? Main.sql.myReader.GetString("place_birth") : "");
                        unvon_comboBox.Text = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        ilmiy_unvoni_textBox.Text = (Main.sql.myReader["ilmiy_u"] != DBNull.Value ? Main.sql.myReader.GetString("ilmiy_u") : "");
                        ilmiy_darajasi_textBox.Text = (Main.sql.myReader["ilmiy_d"] != DBNull.Value ? Main.sql.myReader.GetString("ilmiy_d") : "");
                        lavozimi_textBox.Text = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        buyruq_sanasi_textBox.Text = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("dd.MM.yyyy")) : "");
                        qacondan_textBox.Text = (Main.sql.myReader["date_start2"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("dd.MM.yyyy")) : "");
                        buyruq_nomeri_textBox.Text = (Main.sql.myReader["prikaz_start"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_start") : "");
                        kim_tomonidan_textBox.Text = (Main.sql.myReader["from_him_prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("from_him_prikaz") : "");
                        tillar_textBox.Text = (Main.sql.myReader["tillar"] != DBNull.Value ? Main.sql.myReader.GetString("tillar") : "");
                        pasport_berilgan_textBox.Text = (Main.sql.myReader["pasport_date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("pasport_date_start")).ToString("dd.MM.yyyy")) : "");
                        pasport_amal_qilish_textBox.Text = (Main.sql.myReader["pasport_date_finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("pasport_date_finish")).ToString("dd.MM.yyyy")) : "");
                        pasport_seria_textBox.Text = (Main.sql.myReader["pasport_serial"] != DBNull.Value ? Main.sql.myReader.GetString("pasport_serial") : "");
                        pasport_yashash_joyi_textBox.Text = (Main.sql.myReader["pasport_live"] != DBNull.Value ? Main.sql.myReader.GetString("pasport_live") : "");
                        boshqarma_qismi_comboBox.Text = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel").Replace(boshqarma, "") : "");
                    }
                    Main.sql.myReader.Close();

                    Main.sql_2.mydataAdapter = new MySqlDataAdapter(Main.sql_2.return_MySqlCommand("select image from main where kod_num = '" + dgvRow.Cells[1].Value + "' "));
                    DataTable table = new DataTable();
                    Main.sql_2.mydataAdapter.Fill(table);

                    byte[] bits = null;

                    if (!Convert.IsDBNull(table.Rows[0][0]))
                    {
                        bits = (byte[])table.Rows[0][0];
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.unvon_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.unvon_dataGridView_CellValueChanged);

                    unvon_dataGridView.Rows.Clear();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".unvon where kod_num = '" + kod_num_global + "' ").ExecuteReader();
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
                        zvanie = zvanie.ToLower();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.mehnat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mehnat_dataGridView_CellValueChanged);

                    mehnat_dataGridView.Rows.Clear();
                    year = 0;
                    month = 0;
                    day = 0;

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".trudovoy where kod_num = '" + kod_num_global + "' and prikaz_date is not null and date_start is not null and date_finish is not null order by date_start").ExecuteReader();
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

                        year = year + dateDifference.Years;
                        month = month + dateDifference.Months;
                        day = day + dateDifference.Days;

                    }
                    Main.sql.myReader.Close();

                    //Main.sql.myReader = Main.sql.return_MySqlCommand("select date_start,date_start2,kod_num,otdel,doljnost,otdel,prikaz_start,from_him_prikaz from " + db_name + ".main where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    //while (Main.sql.myReader.Read())
                    //{
                    //    DateDifference dateDifference = new DateDifference(Main.sql.myReader.GetDateTime("date_start2"), DateTime.Today);

                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Add()].Cells[0].Value = ("0");
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["date_start2"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("dd.MM.yyyy")) : null);
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[2].Value = ("ҳозиргача");
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[3].Value = (dateDifference.ToString());
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[6].Value = (Main.sql.myReader["prikaz_start"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_start") : "");
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[7].Value = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("dd.MM.yyyy")) : null);
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[8].Value = (Main.sql.myReader["from_him_prikaz"] != DBNull.Value ? Main.sql.myReader.GetString("from_him_prikaz") : "");
                    //    mehnat_dataGridView.Rows[mehnat_dataGridView.Rows.Count - 2].Cells[9].Value = (true);

                    //    year = year + dateDifference.Years;
                    //    month = month + dateDifference.Months;
                    //    day = day + dateDifference.Days;
                    //}
                    //Main.sql.myReader.Close();

                    year = year + (month / 12);
                    month = month + (day / 30);

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.mt_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.mt_dataGridView_CellValueChanged);

                    mt_dataGridView.Rows.Clear();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.intizomiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.intizomiy_dataGridView_CellValueChanged);

                    intizomiy_dataGridView.Rows.Clear();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.ragbat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.ragbat_dataGridView_CellValueChanged);

                    ragbat_dataGridView.Rows.Clear();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.davlat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);

                    davlat_dataGridView.Rows.Clear();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".davlat where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        davlat_dataGridView.Rows[davlat_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        davlat_dataGridView.Rows[davlat_dataGridView.Rows.Count - 2].Cells[1].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                        davlat_dataGridView.Rows[davlat_dataGridView.Rows.Count - 2].Cells[2].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("dd.MM.yyyy")) : null);
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.xarbiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);

                    xarbiy_dataGridView.Rows.Clear();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.xizmat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xizmat_dataGridView_CellValueChanged);

                    xizmat_dataGridView.Rows.Clear();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    this.guvohnoma_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.guvohnoma_dataGridView_CellValueChanged);

                    guvohnoma_dataGridView.Rows.Clear();
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

        public void get_items_to_hodimning_boshashi()
        {
            try
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                buyruq_nomer_ketish_textBox.Text = "";
                buyruq_sanasi_ketish_textBox.Text = "";
                nizomning_bandi_ketish_comboBox.Text = "";
                kim_tomonidan_ketish_textBox.Text = "";

                Main.sql.myReader = Main.sql.return_MySqlCommand("select * from "+db_name+".boshatish where kod_num = '"+ kod_num_global + "' ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    buyruq_sanasi_ketish_textBox.Text = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("dd.MM.yyyy")) : null);
                    buyruq_nomer_ketish_textBox.Text = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                    kim_tomonidan_ketish_textBox.Text = (Main.sql.myReader["from_him"] != DBNull.Value ? Main.sql.myReader.GetString("from_him") : "");
                    nizomning_bandi_ketish_comboBox.Text = (Main.sql.myReader["bandi"] != DBNull.Value ? Main.sql.myReader.GetString("bandi") : "");
                }
                Main.sql.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("get_items_to_hodimning_boshashi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                get_items_to_hodimning_boshashi();
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
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                string gender = "";
                if (erkak_checkBox.Checked)
                {
                    gender = "1";
                }
                else if (ayol_checkBox.Checked)
                {
                    gender = "2";
                }
                else
                {
                    gender = "0";
                }

                Main.sql.return_MySqlCommand("update " + db_name + ".main set " +
                    "register_num = '" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                    "lichniy_num = '" + (shaxsiy_textBox.Text.ToString() != "" ? shaxsiy_textBox.Text.ToString() : "") + "', " +
                    "surname = '" + (familiyasi_textBox.Text.ToString() != "" ? familiyasi_textBox.Text.ToString() : "") + "', " +
                    "name = '" + (ismi_textBox.Text.ToString() != "" ? ismi_textBox.Text.ToString() : "") + "', " +
                    "fath_name = '" + (otasining_ismi_textBox.Text.ToString() != "" ? otasining_ismi_textBox.Text.ToString() : "") + "', " +
                    "old_surname = '" + (qizining_ismi_textBox.Text.ToString() != "" ? qizining_ismi_textBox.Text.ToString() : "") + "', " +
                    "date_organ = " + (iio_da_qachondan_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(iio_da_qachondan_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                    "tel = '" + (tel_raqami_textBox.Text.ToString() != "" ? tel_raqami_textBox.Text.ToString() : "") + "', " +
                    "national = '" + (millati_textBox.Text.ToString() != "" ? millati_textBox.Text.ToString() : "") + "', " +
                    "gender = '" + (gender) + "', " +
                    "date_birth = " + (tugilgan_sanasi_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(tugilgan_sanasi_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                    "place_birth = '" + (tugilgan_joyi_textBox.Text.ToString() != "" ? tugilgan_joyi_textBox.Text.ToString() : "") + "', " +
                    "zvanie = '" + (unvon_comboBox.Text.ToString() != "" ? unvon_comboBox.Text.ToString() : "") + "', " +
                    "ilmiy_u = '" + (ilmiy_unvoni_textBox.Text.ToString() != "" ? ilmiy_unvoni_textBox.Text.ToString() : "") + "', " +
                    "ilmiy_d = '" + (ilmiy_darajasi_textBox.Text.ToString() != "" ? ilmiy_darajasi_textBox.Text.ToString() : "") + "', " +
                    "doljnost = '" + (lavozimi_textBox.Text.ToString() != "" ? lavozimi_textBox.Text.ToString() : "") + "', " +
                    "date_start = " + (buyruq_sanasi_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(buyruq_sanasi_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                    "date_start2 = " + (qacondan_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(qacondan_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                    "prikaz_start = '" + (buyruq_nomeri_textBox.Text.ToString() != "" ? buyruq_nomeri_textBox.Text.ToString() : "") + "', " +
                    "from_him_prikaz = '" + (kim_tomonidan_textBox.Text.ToString() != "" ? kim_tomonidan_textBox.Text.ToString() : "") + "', " +
                    "tillar = '" + (tillar_textBox.Text.ToString() != "" ? tillar_textBox.Text.ToString() : "") + "', " +
                    "pasport_date_start = " + (pasport_berilgan_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(pasport_berilgan_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                    "pasport_date_finish = " + (pasport_amal_qilish_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(pasport_amal_qilish_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                    "pasport_serial = '" + (pasport_seria_textBox.Text.ToString() != "" ? pasport_seria_textBox.Text.ToString() : "") + "', " +
                    "pasport_live = '" + (pasport_yashash_joyi_textBox.Text.ToString() != "" ? pasport_yashash_joyi_textBox.Text.ToString() : "") + "' " +

                    " where kod_num = '" + kod_num_global + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update "+db_name+".boshatish set bandi = '"+ (nizomning_bandi_ketish_comboBox.Text.ToString() != "" ? nizomning_bandi_ketish_comboBox.Text.ToString() : "") + "',"+
                    " prikaz_num = '"+ (buyruq_nomer_ketish_textBox.Text.ToString() != "" ? buyruq_nomer_ketish_textBox.Text.ToString() : "") + "', " +
                    " prikaz_date = "+ (buyruq_sanasi_ketish_textBox.Text.ToString() != "" ? ("'" + DateTime.Parse(buyruq_sanasi_ketish_textBox.Text).ToString("yyyy-MM-dd") + "'") : "NULL") + ", " +
                    " from_him = '"+ (kim_tomonidan_ketish_textBox.Text.ToString() != "" ? kim_tomonidan_ketish_textBox.Text.ToString() : "") + "' " +
                    " where kod_num = '" +kod_num_global+"' ").ExecuteNonQuery();

                if (image_path != "")
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
                    cmd = new MySqlCommand(CmdString, Main.sql.myConn);
                    cmd.Parameters.Add("@Image", MySqlDbType.LongBlob);
                    cmd.Parameters["@Image"].Value = ImageData;
                    cmd.ExecuteNonQuery();
                }

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
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
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
                catch (Exception ex)
                {
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = tatil_dataGridView.CurrentRow;

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = attestatsiya_dataGridView.CurrentRow;

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = mt_dataGridView.CurrentRow;

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = intizomiy_dataGridView.CurrentRow;

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = ragbat_dataGridView.CurrentRow;

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = davlat_dataGridView.CurrentRow;

                    this.davlat_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }

                    this.davlat_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.davlat_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".davlat (register_num,kod_num,prikaz_num,date) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + " " +
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
                            "date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + " " +

                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = xarbiy_dataGridView.CurrentRow;

                    this.xarbiy_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.xarbiy_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 1)
                    {
                        dgvRow.Cells[1].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[1].Value.ToString());
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
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

                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select max(id) as id from " + db_name + ".trudovoy").ExecuteReader();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = xizmat_dataGridView.CurrentRow;

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = toifa_dataGridView.CurrentRow;

                    this.toifa_dataGridView.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);

                    if (e.ColumnIndex == 2)
                    {
                        dgvRow.Cells[2].Value = convert_date_main_function_INDATAGRIDVIEW(dgvRow.Cells[2].Value.ToString());
                    }


                    this.toifa_dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.toifa_dataGridView_CellValueChanged);

                    if (dgvRow.Cells[0].Value == null)
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".toifa (register_num,kod_num,prikaz_num,prikaz_date,type_toifa) " +
                            " values('" + (shxyj_textBox.Text.ToString() != "" ? shxyj_textBox.Text.ToString() : "") + "', " +
                            " '" + kod_num_global + "'," +
                            " '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                            " " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                            " '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +

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
                        Main.sql.return_MySqlCommand("update " + db_name + ".toifa set " +
                             "prikaz_num = '" + (dgvRow.Cells[1].Value != null ? dgvRow.Cells[1].Value : "") + "', " +
                             "prikaz_date = " + (dgvRow.Cells[2].Value != null ? "'" + DateTime.Parse(dgvRow.Cells[2].Value.ToString()).ToString("yyyy-MM-dd") + "'" : "NULL") + ", " +
                             "type_toifa = '" + (dgvRow.Cells[3].Value != null ? dgvRow.Cells[3].Value : "") + "' " +

                            " where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = maxfiy_dataGridView.CurrentRow;

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
                    TreeNode node = treeView.SelectedNode;
                    TreeNode root = FindRootNode(node);
                    int index1 = root.Index;
                    string[] tags = (string[])root.Tag;
                    string db_name = tags[index1];

                    DataGridViewRow dgvRow = guvohnoma_dataGridView.CurrentRow;

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
            if (oila_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = oila_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".family where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void unvon_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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

        private void mehnat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = mehnat_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".trudovoy where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void malumoti_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = malumoti_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".study where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void tatil_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = tatil_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".otpuska where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void attestatsiya_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = attestatsiya_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".atestat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void mt_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = mt_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".mt where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void intizomiy_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = intizomiy_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".intizomiy where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void ragbat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = ragbat_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".nagrajdenie where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void davlat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = davlat_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".davlat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void xarbiy_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = xarbiy_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".xarbiy where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void xizmat_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = xizmat_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".xizmat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void toifa_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = toifa_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".toifa where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void maxfiy_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = maxfiy_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".ruxsatnoma where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void guvohnoma_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    DataGridViewRow dgvRow = guvohnoma_dataGridView.CurrentRow;
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".xizmat_g where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////

                }
                else
                {
                    e.Cancel = true;
                }
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

                DataGridViewRow dgvRow = poisk_dataGridView.CurrentRow;
                Main.sql.return_MySqlCommand("update " + db_name + ".main set date_finish = null where kod_num = '" + dgvRow.Cells[1].Value + "'").ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Архивдан қайтариш : ", ex.Message);
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
                string str = "";

                var ancestorsAndSelf = treeView.SelectedNode.FullPath.Split(treeView.PathSeparator.ToCharArray());

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

                string kod_num = "";
                Main.sql.myReader = Main.sql.return_MySqlCommand("select max(kod_num)+1 as max_kod_num from "+db_name+".main ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    kod_num = Main.sql.myReader.GetString("max_kod_num");
                }
                Main.sql.myReader.Close();
                string boshqarma = "";
                Main.sql.myReader = Main.sql.return_MySqlCommand("select id, name from " + db_name + ".vacant where type_num = '1' ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    boshqarma = Main.sql.myReader.GetString("name"); // rasmli    
                }
                Main.sql.myReader.Close();
                Main.sql.return_MySqlCommand("insert into "+db_name+".main (kod_num,otdel,date_finish,date_finish2,prikaz_finish) values("+
                    " '"+kod_num+"','"+str+"','"+DateTime.Today.ToString("yyyy-MM-dd")+ "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','-') ").ExecuteNonQuery();

                Main.sql.return_MySqlCommand("insert into "+db_name+".boshatish(kod_num,date,otdel,prikaz_num,prikaz_date) values('"+kod_num+"',"+
                    " '" + DateTime.Today.ToString("yyyy-MM-dd") + "'," +
                    " '" +  boshqarma + " "+ boshqarma_qismi_comboBox.Text + "'," +
                    " '-', " +
                    " '" + DateTime.Today.ToString("yyyy-MM-dd") + "' " +
                    " ) ").ExecuteNonQuery();


                //-------------------------------------------------
                

                poisk_dataGridView.Rows.Clear();

                this.poisk_dataGridView.SelectionChanged -= new System.EventHandler(this.poisk_dataGridView_SelectionChanged);

                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT id,zvanie,kod_num,concat(surname,' ',name,' ',fath_name) as fio,doljnost " +
                    " FROM " + db_name + ".main WHERE otdel like '" + str + "%' and date_finish is not null ").ExecuteReader(); // year(date_finish) = " + e.Node.Text.Replace("\n", "").Replace(" йил", "")
                while (Main.sql.myReader.Read())
                {

                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = "";
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = "";


                }
                Main.sql.myReader.Close();

                this.poisk_dataGridView.SelectionChanged += new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("yangi odam qoshishda xatolik " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void buyruq_sanasi_ketish_textBox_Validated(object sender, EventArgs e)
        {
            convert_date_main_function((TextBox)sender);
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
                get_items_to_hodimning_boshashi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("poisk_dataGridView_CellContentClick " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
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


        private void button5_Click(object sender, EventArgs e)
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
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("SELECT CONCAT(surname, ' ', name, ' ',  fath_name) as fio, date_birth, place_birth, date_organ, national, tillar, image FROM " + db_name + ".main where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        fio = Main.sql_2.myReader["fio"] != DBNull.Value ? Main.sql_2.myReader.GetString("fio") : "" + " ";
                        dob = Main.sql_2.myReader["date_birth"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date_birth")).ToString("dd.MM.yyyy") : "";
                        place_birth = Main.sql_2.myReader["place_birth"] != DBNull.Value ? Main.sql_2.myReader.GetString("place_birth") : "";
                        date_organ = Main.sql_2.myReader["date_organ"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date_organ")).ToString("dd.MM.yyyy") : "";
                        nation = Main.sql_2.myReader["national"] != DBNull.Value ? Main.sql_2.myReader.GetString("national") : "";
                        tillar = Main.sql_2.myReader["tillar"] != DBNull.Value ? Main.sql_2.myReader.GetString("tillar") : "";
                    }
                    Main.sql_2.myReader.Close();
                    var select = "select type_study, profeccional, place, date_finish from " + db_name + ".study where kod_num = '" + kod_num + "'";
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(select).ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        daraja = Main.sql_2.myReader["type_study"] != DBNull.Value ? Main.sql_2.myReader.GetString("type_study") : "";
                        mutahassislik = Main.sql_2.myReader["profeccional"] != DBNull.Value ? Main.sql_2.myReader.GetString("profeccional") : "";
                        study_place = Main.sql_2.myReader["place"] != DBNull.Value ? Main.sql_2.myReader.GetString("place") : "";
                        data_finish = Main.sql_2.myReader["date_finish"] != DBNull.Value ? Main.sql_2.myReader.GetString("date_finish") : "";
                        malumoti = malumoti + data_finish + " йилда " + study_place + ", ";
                    }
                    Main.sql_2.myReader.Close();
                    string[] months = { "январ", "феврал", "март", "апрел", "май", "июн", "июл", "август", "сентябр", "октябр", "ноябр", "декабр" };
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("SELECT zvanie, soni, date, from_him FROM " + db_name + ".unvon where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        zvanie = Main.sql_2.myReader["zvanie"] != DBNull.Value ? Main.sql_2.myReader.GetString("zvanie") : "" + " ";
                        buyruq_num = Main.sql_2.myReader["soni"] != DBNull.Value ? Main.sql_2.myReader.GetString("soni") : "" + " ";
                        string year = Main.sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date")).ToString("yyyy") : "";
                        string day = Main.sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date")).ToString("dd") : "";
                        int month_num = Int32.Parse(Main.sql_2.myReader["date"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date")).ToString("MM") : "");
                        string month = "";
                        if (month_num > 0 && month_num < 13)
                        {
                            month = set_month_name2(month_num - 1);
                        }
                        unvon_date = year + " йил " + day + " " + month.Replace("ь", "");
                        organ = Main.sql_2.myReader["from_him"] != DBNull.Value ? Main.sql_2.myReader.GetString("from_him") : "" + " ";
                    }
                    Main.sql_2.myReader.Close();

                    Main.sql_2.mydataAdapter = new MySqlDataAdapter(Main.sql_2.return_MySqlCommand("select image from " + db_name + ".main where kod_num = '" + kod_num + "' "));
                    DataTable table1 = new DataTable();
                    Main.sql_2.mydataAdapter.Fill(table1);
                    byte[] bits = null;

                    Console.WriteLine((table1.Rows[0][0] != null ? (table1.Rows[0][0] + " true") : "false"));

                    if (!Convert.IsDBNull(table1.Rows[0][0]))
                    {
                        bits = (byte[])table1.Rows[0][0];
                    }


                    Main.sql_2.mydataAdapter.Dispose();
                    p = xodim_malumot1.Rows[0].Cells[0].AddParagraph();
                    TR = p.AppendText("\nСОБИҚ ҲОДИМ " + zvanie.ToUpper());
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
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select otdel, doljnost, extract(year from " + db_name + ".main.date_start2) as year,extract(month from " + db_name + ".main.date_start2) as month,extract(day from " + db_name + ".main.date_start2) as day from " + db_name + ".main where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        string year = Main.sql_2.myReader["year"] != DBNull.Value ? Main.sql_2.myReader.GetString("year") : "";
                        int month = Main.sql_2.myReader["month"] != DBNull.Value ? Int32.Parse(Main.sql_2.myReader.GetString("month")) : 1;
                        string day = Main.sql_2.myReader["day"] != DBNull.Value ? Main.sql_2.myReader.GetString("day") : "";
                        string month_name = set_month_name2(month);
                        string otdel = Main.sql_2.myReader["otdel"] != DBNull.Value ? Main.sql_2.myReader.GetString("otdel") : "";
                        string doljnost = Main.sql_2.myReader["doljnost"] != DBNull.Value ? Main.sql_2.myReader.GetString("doljnost") : "";
                        otdel_plus_doljnost = otdel + " " + doljnost + "";
                        TR = p.AppendText("" + year + " йил " + day + " " + month_name.Replace("ь", "") + "дан ");
                    }
                    Main.sql_2.myReader.Close();
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
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("SELECT date_start, date_finish, work_place, doljnost FROM " + db_name + ".trudovoy where kod_num = '" + kod_num + "' order by date_start asc ").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        mehnat_faoliyati.AddRow();
                        string period = "";
                        string month = "";
                        string data_start_per = Main.sql_2.myReader["date_start"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date_start")).ToString("MM.yyyy") : "";
                        string data_finish_per = Main.sql_2.myReader["date_finish"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date_finish")).ToString("MM.yyyy") : "";
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
                        string work_place = (Main.sql_2.myReader["work_place"] != DBNull.Value ? Main.sql_2.myReader.GetString("work_place") : "") + " " + (Main.sql_2.myReader["doljnost"] != DBNull.Value ? Main.sql_2.myReader.GetString("doljnost") : "");

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
                    Main.sql_2.myReader.Close();
                    var h_q = "SELECT date_start2, date_finish, CONCAT(otdel,' ', doljnost) as work_place_last FROM " + db_name + ".main where kod_num = '" + kod_num + "'";
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(h_q).ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        mehnat_faoliyati.AddRow();
                        string data_start_per_last = Main.sql_2.myReader["date_start2"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date_start2")).ToString("yyyy") : "";
                        string data_finish_per_last = Main.sql_2.myReader["date_finish"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date_finish")).ToString("yyyy") : "";
                        DateTime start;
                        DateTime finish;
                        string period = "";
                        string month = "";
                        DateTime.TryParse(data_start_per_last, out start);
                        DateTime.TryParse(data_finish_per_last, out finish);
                        Spire.Doc.Documents.Paragraph par_m = mehnat_faoliyati.Rows[k].Cells[0].AddParagraph();
                        mehnat_faoliyati.Rows[k].Cells[0].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                        mehnat_faoliyati.Rows[k].Cells[1].CellFormat.VerticalAlignment = Spire.Doc.Documents.VerticalAlignment.Top;
                        if (start.Year == finish.Year)
                        {
                            period = start.Year + " – " + start.Year + " йй. \n";
                            month = set_month_name2(start.Month) + "  " + set_month_name2(finish.Month);
                            Spire.Doc.Fields.TextRange TR15 = par_m.AppendText(period);
                            TR15.CharacterFormat.FontSize = 11;
                            Spire.Doc.Fields.TextRange TR11 = par_m.AppendText(month);
                            TR11.CharacterFormat.FontSize = 10;
                        }
                        else
                        {
                            period = start.Year + " – " + finish.Year + " йй.";
                            Spire.Doc.Fields.TextRange TR15 = par_m.AppendText(period);
                            TR15.CharacterFormat.FontSize = 11;
                        }

                        string work_place_last = Main.sql_2.myReader["work_place_last"] != DBNull.Value ? Main.sql_2.myReader.GetString("work_place_last") : "";
                        Spire.Doc.Documents.Paragraph par_last_work_place0 = mehnat_faoliyati.Rows[k].Cells[0].AddParagraph();
                        Spire.Doc.Fields.TextRange TR10 = par_last_work_place0.AppendText(period);
                        TR10.CharacterFormat.FontSize = 11;
                        Spire.Doc.Documents.Paragraph par_last_work_place1 = mehnat_faoliyati.Rows[k].Cells[1].AddParagraph();
                        TR10 = par_last_work_place1.AppendText(work_place_last);
                        par_last_work_place0.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        par_last_work_place1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
                        TR10.CharacterFormat.FontSize = 12;
                        mehnat_faoliyati.Rows[k].Cells[0].Width = 90;
                        mehnat_faoliyati.Rows[k].Cells[1].Width = 397;
                    }
                    Main.sql_2.myReader.Close();
                    mehnat_faoliyati.Rows.RemoveAt(mehnat_faoliyati.Rows.Count - 1);
                    Spire.Doc.Documents.Paragraph par4 = s.AddParagraph();
                    mehnat_faoliyati.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.None;
                    string jazo = "";
                    string ragbat = "";
                    string xarakatdagi = "";
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select count(*) as count from " + db_name + ".nagrajdenie where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        ragbat = Main.sql_2.myReader["count"] != DBNull.Value ? Main.sql_2.myReader.GetString("count") : "0";
                    }
                    Main.sql_2.myReader.Close();
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select count(*) as count from " + db_name + ".intizomiy where kod_num = '" + kod_num + "'").ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        jazo = Main.sql_2.myReader["count"] != DBNull.Value ? Main.sql_2.myReader.GetString("count") : "0";
                    }
                    Main.sql_2.myReader.Close();

                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select *,extract(year from intizomiy.date) as year,extract(month from intizomiy.date) as month," +
                        " extract(day from intizomiy.date) as day from " + db_name + ".intizomiy where kod_num='" + kod_num + "' and cheeck_jazo='0' ").ExecuteReader();
                    if (Main.sql_2.myReader.Read())
                    {
                        xarakatdagi = "Ҳаракатдаги интизомий жазоси бор. " + (Main.sql_2.myReader["from_him"] != DBNull.Value ? Main.sql_2.myReader.GetString("from_him") : "") + " " +
                            (Main.sql_2.myReader["year"] != DBNull.Value ? (Main.sql_2.myReader.GetString("year") + " йил ") : "") + " " +
                            (Main.sql_2.myReader["day"] != DBNull.Value ? (Main.sql_2.myReader.GetString("day") + "") : "") + " " +
                            (Main.sql_2.myReader["month"] != DBNull.Value ? (set_month_name2(Main.sql_2.myReader.GetInt32("month")) + "даги ") : "") + " " +
                            (Main.sql_2.myReader["prikaz_num"] != DBNull.Value ? (Main.sql_2.myReader.GetString("prikaz_num") + "-сонли буйруғи билан, ") : "") + " " +
                            (Main.sql_2.myReader["malumot"] != DBNull.Value ? (Main.sql_2.myReader.GetString("malumot")) : "") + " " +
                            (Main.sql_2.myReader["type_jazo"] != DBNull.Value ? ("«" + Main.sql_2.myReader.GetString("type_jazo") + "»") : "") + "  интизомий жазоси эълон қилинган.";

                    }
                    else
                    {
                        xarakatdagi = " Ҳаракатдаги интизомий жазоси йўқ. ";
                    }
                    Main.sql_2.myReader.Close();

                   
                    
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".boshatish where kod_num = '" + kod_num_global + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                         TR1 = par4.AppendText("\t" + (Main.sql.myReader["from_him"] != DBNull.Value ? Main.sql.myReader.GetString("from_him") : "") +  " нинг " + 
                             (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("yyyy") + " йил ") : " " ) + (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("dd") +  "-") : " ") + (Main.sql.myReader["prikaz_date"] != DBNull.Value ? set_month_name2((DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).Month)).Replace("ь", "") : "") + "идаги " +
                             (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "") + " буйруғи билан " +
                             (Main.sql.myReader["bandi"] != DBNull.Value ? Main.sql.myReader.GetString("bandi") : "") + " Ички Ишлар Органларидан бўшаган." );
                    }
                    Main.sql.myReader.Close();

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
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(oila_select).ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        row = table.AddRow();

                        string fio_ = Main.sql_2.myReader["fio"] != DBNull.Value ? Main.sql_2.myReader.GetString("fio") : "";
                        string qarindoshlik = Main.sql_2.myReader["qarindosh_d"] != DBNull.Value ? Main.sql_2.myReader.GetString("qarindosh_d") : "";
                        string date_b = Main.sql_2.myReader["date_birth"] != DBNull.Value ? DateTime.Parse(Main.sql_2.myReader.GetString("date_birth")).ToString("yyyy") : "";
                        string place_b = Main.sql_2.myReader["place_birth"] != DBNull.Value ? Main.sql_2.myReader.GetString("place_birth") : "";
                        string address = Main.sql_2.myReader["address"] != DBNull.Value ? Main.sql_2.myReader.GetString("address") : "";
                        string work_place = Main.sql_2.myReader["work_place"] != DBNull.Value ? Main.sql_2.myReader.GetString("work_place") : "";
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
                    Main.sql_2.myReader.Close();
                    string[] empt_rows = empty_rows.Split(' ').ToArray();
                    foreach (var a in empt_rows)
                    {
                        if (a != "")
                        {
                            table.ApplyHorizontalMerge(Int32.Parse(a), 4, 5);
                        }
                    }
                    //Save and Launch
                    //Main.sql_2.return_MySqlCommand("insert into control(user,ip,type,sabab,data_base) values('" + Form1.user_global + "',user(),'Чоп этиш','"+ kod_num + " / "+ fio + " нинг шахсий маълумотлари чоп этилди','"+db_name+"')").ExecuteNonQuery();

                    doc.SaveToFile("docs\\" + fio + ".docx", Spire.Doc.FileFormat.Docx);
                    System.Diagnostics.Process.Start("docs\\" + fio + ".docx");
                }
                catch (Exception ex)
                {
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("Error: " + ex.Source + " " + ex.Message);
                }
            }

    }

        private void poisk_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                TreeNode node = treeView.SelectedNode;
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                poisk_dataGridView.Rows.Clear();
                var query = "select * from (select count(*), id, register_num, kod_num,surname, name, lichniy_num, fath_name, zvanie, doljnost, concat(main.surname,' ',main.name,' ',main.fath_name) as fio, date_finish from " +
     "" + db_name + ".main where date_finish is not null and register_num is not null and concat(main.surname, ' ', main.name, ' ', main.fath_name, ' ', main.register_num) in " +
     "(select concat(main.surname, ' ', main.name, ' ', main.fath_name, ' ', main.register_num) as fio from " + db_name + ".main where date_finish is not null) group by surname, name, fath_name, register_num) as t where (kod_num like '" + poisk_textBox.Text + "%' or zvanie like '" + poisk_textBox.Text + "%' or doljnost like '" + poisk_textBox.Text + "%' or register_num like '" + poisk_textBox.Text + "%' or lichniy_num like '" + poisk_textBox.Text + "%' or surname like '" + poisk_textBox.Text + "%' " +
                                " or name like '" + poisk_textBox.Text + "%' or fio like '" + poisk_textBox.Text + "%')";
                this.poisk_dataGridView.SelectionChanged -= new System.EventHandler(this.poisk_dataGridView_SelectionChanged);
                Main.sql.myReader = Main.sql.return_MySqlCommand(query).ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["lichniy_num"] != DBNull.Value ? Main.sql.myReader.GetString("lichniy_num") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                    poisk_dataGridView.Rows[poisk_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                }
                Main.sql.myReader.Close();
                poisk_dataGridView.ClearSelection();
                this.poisk_dataGridView.SelectionChanged += new System.EventHandler(this.poisk_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("poisk_textBox_TextChanged " + ex.Message);
            }
        }
    }
}
