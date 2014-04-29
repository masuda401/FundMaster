using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace FundMaster
{
    public partial class FundList : Form
    {
        public FundList()
        {
            InitializeComponent();
        }

        private void btnFundListSearch_Click(object sender, EventArgs e)
        {
            //string newHandingDate = "";
            DataSet ds = new DataSet();

            System.Data.OleDb.OleDbDataAdapter da;
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\masuda\\Desktop\\投信銘柄情報管理DB構想\\FundMaster.accdb");
            da = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 投信;", con);
            da.Fill(ds, "投信");
            this.dataGridView1.DataSource = ds.Tables["投信"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FundMaster fr = new FundMaster();
            DialogResult dr = fr.ShowDialog();
        }

        private void FundList_Load(object sender, EventArgs e)
        {
            handingTypeDataSet.HandingTypeDataTable.AddHandingTypeDataTableRow("募集", "1");
            handingTypeDataSet.HandingTypeDataTable.AddHandingTypeDataTableRow("新規取扱", "2");
            handingTypeDataSet.HandingTypeDataTable.AddHandingTypeDataTableRow("全て", "3");

            outputDataSet.OutputDataTable.AddOutputDataTableRow("1", "[投]申請書");
            outputDataSet.OutputDataTable.AddOutputDataTableRow("2", "[決]MS銘柄登録依頼書");
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "[投]申請書")
            {

                for (int i = 0; i < this.dataGridView1.RowCount; i++)
                {
                    DataGridViewRow vr;
                    vr = dataGridView1.Rows[i];
                    makeApplicationForm2(vr);
                }
            }
        }

        private void makeApplicationForm2(DataGridViewRow dgvr)
        {
            object oMissing = System.Reflection.Missing.Value;

            Word._Application oWord;
            Word._Document oDocument;
            oWord = new Word.Application();
            oWord.Visible = false;

            oWord.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;

            object oTemplate = "C:\\Users\\masuda\\Desktop\\申請書.dotx";
            oDocument = oWord.Documents.Open(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

            object fileName = @"C:\Users\masuda\Desktop\申請書_" + dgvr.Cells[0].Value.ToString() + ".docx";
            oDocument.SaveAs(ref fileName, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            
            
            oWord.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            oWord = null;

            this.Close();
        }

        private void makeApplicationForm(DataGridViewRow dgvr)
        {



            object oMissing = System.Reflection.Missing.Value;

            Word._Application oWord;
            Word._Document oDocument;
            oWord = new Word.Application();
            oWord.Visible = true;

            object oTemplate = "C:\\Users\\masuda\\Desktop\\申請書.doc";
            oDocument = oWord.Documents.Open(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

            // 申請年月日
            DateTime dt = DateTime.Today;
            object oProposedDate = "ProposedDate";
            oDocument.Bookmarks.get_Item(ref oProposedDate).Range.Text = dt.ToLongDateString();

            // 件名
            object oSubject = "Subject";
            oDocument.Bookmarks.get_Item(ref oSubject).Range.Text = "";

            // 件名
            object oFundName1 = "FundName1";
            oDocument.Bookmarks.get_Item(ref oFundName1).Range.Text = dgvr.Cells[0].Value.ToString();

            // 委託会社
            object oSettlorCompany = "SettlorCompany";
            oDocument.Bookmarks.get_Item(ref oSettlorCompany).Range.Text = dgvr.Cells[1].Value.ToString();

            // 名称
            object oFundName2 = "FundName2";
            oDocument.Bookmarks.get_Item(ref oFundName2).Range.Text = dgvr.Cells[0].Value.ToString();

            // 販売開始日
            object oSaleStartDate = "SaleStartDate";
            oDocument.Bookmarks.get_Item(ref oSaleStartDate).Range.Text = "";

            // 手数料(ネット)
            object oNetCommission = "NetCommission";
            oDocument.Bookmarks.get_Item(ref oNetCommission).Range.Text = "";

            // 手数料(対面)
            object oCounterCommission = "CounterCommission";
            oDocument.Bookmarks.get_Item(ref oCounterCommission).Range.Text = "";

            // 商品性
            object oMarketability = "Marketability";
            oDocument.Bookmarks.get_Item(ref oMarketability).Range.Text = dgvr.Cells[2].Value.ToString();

            //oWord.Documents[@"C:\Users\masuda\Desktop\申請書_" + dgvr.Cells[0].Value.ToString() + ".doc"].Save();

            try
            {
                object fileName = @"C:\Users\masuda\Desktop\申請書_" + dgvr.Cells[0].Value.ToString() + ".doc";
                oWord.ActiveDocument.SaveAs(ref fileName, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            oWord.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            oWord = null;

            this.Close();
        }

    }
}
