namespace CH01
{
    partial class yuangong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yuangong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yuangongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jiudian_guanliDataSet1 = new CH01.jiudian_guanliDataSet1();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jiudian_guanliDataSet = new CH01.jiudian_guanliDataSet();
            this.guestTableAdapter = new CH01.jiudian_guanliDataSetTableAdapters.guestTableAdapter();
            this.butEntry = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yuangongTableAdapter = new CH01.jiudian_guanliDataSet1TableAdapters.yuangongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuangongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiudian_guanliDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiudian_guanliDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.yuangongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(483, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "工号";
            this.dataGridViewTextBoxColumn1.HeaderText = "工号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "员工职位";
            this.dataGridViewTextBoxColumn2.HeaderText = "员工职位";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "员工姓名";
            this.dataGridViewTextBoxColumn3.HeaderText = "员工姓名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "密码";
            this.dataGridViewTextBoxColumn4.HeaderText = "密码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // yuangongBindingSource
            // 
            this.yuangongBindingSource.DataMember = "yuangong";
            this.yuangongBindingSource.DataSource = this.jiudian_guanliDataSet1;
            // 
            // jiudian_guanliDataSet1
            // 
            this.jiudian_guanliDataSet1.DataSetName = "jiudian_guanliDataSet1";
            this.jiudian_guanliDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "guest";
            this.guestBindingSource.DataSource = this.jiudian_guanliDataSet;
            // 
            // jiudian_guanliDataSet
            // 
            this.jiudian_guanliDataSet.DataSetName = "jiudian_guanliDataSet";
            this.jiudian_guanliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // butEntry
            // 
            this.butEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.butEntry.Location = new System.Drawing.Point(516, 295);
            this.butEntry.Name = "butEntry";
            this.butEntry.Size = new System.Drawing.Size(168, 46);
            this.butEntry.TabIndex = 17;
            this.butEntry.Text = "添加";
            this.butEntry.UseVisualStyleBackColor = true;
            this.butEntry.Click += new System.EventHandler(this.butEntry_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(738, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工职位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "登录密码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 36);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 36);
            this.textBox2.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 36);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "员工姓名：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 36);
            this.textBox3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(516, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "工号：";
            // 
            // yuangongTableAdapter
            // 
            this.yuangongTableAdapter.ClearBeforeFill = true;
            // 
            // yuangong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butEntry);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "yuangong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "yuangong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuangongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiudian_guanliDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiudian_guanliDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private jiudian_guanliDataSet jiudian_guanliDataSet;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private jiudian_guanliDataSetTableAdapters.guestTableAdapter guestTableAdapter;
        private System.Windows.Forms.Button butEntry;
        private System.Windows.Forms.Button button1;
       // private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工职位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private jiudian_guanliDataSet1 jiudian_guanliDataSet1;
        private System.Windows.Forms.BindingSource yuangongBindingSource;
        private jiudian_guanliDataSet1TableAdapters.yuangongTableAdapter yuangongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}