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
    public partial class Spiska_buyruqlar : Form
    {
        private string[] db_names;
        public Spiska_buyruqlar()
        {
            
            InitializeComponent();
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
                db_names = new string[db_count];
                int ind = 0;
                Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT schema_name FROM information_schema.schemata where schema_name " + db + " order by schema_name").ExecuteReader();
                while (Main.sql.myReader.Read())
                {
                    db_names[ind] = Main.sql.myReader.GetString("schema_name");
                    ind++;
                }
                Main.sql.myReader.Close();

                //tay_yan_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //tay_yan_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                var topLeftHeaderCell = tay_yan_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell1 = main_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell2 = tay_per_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell3 = bowatilsin_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell4 = oz_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell5 = yuborilsin_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell6 = qoldirilsin_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell7 = tasdiqlansin_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell8 = berilsin_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell9 = elon_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell10 = olib_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell11 = tatil_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell12 = mwt_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell13 = mwBekor_dataGridView;
                var topLeftHeaderCell14 = zaxiraga_oliw_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell15 = med_dobavit_dataGridView.TopLeftHeaderCell;
                var topLeftHeaderCell16 = bolnicniy_dobavit_dataGridView.TopLeftHeaderCell;

                this.tay_yan_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.tay_yan_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //tay_per_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //tay_per_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.tay_per_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.tay_per_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

              
                //oz_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //oz_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.oz_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.oz_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //bowatilsin_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //bowatilsin_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.bowatilsin_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.bowatilsin_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //yuborilsin_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //yuborilsin_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.yuborilsin_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.yuborilsin_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //qoldirilsin_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //qoldirilsin_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.qoldirilsin_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.qoldirilsin_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //tasdiqlansin_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //tasdiqlansin_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.tasdiqlansin_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.tasdiqlansin_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

                //berilsin_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //berilsin_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.berilsin_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.berilsin_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //elon_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //elon_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.elon_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.elon_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

                //olib_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //olib_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.olib_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.olib_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

                //tatil_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //tatil_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.tatil_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.tatil_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

                //mwt_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //mwt_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.mwt_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.mwt_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

                //mwBekor_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //mwBekor_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.mwBekor_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.mwBekor_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //zaxiraga_oliw_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //zaxiraga_oliw_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.zaxiraga_oliw_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.zaxiraga_oliw_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //med_dobavit_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //med_dobavit_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.med_dobavit_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.med_dobavit_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //bolnicniy_dobavit_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //bolnicniy_dobavit_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.bolnicniy_dobavit_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.bolnicniy_dobavit_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);
                
                //main_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //main_dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.main_dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.main_dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 233, 234);

                main_dataGridView.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                main_dataGridView.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Spiska_buyruqlar "+ ex.Message);
                Main.sql.myReader.Close();
            }
        }

        public void run_main()
        {
            try
            {
                refresh_button();
            }
            catch (Exception ex)
            {
                MessageBox.Show("run_main " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void refresh_button()
        {
            get_items_from_tay_yan_function();
            get_items_from_tay_per_function();
            get_items_from_oz_function();
            get_items_from_bowatilsin_function();
            get_items_from_yuborilsin_function();
            get_items_from_qoldirilsin_function();
            get_items_from_tasdiqlansin_function();
            get_items_from_berilsin_function();
            get_items_from_elon_qilinsin_function();
            get_items_from_olib_tashlansin_function();
            get_items_from_mwt_function();
            get_items_from_tatil_function();
            get_items_from_mwBekor_function();
            get_items_from_zaxiraga_oliw_function();
            get_items_from_med_dobavit_function();
            get_items_from_bolnicniy_dobavit_function();

            main_dataGridView.Rows.Clear();
        }


        public void get_items_from_tay_yan_function()
        {
            try
            {
                this.tay_yan_dataGridView.SelectionChanged -= new System.EventHandler(this.tay_yan_dataGridView_SelectionChanged);

                tay_yan_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT * FROM " + db_names[i] + ".dobavit where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("yyyy-MM-dd")) : null);
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("yyyy-MM-dd")) : null);
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[10].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[11].Value = (Main.sql.myReader["v_b"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("v_b")) : "0");
                        tay_yan_dataGridView.Rows[tay_yan_dataGridView.Rows.Count - 1].Cells[12].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }
                this.tay_yan_dataGridView.SelectionChanged += new System.EventHandler(this.tay_yan_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_tay_yan_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_tay_per_function()
        {
            try
            {
                this.tay_per_dataGridView.SelectionChanged -= new System.EventHandler(this.tay_per_dataGridView_SelectionChanged);

                tay_per_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".perevod where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("yyyy-MM-dd")) : null);
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["other_organ"] != DBNull.Value ? Main.sql.myReader.GetString("other_organ") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["asos"] != DBNull.Value ? Main.sql.myReader.GetString("asos") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("yyyy-MM-dd")) : null);
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[10].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[11].Value = (Main.sql.myReader["boshqa_cheeck"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("boshqa_cheeck")) : "0");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["old_otdel"] != DBNull.Value ? Main.sql.myReader.GetString("old_otdel") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[13].Value = (Main.sql.myReader["v_b"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("v_b")) : "0");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[14].Value = (Main.sql.myReader["organ_from"] != DBNull.Value ? Main.sql.myReader.GetString("organ_from") : "");
                        tay_per_dataGridView.Rows[tay_per_dataGridView.Rows.Count - 1].Cells[15].Value = (Main.sql.myReader["organ_to"] != DBNull.Value ? Main.sql.myReader.GetString("organ_to") : "");
                    }
                    Main.sql.myReader.Close();
                }
                this.tay_per_dataGridView.SelectionChanged += new System.EventHandler(this.tay_per_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_tay_per_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_oz_function()
        {
            try
            {
                this.oz_dataGridView.SelectionChanged -= new System.EventHandler(this.oz_dataGridView_SelectionChanged);

                oz_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".perevod_oz where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num1"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num1") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["kod_num2"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num2") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio1"] != DBNull.Value ? Main.sql.myReader.GetString("fio1") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel1"] != DBNull.Value ? Main.sql.myReader.GetString("otdel1") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost1"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost1") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["fio2"] != DBNull.Value ? Main.sql.myReader.GetString("fio2") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel2"] != DBNull.Value ? Main.sql.myReader.GetString("otdel2") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost2"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost2") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["id_work_place1"] != DBNull.Value ? Main.sql.myReader.GetString("id_work_place1") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[10].Value = (Main.sql.myReader["id_work_place2"] != DBNull.Value ? Main.sql.myReader.GetString("id_work_place2") : "");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[11].Value = (Main.sql.myReader["date_start1"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start1")).ToString("yyyy-MM-dd")) : null);
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["date_start2"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start2")).ToString("yyyy-MM-dd")) : null);
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[13].Value = (Main.sql.myReader["v_b1"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("v_b1")) : "0");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[14].Value = (Main.sql.myReader["v_b2"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("v_b2")) : "0");
                        oz_dataGridView.Rows[oz_dataGridView.Rows.Count - 1].Cells[15].Value = db_names[i];


                    }
                    Main.sql.myReader.Close();
                }
                this.oz_dataGridView.SelectionChanged += new System.EventHandler(this.oz_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_oz_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_bowatilsin_function()
        {
            try
            {
                this.bowatilsin_dataGridView.SelectionChanged -= new System.EventHandler(this.bowatilsin_dataGridView_SelectionChanged);

                bowatilsin_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM  " + db_names[i] + ".boshatish where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("yyyy-MM-dd")) : null);
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["bandi"] != DBNull.Value ? Main.sql.myReader.GetString("bandi") : "");
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["asos"] != DBNull.Value ? Main.sql.myReader.GetString("asos") : "");
                        bowatilsin_dataGridView.Rows[bowatilsin_dataGridView.Rows.Count - 1].Cells[9].Value = db_names[i];

                    }
                    Main.sql.myReader.Close();
                }

                this.bowatilsin_dataGridView.SelectionChanged += new System.EventHandler(this.bowatilsin_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_bowatilsin_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_yuborilsin_function()
        {
            try
            {
                this.yuborilsin_dataGridView.SelectionChanged -= new System.EventHandler(this.yuborilsin_dataGridView_SelectionChanged);

                yuborilsin_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".yuborish where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("yyyy-MM-dd")) : null);
                        yuborilsin_dataGridView.Rows[yuborilsin_dataGridView.Rows.Count - 1].Cells[7].Value = db_names[i];

                    }
                    Main.sql.myReader.Close();
                }
                this.yuborilsin_dataGridView.SelectionChanged += new System.EventHandler(this.yuborilsin_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_yuborilsin_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_qoldirilsin_function()
        {
            try
            {
                this.qoldirilsin_dataGridView.SelectionChanged -= new System.EventHandler(this.qoldirilsin_dataGridView_SelectionChanged);

                qoldirilsin_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".qoldirilsin where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Count - 1].Cells[2].Value = ("");
                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("yyyy-MM-dd")) : null);
                        qoldirilsin_dataGridView.Rows[qoldirilsin_dataGridView.Rows.Count - 1].Cells[7].Value = db_names[i];

                    }
                    Main.sql.myReader.Close();
                }
                this.qoldirilsin_dataGridView.SelectionChanged += new System.EventHandler(this.qoldirilsin_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_qoldirilsin_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_tasdiqlansin_function()
        {
            try
            {
                this.tasdiqlansin_dataGridView.SelectionChanged -= new System.EventHandler(this.tasdiqlansin_dataGridView_SelectionChanged);

                tasdiqlansin_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".tasdiqlansin where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("prikaz_num") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("prikaz_date")).ToString("yyyy-MM-dd")) : null);
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["asos"] != DBNull.Value ? Main.sql.myReader.GetString("asos") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["old_otdel"] != DBNull.Value ? Main.sql.myReader.GetString("old_otdel") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[10].Value = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("yyyy-MM-dd")) : null);
                        tasdiqlansin_dataGridView.Rows[tasdiqlansin_dataGridView.Rows.Count - 1].Cells[11].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }
                this.tasdiqlansin_dataGridView.SelectionChanged += new System.EventHandler(this.tasdiqlansin_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_tasdiqlansin_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_berilsin_function()
        {
            try
            {
                this.berilsin_dataGridView.SelectionChanged -= new System.EventHandler(this.berilsin_dataGridView_SelectionChanged);

                berilsin_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT * FROM " + db_names[i] + ".berilsin where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {

                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");
                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        berilsin_dataGridView.Rows[berilsin_dataGridView.Rows.Count - 1].Cells[7].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }
                this.berilsin_dataGridView.SelectionChanged += new System.EventHandler(this.berilsin_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_berilsin_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_elon_qilinsin_function()
        {
            try
            {
                this.elon_dataGridView.SelectionChanged -= new System.EventHandler(this.elon_dataGridView_SelectionChanged);

                elon_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".elon_q where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["asos"] != DBNull.Value ? Main.sql.myReader.GetString("asos") : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["type_jazo"] != DBNull.Value ? Main.sql.myReader.GetString("type_jazo") : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["malumot"] != DBNull.Value ? Main.sql.myReader.GetString("malumot") : "");
                        elon_dataGridView.Rows[elon_dataGridView.Rows.Count - 1].Cells[9].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }

                this.elon_dataGridView.SelectionChanged += new System.EventHandler(this.elon_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_elon_qilinsin_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_olib_tashlansin_function()
        {
            try
            {
                this.olib_dataGridView.SelectionChanged -= new System.EventHandler(this.olib_dataGridView_SelectionChanged);

                olib_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".olib_t where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["type_jazo"] != DBNull.Value ? Main.sql.myReader.GetString("type_jazo") : "");
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["ij_prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("ij_prikaz_num") : "");
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["ij_prikaz_date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("ij_prikaz_date")).ToString("yyyy-MM-dd")) : null);
                        olib_dataGridView.Rows[olib_dataGridView.Rows.Count - 1].Cells[9].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }
                this.olib_dataGridView.SelectionChanged += new System.EventHandler(this.olib_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_olib_tashlansin_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_mwt_function()
        {
            try
            {
                this.mwt_dataGridView.SelectionChanged -= new System.EventHandler(this.mwt_dataGridView_SelectionChanged);

                mwt_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".mehnat where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");

                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["old_kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("old_kod_num") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["id_parent"] != DBNull.Value ? Main.sql.myReader.GetString("id_parent") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("yyyy-MM-dd")) : null);
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[10].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[11].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        mwt_dataGridView.Rows[mwt_dataGridView.Rows.Count - 1].Cells[13].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }
                this.mwt_dataGridView.SelectionChanged += new System.EventHandler(this.mwt_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_mwt_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_tatil_function()
        {
            try
            {
                this.tatil_dataGridView.SelectionChanged -= new System.EventHandler(this.tatil_dataGridView_SelectionChanged);

                tatil_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".otpuska_p where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");

                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["date_start"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("yyyy-MM-dd")) : null);
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["date_finish"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date_finish")).ToString("yyyy-MM-dd")) : null);
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["type_otpusk"] != DBNull.Value ? Main.sql.myReader.GetString("type_otpusk") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["tashxis"] != DBNull.Value ? Main.sql.myReader.GetString("tashxis") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[10].Value = (Main.sql.myReader["asos"] != DBNull.Value ? Main.sql.myReader.GetString("asos") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[11].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[13].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        tatil_dataGridView.Rows[tatil_dataGridView.Rows.Count - 1].Cells[14].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }
                this.tatil_dataGridView.SelectionChanged += new System.EventHandler(this.tatil_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_tatil_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_mwBekor_function()
        {
            try
            {
                this.mwBekor_dataGridView.SelectionChanged -= new System.EventHandler(this.mwBekor_dataGridView_SelectionChanged);

                mwBekor_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".mehnat_b where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");

                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["bandi"] != DBNull.Value ? Main.sql.myReader.GetString("bandi") : "");
                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["date"] != DBNull.Value ? (DateTime.Parse(Main.sql.myReader.GetString("date")).ToString("yyyy-MM-dd")) : null);
                        mwBekor_dataGridView.Rows[mwBekor_dataGridView.Rows.Count - 1].Cells[8].Value = db_names[i];

                    }
                    Main.sql.myReader.Close();
                }
                this.mwBekor_dataGridView.SelectionChanged += new System.EventHandler(this.mwBekor_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_mwt_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_zaxiraga_oliw_function()
        {
            try
            {
                this.zaxiraga_oliw_dataGridView.SelectionChanged -= new System.EventHandler(this.zaxiraga_oliw_dataGridView_SelectionChanged);

                zaxiraga_oliw_dataGridView.Rows.Clear();
                for (int i = 0; i < db_names.Length; i++)
                {
                    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".zaxira_boshliq where cheeck='0' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        zaxiraga_oliw_dataGridView.Rows[zaxiraga_oliw_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        zaxiraga_oliw_dataGridView.Rows[zaxiraga_oliw_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        zaxiraga_oliw_dataGridView.Rows[zaxiraga_oliw_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["fio"] != DBNull.Value ? Main.sql.myReader.GetString("fio") : "");
                        zaxiraga_oliw_dataGridView.Rows[zaxiraga_oliw_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        zaxiraga_oliw_dataGridView.Rows[zaxiraga_oliw_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        zaxiraga_oliw_dataGridView.Rows[zaxiraga_oliw_dataGridView.Rows.Count - 1].Cells[5].Value = db_names[i];
                    }
                    Main.sql.myReader.Close();
                }
                this.zaxiraga_oliw_dataGridView.SelectionChanged += new System.EventHandler(this.zaxiraga_oliw_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Main.sql.myReader.Close();
                MessageBox.Show("get_items_from_zaxiraga_oliw_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_med_dobavit_function()
        {
            try
            {
                //this.med_dobavit_dataGridView.SelectionChanged -= new System.EventHandler(this.med_dobavit_dataGridView_SelectionChanged);

                //med_dobavit_dataGridView.Rows.Clear();
                //for (int i = 0; i < db_names.Length; i++)
                //{
                //    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".dobavit_med where cheeck='0' ").ExecuteReader();
                //    while (Main.sql.myReader.Read())
                //    {
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                //                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                //                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["stavka"] != DBNull.Value ? Main.sql.myReader.GetString("stavka") : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                //        med_dobavit_dataGridView.Rows[med_dobavit_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["yangi1_bowqarmadagi2"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("yangi1_bowqarmadagi2")) : "");
                //    }
                //    Main.sql.myReader.Close();
                //}
                //this.med_dobavit_dataGridView.SelectionChanged += new System.EventHandler(this.med_dobavit_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                MessageBox.Show("get_items_from_med_dobavit_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void get_items_from_bolnicniy_dobavit_function()
        {
            try
            {
                //this.bolnicniy_dobavit_dataGridView.SelectionChanged -= new System.EventHandler(this.bolnicniy_dobavit_dataGridView_SelectionChanged);

                //bolnicniy_dobavit_dataGridView.Rows.Clear();
                //for (int i = 0; i < db_names.Length; i++)
                //{
                //    Main.sql.myReader = Main.sql.return_MySqlCommand(" SELECT * FROM " + db_names[i] + ".bolnicniy_dobavit where cheeck='0' ").ExecuteReader();
                //    while (Main.sql.myReader.Read())
                //    {
                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[1].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") + " " : "") +
                //                                                                                              (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") + " " : "") +
                //                                                                                              (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") + " " : "");

                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["stavka"] != DBNull.Value ? Main.sql.myReader.GetString("stavka") : "");
                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                //        bolnicniy_dobavit_dataGridView.Rows[bolnicniy_dobavit_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");

                //    }
                //    Main.sql.myReader.Close();
                //}

                //this.bolnicniy_dobavit_dataGridView.SelectionChanged += new System.EventHandler(this.bolnicniy_dobavit_dataGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                MessageBox.Show("get_items_from_bolnicniy_function " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Spiska_buyruqlar_Load(object sender, EventArgs e)
        {
            run_main();
        }

        string vacant_m = "";
        string otpuska_m = "";
        private void tay_yan_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (tay_yan_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    /*DataGridViewRow dgvRow = tay_yan_dataGridView.CurrentRow;
                    int a = 1;
                    main_dataGridView.Rows.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from work_place where otdel = '" + dgvRow.Cells[5].Value.ToString().Replace("\n", "") + "' and type='1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        if (((Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "")).Equals("1"))
                        {
                            vacant_m = "Б А Н Д";
                        }
                        else
                        {
                            vacant_m = "Б Ў Ш";
                        }

                        if (((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "")).Equals("1"))
                        {
                            otpuska_m = "О Т П У С К А";
                        }
                        else
                        {
                            otpuska_m = "";
                        }


                        main_dataGridView.Rows[main_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[1].Value = (a);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Value = (vacant_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Value = (otpuska_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "0");

                        a++;

                        if (vacant_m == "Б Ў Ш")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Style.BackColor = Color.GreenYellow;
                        }
                        if (otpuska_m != "")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                        }
                    }
                    Main.sql.myReader.Close();*/
                }
                catch (Exception ex)
                {
                    //   Main.sql.myReader.Close();
                    MessageBox.Show("tay_yan_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
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


        string id_noviy;
        private void button1_Click(object sender, EventArgs e)
        {
            string db_name = tay_yan_dataGridView.CurrentRow.Cells[tay_yan_dataGridView.Columns.Count - 1].Value.ToString();
            if (tay_yan_dataGridView.SelectedCells.Count > 0 &&
               buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_tay_yan = tay_yan_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_main = main_dataGridView.CurrentRow;

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select max(kod_num)+1 as kod_num from " + db_name + ".main").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        id_noviy = Main.sql.myReader.GetString("kod_num");
                    }
                    Main.sql.myReader.Close();


                    if (dgvRow_tay_yan.Cells[9].Value == null)
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".dobavit set date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where id = '" + dgvRow_tay_yan.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                        dgvRow_tay_yan.Cells[9].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");
                    }

                    string nameklatura = "";
                    string korxona_string = "";
                    string stavka = "";

                    string val = "select nameklatura,korxona_string,stavka from " + db_name + ".main where " +
                        " otdel = '" + (dgvRow_tay_yan.Cells[5].Value != null ? dgvRow_tay_yan.Cells[5].Value : "") + "' " +
                        " and doljnost = '" + (dgvRow_tay_yan.Cells[6].Value != null ? dgvRow_tay_yan.Cells[6].Value : "") + "' ";

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select nameklatura,korxona_string,stavka from " + db_name + ".work_place where " +
                        " otdel = '" + (dgvRow_tay_yan.Cells[5].Value != null ? dgvRow_tay_yan.Cells[5].Value : "") + "' " +
                        " and doljnost = '" + (dgvRow_tay_yan.Cells[6].Value != null ? dgvRow_tay_yan.Cells[6].Value : "") + "' limit 1").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        nameklatura = Main.sql.myReader["nameklatura"] != DBNull.Value ? Main.sql.myReader.GetString("nameklatura") : "";
                        korxona_string = Main.sql.myReader["korxona_string"] != DBNull.Value ? Main.sql.myReader.GetString("korxona_string") : "";
                        stavka = Main.sql.myReader["stavka"] != DBNull.Value ? Main.sql.myReader.GetString("stavka") : "";
                    }
                    Main.sql.myReader.Close();


                    Main.sql.return_MySqlCommand("insert into " + db_name + ".main (kod_num,surname,name,fath_name,otdel,doljnost,zvanie,prikaz_start,date_start," +
                                                 "date_start2,date_organ,from_him_prikaz,nameklatura,korxona_string,stavka) values( " +
                        " '" + id_noviy + "', " +
                        " '" + (dgvRow_tay_yan.Cells[2].Value != null ? dgvRow_tay_yan.Cells[2].Value : "") + "', " +
                        " '" + (dgvRow_tay_yan.Cells[3].Value != null ? dgvRow_tay_yan.Cells[3].Value : "") + "', " +
                        " '" + (dgvRow_tay_yan.Cells[4].Value != null ? dgvRow_tay_yan.Cells[4].Value : "") + "', " +
                        " '" + (dgvRow_tay_yan.Cells[5].Value != null ? dgvRow_tay_yan.Cells[5].Value : "") + "', " +
                        " '" + (dgvRow_tay_yan.Cells[6].Value != null ? dgvRow_tay_yan.Cells[6].Value : "") + "', " +
                        " '" + (dgvRow_tay_yan.Cells[10].Value != null ? dgvRow_tay_yan.Cells[10].Value : "") + "', " +
                        " '" + (buyruq_num_textBox.Text) + "', " +
                        " '" + (buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd")) + "', " +
                        " '" + (dgvRow_tay_yan.Cells[9].Value != null ? dgvRow_tay_yan.Cells[9].Value : "") + "', " +
                        " '" + (dgvRow_tay_yan.Cells[9].Value != null ? dgvRow_tay_yan.Cells[9].Value : "") + "', " +
                        " '" + (kim_tomonidan_textBox.Text) + "', " +
                        " '" + (nameklatura) + "', " +
                        " '" + (korxona_string) + "', " +
                        " '" + (stavka) + "' " +

                        ") ").ExecuteNonQuery();

                    if (dgvRow_tay_yan.Cells[11].Value.ToString().Equals("1"))
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".main set v_b = '1', doljnost = CONCAT(doljnost,' вазифасини бажарувчи') where " +
                            " kod_num = '" + id_noviy + "' ").ExecuteNonQuery();
                    }

                    Main.sql.return_MySqlCommand("update " + db_name + ".dobavit set cheeck = '1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "'," +
                        " kod_num = '" + id_noviy + "' " +
                        " where id = '" + dgvRow_tay_yan.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".unvon(kod_num,zvanie,soni,date,from_him) values( " +
                        " '" + id_noviy + "', " +
                        " '" + (dgvRow_tay_yan.Cells[10].Value != null ? dgvRow_tay_yan.Cells[10].Value : "") + "', " +
                        " '" + buyruq_num_textBox.Text + "', " +
                        " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                        " '" + kim_tomonidan_textBox.Text + "' " +
                        " ) ").ExecuteNonQuery();

                    //Main.sql.myReader = Main.sql.return_MySqlCommand("SELECT min(id) as min_id FROM " + db_name + ".work_place where otdel = '" + (dgvRow_tay_yan.Cells[5].Value != null ? dgvRow_tay_yan.Cells[5].Value : "") + "' and doljnost =  '" + (dgvRow_tay_yan.Cells[6].Value != null ? dgvRow_tay_yan.Cells[6].Value : "") + "' and surname = '' and name = '' and fath_name = '' and type = 1").ExecuteReader();
                    //while(Main.sql.myReader.Read())
                    //{
                    //    string max_id = Main.sql.myReader["min_id"] != DBNull.Value ? Main.sql.myReader.GetString("min_id") : "";
                    //    if (max_id != "")
                    //    {
                    //        Main.sql.return_MySqlCommand("update work_place set " +
                    //        " kod_num = '" + id_noviy + "'," +
                    //        " surname = '" + (dgvRow_tay_yan.Cells[2].Value != null ? dgvRow_tay_yan.Cells[2].Value : "") + "', " +
                    //        " name = '" + (dgvRow_tay_yan.Cells[3].Value != null ? dgvRow_tay_yan.Cells[3].Value : "") + "', " +
                    //        " fath_name = '" + (dgvRow_tay_yan.Cells[4].Value != null ? dgvRow_tay_yan.Cells[4].Value : "") + "', " +
                    //        " zvanie = '" + (dgvRow_tay_yan.Cells[10].Value != null ? dgvRow_tay_yan.Cells[10].Value : "") + "', " +
                    //        " vacant = '1' " +
                    //        " where id = '" + max_id + "' ").ExecuteNonQuery();

                    //    }
                    //}
                    //Main.sql.myReader.Close();

                    /*
                    Main.sql.return_MySqlCommand("update work_place set " +
                        " kod_num = '" + id_noviy + "'," +
                        " surname = '" + (dgvRow_tay_yan.Cells[2].Value != null ? dgvRow_tay_yan.Cells[2].Value : "") + "', " +
                        " name = '" + (dgvRow_tay_yan.Cells[3].Value != null ? dgvRow_tay_yan.Cells[3].Value : "") + "', " +
                        " fath_name = '" + (dgvRow_tay_yan.Cells[4].Value != null ? dgvRow_tay_yan.Cells[4].Value : "") + "', " +
                        " zvanie = '" + (dgvRow_tay_yan.Cells[10].Value != null ? dgvRow_tay_yan.Cells[10].Value : "") + "', " +
                        " vacant = '1' " +
                        " where id = '" + dgvRow_main.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();*/

                    run_alert("");
                    refresh_button();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button1_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tay_per_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            string db_name = tay_per_dataGridView.CurrentRow.Cells[tay_yan_dataGridView.Columns.Count - 1].Value.ToString();
            if (tay_per_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = tay_per_dataGridView.CurrentRow;
                    int a = 1;
                    main_dataGridView.Rows.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from work_place where otdel = '" + dgvRow.Cells[3].Value.ToString().Replace("\n", "") + "' and type='1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        if (((Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "")).Equals("1"))
                        {
                            vacant_m = "Б А Н Д";
                        }
                        else
                        {
                            vacant_m = "Б Ў Ш";
                        }

                        if (((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "")).Equals("1"))
                        {
                            otpuska_m = "О Т П У С К А";
                        }
                        else
                        {
                            otpuska_m = "";
                        }


                        main_dataGridView.Rows[main_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[1].Value = (a);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Value = (vacant_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Value = (otpuska_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "0");

                        a++;

                        if (vacant_m == "Б Ў Ш")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Style.BackColor = Color.GreenYellow;
                        }
                        if (otpuska_m != "")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                        }
                    }
                    Main.sql.myReader.Close();

                    //------- Dekretga ketganlarni ustini korsatadi

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from work_place where otdel = '" + dgvRow.Cells[3].Value.ToString().Replace("\n", "") + "' and id_parent in " +
                        " (select id from work_place where otdel = '" + dgvRow.Cells[3].Value.ToString().Replace("\n", "") + "' and otpuska = '1' ) ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        Main.sql_2.myReader = Main.sql_2.return_MySqlCommand("select surname,name,fath_name from work_place where id='" + Main.sql.myReader.GetString("id_parent") + "' ").ExecuteReader();
                        while (Main.sql_2.myReader.Read())
                        {

                            if (((Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "")).Equals("1"))
                            {
                                vacant_m = "Б А Н Д";
                            }
                            else
                            {
                                vacant_m = "Б Ў Ш";
                            }

                            if (((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "")).Equals("1"))
                            {
                                otpuska_m = "О Т П У С К А";
                            }
                            else
                            {
                                otpuska_m = "";
                            }


                            main_dataGridView.Rows[main_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[1].Value = (a);
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[4].Value = ("ДЕКРЕТ ХИСОБИДАН ");
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql_2.myReader["surname"] != DBNull.Value ? Main.sql_2.myReader.GetString("surname") : "") + " " +
                                                                                                      (Main.sql_2.myReader["name"] != DBNull.Value ? Main.sql_2.myReader.GetString("name").Substring(0, 1) : "") + ". " +
                                                                                                      (Main.sql_2.myReader["fath_name"] != DBNull.Value ? Main.sql_2.myReader.GetString("fath_name").Substring(0, 1) : "") + ".";
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[6].Value = (" ЎРНИГА ");
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[9].Value = (" ---- ");
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Value = (vacant_m);
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Value = (otpuska_m);
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "0");

                            a++;

                            if (vacant_m == "Б Ў Ш")
                            {
                                main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Style.BackColor = Color.GreenYellow;
                            }
                            if (otpuska_m != "")
                            {
                                main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                            }
                        }
                        Main.sql_2.myReader.Close();
                    }
                    Main.sql.myReader.Close();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    Main.sql_2.myReader.Close();
                    MessageBox.Show("tay_per_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        string id_p;
        string type_p;
        string id_p_new;
        private void button4_Click(object sender, EventArgs e)
        {
            if (tay_per_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_tay_per = tay_per_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_main = main_dataGridView.CurrentRow;
                    string db_from = dgvRow_tay_per.Cells[tay_per_dataGridView.ColumnCount - 2].Value.ToString();
                    string db_to = dgvRow_tay_per.Cells[tay_per_dataGridView.ColumnCount - 1].Value.ToString();
                    int kod_num_global = dgvRow_tay_per.Cells[8].Value != null ? Int32.Parse(dgvRow_tay_per.Cells[8].Value.ToString()) : 0;

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select work_place_id as id from " + db_from + ".main where kod_num='" + dgvRow_tay_per.Cells[8].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        id_p = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                    }
                    Main.sql.myReader.Close();

                    if (dgvRow_tay_per.Cells[5].Value == null)
                    {
                        dgvRow_tay_per.Cells[5].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");

                        Main.sql.return_MySqlCommand("update " + db_from + ".perevod set date_start = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where id = '" + dgvRow_tay_per.Cells[0].Value + "' ").ExecuteNonQuery();
                    }

                    string date_start = "";
                    string date_finish = "";
                    string prikaz_num_old = "";
                    string otdel_old = "";
                    string doljnost_old = "";
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select date_start, old_prikaz_date, old_prikaz_num, old_doljnost, old_otdel from " + db_from + ".perevod where id = '" + dgvRow_tay_per.Cells[0].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        date_finish = (Main.sql.myReader["date_start"] != DBNull.Value ? DateTime.Parse(Main.sql.myReader.GetString("date_start")).ToString("yyyy-MM-dd") : "");
                        date_start = (Main.sql.myReader["old_prikaz_date"] != DBNull.Value ? DateTime.Parse(Main.sql.myReader.GetString("old_prikaz_date")).ToString("yyyy-MM-dd") : "");
                        prikaz_num_old = (Main.sql.myReader["old_prikaz_num"] != DBNull.Value ? Main.sql.myReader.GetString("old_prikaz_num") : "");
                        otdel_old = (Main.sql.myReader["old_otdel"] != DBNull.Value ? Main.sql.myReader.GetString("old_otdel") : "");
                        doljnost_old = (Main.sql.myReader["old_doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("old_doljnost") : "");
                    }
                    Main.sql.myReader.Close();
                    string prikaz_date = DateTime.Parse(buyruq_date_dateTimePicker.Text).ToString("yyyy-MM-dd");
                    //string data_fin = DateTime.Parse(buyruq_date_dateTimePicker.Text).ToString("yyyy-MM-dd");
                    string prikaz_num = buyruq_num_textBox.Text;
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
                    int num = 0;
                    string db_name = dgvRow_tay_per.Cells[15].Value.ToString();
                    string db_name_org = dgvRow_tay_per.Cells[14].Value.ToString();

                    
                        var insert = "insert into " + db_name_org + ".trudovoy(register_num, kod_num, work_place, prikaz_date, prikaz_num, date_start, doljnost, date_finish) " +
                               "SELECT register_num, kod_num, otdel, '" + prikaz_date + "', '" + prikaz_num + "', date_start2, doljnost, '" + date_finish + "' FROM " + db_name_org + ".main " +
                               "where " + db_name_org + ".main.kod_num = " + kod_num_global + "";
                        Main.sql.return_MySqlCommand(insert).ExecuteNonQuery();
                    if (db_name != db_name_org)
                    {
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select max(kod_num)+1 as max from " + db_name + ".main").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            num = Main.sql.myReader["max"] != DBNull.Value ? Main.sql.myReader.GetInt32("max") : 1;
                        }
                        Main.sql.myReader.Close();
                        var insert_new = "insert into " + db_name + ".main (register_num,kod_num,lichniy_num,surname,old_surname,name,fath_name,date_birth,place_birth,national,zvanie,tillar,otdel,date_start,date_start2,prikaz_start,doljnost," +
                            "doljnost_darajasi,grade,date_organ,ilmiy_d,ilmiy_u,xalq_a,gender,tel,image,from_him_prikaz,date_finish,date_finish2,prikaz_finish,pasport_date_start,pasport_date_finish,pasport_serial,pasport_live,prava_type," +
                            "prava_talon,dopusk,time,v_b,zaxira_work_place_id,stavka,orindosh_work_place_id,nameklatura,korxona_string) " +
                        "SELECT register_num," + num + ",lichniy_num,surname,old_surname,name,fath_name,date_birth,place_birth,national,zvanie,tillar,'" + dgvRow_tay_per.Cells[3].Value + "','" + prikaz_date + "','" + date_finish + "','" + buyruq_num_textBox.Text + "','" + dgvRow_tay_per.Cells[4].Value + "'," +
                            "doljnost_darajasi,grade,date_organ,ilmiy_d,ilmiy_u,xalq_a,gender,tel,image,from_him_prikaz,date_finish,date_finish2,prikaz_finish,pasport_date_start,pasport_date_finish,pasport_serial,pasport_live,prava_type," +
                            "prava_talon,dopusk,time,v_b,zaxira_work_place_id,stavka,orindosh_work_place_id,nameklatura,korxona_string FROM " + db_name_org + ".main where " + db_name_org + ".main.kod_num =" + kod_num_global + "";
                        Main.sql.return_MySqlCommand(insert_new).ExecuteNonQuery();

                        var inser_trudovoy = "insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal,time) " +
                            " SELECT register_num," + num + ",work_place, prikaz_date, prikaz_num,from_him,date_start,date_finish,doljnost,for_cal,time FROM " + db_name_org + ".trudovoy where " + db_name_org + ".trudovoy.kod_num =" + kod_num_global + "";
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
                        var inser_study = "insert into " + db_name + ".study (register_num,kod_num,type_study,place,profeccional,date_finish,dip_serial) " +
                   " SELECT register_num," + num + ",type_study,place,profeccional,date_finish,dip_serial FROM " + db_name_org + ".study where " + db_name_org + ".study.kod_num =" + kod_num_global + "";
                        Main.sql.return_MySqlCommand(inser_study).ExecuteNonQuery();
                    }
                    else
                    {
                        var update = "update " + db_name + ".main set otdel = '" + dgvRow_tay_per.Cells[3].Value + "', date_start =  '" + prikaz_date + "', date_start2 = '" + date_finish + "', prikaz_start = '" + buyruq_num_textBox.Text + "', doljnost = '" + dgvRow_tay_per.Cells[4].Value + "' where " + db_name + ".main.kod_num = " + kod_num_global + "";
                        Main.sql.return_MySqlCommand(update).ExecuteNonQuery();                        
                    }

                    Main.sql.return_MySqlCommand("update " + db_from + ".perevod set cheeck = '1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_tay_per.Cells[0].Value + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_from + ".work_place set register_num='',kod_num='0',surname=null,name=null,fath_name=null,zvanie=null,vacant='0',lichniy_num=null " +
                        " where id = '" + id_p + "' ").ExecuteNonQuery();
                    var sel1 = "select min(id) as min_id from " + db_name + ".work_place where type = 1 and otdel='" + dgvRow_tay_per.Cells[3].Value + "' and doljnost ='" + dgvRow_tay_per.Cells[4].Value + "' and id not in (SELECT distinct work_place_id FROM main where otdel = '" + dgvRow_tay_per.Cells[3].Value + "' and work_place_id is not null)";
                    Main.sql.myReader = Main.sql.return_MySqlCommand(sel1).ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        id_p_new = (Main.sql.myReader["min_id"] != DBNull.Value ? Main.sql.myReader.GetString("min_id") : "");
                    }
                    Main.sql.myReader.Close();

                    if (id_p_new != "")
                    {
                        var update_w = "update " + db_name + ".work_place set kod_num = '"+num+"', otdel = '" + dgvRow_tay_per.Cells[3].Value + "', doljnost = '" + dgvRow_tay_per.Cells[4].Value + "' where " + db_name + ".work_place.id = " + id_p_new + "";
                        Main.sql.return_MySqlCommand(update_w).ExecuteNonQuery();
                        var update_m = "update " + db_name + ".main set work_place_id = '" + id_p_new + "' where " + db_name + ".main.kod_num = " + kod_num_global + "";
                        Main.sql.return_MySqlCommand(update_m).ExecuteNonQuery();
                    }
                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button4_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (oz_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                string db_name = oz_dataGridView.CurrentRow.Cells[oz_dataGridView.Columns.Count - 1].Value.ToString();
                try
                {
                    DataGridViewRow dgvRow_oz = oz_dataGridView.CurrentRow;

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_num,prikaz_date,from_him,date_start,date_finish,doljnost,for_cal) select register_num1, " +
                                                 "kod_num1,old_otdel1,old_prikaz_num1,old_prikaz_date11,old_prikaz_from_him1,old_prikaz_date1,date_start1,old_doljnost1,'1' from " + db_name + ".perevod_oz " +
                                                 "where id = '" + dgvRow_oz.Cells[0].Value + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_num,prikaz_date,from_him,date_start,date_finish,doljnost,for_cal) select register_num2, " +
                                                 "kod_num2,old_otdel2,old_prikaz_num2,old_prikaz_date12,old_prikaz_from_him2,old_prikaz_date2,date_start2,old_doljnost2,'1' from " + db_name + ".perevod_oz " +
                                                 "where id = '" + dgvRow_oz.Cells[0].Value + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_name + ".perevod_oz set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " prikaz_from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_oz.Cells[0].Value + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set " +
                        " otdel = '" + dgvRow_oz.Cells[4].Value + "'," +
                        " doljnost = '" + dgvRow_oz.Cells[5].Value.ToString().Replace(" вазифасини бажарувчи", "") + "'," +
                        " date_start = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " date_start2 = " + (dgvRow_oz.Cells[11].Value != null ? ("'" + dgvRow_oz.Cells[11].Value + "'") : "NULL") + "," +
                        " prikaz_start = '" + buyruq_num_textBox.Text + "'," +
                        " from_him_prikaz = '" + kim_tomonidan_textBox.Text + "'," +
                        " v_b = '0' " +

                        " where kod_num = '" + dgvRow_oz.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set " +
                        " otdel = '" + dgvRow_oz.Cells[7].Value + "'," +
                        " doljnost = '" + dgvRow_oz.Cells[8].Value.ToString().Replace(" вазифасини бажарувчи", "") + "'," +
                        " date_start = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " date_start2 = " + (dgvRow_oz.Cells[12].Value != null ? ("'" + dgvRow_oz.Cells[12].Value + "'") : "NULL") + "," +
                        " prikaz_start = '" + buyruq_num_textBox.Text + "'," +
                        " from_him_prikaz = '" + kim_tomonidan_textBox.Text + "'," +
                        " v_b = '0' " +

                        " where kod_num = '" + dgvRow_oz.Cells[2].Value.ToString() + "' ").ExecuteNonQuery();


                    /* Main.sql.myReader = Main.sql.return_MySqlCommand("select surname,name,fath_name,zvanie,lichniy_num,register_num from main where "+
                         " kod_num = '" + dgvRow_oz.Cells[1].Value.ToString() + "' ").ExecuteReader();
                     while (Main.sql.myReader.Read())
                     {
                         Main.sql_2.return_MySqlCommand("update work_place set "+
                             " register_num = '" + (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "") + "', "+
                             " kod_num = '" + (dgvRow_oz.Cells[1].Value.ToString()) + "', " +
                             " surname = '" + (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "") + "', " +
                             " name = '" + (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "") + "', " +
                             " fath_name = '" + (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "") + "', " +
                             " zvanie = '" + (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "") + "', " +
                             " lichniy_num = '" + (Main.sql.myReader["lichniy_num"] != DBNull.Value ? Main.sql.myReader.GetString("lichniy_num") : "") + "' " +

                             " where id = '" + (dgvRow_oz.Cells[10].Value.ToString()) + "' ").ExecuteNonQuery();//  bir birini orniga o`tgani uchun kod_num1 ga work_place2 ni qoydim
                     }
                     Main.sql.myReader.Close();*/


                    /*sql.myReader = Main.sql.return_MySqlCommand("select surname,name,fath_name,zvanie,lichniy_num,register_num from main where " +
                        " kod_num = '" + dgvRow_oz.Cells[2].Value.ToString() + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        Main.sql_2.return_MySqlCommand("update work_place set " +
                            " register_num = '" + (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "") + "', " +
                            " kod_num = '" + (dgvRow_oz.Cells[2].Value.ToString()) + "', " +
                            " surname = '" + (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "") + "', " +
                            " name = '" + (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "") + "', " +
                            " fath_name = '" + (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "") + "', " +
                            " zvanie = '" + (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "") + "', " +
                            " lichniy_num = '" + (Main.sql.myReader["lichniy_num"] != DBNull.Value ? Main.sql.myReader.GetString("lichniy_num") : "") + "' " +

                            " where id = '" + (dgvRow_oz.Cells[9].Value.ToString()) + "' ").ExecuteNonQuery();//  bir birini orniga o`tgani uchun kod_num2 ga work_place1 ni qoydim
                    }
                    Main.sql.myReader.Close();*/

                    if (dgvRow_oz.Cells[13].Value.ToString().Equals("1"))
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".main set v_b = '1',doljnost = CONCAT(doljnost,' вазифасини бажарувчи') " +
                            " where kod_num = '" + (dgvRow_oz.Cells[1].Value.ToString()) + "' ").ExecuteNonQuery();
                    }

                    if (dgvRow_oz.Cells[14].Value.ToString().Equals("1"))
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".main set v_b = '1',doljnost = CONCAT(doljnost,' вазифасини бажарувчи') " +
                            " where kod_num = '" + (dgvRow_oz.Cells[2].Value.ToString()) + "' ").ExecuteNonQuery();
                    }

                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button6_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void oz_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void bowatilsin_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bowatilsin_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                string db_name = bowatilsin_dataGridView.CurrentRow.Cells[bowatilsin_dataGridView.Columns.Count - 1].Value.ToString();
                try
                {
                    DataGridViewRow dgvRow_bowatilsin = bowatilsin_dataGridView.CurrentRow;

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select work_place_id from " + db_name + ".main where kod_num='" + dgvRow_bowatilsin.Cells[1].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        //type_p = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "");
                        id_p = (Main.sql.myReader["work_place_id"] != DBNull.Value ? Main.sql.myReader.GetString("work_place_id") : "");
                    }
                    Main.sql.myReader.Close();

                    Main.sql.return_MySqlCommand("update " + db_name + ".boshatish set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_bowatilsin.Cells[0].Value + "' ").ExecuteNonQuery();

                    if (dgvRow_bowatilsin.Cells[6].Value == null)
                    {
                        dgvRow_bowatilsin.Cells[6].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");

                        Main.sql.return_MySqlCommand("update " + db_name + ".boshatish set date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where id = '" + dgvRow_bowatilsin.Cells[0].Value + "' ").ExecuteNonQuery();
                    }

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set date_finish = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                        " prikaz_finish = '" + buyruq_num_textBox.Text + "', " +
                        " date_finish2 = '" + dgvRow_bowatilsin.Cells[6].Value.ToString() + "' " +
                        " where kod_num = '" + dgvRow_bowatilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal) select register_num, " +
                        "kod_num,otdel,date_start,prikaz_start,from_him_prikaz,date_start2,date_finish2,doljnost,'1' from main " +
                        "where kod_num = '" + dgvRow_bowatilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();
                    if (id_p != "")
                    {
                        Main.sql.return_MySqlCommand("update work_place set register_num='',kod_num='0',surname='',name='',fath_name='',zvanie='',vacant='0',lichniy_num='' " +
                            " where id = '" + id_p + "' ").ExecuteNonQuery();
                    }

                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void yuborilsin_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (yuborilsin_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_yuborilsin = yuborilsin_dataGridView.CurrentRow;
                    string db_name = yuborilsin_dataGridView.CurrentRow.Cells[yuborilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id,type from " + db_name + ".work_place where kod_num='" + dgvRow_yuborilsin.Cells[1].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        type_p = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "");
                        id_p = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                    }
                    Main.sql.myReader.Close();

                    Main.sql.return_MySqlCommand("update " + db_name + ".yuborish set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_yuborilsin.Cells[0].Value + "' ").ExecuteNonQuery();

                    if (dgvRow_yuborilsin.Cells[6].Value == null)
                    {
                        dgvRow_yuborilsin.Cells[6].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");

                        Main.sql.return_MySqlCommand("update " + db_name + ".yuborish set date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where id = '" + dgvRow_yuborilsin.Cells[0].Value + "' ").ExecuteNonQuery();
                    }

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set date_finish = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                        " prikaz_finish = '" + buyruq_num_textBox.Text + "', " +
                        " date_finish2 = '" + dgvRow_yuborilsin.Cells[6].Value.ToString() + "' " +
                        " where kod_num = '" + dgvRow_yuborilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal) select register_num, " +
                        "kod_num,otdel,date_start,prikaz_start,from_him_prikaz,date_start2,date_finish2,doljnost,'1' from " + db_name + ".main " +
                        "where kod_num = '" + dgvRow_yuborilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();

                    /*sql.return_MySqlCommand("update work_place set register_num='',kod_num='0',surname='',name='',fath_name='',zvanie='',vacant='0',lichniy_num='' " +
                        " where id = '" + id_p + "' ").ExecuteNonQuery();*/


                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (qoldirilsin_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_qoldirilsin = qoldirilsin_dataGridView.CurrentRow;
                    string db_name = qoldirilsin_dataGridView.CurrentRow.Cells[qoldirilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id,type from " + db_name + ".work_place where kod_num='" + dgvRow_qoldirilsin.Cells[1].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        type_p = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "");
                        id_p = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                    }
                    Main.sql.myReader.Close();

                    Main.sql.return_MySqlCommand("update " + db_name + ".qoldirilsin set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_qoldirilsin.Cells[0].Value + "' ").ExecuteNonQuery();

                    if (dgvRow_qoldirilsin.Cells[6].Value == null)
                    {
                        dgvRow_qoldirilsin.Cells[6].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");

                        Main.sql.return_MySqlCommand("update " + db_name + ".qoldirilsin set date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where id = '" + dgvRow_qoldirilsin.Cells[0].Value + "' ").ExecuteNonQuery();
                    }

                    //sql.return_MySqlCommand("update main set date_finish = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                    //    " prikaz_finish = '" + buyruq_num_textBox.Text + "', " +
                    //    " date_finish2 = '" + dgvRow_qoldirilsin.Cells[6].Value.ToString() + "' " +
                    //    " where kod_num = '" + dgvRow_qoldirilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal) select register_num, " +
                        "kod_num,otdel,date_start,prikaz_start,from_him_prikaz,date_start2,'" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "',doljnost,'1' from " + db_name + ".main " +
                        "where kod_num = '" + dgvRow_qoldirilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();


                    /*sql.return_MySqlCommand("update work_place set register_num='',kod_num='0',surname='',name='',fath_name='',zvanie='',vacant='0',lichniy_num='' " +
                        " where id = '" + id_p + "' ").ExecuteNonQuery();*/


                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void qoldirilsin_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void tasdiqlansin_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tasdiqlansin_dataGridView.SelectedCells.Count > 0 &&
               buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_tasdiqlansin = tasdiqlansin_dataGridView.CurrentRow;
                    string db_name = tasdiqlansin_dataGridView.CurrentRow.Cells[tasdiqlansin_dataGridView.Columns.Count - 1].Value.ToString();
                    //sql.myReader = Main.sql.return_MySqlCommand("select id,type from work_place where kod_num='" + dgvRow_qoldirilsin.Cells[9].Value + "' ").ExecuteReader();
                    //while (Main.sql.myReader.Read())
                    //{
                    //    type_p = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "");
                    //    id_p = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                    //}
                    //sql.myReader.Close();

                    Main.sql.return_MySqlCommand("update " + db_name + ".tasdiqlansin set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_tasdiqlansin.Cells[0].Value + "' ").ExecuteNonQuery();

                    if (dgvRow_tasdiqlansin.Cells[10].Value == null)
                    {
                        dgvRow_tasdiqlansin.Cells[10].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");

                        Main.sql.return_MySqlCommand("update " + db_name + ".tasdiqlansin set date_start = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where id = '" + dgvRow_tasdiqlansin.Cells[0].Value + "' ").ExecuteNonQuery();
                    }

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal) select register_num, " +
                        "kod_num,old_otdel,old_prikaz_date1,old_prikaz_num,old_from_him,old_prikaz_date,date_start,old_doljnost,'1' from " + db_name + ".tasdiqlansin " +
                        "where id = '" + dgvRow_tasdiqlansin.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set " +
                        " otdel = '" + dgvRow_tasdiqlansin.Cells[3].Value.ToString() + "', " +
                        " doljnost = '" + dgvRow_tasdiqlansin.Cells[4].Value.ToString() + "', " +
                        " date_start = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                        " date_start2 = '" + dgvRow_tasdiqlansin.Cells[10].Value.ToString() + "', " +
                        " prikaz_start = '" + buyruq_num_textBox.Text + "', " +
                        " from_him_prikaz = '" + kim_tomonidan_textBox.Text + "', " +
                        " v_b = '0' " +
                        " where kod_num = '" + dgvRow_tasdiqlansin.Cells[9].Value.ToString() + "' ").ExecuteNonQuery();


                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void berilsin_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (berilsin_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_berilsin = berilsin_dataGridView.CurrentRow;
                    string db_name = berilsin_dataGridView.CurrentRow.Cells[berilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".unvon (register_num,kod_num,zvanie,soni,date,from_him) values( " +
                        " '" + dgvRow_berilsin.Cells[2].Value + "', " +
                        " '" + dgvRow_berilsin.Cells[1].Value + "', " +
                        " '" + dgvRow_berilsin.Cells[6].Value + "', " +
                        " '" + buyruq_num_textBox.Text + "', " +
                        " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                        " '" + kim_tomonidan_textBox.Text + "' " +
                        " )").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set " +
                       " zvanie = '" + dgvRow_berilsin.Cells[6].Value.ToString() + "' " +
                       " where kod_num = '" + dgvRow_berilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();

                    /* Main.sql.return_MySqlCommand("update work_place set " +
                        " zvanie = '" + dgvRow_berilsin.Cells[6].Value.ToString() + "' " +
                        " where kod_num = '" + dgvRow_berilsin.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();*/


                    Main.sql.return_MySqlCommand("update " + db_name + ".berilsin set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_berilsin.Cells[0].Value + "' ").ExecuteNonQuery();



                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button8_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void elon_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (elon_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_elonQilinsin = elon_dataGridView.CurrentRow;
                    string db_name = elon_dataGridView.CurrentRow.Cells[elon_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("insert into " + db_name + ".intizomiy (register_num,kod_num,date,prikaz_num,status,type_jazo,from_him,malumot) values( " +
                        " '" + dgvRow_elonQilinsin.Cells[2].Value + "', " +
                        " '" + dgvRow_elonQilinsin.Cells[1].Value + "', " +
                        " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                        " '" + buyruq_num_textBox.Text + "', " +
                        " '" + dgvRow_elonQilinsin.Cells[6].Value + "', " +
                        " '" + dgvRow_elonQilinsin.Cells[7].Value + "', " +
                        " '" + kim_tomonidan_textBox.Text + "', " +
                        " '" + dgvRow_elonQilinsin.Cells[8].Value + "' " +
                        " )").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("update " + db_name + ".elon_q set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_elonQilinsin.Cells[0].Value + "' ").ExecuteNonQuery();


                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button18_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void olib_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (olib_dataGridView.SelectedCells.Count > 0 &&
               buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_olib = olib_dataGridView.CurrentRow;
                    string db_name = olib_dataGridView.CurrentRow.Cells[olib_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("update " + db_name + ".intizomiy set cheeck_jazo='1' " +
                        " where kod_num = '" + dgvRow_olib.Cells[1].Value.ToString() + "' and " +
                        " prikaz_num = '" + dgvRow_olib.Cells[7].Value.ToString() + "' and " +
                        " date = '" + dgvRow_olib.Cells[8].Value.ToString() + "' ").ExecuteNonQuery();


                    Main.sql.return_MySqlCommand("update " + db_name + ".olib_t set cheeck='1'," +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " prikaz_from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_olib.Cells[0].Value + "' ").ExecuteNonQuery();


                    refresh_button();
                    run_alert("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void mwt_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (mwt_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = mwt_dataGridView.CurrentRow;
                    string db_name = mwt_dataGridView.CurrentRow.Cells[mwt_dataGridView.Columns.Count - 1].Value.ToString();
                    int a = 1;
                    main_dataGridView.Rows.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".work_place where otdel = '" + dgvRow.Cells[4].Value.ToString().Replace("\n", "") + "' and type='1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        if (((Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "")).Equals("1"))
                        {
                            vacant_m = "Б А Н Д";
                        }
                        else
                        {
                            vacant_m = "Б Ў Ш";
                        }

                        if (((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "")).Equals("1"))
                        {
                            otpuska_m = "О Т П У С К А";
                        }
                        else
                        {
                            otpuska_m = "";
                        }


                        main_dataGridView.Rows[main_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[1].Value = (a);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Value = (vacant_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Value = (otpuska_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "0");

                        a++;

                        if (vacant_m == "Б Ў Ш")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Style.BackColor = Color.GreenYellow;
                        }
                        if (otpuska_m != "")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                        }
                    }
                    Main.sql.myReader.Close();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("mwt_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (mwt_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_mwt = mwt_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_main = main_dataGridView.CurrentRow;
                    string db_name = mwt_dataGridView.CurrentRow.Cells[mwt_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select max(kod_num)+1 as kod_num from " + db_name + ".main").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        id_noviy = Main.sql.myReader.GetString("kod_num");
                    }
                    Main.sql.myReader.Close();

                    string nameklatura = "";
                    string korxona_string = "";
                    string stavka = "";

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select nameklatura,korxona_string,stavka from " + db_name + ".work_place where " +
                        " otdel = '" + (dgvRow_mwt.Cells[4].Value.ToString() != null ? dgvRow_mwt.Cells[4].Value.ToString() : "") + "' " +
                        " and doljnost = '" + (dgvRow_mwt.Cells[5].Value.ToString() != null ? dgvRow_mwt.Cells[5].Value.ToString() : "") + "' limit 1").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        nameklatura = Main.sql.myReader["nameklatura"] != DBNull.Value ? Main.sql.myReader.GetString("nameklatura") : "";
                        korxona_string = Main.sql.myReader["korxona_string"] != DBNull.Value ? Main.sql.myReader.GetString("korxona_string") : "";
                        stavka = Main.sql.myReader["stavka"] != DBNull.Value ? Main.sql.myReader.GetString("stavka") : "";
                    }
                    Main.sql.myReader.Close();

                    if (dgvRow_mwt.Cells[6].Value.ToString().Equals("0")) //yangi, bo`sh doljnostga otiradi
                    {
                        //if (mwt_dataGridView.CurrentRow.Cells[5].Value.ToString().Equals(main_dataGridView.CurrentRow.Cells[8].Value.ToString()))
                        //{
                            if (dgvRow_mwt.Cells[8].Value == null)
                            {
                                Main.sql.return_MySqlCommand("update " + db_name + ".mehnat set date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                                    " where id = '" + dgvRow_mwt.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                                dgvRow_mwt.Cells[8].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");
                            }


                            Main.sql.return_MySqlCommand("insert into " + db_name + ".main (kod_num,surname,name,fath_name,zvanie,otdel,doljnost,prikaz_start,date_start,date_start2,from_him_prikaz," +
                                "nameklatura,korxona_string,stavka, parent_kod_num) values (" +
                                " '" + id_noviy + "', " +
                                " '" + dgvRow_mwt.Cells[10].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[11].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[12].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[9].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[4].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[5].Value.ToString() + "', " +
                                " '" + buyruq_num_textBox.Text + "', " +
                                " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                                " '" + dgvRow_mwt.Cells[8].Value.ToString() + "', " +
                                " '" + kim_tomonidan_textBox.Text + "', " +
                                " '" + nameklatura + "', " +
                                " '" + korxona_string + "', " +
                                " '" + stavka + "', " +
                                " '0' " +
                                " )").ExecuteNonQuery();

                            /* Main.sql.return_MySqlCommand("update work_place set " +
                                 " kod_num = '" + id_noviy + "', " +
                                 " surname = '" + dgvRow_mwt.Cells[10].Value.ToString() + "', " +
                                 " name = '" + dgvRow_mwt.Cells[11].Value.ToString() + "', " +
                                 " fath_name = '" + dgvRow_mwt.Cells[12].Value.ToString() + "', " +
                                 " zvanie = '" + dgvRow_mwt.Cells[9].Value.ToString() + "', " +
                                 " vacant = '1' " +

                                 " where id = '" + dgvRow_main.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();*/

                            Main.sql.return_MySqlCommand("update " + db_name + ".mehnat set cheeck = '1', " +
                                " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                                " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                                " prikaz_from_him = '" + kim_tomonidan_textBox.Text + "', " +
                                " kod_num = '" + id_noviy + "' " +
                                " where id = '" + dgvRow_mwt.Cells[0].Value + "' ").ExecuteNonQuery();

                            refresh_button();
                            run_alert("");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        //}
                    }
                    else
                    {
                        if (dgvRow_mwt.Cells[8].Value == null)
                        {
                            Main.sql.return_MySqlCommand("update " + db_name + ".mehnat set date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                                " where id = '" + dgvRow_mwt.Cells[0].Value.ToString() + "' ").ExecuteNonQuery();

                            dgvRow_mwt.Cells[8].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");
                        }

                        Main.sql.return_MySqlCommand("insert into " + db_name + ".main (kod_num,surname,name,fath_name,zvanie,otdel,doljnost,prikaz_start,date_start,date_start2,from_him_prikaz," +
                            "nameklatura,korxona_string,stavka,parent_kod_num) values (" +
                                " '" + id_noviy + "', " +
                                " '" + dgvRow_mwt.Cells[10].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[11].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[12].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[9].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[4].Value.ToString() + "', " +
                                " '" + dgvRow_mwt.Cells[5].Value.ToString() + "', " +
                                " '" + buyruq_num_textBox.Text + "', " +
                                " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                                " '" + dgvRow_mwt.Cells[8].Value.ToString() + "', " +
                                " '" + kim_tomonidan_textBox.Text + "', " +
                                " '" + nameklatura + "', " +
                                " '" + korxona_string + "', " +
                                " '" + stavka + "', " +
                                " '" + dgvRow_mwt.Cells[6].Value.ToString() + "' " +

                                " )").ExecuteNonQuery();

                        Main.sql.myReader = Main.sql.return_MySqlCommand("select count(*) as count,id from " + db_name + ".work_place where type = '2' and vacant = '0' and id_parent = '" + dgvRow_mwt.Cells[7].Value.ToString() + "' ").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            if (Main.sql.myReader.GetString("count").Equals("0"))
                            {
                                Console.WriteLine(Main.sql.myReader.GetString("count") + " IF");
                                //Main.sql_2.return_MySqlCommand("insert into " + db_name + ".work_place(kod_num,surname,name,fath_name,otdel,doljnost,zvanie,ornida,vacant,type,id_parent) values(" +
                                //    " '" + id_noviy + "', " +
                                //    " '" + dgvRow_mwt.Cells[10].Value.ToString() + "', " +
                                //    " '" + dgvRow_mwt.Cells[11].Value.ToString() + "', " +
                                //    " '" + dgvRow_mwt.Cells[12].Value.ToString() + "', " +
                                //    " '" + dgvRow_mwt.Cells[4].Value.ToString() + "', " +
                                //    " '" + dgvRow_mwt.Cells[5].Value.ToString() + "', " +
                                //    " '" + dgvRow_mwt.Cells[9].Value.ToString() + "', " +
                                //    " '2', " +
                                //    " '1', " +
                                //    " '2', " +
                                //    " '" + dgvRow_mwt.Cells[7].Value.ToString() + "' " +
                                //    ")").ExecuteNonQuery();
                            }
                            else
                            {
                                Console.WriteLine(Main.sql.myReader.GetString("count") + " Else");
                                //Main.sql_2.return_MySqlCommand("update " + db_name + ".work_place set " +
                                //" kod_num = '" + id_noviy + "', " +
                                //" surname = '" + dgvRow_mwt.Cells[10].Value.ToString() + "', " +
                                //" name = '" + dgvRow_mwt.Cells[11].Value.ToString() + "', " +
                                //" fath_name = '" + dgvRow_mwt.Cells[12].Value.ToString() + "', " +
                                //" zvanie = '" + dgvRow_mwt.Cells[9].Value.ToString() + "', " +
                                //" ornida='2', " +
                                //" vacant = '1' " +

                                //" where id_parent = '" + dgvRow_mwt.Cells[7].Value.ToString() + "' and " +
                                //" id = '" + Main.sql.myReader.GetString("id") + "' ").ExecuteNonQuery();
                            }
                        }
                        Main.sql.myReader.Close();


                        Main.sql.return_MySqlCommand("update " + db_name + ".mehnat set cheeck = '1', " +
                                " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                                " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                                " prikaz_from_him = '" + kim_tomonidan_textBox.Text + "', " +
                                " kod_num = '" + id_noviy + "' " +
                                " where id = '" + dgvRow_mwt.Cells[0].Value + "' ").ExecuteNonQuery();


                        refresh_button();
                        run_alert("");
                    }


                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tatil_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (tatil_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_tatil = tatil_dataGridView.CurrentRow;
                    string db_name = tatil_dataGridView.CurrentRow.Cells[tatil_dataGridView.Columns.Count - 1].Value.ToString();
                    if (dgvRow_tatil.Cells[8].Value.ToString().Equals("Ўз хизмат вазифасига киришди"))
                    {

                        Main.sql.return_MySqlCommand("insert into " + db_name + ".otpuska (register_num,kod_num,date_start,surname,name,fath_name,otdel,doljnost,tashxis,asos,type_otpusk, " +
                            " prikaz_date,prikaz_num,prikaz_from_him) values( " +
                            " '" + dgvRow_tatil.Cells[2].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[1].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[6].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[11].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[12].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[13].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[4].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[5].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[9].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[10].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[8].Value.ToString() + "', " +
                            " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                            " '" + buyruq_num_textBox.Text + "'," +
                            " '" + kim_tomonidan_textBox.Text + "' " +
                            " )").ExecuteNonQuery();
                    }
                    else
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".otpuska (register_num,kod_num,date_start,date_finish,surname,name,fath_name,otdel,doljnost,tashxis,asos,type_otpusk, " +
                            " prikaz_date,prikaz_num,prikaz_from_him) values( " +
                            " '" + dgvRow_tatil.Cells[2].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[1].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[6].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[7].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[11].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[12].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[13].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[4].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[5].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[9].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[10].Value.ToString() + "', " +
                            " '" + dgvRow_tatil.Cells[8].Value.ToString() + "', " +
                            " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                            " '" + buyruq_num_textBox.Text + "'," +
                            " '" + kim_tomonidan_textBox.Text + "' " +
                            " )").ExecuteNonQuery();
                    }

                    /* if (dgvRow_tatil.Cells[8].Value.ToString().Equals("Фарзанди 2 ёшга тўлгунга қадар декрет таътилида деб хисоблансин") ||
                         dgvRow_tatil.Cells[8].Value.ToString().Equals("Фарзанди 3 ёшга тўлгунга қадар декрет таътилида деб хисоблансин") ||
                         dgvRow_tatil.Cells[8].Value.ToString().Equals("Туғруққача ва туғруқдан кейинги таътилда деб хисоблансин") ||
                         dgvRow_tatil.Cells[8].Value.ToString().Equals("Туғруққача ва туғруқдан кейинги таътили узайтирилсин"))
                     {
                         Main.sql.return_MySqlCommand("update work_place set otpuska = '1' where kod_num = '" + dgvRow_tatil.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();
                     }

                     if (dgvRow_tatil.Cells[8].Value.ToString().Equals("Ўз хизмат вазифасига киришди"))
                     {
                         Main.sql.return_MySqlCommand("update work_place set otpuska = '0' where kod_num = '" + dgvRow_tatil.Cells[1].Value.ToString() + "' ").ExecuteNonQuery();
                     }*/

                    Main.sql.return_MySqlCommand("update " + db_name + ".otpuska_p set cheeck = '1', " +
                                " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                                " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                                " prikaz_from_him = '" + kim_tomonidan_textBox.Text + "' " +
                                " where id = '" + dgvRow_tatil.Cells[0].Value + "' ").ExecuteNonQuery();


                    refresh_button();
                    run_alert("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void mwBekor_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            main_dataGridView.Rows.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (mwBekor_dataGridView.SelectedCells.Count > 0 &&
                buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_mwBekor = mwBekor_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_main = main_dataGridView.CurrentRow;
                    string db_name = mwBekor_dataGridView.CurrentRow.Cells[mwBekor_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id,type from " + db_name + ".work_place where kod_num='" + dgvRow_mwBekor.Cells[1].Value + "' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        type_p = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "");
                        id_p = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");
                    }
                    Main.sql.myReader.Close();

                    Main.sql.return_MySqlCommand("update " + db_name + ".mehnat_b set cheeck = '1', " +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " prikaz_from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_mwBekor.Cells[0].Value + "' ").ExecuteNonQuery();

                    if (dgvRow_mwBekor.Cells[7].Value == null)
                    {
                        dgvRow_mwBekor.Cells[7].Value = buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd");

                        Main.sql.return_MySqlCommand("update " + db_name + ".mehnat_b set date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                            " where id = '" + dgvRow_mwBekor.Cells[0].Value + "' ").ExecuteNonQuery();
                    }

                    Main.sql.return_MySqlCommand("update " + db_name + ".main set " +
                                " date_finish = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                                " prikaz_finish = '" + buyruq_num_textBox.Text + "'," +
                                " date_finish2 = '" + dgvRow_mwBekor.Cells[7].Value + "' " +
                                " where kod_num = '" + dgvRow_mwBekor.Cells[1].Value + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".trudovoy (register_num,kod_num,work_place,prikaz_date,prikaz_num,from_him,date_start,date_finish,doljnost,for_cal) select register_num, " +
                        " kod_num,otdel,date_start,prikaz_start,from_him_prikaz,date_start2,date_finish2,doljnost,'1' from " + db_name + ".main where " +
                        " kod_num = '" + dgvRow_mwBekor.Cells[1].Value + "' ").ExecuteNonQuery();

                    /*sql.return_MySqlCommand("update work_place set register_num='',kod_num='0',surname='',name='',fath_name='',zvanie='',vacant='0',lichniy_num='',ornida='0' "+
                        " where id = '" + id_p + "' ").ExecuteNonQuery();*/


                    refresh_button();
                    run_alert("");

                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void zaxiraga_oliw_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (zaxiraga_oliw_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = zaxiraga_oliw_dataGridView.CurrentRow;
                    string db_name = zaxiraga_oliw_dataGridView.CurrentRow.Cells[zaxiraga_oliw_dataGridView.Columns.Count - 1].Value.ToString();
                    int a = 1;
                    main_dataGridView.Rows.Clear();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".work_place where otdel = '" + dgvRow.Cells[3].Value.ToString().Replace("\n", "") + "' and type='1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        if (((Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "")).Equals("1"))
                        {
                            vacant_m = "Б А Н Д";
                        }
                        else
                        {
                            vacant_m = "Б Ў Ш";
                        }

                        if (((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "")).Equals("1"))
                        {
                            otpuska_m = "О Т П У С К А";
                        }
                        else
                        {
                            otpuska_m = "";
                        }


                        main_dataGridView.Rows[main_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[1].Value = (a);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Value = (vacant_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Value = (otpuska_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "0");

                        a++;

                        if (vacant_m == "Б Ў Ш")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Style.BackColor = Color.GreenYellow;
                        }
                        if (otpuska_m != "")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                        }
                    }
                    Main.sql.myReader.Close();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("zaxiraga_oliw_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (buyruq_num_textBox.Text != "" &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_zaxiraga_olish = zaxiraga_oliw_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_main = main_dataGridView.CurrentRow;
                    string db_name = zaxiraga_oliw_dataGridView.CurrentRow.Cells[zaxiraga_oliw_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("update " + db_name + ".zaxira_boshliq set cheeck = '1'" +
                        " where id = '" + dgvRow_zaxiraga_olish.Cells[0].Value + "' ").ExecuteNonQuery();

                    Main.sql.myReader = Main.sql.return_MySqlCommand("select id from " + db_name + ".work_place where otdel = '" + dgvRow_zaxiraga_olish.Cells[3].Value.ToString() + "' and doljnost = '" + dgvRow_zaxiraga_olish.Cells[4].Value.ToString() + "'").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        Main.sql.return_MySqlCommand("update " + db_name + ".main set " +
                                    " zaxira_work_place_id = '" + Main.sql.myReader.GetString("id") + "' " +
                                    " where kod_num = '" + dgvRow_zaxiraga_olish.Cells[1].Value + "' ").ExecuteNonQuery();
                    }
                    Main.sql.myReader.Close();
                    refresh_button();
                    run_alert("");

                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void med_dobavit_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (med_dobavit_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = med_dobavit_dataGridView.CurrentRow;
                    int a = 1;
                    main_dataGridView.Rows.Clear();
                    string db_name = med_dobavit_dataGridView.CurrentRow.Cells[med_dobavit_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".work_place where otdel = '" + dgvRow.Cells[3].Value.ToString().Replace("\n", "") + "' and type='1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        if (((Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "")).Equals("1"))
                        {
                            vacant_m = "Б А Н Д";
                        }
                        else
                        {
                            vacant_m = "Б Ў Ш";
                        }

                        if (((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "")).Equals("1"))
                        {
                            otpuska_m = "О Т П У С К А";
                        }
                        else
                        {
                            otpuska_m = "";
                        }


                        main_dataGridView.Rows[main_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[1].Value = (a);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Value = (vacant_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Value = (otpuska_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "0");

                        a++;

                        if (vacant_m == "Б Ў Ш")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Style.BackColor = Color.GreenYellow;
                        }
                        if (otpuska_m != "")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                        }
                    }
                    Main.sql.myReader.Close();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("med_dobavit_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_med_dobavit = med_dobavit_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_main = main_dataGridView.CurrentRow;
                    string db_name = med_dobavit_dataGridView.CurrentRow.Cells[med_dobavit_dataGridView.Columns.Count - 1].Value.ToString();
                    if (dgvRow_med_dobavit.Cells[9].Value.ToString().Equals("1"))
                    {
                        Main.sql.myReader = Main.sql.return_MySqlCommand("select max(kod_num)+1 as kod_num from " + db_name + ".main").ExecuteReader();
                        while (Main.sql.myReader.Read())
                        {
                            id_noviy = Main.sql.myReader.GetString("kod_num");
                        }
                        Main.sql.myReader.Close();
                    }
                    else if (dgvRow_med_dobavit.Cells[9].Value.ToString().Equals("2"))
                    {
                        id_noviy = dgvRow_med_dobavit.Cells[1].Value.ToString();
                    }

                    if (dgvRow_med_dobavit.Cells[9].Value.ToString().Equals("1")) // Agar iwci kocadan, yangi keledigon bosa mainga qowamiz, 2 bolsa bazada uni danniysi uje boladi
                    {
                        Main.sql.return_MySqlCommand("insert into " + db_name + ".main (kod_num,surname,name,fath_name,zvanie,otdel,doljnost,prikaz_start,date_start,date_start2,from_him_prikaz," +
                            "stavka,orindosh_work_place_id) values ( " +
                            " '" + id_noviy + "', " +
                            " '" + (dgvRow_med_dobavit.Cells[6].Value) + "', " +
                            " '" + (dgvRow_med_dobavit.Cells[7].Value) + "', " +
                            " '" + (dgvRow_med_dobavit.Cells[8].Value) + "', " +
                            " 'ўриндош', " +
                            " '" + (dgvRow_med_dobavit.Cells[3].Value) + "', " +
                            " '" + (dgvRow_med_dobavit.Cells[4].Value) + "', " +
                            " '" + buyruq_num_textBox.Text + "', " +
                            " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                            " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
                            " '" + kim_tomonidan_textBox.Text + "', " +
                            " '" + (dgvRow_med_dobavit.Cells[5].Value) + "', " +
                            " '" + (dgvRow_main.Cells[0].Value) + "' " +
                            " )").ExecuteNonQuery();
                    }

                    Main.sql.return_MySqlCommand("update " + db_name + ".dobavit_med set cheeck = '1', " +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "', " +
                        " kod_num = '" + id_noviy + "' " +
                        " where id = '" + dgvRow_med_dobavit.Cells[0].Value + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".orindoshlar(kod_num,surname,name,fath_name,otdel,doljnost,stavka,orindosh_work_place_id,date_start) values(" +
                        " '" + id_noviy + "', " +
                        " '" + (dgvRow_med_dobavit.Cells[6].Value) + "', " +
                        " '" + (dgvRow_med_dobavit.Cells[7].Value) + "', " +
                        " '" + (dgvRow_med_dobavit.Cells[8].Value) + "', " +
                        " '" + (dgvRow_med_dobavit.Cells[3].Value) + "', " +
                        " '" + (dgvRow_med_dobavit.Cells[4].Value) + "', " +
                        " '" + (dgvRow_med_dobavit.Cells[5].Value) + "', " +
                        " '" + (dgvRow_main.Cells[0].Value) + "', " +
                        " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                        ")").ExecuteNonQuery();


                    refresh_button();
                    run_alert("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tay_yan_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (tay_yan_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = tay_yan_dataGridView.CurrentRow;
                    string db_name = tay_yan_dataGridView.CurrentRow.Cells[tay_yan_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".dobavit where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tay_yan_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = tay_yan_dataGridView.CurrentRow;
                    string db_name = tay_yan_dataGridView.CurrentRow.Cells[tay_yan_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".dobavit where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    get_items_from_tay_yan_function();
                }
                else
                {

                }
            }
        }

        private void tay_per_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (tay_per_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = tay_per_dataGridView.CurrentRow;
                    string db_name = tay_per_dataGridView.CurrentRow.Cells[tay_per_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".perevod where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tay_per_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = tay_per_dataGridView.CurrentRow;
                    string db_name = tay_per_dataGridView.CurrentRow.Cells[tay_per_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".perevod where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    get_items_from_tay_per_function();
                }
                else
                {

                }
            }
        }

        private void oz_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (oz_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = oz_dataGridView.CurrentRow;
                    string db_name = oz_dataGridView.CurrentRow.Cells[oz_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".perevod_oz where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void bowatilsin_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (bowatilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = bowatilsin_dataGridView.CurrentRow;
                    string db_name = bowatilsin_dataGridView.CurrentRow.Cells[bowatilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".boshatish where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void yuborilsin_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (yuborilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = yuborilsin_dataGridView.CurrentRow;
                    string db_name = yuborilsin_dataGridView.CurrentRow.Cells[yuborilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".yuborish where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void qoldirilsin_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (qoldirilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = qoldirilsin_dataGridView.CurrentRow;
                    string db_name = qoldirilsin_dataGridView.CurrentRow.Cells[qoldirilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".qoldirilsin where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void tasdiqlansin_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (tasdiqlansin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = tasdiqlansin_dataGridView.CurrentRow;
                    string db_name = tasdiqlansin_dataGridView.CurrentRow.Cells[tasdiqlansin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".tasdiqlansin where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void berilsin_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (berilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = berilsin_dataGridView.CurrentRow;
                    string db_name = berilsin_dataGridView.CurrentRow.Cells[berilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".berilsin where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void elon_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (elon_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = elon_dataGridView.CurrentRow;
                    string db_name = elon_dataGridView.CurrentRow.Cells[elon_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".elon_q where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void olib_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (olib_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = olib_dataGridView.CurrentRow;
                    string db_name = olib_dataGridView.CurrentRow.Cells[olib_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".olib_t where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void mwt_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (mwt_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = mwt_dataGridView.CurrentRow;
                    string db_name = mwt_dataGridView.CurrentRow.Cells[mwt_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".mehnat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
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
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = tatil_dataGridView.CurrentRow;
                    string db_name = tatil_dataGridView.CurrentRow.Cells[tatil_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".otpuska_p where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void mwBekor_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (mwBekor_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = mwBekor_dataGridView.CurrentRow;
                    string db_name = mwBekor_dataGridView.CurrentRow.Cells[mwBekor_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".mehnat_b where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void zaxiraga_oliw_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (zaxiraga_oliw_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = zaxiraga_oliw_dataGridView.CurrentRow;
                    string db_name = zaxiraga_oliw_dataGridView.CurrentRow.Cells[zaxiraga_oliw_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".zaxira_boshliq where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void med_dobavit_dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (med_dobavit_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = med_dobavit_dataGridView.CurrentRow;
                    string db_name = med_dobavit_dataGridView.CurrentRow.Cells[med_dobavit_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".dobavit_med where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void bolnicniy_dobavit_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (bolnicniy_dobavit_dataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    DataGridViewRow dgvRow = bolnicniy_dobavit_dataGridView.CurrentRow;
                    int a = 1;
                    main_dataGridView.Rows.Clear();
                    string db_name = bolnicniy_dobavit_dataGridView.CurrentRow.Cells[bolnicniy_dobavit_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.myReader = Main.sql.return_MySqlCommand("select * from " + db_name + ".work_place where otdel = '" + dgvRow.Cells[3].Value.ToString().Replace("\n", "") + "' and type='1' ").ExecuteReader();
                    while (Main.sql.myReader.Read())
                    {
                        if (((Main.sql.myReader["vacant"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("vacant")) : "")).Equals("1"))
                        {
                            vacant_m = "Б А Н Д";
                        }
                        else
                        {
                            vacant_m = "Б Ў Ш";
                        }

                        if (((Main.sql.myReader["otpuska"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("otpuska")) : "")).Equals("1"))
                        {
                            otpuska_m = "О Т П У С К А";
                        }
                        else
                        {
                            otpuska_m = "";
                        }


                        main_dataGridView.Rows[main_dataGridView.Rows.Add()].Cells[0].Value = (Main.sql.myReader["id"] != DBNull.Value ? Main.sql.myReader.GetString("id") : "");

                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[1].Value = (a);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[2].Value = (Main.sql.myReader["register_num"] != DBNull.Value ? Main.sql.myReader.GetString("register_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[3].Value = (Main.sql.myReader["kod_num"] != DBNull.Value ? Main.sql.myReader.GetString("kod_num") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[4].Value = (Main.sql.myReader["surname"] != DBNull.Value ? Main.sql.myReader.GetString("surname") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[5].Value = (Main.sql.myReader["name"] != DBNull.Value ? Main.sql.myReader.GetString("name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[6].Value = (Main.sql.myReader["fath_name"] != DBNull.Value ? Main.sql.myReader.GetString("fath_name") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[7].Value = (Main.sql.myReader["otdel"] != DBNull.Value ? Main.sql.myReader.GetString("otdel") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[8].Value = (Main.sql.myReader["doljnost"] != DBNull.Value ? Main.sql.myReader.GetString("doljnost") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[9].Value = (Main.sql.myReader["zvanie"] != DBNull.Value ? Main.sql.myReader.GetString("zvanie") : "");
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Value = (vacant_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Value = (otpuska_m);
                        main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[12].Value = (Main.sql.myReader["type"] != DBNull.Value ? Convert.ToString(Main.sql.myReader.GetByte("type")) : "0");

                        a++;

                        if (vacant_m == "Б Ў Ш")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[10].Style.BackColor = Color.GreenYellow;
                        }
                        if (otpuska_m != "")
                        {
                            main_dataGridView.Rows[main_dataGridView.Rows.Count - 1].Cells[11].Style.BackColor = Color.GreenYellow;
                        }
                    }
                    Main.sql.myReader.Close();
                }
                catch (Exception ex)
                {
                    Main.sql.myReader.Close();
                    MessageBox.Show("bolnicniy_dobavit_dataGridView_SelectionChanged " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (buyruq_num_textBox.Text != "" && buyruq_num_textBox.Text != "   ш.т." &&
                kim_tomonidan_textBox.Text != "")
            {
                try
                {
                    DataGridViewRow dgvRow_bolnicniy_dobavit = bolnicniy_dobavit_dataGridView.CurrentRow;
                    DataGridViewRow dgvRow_main = main_dataGridView.CurrentRow;
                    string db_name = bolnicniy_dobavit_dataGridView.CurrentRow.Cells[bolnicniy_dobavit_dataGridView.Columns.Count - 1].Value.ToString();


                    Main.sql.return_MySqlCommand("update " + db_name + ".bolnicniy_dobavit set cheeck = '1', " +
                        " prikaz_num = '" + buyruq_num_textBox.Text + "'," +
                        " prikaz_date = '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                        " from_him = '" + kim_tomonidan_textBox.Text + "' " +
                        " where id = '" + dgvRow_bolnicniy_dobavit.Cells[0].Value + "' ").ExecuteNonQuery();

                    Main.sql.return_MySqlCommand("insert into " + db_name + ".bolnichniylar_orniga(kod_num,surname,name,fath_name,otdel,doljnost,stavka,bolnichniy_work_place_id,date_start) values(" +
                        " '" + (dgvRow_bolnicniy_dobavit.Cells[1].Value) + "', " +
                        " '" + (dgvRow_bolnicniy_dobavit.Cells[6].Value) + "', " +
                        " '" + (dgvRow_bolnicniy_dobavit.Cells[7].Value) + "', " +
                        " '" + (dgvRow_bolnicniy_dobavit.Cells[8].Value) + "', " +
                        " '" + (dgvRow_bolnicniy_dobavit.Cells[3].Value) + "', " +
                        " '" + (dgvRow_bolnicniy_dobavit.Cells[4].Value) + "', " +
                        " '" + (dgvRow_bolnicniy_dobavit.Cells[5].Value) + "', " +
                        " '" + (dgvRow_main.Cells[0].Value) + "', " +
                        " '" + buyruq_date_dateTimePicker.Value.ToString("yyyy-MM-dd") + "' " +
                        ")").ExecuteNonQuery();


                    refresh_button();
                    run_alert("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("button20_Click " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Проверьте одну из пунктов:\n\n1. Заполните данные\n2. Вы не выбрали должность или этот должность занят\n3. Должность не совпадает", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bowatilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = bowatilsin_dataGridView.CurrentRow;
                    string db_name = bowatilsin_dataGridView.CurrentRow.Cells[bowatilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".boshatish where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (yuborilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = yuborilsin_dataGridView.CurrentRow;
                    string db_name = yuborilsin_dataGridView.CurrentRow.Cells[yuborilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".yuborish where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (qoldirilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = qoldirilsin_dataGridView.CurrentRow;
                    string db_name = qoldirilsin_dataGridView.CurrentRow.Cells[qoldirilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".qoldirilsin where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (berilsin_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = berilsin_dataGridView.CurrentRow;
                    string db_name = berilsin_dataGridView.CurrentRow.Cells[berilsin_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".berilsin where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (elon_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = elon_dataGridView.CurrentRow;
                    string db_name = elon_dataGridView.CurrentRow.Cells[elon_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".elon_q where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (mwt_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = mwt_dataGridView.CurrentRow;

                    string db_name = mwt_dataGridView.CurrentRow.Cells[mwt_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".mehnat where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    mwt_dataGridView.Rows.Remove(dgvRow);
                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                    refresh_button();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (tatil_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = tatil_dataGridView.CurrentRow;
                    string db_name = tatil_dataGridView.CurrentRow.Cells[tatil_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".optuska_p where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                    refresh_button();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (mwBekor_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow dgvRow = mwBekor_dataGridView.CurrentRow;
                    string db_name = mwBekor_dataGridView.CurrentRow.Cells[mwBekor_dataGridView.Columns.Count - 1].Value.ToString();
                    Main.sql.return_MySqlCommand("delete from " + db_name + ".mehnat_b where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();

                    /////////////////////////////////////////////////////////////////////////////
                    //get_items_from_tay_yan_function();
                    refresh_button();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (elon_dataGridView.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Вы уверены ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dgvRow in olib_dataGridView.SelectedRows)
                    {
                        string db_name = dgvRow.Cells[elon_dataGridView.Columns.Count - 1].Value.ToString();
                        Main.sql.return_MySqlCommand("delete from " + db_name + ".olib_t where id = '" + dgvRow.Cells[0].Value + "' ").ExecuteNonQuery();
                    }
                    /////////////////////////////////////////////////////////////////////////////
                    refresh_button();
                }
                else
                {
                    //e.Cancel = true;
                }
            }
        }
    }
}