using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kadr
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            chart1.Series.Clear();
            run_treeview();
            //if (treeNode.Level == 0 && treeNode.Nodes.Count > 0)
            //{
            //    treeNode.SelectedImageIndex = 0;
            //}
            //ImageList imageList = new ImageList();
            //imageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "\\images\\folder-icon.png"), Color.Transparent);
            //treeView1.ImageList = imageList;
            //foreach (TreeNode node in treeView1.Nodes)
            //{
            //    foreach (TreeNode node2 in node.Nodes)
            //    {
            //        node2.ImageIndex = 100;
            //        node2.SelectedImageIndex = 100;
            //    }
            //}
            //foreach (TreeNode node in treeView1.Nodes)
            //{
            //    if (node.Nodes.Count == 0)
            //    {
            //        node.ImageIndex = 100;
            //        node.SelectedImageIndex = 100;
            //    }
            //}
            //populate_chart1();
            //populate_treeGridView(0);
            populate_all_table("");
            setGenderCount();
            updateYearLabel();
        }
        TreeNode treeNode;
        String glavka_string;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("run_treeview " + ex.Message);
            }

        }
        private String refresh_treeview_value(String value)
        {
            String myValue = "";
            int len = value.Length / 80;
            for (int i = 0; i < len; i++)
            {
                myValue = myValue + value.Substring(i * 80, 80) + "\n";
            }
            int startIndex = len * 80;
            int subLength = (value.Length - len * 80);
            myValue = myValue + value.Substring(startIndex, subLength);
            return myValue;
        }

        public void setGenderCount()
        {

            TreeNode node = treeView.SelectedNode;
            if (node != null)
            {
                var ancestorsAndSelf = node.FullPath.Split(treeView.PathSeparator.ToCharArray());

                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(main.gender) as man from " + db_name + ".main  where  main.gender='1' ").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    manCount.Text = (Main.sql.myReader["man"] != DBNull.Value ? Main.sql.myReader.GetString("man") : "");
                }
                Main.sql.myReader.Close();
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT count(main.gender) as woman from " + db_name + ".main  where  main.gender='2'").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    label2.Text = (Main.sql.myReader["woman"] != DBNull.Value ? Main.sql.myReader.GetString("woman") : "");
                }
                Main.sql.myReader.Close();
            }
        }
        public void populate_all_table(string str)
        {
            //try
            //{


            TreeNode node = treeView.SelectedNode;
            if (node != null)
            {
                TreeNode root = FindRootNode(node);
                int index1 = root.Index;
                string[] tags = (string[])root.Tag;
                string db_name = tags[index1];

                birthPlaceCountTable.Rows.Clear();
                nationalTable.Rows.Clear();
                lavozimTable.Rows.Clear();
                vakantTable.Rows.Clear();
                if (str != "")
                {
                    this.birthPlaceCountTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.vakantTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.nationalTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    this.lavozimTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    int i = 0;
                    int index = 0;
                    var select2 = "SELECT substring_index(main.place_birth,',',1) as place_birth,count(main.place_birth) as place_birth_num from " + db_name + ".main  where "
                + "main.place_birth is not null and main.otdel LIKE '" + str + "' group by substring_index(main.place_birth,',',1)";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = birthPlaceCountTable.Rows.Add();
                        birthPlaceCountTable.Rows[index].Cells[0].Value = (Main.sql.myReader["place_birth"] != DBNull.Value ? Main.sql.myReader.GetString("place_birth") : "");
                        birthPlaceCountTable.Rows[index].Cells[1].Value = (Main.sql.myReader["place_birth_num"] != DBNull.Value ? Main.sql.myReader.GetString("place_birth_num") : "");
                        i = i + (Main.sql.myReader["place_birth_num"] != DBNull.Value ? Int32.Parse(Main.sql.myReader.GetString("place_birth_num")) : 0);
                    }
                    Main.sql.myReader.Close();
                    index = birthPlaceCountTable.Rows.Add();
                    birthPlaceCountTable.Rows[index].Cells[0].Value = "Жами";
                    birthPlaceCountTable.Rows[index].Cells[1].Value = i.ToString();
                    select2 = "SELECT count(*) as place_birth_num from " + db_name + ".main where main.place_birth is null and "
              + "main.otdel LIKE '" + str + "'";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = birthPlaceCountTable.Rows.Add();
                        birthPlaceCountTable.Rows[index].Cells[0].Value = "ТЎЛДИРИЛИШИ ЛОЗИМ";
                        birthPlaceCountTable.Rows[index].Cells[1].Value = (Main.sql.myReader["place_birth_num"] != DBNull.Value ? Main.sql.myReader.GetString("place_birth_num") : "");

                    }
                    Main.sql.myReader.Close();
                    select2 = "SELECT main.national,count(main.national) as national_num from " + db_name + ".main  where "
                    + "main.national is not null and main.otdel LIKE '" + str + "' group by main.national";

                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = nationalTable.Rows.Add();
                        nationalTable.Rows[index].Cells[0].Value = (Main.sql.myReader["national"] != DBNull.Value ? Main.sql.myReader.GetString("national") : "");
                        nationalTable.Rows[index].Cells[1].Value = (Main.sql.myReader["national_num"] != DBNull.Value ? Main.sql.myReader.GetString("national_num") : "");

                    }
                    Main.sql.myReader.Close();

                    index = nationalTable.Rows.Add();
                    nationalTable.Rows[index].Cells[0].Value = "Жами";
                    nationalTable.Rows[index].Cells[1].Value = i.ToString();
                    select2 = "SELECT count(*) as national_num from " + db_name + ".main  where main.national is null and "
                + "main.otdel LIKE '" + str + "'";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = nationalTable.Rows.Add();
                        nationalTable.Rows[index].Cells[0].Value = "ТЎЛДИРИЛИШИ ЛОЗИМ";
                        nationalTable.Rows[index].Cells[1].Value = (Main.sql.myReader["national_num"] != DBNull.Value ? Main.sql.myReader.GetString("national_num") : "");

                    }
                    Main.sql.myReader.Close();
                    select2 = "SELECT main.doljnost,count(main.doljnost) as doljnost_num from " + db_name + ".main  where "
               + "main.doljnost is not null and main.otdel LIKE '" + str + "' group by main.doljnost";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = lavozimTable.Rows.Add();
                        lavozimTable.Rows[index].Cells[0].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        lavozimTable.Rows[index].Cells[1].Value = (Main.sql.myReader["doljnost_num"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost_num") : "");

                    }
                    Main.sql.myReader.Close();

                    index = lavozimTable.Rows.Add();
                    lavozimTable.Rows[index].Cells[0].Value = "Жами";
                    lavozimTable.Rows[index].Cells[1].Value = i.ToString();
                    select2 = "SELECT count(*) as doljnost_num from " + db_name + ".main  where main.doljnost is null and "
               + "main.otdel LIKE '" + str + "'";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = lavozimTable.Rows.Add();
                        lavozimTable.Rows[index].Cells[0].Value = "ТЎЛДИРИЛИШИ ЛОЗИМ";
                        lavozimTable.Rows[index].Cells[1].Value = (Main.sql.myReader["doljnost_num"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost_num") : "");

                    }
                    Main.sql.myReader.Close();
                    select2 = "SELECT doljnost,count(*) as doljnost_num from " + db_name + ".main where otdel = '" + str + "' group by doljnost ";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = vakantTable.Rows.Add();
                        vakantTable.Rows[index].Cells[0].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        vakantTable.Rows[index].Cells[1].Value = (Main.sql.myReader["doljnost_num"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost_num") : "");

                    }
                    Main.sql.myReader.Close();

                    index = vakantTable.Rows.Add();
                    vakantTable.Rows[index].Cells[0].Value = "Жами";
                    vakantTable.Rows[index].Cells[1].Value = i.ToString();
                    select2 = "SELECT count(*) as place_birth_num from " + db_name + ".main where main.place_birth is null and "
              + "main.otdel LIKE '" + str + "'";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        index = vakantTable.Rows.Add();
                        vakantTable.Rows[index].Cells[0].Value = "ТЎЛДИРИЛИШИ ЛОЗИМ";
                        vakantTable.Rows[index].Cells[1].Value = (Main.sql.myReader["place_birth_num"] != DBNull.Value ? Main.sql.myReader.GetString("place_birth_num") : "");

                    }
                    Main.sql.myReader.Close();
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error in Populating Table " + ex);
            //}

        }

        public void populate_treeGridView(string str)
        {

            //Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);


            //foreach (TreeGridNode node1 in treeGridView1.Nodes)
            //{
            //    foreach (TreeGridNode node2 in node1.Nodes)
            //    {
            //        node2.ImageIndex = 100;
            //    }
            //}
            //foreach (TreeGridNode node1 in treeGridView1.Nodes)
            //{
            //    if (node1.Nodes.Count == 0)
            //    {
            //        node1.ImageIndex = 100;
            //    }
            //}

            int i = 0;
            int j = 0;

           /* //node = treeGridView1.Nodes.Add( @"Using CurrencyManager's ItemChanged Event correctly", "michael", @"11/27/2005 1:02 AM");
            var select = "SELECT sum(case when grade='ишчи' then 1 else 0 end) as ishchi," +
            "sum(case when grade='капитан' then 1 else 0 end) as kap_may," +
            "sum(case when grade='майор' then 1 else 0 end) as kley_kap," +
            "sum(case when grade='подполковник' then 1 else 0 end) as may_pod," +
            "sum(case when grade='полковник' then 1 else 0 end) as pod_pol," +
            "sum(case when grade='сафдор' then 1 else 0 end) as saf_kser," +
            "sum(case when grade='катта сержант' then 1 else 0 end) as ser_kser," +
            "sum(case when grade='хизматчи' then 1 else 0 end) as xizmatchi," +

            "sum(case when grade='ишчи' and vacant='0' then 1 else 0 end) as ishchi_v," +
            "sum(case when grade='капитан' and vacant='0' then 1 else 0 end) as kap_may_v," +
            "sum(case when grade='майор' and vacant='0' then 1 else 0 end) as kley_kap_v," +
            "sum(case when grade='подполковник' and vacant='0' then 1 else 0 end) as may_pod_v," +
            "sum(case when grade='полковник' and vacant='0' then 1 else 0 end) as pod_pol_v," +
            "sum(case when grade='сафдор' and vacant='0' then 1 else 0 end) as saf_kser_v," +
            "sum(case when grade='катта сержант' and vacant='0' then 1 else 0 end) as ser_kser_v," +
            "sum(case when grade='хизматчи' and vacant='0' then 1 else 0 end) as xizmatchi_v," +

            "sum(case when grade='ишчи' and vacant='1' then 1 else 0 end) as ishchi_z," +
            "sum(case when grade='капитан' and vacant='1' then 1 else 0 end) as kap_may_z," +
            "sum(case when grade='майор' and vacant='1' then 1 else 0 end) as kley_kap_z," +
            "sum(case when grade='подполковник' and vacant='1' then 1 else 0 end) as may_pod_z," +
            "sum(case when grade='полковник' and vacant='1' then 1 else 0 end) as pod_pol_z," +
            "sum(case when grade='сафдор' and vacant='1 ' then 1 else 0 end) as saf_kser_z," +
            "sum(case when grade='катта сержант' and vacant='1' then 1 else 0 end) as ser_kser_z," +
            "sum(case when grade='хизматчи' and vacant='1' then 1 else 0 end) as xizmatchi_z FROM work_place where type='1' and otdel = '" + str + "'";
            Main.sql.myReader = Main.sql.return_MySqlCommand(select).ExecuteReader();
            treeGridView1.Nodes.Clear();

            while (Main.sql.myReader.Read())
            {

                TreeGridNode node0 = treeGridView1.Nodes.Add("- - - - - - - -", (Main.sql.myReader["pod_pol_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol_z") : 0) + (Main.sql.myReader["may_pod_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod_z") : 0) + (Main.sql.myReader["kap_may_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may_z") : 0) + (Main.sql.myReader["kley_kap_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap_z") : 0) + (Main.sql.myReader["ser_kser_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("ser_kser_z") : 0) + (Main.sql.myReader["saf_kser_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("saf_kser_z") : 0),
                    (Main.sql.myReader["pod_pol_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol_v") : 0) + (Main.sql.myReader["may_pod_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod_v") : 0) + (Main.sql.myReader["kap_may_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may_v") : 0) + (Main.sql.myReader["kley_kap_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap_v") : 0) + (Main.sql.myReader["ser_kser_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("ser_kser_v") : 0) + (Main.sql.myReader["saf_kser_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("saf_kser_v") : 0),
                    (Main.sql.myReader["pod_pol"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol") : 0) + (Main.sql.myReader["may_pod"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod") : 0) + (Main.sql.myReader["kap_may"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may") : 0) + (Main.sql.myReader["kley_kap"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap") : 0) + (Main.sql.myReader["ser_kser"] != DBNull.Value ? Main.sql.myReader.GetInt32("ser_kser") : 0) + (Main.sql.myReader["saf_kser"] != DBNull.Value ? Main.sql.myReader.GetInt32("saf_kser") : 0));
                node0.Expand();
                TreeGridNode node1 = node0.Nodes.Add("Офицер", (
                   (Main.sql.myReader["pod_pol_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol_z") : 0) + //pod_pol_z
                    (Main.sql.myReader["may_pod_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod_z") : 0) + //may_pod_z
                    (Main.sql.myReader["kap_may_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may_z") : 0) + //kap_may_z
                    (Main.sql.myReader["kley_kap_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap_z") : 0)),//kley_kap_z
          ((Main.sql.myReader["pod_pol_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol_v") : 0) + //pod_pol_v
         (Main.sql.myReader["may_pod_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod_v") : 0) + //may_pod_v
          (Main.sql.myReader["kap_may_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may_v") : 0) + //kap_may_v
          (Main.sql.myReader["kley_kap_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap_v") : 0)), //kley_kap_v
          ((Main.sql.myReader["pod_pol"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol") : 0) + //pod_pol
          (Main.sql.myReader["may_pod"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod") : 0) + //may_pod
          (Main.sql.myReader["kap_may"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may") : 0) + //kap_may
          (Main.sql.myReader["kley_kap"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap") : 0))); //kley_kap

                TreeGridNode podpolkovnik_polkovnik = node1.Nodes.Add("Подполковник-Полковник",
                      (Main.sql.myReader["pod_pol_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol_z") : 0), //pod_pol_z
                    (Main.sql.myReader["pod_pol_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol_v") : 0), //pod_pol_v
                    (Main.sql.myReader["pod_pol"] != DBNull.Value ? Main.sql.myReader.GetInt32("pod_pol") : 0));//pod_pol
                TreeGridNode mayor_podpolkovnik = node1.Nodes.Add("Майор-Подполковник",
                    (Main.sql.myReader["may_pod_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod_z") : 0), //may_pod_z
                    (Main.sql.myReader["may_pod_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod_v") : 0), //may_pod_v
                    (Main.sql.myReader["may_pod"] != DBNull.Value ? Main.sql.myReader.GetInt32("may_pod") : 0)); //may_pod
                TreeGridNode kapitan_mayor = node1.Nodes.Add("Капитан-Майор",
                    (Main.sql.myReader["kap_may_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may_z") : 0), //kap_may_z
                    (Main.sql.myReader["kap_may_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may_v") : 0), //kap_may_v
                    (Main.sql.myReader["kap_may"] != DBNull.Value ? Main.sql.myReader.GetInt32("kap_may") : 0)); //kap_may
                TreeGridNode kattaleytenant_kapitan = node1.Nodes.Add("Катта лейтенант-Капитан",
                    (Main.sql.myReader["kley_kap_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap_z") : 0), //kley_kap_z
                    (Main.sql.myReader["kley_kap_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap_v") : 0), //kley_kap_v
                    (Main.sql.myReader["kley_kap"] != DBNull.Value ? Main.sql.myReader.GetInt32("kley_kap") : 0)); //kley_kap

                TreeGridNode serjant = node0.Nodes.Add("Сержант (кичик сержант-катта сержант)",
                    (Main.sql.myReader["ser_kser_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("ser_kser_z") : 0), //ser_kser_z
                    (Main.sql.myReader["ser_kser_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("ser_kser_v") : 0), //ser_kser_v
                    (Main.sql.myReader["ser_kser"] != DBNull.Value ? Main.sql.myReader.GetInt32("ser_kser") : 0));  //ser_kser

                TreeGridNode safdor = node0.Nodes.Add("Сафдор",
                    (Main.sql.myReader["saf_kser_z"] != DBNull.Value ? Main.sql.myReader.GetInt32("saf_kser_z") : 0), //saf_kser_z
                    (Main.sql.myReader["saf_kser_v"] != DBNull.Value ? Main.sql.myReader.GetInt32("saf_kser_v") : 0), //saf_kser_v
                    (Main.sql.myReader["saf_kser"] != DBNull.Value ? Main.sql.myReader.GetInt32("saf_kser") : 0)); //saf_kser

            }
            Main.sql.myReader.Close();
            */

            /*
            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "\\images\\folder-icon.png"), Color.Transparent);
            treeGridView1.ImageList = imageList;
            //TreeGridNode node0 = treeGridView1.Nodes.Add("Using CurrencyManager's ItemChanged Event correctly", "michael", @"11/27/2005 1:02 AM");
            foreach (TreeGridNode node0 in treeGridView1.Nodes)
            {

                // TreeGridNode node1 = treeGridView1.Nodes.Add("Using CurrencyManager's ItemChanged Event correctly", "michael", @"11/27/2005 1:02 AM");
                node0.ImageIndex = 0;
                foreach (TreeGridNode node1 in node0.Nodes)
                {
                    // TreeGridNode node2 = node1.Nodes.Add(null, "Re: Using CurrencyManager's ItemChanged Event correctly", "tab", @"10/19/2005 1:02 AM");
                    node1.ImageIndex = 1;
                    foreach (TreeGridNode node2 in node1.Nodes)
                    {
                        // TreeGridNode node2 = node1.Nodes.Add(null, "Re: Using CurrencyManager's ItemChanged Event correctly", "tab", @"10/19/2005 1:02 AM");
                        node1.ImageIndex = 0;
                    }
                }

            }*/

        }
        public void populate_chart1(int type, double full, double empty)
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Row;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            //chart1.Legends[0].Title = "MyTitle";
            //chart1.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
            //Add some datapoints so the series. in this case you can pass the values to this method
            chart1.Series[seriesname].Points.AddXY("Банд", full);
            chart1.Series[seriesname].Points.AddXY("Бўш", empty);
            chart1.Series[seriesname].Label = "#VALX : #VALY";
            chart1.Series[seriesname].LegendText = "#VALX : #VALY";
            chart1.Series[seriesname]["PieLabelStyle"] = "Outside";
            if (type == 0)
            {
                chart1.Series[0].Points[0].Color = Color.FromArgb(76, 168, 196);
                chart1.Series[0].Points[1].Color = Color.FromArgb(85, 171, 85);
            }
            if (type == 1)
            {
                chart1.Series[0].Points[0].Color = Color.FromArgb(231, 156, 35);
                chart1.Series[0].Points[1].Color = Color.FromArgb(226, 99, 52);
            }
            chart1.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void vakantTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
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
                double full = 0;
                double empty = 0;
                double present_num = 0;

                var sel = "select count(main.gender) as man from " + db_name + ".main where main.gender = '1' and main.otdel LIKE '" + str + "%'";
                Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(sel).ExecuteReader();
                while (Main.sql_2.myReader.Read())
                {
                    manCount.Text = (Main.sql_2.myReader["man"] != DBNull.Value ? Main.sql_2.myReader.GetString("man") : "");
                }
                Main.sql_2.myReader.Close();
                Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select count(main.gender) as woman from " + db_name + ".main  where main.gender = '0' and main.otdel LIKE '" + str + "%'").ExecuteReader();
                while (Main.sql_2.myReader.Read())
                {
                    label2.Text = (Main.sql_2.myReader["woman"] != DBNull.Value ? Main.sql_2.myReader.GetString("woman") : "");
                }
                Main.sql_2.myReader.Close();
                var select2 = "SELECT sum(mytable.diff) as empty from (SELECT * FROM (SELECT cnt2 - cnt1 as diff, t.nameklatura, t.doljnost FROM " +
                "(SELECT count(*) as cnt1, nameklatura, doljnost, otdel FROM " + db_name + ".main where otdel = '" + str + "%' group by doljnost) as t " +
                "JOIN " +
                "(SELECT count(*) as cnt2, nameklatura, doljnost, otdel FROM " + db_name + ".work_place where otdel = '" + str + "' group by doljnost) as t2) as t3 group by doljnost) as mytable where mytable.diff > 0 ";
                Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(select2).ExecuteReader();

                while (Main.sql_2.myReader.Read())
                {

                    empty = (Main.sql_2.myReader["empty"] != DBNull.Value ? Double.Parse(Main.sql_2.myReader.GetString("empty")) : 0);
                }
                Main.sql_2.myReader.Close();

                select2 = "select count(*) as full from " + db_name + ".main where isnull(date_finish) and otdel = '" + str + "%'";
                Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(select2).ExecuteReader();

                while (Main.sql_2.myReader.Read())
                {

                    full = (Main.sql_2.myReader["full"] != DBNull.Value ? Double.Parse(Main.sql_2.myReader.GetString("full")) : 0);
                }
                Main.sql_2.myReader.Close();



                if (node.Parent == null)
                {
                    //MessageBox.Show("Parent");
                    populate_chart1(0, full, empty);
                }
                else
                {
                    //MessageBox.Show("Child");
                    populate_chart1(1, full, empty);
                }

                populate_all_table(str);
                // populate_treeGridView(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Main.sql.myReader.Close();
                Main.sql_2.myReader.Close();
            }
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.Graphics.DrawString(e.Node.Text, Font, Brushes.Black, Rectangle.Inflate(e.Bounds, 2, 0));
        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {
            updateYearLabel();
            stajPeriod();
        }
        public void show_rangeslider()
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
            //try
            //{
                minYosh.Text = bunifuRange2.RangeMin.ToString();
                maxYosh.Text = bunifuRange2.RangeMax.ToString();
                int count = 0;
                // System.out.println((int)slider.getLowValue());
                // System.out.println((int)slider.getHighValue());

                for (int i = bunifuRange2.RangeMin; i < bunifuRange2.RangeMax; i++)
                {

                    String select2 = "select count(*) as cnt from " + db_name + ".main  where timestampdiff(YEAR,date_birth,now())='" + i + "' and main.otdel LIKE '" + str + "%'";//
                    Main.sql.myReader = Main.sql.return_MySqlCommand(select2).ExecuteReader();

                    while (Main.sql.myReader.Read())
                    {
                        count = count + Main.sql.myReader.GetInt32("cnt");
                    }
                    Main.sql.myReader.Close();
                }
                yoshCount.Text = "<< " + count + " >>";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

        }
        public void stajPeriod()
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
            //try
            //{
            int count = 0;

            if (node.Text.ToString().Replace("\n", "") == (glavka_string))
            {
                for (int i = bunifuRange1.RangeMin; i < bunifuRange1.RangeMax; i++)
                {
                    String select2 = "select count(*) as cnt from " + db_name + ".main  where  and "
                            + "timestampdiff(YEAR,date_organ,now())='" + i + "' ";//
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(select2).ExecuteReader();

                    while (Main.sql_2.myReader.Read())
                    {
                        count = count + Main.sql_2.myReader.GetInt32("cnt");
                    }
                    Main.sql_2.myReader.Close();
                }
            }
            else
            {
                for (int i = bunifuRange1.RangeMin; i < bunifuRange1.RangeMax; i++)
                {

                    String select2 = "select count(*) as cnt from " + db_name + ".main  where "
                    + "timestampdiff(YEAR,date_organ,now())='" + i + "' and main.otdel LIKE '" + str + "%'";
                    Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(select2).ExecuteReader();
                    while (Main.sql_2.myReader.Read())
                    {
                        count = count + Main.sql_2.myReader.GetInt32("cnt");
                    }
                    Main.sql_2.myReader.Close();
                }
            }
            stajCount.Text = "<< " + count + " >>";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }
        public void updateYearLabel()
        {
            minAgeText.Text = bunifuRange1.RangeMin.ToString();
            maxAgeText.Text = bunifuRange1.RangeMax.ToString();

        }
        public void updateAgeLabel()
        {
            minYosh.Text = bunifuRange2.RangeMin.ToString();
            maxYosh.Text = bunifuRange2.RangeMax.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bunifuRange1.RangeMin--;
            updateYearLabel();
            stajPeriod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // bunifuRange1.RangeMin++;
            updateYearLabel();
            stajPeriod();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  bunifuRange1.RangeMax--;
            updateYearLabel();
            stajPeriod();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //bunifuRange1.RangeMax++;
            updateYearLabel();
            stajPeriod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //bunifuRange2.RangeMin--;
            updateAgeLabel();
            show_rangeslider();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //bunifuRange2.RangeMin++;
            updateAgeLabel();
            show_rangeslider();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //bunifuRange2.RangeMax--;
            updateAgeLabel();
            show_rangeslider();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // bunifuRange2.RangeMax++;
            updateAgeLabel();
            show_rangeslider();
        }

        private void bunifuRange2_RangeChanged(object sender, EventArgs e)
        {
            show_rangeslider();
            updateAgeLabel();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           /* Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select count(main.gender) as woman from " + db_name + ".main  where main.gender = '2' and main.otdel LIKE '" + str + "' ").ExecuteReader();
            while (Main.sql_2.myReader.Read())
            {
                label2.Text = (Main.sql_2.myReader["woman"] != DBNull.Value ? Main.sql_2.myReader.GetString("woman") : "");
            }
            Main.sql_2.myReader.Close();*/

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.Name, label2.Font.SizeInPoints, FontStyle.Regular);
        }

        private void yoshCount_MouseEnter(object sender, EventArgs e)
        {
            yoshCount.Font = new Font(yoshCount.Font.Name, yoshCount.Font.SizeInPoints, FontStyle.Underline);
        }

        private void yoshCount_MouseLeave(object sender, EventArgs e)
        {
            yoshCount.Font = new Font(yoshCount.Font.Name, yoshCount.Font.SizeInPoints, FontStyle.Regular);
        }

        private void manCount_MouseEnter(object sender, EventArgs e)
        {
            manCount.Font = new Font(manCount.Font.Name, manCount.Font.SizeInPoints, FontStyle.Underline);
        }

        private void manCount_MouseLeave(object sender, EventArgs e)
        {
            manCount.Font = new Font(manCount.Font.Name, manCount.Font.SizeInPoints, FontStyle.Regular);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.Name, label2.Font.SizeInPoints, FontStyle.Underline);
        }

        private void stajCount_MouseEnter(object sender, EventArgs e)
        {
            stajCount.Font = new Font(stajCount.Font.Name, stajCount.Font.SizeInPoints, FontStyle.Underline);
        }

        private void stajCount_MouseLeave(object sender, EventArgs e)
        {
            stajCount.Font = new Font(stajCount.Font.Name, stajCount.Font.SizeInPoints, FontStyle.Regular);
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manCount_Click(object sender, EventArgs e)
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
            double full = 0;
            double empty = 0;
            double present_num = 0;

         

            Workbook workbook = new Workbook();
            Worksheet sheet = workbook.Worksheets[0];

            sheet.Range["a1:a1"].Text = "ШХЙЖ №";
            sheet.Range["b1:b1"].Text = "PC №";
            sheet.Range["c1:c1"].Text = "Ф. И. Ш.";
            sheet.Range["d1:d1"].Text = "Бошқарма қисми";
            sheet.Range["e1:e1"].Text = "Лавозими";
            sheet.Range["f1:f1"].Text = "Охирги МТ санаси";
            sheet.Range["g1:g1"].Text = "Давр";

            int myrow = 2;
            var sel = "select  *, concat(surname, ' ', name, ' ', fath_name) as fio from " + db_name + ".main where main.gender = '1' and main.otdel LIKE '" + str + "' ";
            Main.sql_2.myReader = Main.sql_2.return_MySqlCommand(sel).ExecuteReader();
            while (Main.sql_2.myReader.Read())
            {
                sheet.Range["a" + myrow + ":a" + myrow].Text = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                sheet.Range["b" + myrow + ":b" + myrow].Text = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                sheet.Range["c" + myrow + ":c" + myrow].Text = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                sheet.Range["d" + myrow + ":d" + myrow].Text = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                sheet.Range["e" + myrow + ":e" + myrow].Text = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                sheet.Range["f" + myrow + ":f" + myrow].Text = (Main.sql.myReader["date"] != DBNull.Value ? Main.sql.myReader.GetString("date") : "");
                myrow++;
            }
            Main.sql_2.myReader.Close();
         

            workbook.SaveToFile("docs\\men.xlsx", Spire.Xls.FileFormat.Version2007);
            System.Diagnostics.Process.Start("docs\\men.xlsx");
        }


    }
}
