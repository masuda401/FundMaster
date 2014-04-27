namespace FundMaster
{
    partial class FundList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnFundListSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.outputDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outputDataSet = new OutputDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.handingTypeDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.handingTypeDataSet = new HandingTypeDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handingTypeDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handingTypeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 19);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnFundListSearch
            // 
            this.btnFundListSearch.Location = new System.Drawing.Point(447, 14);
            this.btnFundListSearch.Name = "btnFundListSearch";
            this.btnFundListSearch.Size = new System.Drawing.Size(75, 23);
            this.btnFundListSearch.TabIndex = 2;
            this.btnFundListSearch.Text = "検索";
            this.btnFundListSearch.UseVisualStyleBackColor = true;
            this.btnFundListSearch.Click += new System.EventHandler(this.btnFundListSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "募集・新規取扱日";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(508, 215);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(365, 274);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(446, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(245, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "商品タイプ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.outputDataTableBindingSource;
            this.comboBox2.DisplayMember = "アウトプット名";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 277);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // outputDataTableBindingSource
            // 
            this.outputDataTableBindingSource.DataMember = "OutputDataTable";
            this.outputDataTableBindingSource.DataSource = this.outputDataSet;
            // 
            // outputDataSet
            // 
            this.outputDataSet.DataSetName = "OutputDataSet";
            this.outputDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "アウトプット書式";
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(227, 275);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(75, 23);
            this.btnDownLoad.TabIndex = 14;
            this.btnDownLoad.Text = "ダウンロード";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.handingTypeDataTableBindingSource;
            this.comboBox1.DisplayMember = "取扱種別";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(312, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 15;
            // 
            // handingTypeDataTableBindingSource
            // 
            this.handingTypeDataTableBindingSource.DataMember = "HandingTypeDataTable";
            this.handingTypeDataTableBindingSource.DataSource = this.handingTypeDataSet;
            // 
            // handingTypeDataSet
            // 
            this.handingTypeDataSet.DataSetName = "HandingTypeDataSet";
            this.handingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FundList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 316);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFundListSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FundList";
            this.Text = "国内投信銘柄情報一覧";
            this.Load += new System.EventHandler(this.FundList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handingTypeDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handingTypeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnFundListSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource handingTypeDataTableBindingSource;
        private HandingTypeDataSet handingTypeDataSet;
        private System.Windows.Forms.BindingSource outputDataTableBindingSource;
        private OutputDataSet outputDataSet;

    }
}