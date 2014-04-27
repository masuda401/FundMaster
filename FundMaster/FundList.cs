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
                makeApplicationForm();
            }
        }

        private void makeApplicationForm()
        {
            object oMissing = System.Reflection.Missing.Value;

            Word._Application oWord;
            Word._Document oDocument;
            oWord = new Word.Application();
            oWord.Visible = true;

            object oTemplate = "C:\\申請書.dot";
            oDocument = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

            // 申請年月日
            object oBookMark = "ProposedDate";
            oDocument.Bookmarks.get_Item(ref oBookMark).Range.Text = "システムからの入力です。";

            this.Close();
        }

    }
}
