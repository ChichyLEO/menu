using ListViewGroupCollapse;

namespace Menu
{
    partial class FormMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.listViewReceipts = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listViewMenu = new System.Windows.Forms.ListViewExtended();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Start_hour = new System.Windows.Forms.NumericUpDown();
            this.Start_minute = new System.Windows.Forms.NumericUpDown();
            this.End_hour = new System.Windows.Forms.NumericUpDown();
            this.End_minute = new System.Windows.Forms.NumericUpDown();
            this.Time_button = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Outside_food = new System.Windows.Forms.Button();
            this.discount = new System.Windows.Forms.TextBox();
            this.Discount_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.End_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.End_minute)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewReceipts
            // 
            this.listViewReceipts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPrice,
            this.columnHeaderNumber,
            this.columnHeaderTotal});
            this.listViewReceipts.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewReceipts.HideSelection = false;
            this.listViewReceipts.Location = new System.Drawing.Point(29, 465);
            this.listViewReceipts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewReceipts.MultiSelect = false;
            this.listViewReceipts.Name = "listViewReceipts";
            this.listViewReceipts.Size = new System.Drawing.Size(674, 199);
            this.listViewReceipts.TabIndex = 0;
            this.listViewReceipts.UseCompatibleStateImageBehavior = false;
            this.listViewReceipts.View = System.Windows.Forms.View.Details;
            this.listViewReceipts.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "品名";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "單價";
            this.columnHeaderPrice.Width = 71;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "數量";
            // 
            // columnHeaderTotal
            // 
            this.columnHeaderTotal.Text = "小計";
            this.columnHeaderTotal.Width = 120;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ChickenBig.jpg");
            this.imageList.Images.SetKeyName(1, "ChickenChop.jpg");
            this.imageList.Images.SetKeyName(2, "Coke.jpg");
            this.imageList.Images.SetKeyName(3, "Sprite.jpg");
            this.imageList.Images.SetKeyName(4, "FriedPotato.jpg");
            this.imageList.Images.SetKeyName(5, "Hamburger.jpg");
            // 
            // listViewMenu
            // 
            this.listViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewMenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.LargeImageList = this.imageList;
            this.listViewMenu.Location = new System.Drawing.Point(29, 111);
            this.listViewMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(448, 231);
            this.listViewMenu.TabIndex = 3;
            this.listViewMenu.TileSize = new System.Drawing.Size(356, 10);
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            this.listViewMenu.View = System.Windows.Forms.View.Details;
            this.listViewMenu.SelectedIndexChanged += new System.EventHandler(this.listViewMenu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "品名";
            this.columnHeader1.Width = 237;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "單價";
            this.columnHeader2.Width = 121;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(29, 391);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(224, 35);
            this.textBoxName.TabIndex = 5;
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDownNumber.Location = new System.Drawing.Point(351, 391);
            this.numericUpDownNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(63, 35);
            this.numericUpDownNumber.TabIndex = 6;
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPrice.Location = new System.Drawing.Point(261, 391);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(82, 35);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxSubTotal.Location = new System.Drawing.Point(421, 391);
            this.textBoxSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(126, 35);
            this.textBoxSubTotal.TabIndex = 8;
            this.textBoxSubTotal.TextChanged += new System.EventHandler(this.textBoxSubTotal_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAdd.Location = new System.Drawing.Point(575, 391);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 33);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "加入";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOrder.Location = new System.Drawing.Point(575, 687);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(112, 44);
            this.buttonOrder.TabIndex = 11;
            this.buttonOrder.Text = "結帳";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTotal.Location = new System.Drawing.Point(421, 687);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(126, 35);
            this.textBoxTotal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(325, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "總計";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(98, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "開始時間";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(710, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "刪除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(392, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "結束時間";
            // 
            // Start_hour
            // 
            this.Start_hour.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_hour.Location = new System.Drawing.Point(51, 45);
            this.Start_hour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_hour.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.Start_hour.Name = "Start_hour";
            this.Start_hour.Size = new System.Drawing.Size(63, 35);
            this.Start_hour.TabIndex = 21;
            // 
            // Start_minute
            // 
            this.Start_minute.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_minute.Location = new System.Drawing.Point(161, 45);
            this.Start_minute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Start_minute.Name = "Start_minute";
            this.Start_minute.Size = new System.Drawing.Size(63, 35);
            this.Start_minute.TabIndex = 22;
            // 
            // End_hour
            // 
            this.End_hour.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.End_hour.Location = new System.Drawing.Point(351, 45);
            this.End_hour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.End_hour.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.End_hour.Name = "End_hour";
            this.End_hour.Size = new System.Drawing.Size(63, 35);
            this.End_hour.TabIndex = 23;
            this.End_hour.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // End_minute
            // 
            this.End_minute.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.End_minute.Location = new System.Drawing.Point(461, 45);
            this.End_minute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.End_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.End_minute.Name = "End_minute";
            this.End_minute.Size = new System.Drawing.Size(63, 35);
            this.End_minute.TabIndex = 24;
            // 
            // Time_button
            // 
            this.Time_button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Time_button.Location = new System.Drawing.Point(589, 45);
            this.Time_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Time_button.Name = "Time_button";
            this.Time_button.Size = new System.Drawing.Size(134, 44);
            this.Time_button.TabIndex = 25;
            this.Time_button.Text = "計算時間";
            this.Time_button.UseVisualStyleBackColor = true;
            this.Time_button.Click += new System.EventHandler(this.Time_button_Click);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.student.Location = new System.Drawing.Point(537, 132);
            this.student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(86, 28);
            this.student.TabIndex = 26;
            this.student.Text = "學生證";
            this.student.UseVisualStyleBackColor = true;
            this.student.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(121, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "時";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(421, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "時";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(231, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(531, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "分";
            // 
            // Outside_food
            // 
            this.Outside_food.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Outside_food.Location = new System.Drawing.Point(537, 183);
            this.Outside_food.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Outside_food.Name = "Outside_food";
            this.Outside_food.Size = new System.Drawing.Size(112, 44);
            this.Outside_food.TabIndex = 31;
            this.Outside_food.Text = "清潔費";
            this.Outside_food.UseVisualStyleBackColor = true;
            this.Outside_food.Click += new System.EventHandler(this.Outside_food_Click);
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discount.Location = new System.Drawing.Point(521, 264);
            this.discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(126, 35);
            this.discount.TabIndex = 32;
            // 
            // Discount_button
            // 
            this.Discount_button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Discount_button.Location = new System.Drawing.Point(675, 264);
            this.Discount_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Discount_button.Name = "Discount_button";
            this.Discount_button.Size = new System.Drawing.Size(113, 35);
            this.Discount_button.TabIndex = 33;
            this.Discount_button.Text = "折扣";
            this.Discount_button.UseVisualStyleBackColor = true;
            this.Discount_button.Click += new System.EventHandler(this.Discount_button_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 740);
            this.Controls.Add(this.Discount_button);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.Outside_food);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.student);
            this.Controls.Add(this.Time_button);
            this.Controls.Add(this.End_minute);
            this.Controls.Add(this.End_hour);
            this.Controls.Add(this.Start_minute);
            this.Controls.Add(this.Start_hour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listViewMenu);
            this.Controls.Add(this.listViewReceipts);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.Text = "點餐系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.End_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.End_minute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewReceipts;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderTotal;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Start_hour;
        private System.Windows.Forms.NumericUpDown Start_minute;
        private System.Windows.Forms.NumericUpDown End_hour;
        private System.Windows.Forms.NumericUpDown End_minute;
        private System.Windows.Forms.Button Time_button;
        private System.Windows.Forms.CheckBox student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Outside_food;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Button Discount_button;
        private System.Windows.Forms.ListViewExtended listViewMenu;
    }
}

