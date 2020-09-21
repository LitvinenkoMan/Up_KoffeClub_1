namespace Up_KoffeClub_1
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSerch = new System.Windows.Forms.TextBox();
            this.tabControlView = new System.Windows.Forms.TabControl();
            this.tabPageCategorees = new System.Windows.Forms.TabPage();
            this.tabPageDrinks = new System.Windows.Forms.TabPage();
            this.tabPageSells = new System.Windows.Forms.TabPage();
            this.labelSerch = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.Location = new System.Drawing.Point(11, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxSerch
            // 
            this.textBoxSerch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSerch.Name = "textBoxSerch";
            this.textBoxSerch.Size = new System.Drawing.Size(240, 20);
            this.textBoxSerch.TabIndex = 1;
            this.textBoxSerch.TextChanged += new System.EventHandler(this.textBoxSerch_TextChanged);
            // 
            // tabControlView
            // 
            this.tabControlView.Controls.Add(this.tabPageCategorees);
            this.tabControlView.Controls.Add(this.tabPageDrinks);
            this.tabControlView.Controls.Add(this.tabPageSells);
            this.tabControlView.Location = new System.Drawing.Point(12, 70);
            this.tabControlView.Name = "tabControlView";
            this.tabControlView.SelectedIndex = 0;
            this.tabControlView.Size = new System.Drawing.Size(217, 23);
            this.tabControlView.TabIndex = 2;
            this.tabControlView.SelectedIndexChanged += new System.EventHandler(this.tabControlView_SelectedIndexChanged);
            // 
            // tabPageCategorees
            // 
            this.tabPageCategorees.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategorees.Name = "tabPageCategorees";
            this.tabPageCategorees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategorees.Size = new System.Drawing.Size(209, 0);
            this.tabPageCategorees.TabIndex = 0;
            this.tabPageCategorees.Text = "Categorees";
            this.tabPageCategorees.UseVisualStyleBackColor = true;
            // 
            // tabPageDrinks
            // 
            this.tabPageDrinks.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrinks.Name = "tabPageDrinks";
            this.tabPageDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrinks.Size = new System.Drawing.Size(209, 0);
            this.tabPageDrinks.TabIndex = 1;
            this.tabPageDrinks.Text = "Drinks";
            this.tabPageDrinks.UseVisualStyleBackColor = true;
            // 
            // tabPageSells
            // 
            this.tabPageSells.Location = new System.Drawing.Point(4, 22);
            this.tabPageSells.Name = "tabPageSells";
            this.tabPageSells.Size = new System.Drawing.Size(209, 0);
            this.tabPageSells.TabIndex = 2;
            this.tabPageSells.Text = "Sells";
            this.tabPageSells.UseVisualStyleBackColor = true;
            // 
            // labelSerch
            // 
            this.labelSerch.AutoSize = true;
            this.labelSerch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSerch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSerch.Location = new System.Drawing.Point(268, 15);
            this.labelSerch.Name = "labelSerch";
            this.labelSerch.Size = new System.Drawing.Size(118, 17);
            this.labelSerch.TabIndex = 3;
            this.labelSerch.Text = "Поиск/Диапазон";
            this.labelSerch.Click += new System.EventHandler(this.labelSerch_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(12, 12);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 4;
            this.textBoxFrom.Visible = false;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            this.textBoxFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFrom_KeyPress);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(152, 12);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 5;
            this.textBoxTo.Visible = false;
            this.textBoxTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFrom_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSerch);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelSerch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControlView);
            this.Name = "MainForm";
            this.Text = "Коффе Клуб";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSerch;
        private System.Windows.Forms.TabControl tabControlView;
        private System.Windows.Forms.TabPage tabPageCategorees;
        private System.Windows.Forms.TabPage tabPageDrinks;
        private System.Windows.Forms.TabPage tabPageSells;
        private System.Windows.Forms.Label labelSerch;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
    }
}

