namespace Toode_app_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToodeNimetus = new System.Windows.Forms.TextBox();
            this.txtKogus = new System.Windows.Forms.TextBox();
            this.txtHind = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kustutaBtn = new System.Windows.Forms.Button();
            this.uuendaBtn = new System.Windows.Forms.Button();
            this.lisaBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addCategory = new System.Windows.Forms.Button();
            this.delCategory = new System.Windows.Forms.Button();
            this.toodeDataSet = new Toode_app_2.toodeDataSet();
            this.toodedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodeDataSet1 = new Toode_app_2.toodeDataSet();
            this.toodedTableAdapter = new Toode_app_2.toodeDataSetTableAdapters.toodedTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategooriaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toodedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leleleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kekkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jjejejeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qweqweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qweqweToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dsfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsdfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsdfToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(88, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toode nimetus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(136, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategooria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(211, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hind";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(190, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kogus";
            // 
            // txtToodeNimetus
            // 
            this.txtToodeNimetus.Location = new System.Drawing.Point(365, 84);
            this.txtToodeNimetus.Name = "txtToodeNimetus";
            this.txtToodeNimetus.Size = new System.Drawing.Size(295, 20);
            this.txtToodeNimetus.TabIndex = 5;
            // 
            // txtKogus
            // 
            this.txtKogus.Location = new System.Drawing.Point(365, 138);
            this.txtKogus.Name = "txtKogus";
            this.txtKogus.Size = new System.Drawing.Size(295, 20);
            this.txtKogus.TabIndex = 6;
            // 
            // txtHind
            // 
            this.txtHind.Location = new System.Drawing.Point(365, 197);
            this.txtHind.Name = "txtHind";
            this.txtHind.Size = new System.Drawing.Size(295, 20);
            this.txtHind.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(707, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // kustutaBtn
            // 
            this.kustutaBtn.Location = new System.Drawing.Point(944, 349);
            this.kustutaBtn.Name = "kustutaBtn";
            this.kustutaBtn.Size = new System.Drawing.Size(144, 78);
            this.kustutaBtn.TabIndex = 10;
            this.kustutaBtn.Text = "Kustuta";
            this.kustutaBtn.UseVisualStyleBackColor = true;
            this.kustutaBtn.Click += new System.EventHandler(this.kustutaBtn_Click);
            // 
            // uuendaBtn
            // 
            this.uuendaBtn.Location = new System.Drawing.Point(763, 349);
            this.uuendaBtn.Name = "uuendaBtn";
            this.uuendaBtn.Size = new System.Drawing.Size(144, 78);
            this.uuendaBtn.TabIndex = 11;
            this.uuendaBtn.Text = "Uenda";
            this.uuendaBtn.UseVisualStyleBackColor = true;
            this.uuendaBtn.Click += new System.EventHandler(this.uuendaBtn_Click);
            // 
            // lisaBtn
            // 
            this.lisaBtn.Location = new System.Drawing.Point(582, 349);
            this.lisaBtn.Name = "lisaBtn";
            this.lisaBtn.Size = new System.Drawing.Size(144, 78);
            this.lisaBtn.TabIndex = 13;
            this.lisaBtn.Text = "Lisa";
            this.lisaBtn.UseVisualStyleBackColor = true;
            this.lisaBtn.Click += new System.EventHandler(this.lisaBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 78);
            this.button4.TabIndex = 16;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 78);
            this.button5.TabIndex = 15;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(38, 349);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(144, 78);
            this.addCategory.TabIndex = 18;
            this.addCategory.Text = "Lisa kategooria";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // delCategory
            // 
            this.delCategory.Location = new System.Drawing.Point(219, 349);
            this.delCategory.Name = "delCategory";
            this.delCategory.Size = new System.Drawing.Size(144, 78);
            this.delCategory.TabIndex = 17;
            this.delCategory.Text = "Kustuta kategooria";
            this.delCategory.UseVisualStyleBackColor = true;
            this.delCategory.Click += new System.EventHandler(this.delCategoryBtn_Click);
            // 
            // toodeDataSet
            // 
            this.toodeDataSet.DataSetName = "toodeDataSet";
            this.toodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodedBindingSource
            // 
            this.toodedBindingSource.DataMember = "tooded";
            this.toodedBindingSource.DataSource = this.toodeDataSet1;
            // 
            // toodeDataSet1
            // 
            this.toodeDataSet1.DataSetName = "toodeDataSet";
            this.toodeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodedTableAdapter
            // 
            this.toodedTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn,
            this.piltDataGridViewTextBoxColumn,
            this.kategooriaidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodedBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(38, 448);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 308);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimetusDataGridViewTextBoxColumn
            // 
            this.nimetusDataGridViewTextBoxColumn.DataPropertyName = "nimetus";
            this.nimetusDataGridViewTextBoxColumn.HeaderText = "nimetus";
            this.nimetusDataGridViewTextBoxColumn.Name = "nimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // piltDataGridViewTextBoxColumn
            // 
            this.piltDataGridViewTextBoxColumn.DataPropertyName = "pilt";
            this.piltDataGridViewTextBoxColumn.HeaderText = "pilt";
            this.piltDataGridViewTextBoxColumn.Name = "piltDataGridViewTextBoxColumn";
            // 
            // kategooriaidDataGridViewTextBoxColumn
            // 
            this.kategooriaidDataGridViewTextBoxColumn.DataPropertyName = "kategooria_id";
            this.kategooriaidDataGridViewTextBoxColumn.HeaderText = "kategooria_id";
            this.kategooriaidDataGridViewTextBoxColumn.Name = "kategooriaidDataGridViewTextBoxColumn";
            // 
            // toodedBindingSource1
            // 
            this.toodedBindingSource1.DataMember = "tooded";
            this.toodedBindingSource1.DataSource = this.toodeDataSet1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lelleToolStripMenuItem,
            this.leleleToolStripMenuItem,
            this.kekkToolStripMenuItem,
            this.jjejejeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 92);
            // 
            // lelleToolStripMenuItem
            // 
            this.lelleToolStripMenuItem.Name = "lelleToolStripMenuItem";
            this.lelleToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.lelleToolStripMenuItem.Text = "lelle";
            // 
            // leleleToolStripMenuItem
            // 
            this.leleleToolStripMenuItem.Name = "leleleToolStripMenuItem";
            this.leleleToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.leleleToolStripMenuItem.Text = "lelele";
            // 
            // kekkToolStripMenuItem
            // 
            this.kekkToolStripMenuItem.Name = "kekkToolStripMenuItem";
            this.kekkToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.kekkToolStripMenuItem.Text = "kekk";
            // 
            // jjejejeToolStripMenuItem
            // 
            this.jjejejeToolStripMenuItem.Name = "jjejejeToolStripMenuItem";
            this.jjejejeToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.jjejejeToolStripMenuItem.Text = "jjejeje";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdToolStripMenuItem,
            this.qweqweToolStripMenuItem,
            this.qweqweToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(119, 70);
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.asdasdToolStripMenuItem.Text = "asdasd";
            // 
            // qweqweToolStripMenuItem
            // 
            this.qweqweToolStripMenuItem.Name = "qweqweToolStripMenuItem";
            this.qweqweToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.qweqweToolStripMenuItem.Text = "qweqwe";
            // 
            // qweqweToolStripMenuItem1
            // 
            this.qweqweToolStripMenuItem1.Name = "qweqweToolStripMenuItem1";
            this.qweqweToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.qweqweToolStripMenuItem1.Text = "qweqwe";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsfsdfToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(107, 26);
            // 
            // dsfsdfToolStripMenuItem
            // 
            this.dsfsdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsdfToolStripMenuItem});
            this.dsfsdfToolStripMenuItem.Name = "dsfsdfToolStripMenuItem";
            this.dsfsdfToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.dsfsdfToolStripMenuItem.Text = "dsfsdf";
            // 
            // sdfsdfToolStripMenuItem
            // 
            this.sdfsdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsdfToolStripMenuItem1});
            this.sdfsdfToolStripMenuItem.Name = "sdfsdfToolStripMenuItem";
            this.sdfsdfToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.sdfsdfToolStripMenuItem.Text = "sdfsdf";
            // 
            // sdfsdfToolStripMenuItem1
            // 
            this.sdfsdfToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsdfToolStripMenuItem2});
            this.sdfsdfToolStripMenuItem1.Name = "sdfsdfToolStripMenuItem1";
            this.sdfsdfToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.sdfsdfToolStripMenuItem1.Text = "sdfsdf";
            // 
            // sdfsdfToolStripMenuItem2
            // 
            this.sdfsdfToolStripMenuItem2.Name = "sdfsdfToolStripMenuItem2";
            this.sdfsdfToolStripMenuItem2.Size = new System.Drawing.Size(106, 22);
            this.sdfsdfToolStripMenuItem2.Text = "sdfsdf";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(365, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 768);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.delCategory);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lisaBtn);
            this.Controls.Add(this.uuendaBtn);
            this.Controls.Add(this.kustutaBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHind);
            this.Controls.Add(this.txtKogus);
            this.Controls.Add(this.txtToodeNimetus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToodeNimetus;
        private System.Windows.Forms.TextBox txtKogus;
        private System.Windows.Forms.TextBox txtHind;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kustutaBtn;
        private System.Windows.Forms.Button uuendaBtn;
        private System.Windows.Forms.Button lisaBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button delCategory;
        private toodeDataSet toodeDataSet;
        private System.Windows.Forms.BindingSource toodedBindingSource;
        private toodeDataSetTableAdapters.toodedTableAdapter toodedTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private toodeDataSet toodeDataSet1;
        private System.Windows.Forms.BindingSource toodedBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leleleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kekkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jjejejeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qweqweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qweqweToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem dsfsdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfsdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfsdfToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sdfsdfToolStripMenuItem2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategooriaidDataGridViewTextBoxColumn;
    }
}

