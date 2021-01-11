
namespace CRMGuru
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.городаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMGuruDataSet = new CRMGuru.CRMGuruDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.fKСтраныГородаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.регионыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городаTableAdapter = new CRMGuru.CRMGuruDataSetTableAdapters.ГородаTableAdapter();
            this.tableAdapterManager = new CRMGuru.CRMGuruDataSetTableAdapters.TableAdapterManager();
            this.регионыTableAdapter = new CRMGuru.CRMGuruDataSetTableAdapters.РегионыTableAdapter();
            this.страныTableAdapter = new CRMGuru.CRMGuruDataSetTableAdapters.СтраныTableAdapter();
            this.страныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMGuruDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.страныDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMGuruDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСтраныГородаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.регионыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMGuruDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // городаBindingSource
            // 
            this.городаBindingSource.DataMember = "Города";
            this.городаBindingSource.DataSource = this.cRMGuruDataSet;
            // 
            // cRMGuruDataSet
            // 
            this.cRMGuruDataSet.DataSetName = "CRMGuruDataSet";
            this.cRMGuruDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Страны";
            this.label3.Visible = false;
            // 
            // fKСтраныГородаBindingSource
            // 
            this.fKСтраныГородаBindingSource.DataMember = "FK_Страны_Города";
            this.fKСтраныГородаBindingSource.DataSource = this.городаBindingSource;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 335);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "Показать ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(127, 335);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Скрыть";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Все страны";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 22);
            this.textBox3.TabIndex = 17;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(400, 22);
            this.textBox4.TabIndex = 18;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(112, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(400, 22);
            this.textBox5.TabIndex = 19;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(112, 233);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(400, 22);
            this.textBox6.TabIndex = 20;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(112, 272);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(400, 22);
            this.textBox7.TabIndex = 21;
            this.textBox7.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Название";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Код страны";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Столица";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Площадь";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Население";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Регион";
            this.label10.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Скрыть результат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // регионыBindingSource
            // 
            this.регионыBindingSource.DataMember = "Регионы";
            this.регионыBindingSource.DataSource = this.cRMGuruDataSet;
            // 
            // городаTableAdapter
            // 
            this.городаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CRMGuru.CRMGuruDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородаTableAdapter = this.городаTableAdapter;
            this.tableAdapterManager.РегионыTableAdapter = this.регионыTableAdapter;
            this.tableAdapterManager.СтраныTableAdapter = this.страныTableAdapter;
            // 
            // регионыTableAdapter
            // 
            this.регионыTableAdapter.ClearBeforeFill = true;
            // 
            // страныTableAdapter
            // 
            this.страныTableAdapter.ClearBeforeFill = true;
            // 
            // страныBindingSource
            // 
            this.страныBindingSource.DataMember = "Страны";
            this.страныBindingSource.DataSource = this.cRMGuruDataSet;
            // 
            // cRMGuruDataSetBindingSource
            // 
            this.cRMGuruDataSetBindingSource.DataSource = this.cRMGuruDataSet;
            this.cRMGuruDataSetBindingSource.Position = 0;
            // 
            // страныDataGridView
            // 
            this.страныDataGridView.AutoGenerateColumns = false;
            this.страныDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.страныDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.страныDataGridView.DataSource = this.страныBindingSource;
            this.страныDataGridView.Location = new System.Drawing.Point(12, 390);
            this.страныDataGridView.Name = "страныDataGridView";
            this.страныDataGridView.RowHeadersWidth = 51;
            this.страныDataGridView.RowTemplate.Height = 24;
            this.страныDataGridView.Size = new System.Drawing.Size(1180, 163);
            this.страныDataGridView.TabIndex = 31;
            this.страныDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn6.HeaderText = "Название";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Код_страны";
            this.dataGridViewTextBoxColumn10.HeaderText = "Код_страны";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Столица";
            this.dataGridViewTextBoxColumn11.DataSource = this.городаBindingSource;
            this.dataGridViewTextBoxColumn11.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn11.HeaderText = "Столица";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "Id";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Площадь";
            this.dataGridViewTextBoxColumn12.HeaderText = "Площадь";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Население";
            this.dataGridViewTextBoxColumn13.HeaderText = "Население";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Регион";
            this.dataGridViewTextBoxColumn14.DataSource = this.регионыBindingSource;
            this.dataGridViewTextBoxColumn14.DisplayMember = "Название";
            this.dataGridViewTextBoxColumn14.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn14.HeaderText = "Регион";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn14.ValueMember = "Id";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 566);
            this.Controls.Add(this.страныDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMGuruDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСтраныГородаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.регионыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMGuruDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRMGuruDataSet cRMGuruDataSet;
        private System.Windows.Forms.BindingSource городаBindingSource;
        private CRMGuruDataSetTableAdapters.ГородаTableAdapter городаTableAdapter;
        private CRMGuruDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CRMGuruDataSetTableAdapters.РегионыTableAdapter регионыTableAdapter;
        private System.Windows.Forms.BindingSource регионыBindingSource;
        private CRMGuruDataSetTableAdapters.СтраныTableAdapter страныTableAdapter;
        private System.Windows.Forms.BindingSource страныBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fKСтраныГородаBindingSource;
        private System.Windows.Forms.BindingSource cRMGuruDataSetBindingSource;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView страныDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn14;
    }
}

