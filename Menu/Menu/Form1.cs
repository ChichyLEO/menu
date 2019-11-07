using ListViewGroupCollapse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Menu
{
    public partial class FormMenu : Form
    {

        public string[] menu = new string[] { "錫蘭紅茶", "約克夏茶", "巧克力香茶", "唐寧英國早餐茶", "唐寧皇家伯爵茶", "倫敦之霧", "倫敦霧霾", "開普敦之霧", "早餐之霧", "加牛奶", "手工檸檬紅茶", "黑糖冰鎮紅茶", "南非國寶茶", "精選綠茶", "家外之家奶茶", "伯爵奶茶", "可可牛奶", "抹茶牛奶", "貝里斯牛奶", "緣分", "吧檯手", "烘焙香草榛果咖啡", "經典美式黑咖啡", "義式濃縮咖啡", "咖啡拿鐵", "香草拿鐵", "焦糖拿鐵", "黑糖拿鐵", "蜂蜜肉桂拿鐵", "巧克力摩卡", "貝里斯拿鐵", "厚片抹醬烤土司", "自製布朗尼", "手工司康", "帕瑪森乾酪貝果", "荷蘭焦糖煎餅", "義式香腸披薩", "夏威夷披薩", "純牛肉丸披薩", "馬鈴薯番茄披薩", "鯷魚洋蔥披薩", "巧克力榛果醬披薩" ,"25元蛋糕", "35元蛋糕","65元蛋糕","手沖咖啡","愛樂壓" };
        public string[] price = new string[] { "0", "0", "10", "20", "20", "50", "60", "50", "50", "10", "10", "0", "0", "0", "40", "40", "40", "40", "60", "20", "50", "0", "10", "10", "45", "50", "50", "50", "50", "50", "70", "30", "40", "40", "50", "20", "150", "180", "180", "180", "180", "130", "25", "35", "65",  "60", "60" };
        public string[] group = new string[] { "傳統英式茶選", "精選特調", "特選茶飲", "咖啡˙特調", "輕食", "8吋披薩","其他" };
        public int[] group_count = new int[] {5, 5, 11, 10, 5, 6, 5 };
        public FormMenu()
        {
            InitializeComponent();
            string[] temp = new string[2];
            //ListViewGroup temp_group = new ListViewGroup();
            for (int i = 0; i < group.Length; i++){
                listViewMenu.Groups.Add(Convert.ToString(i), group[i]);
                listViewMenu.Groups[i].HeaderAlignment = HorizontalAlignment.Center;
            }
            
            listViewMenu.ShowGroups = true; // 顯示分組
            //string[] arr = new string["A","B"];
            for(int j=0,k=0;j< group_count.Length; j++)
            {
                for (int i = k; i < group_count[j]+k; i++)
                {
                    Console.WriteLine(i);
                    temp[0] = menu[i];
                    temp[1] = price[i];
                    ListViewItem listItem = new ListViewItem(temp);
                    listViewMenu.Items.Add(listItem);
                    listViewMenu.Items[i].Group = listViewMenu.Groups[j];
                }
                k += group_count[j];
            }
            
        }
        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void WriteExcel(string filename)
        {
            //new an excel object
            Excel.Application excelApp = new Excel.ApplicationClass();
            if (excelApp == null)
            {
                // if equal null means EXCEL is not installed.
                MessageBox.Show("Excel is not properly installed!");
                return;
            }

            // open a workbook,if not exist, create a new one
            Excel.Workbook workBook;
            if (File.Exists(filename))
            {
                workBook = excelApp.Workbooks.Open(filename);
            }
            else
            {
                workBook = excelApp.Workbooks.Add(true);
            }

            //new a worksheet
            Excel.Worksheet workSheet_ = new  Excel.Worksheet();

            //write data
            workSheet_ = (Excel.Worksheet)workBook.Worksheets["工作表1"];//获得第i个sheet，准备写入
                                                                      //workSheet.Cells[1, 3] = "(1,3)Content";
                                                                      //workSheet_ = workBook.Worksheets[1];

            int row = workSheet_.UsedRange.Rows.Count;//獲取不為空的列數
            Console.WriteLine(row);
            else_receipt_price[3] = Convert.ToString(total());
            int i = 0;
            DateTime localDate = DateTime.Now;
            workSheet_.Cells[row + 1, 1] = localDate.ToString();
            for (i = 0; i < receipt_name.Length; i++)
            {
                workSheet_.Cells[row + 1, 6 + Convert.ToInt32(receipt_name[i])] = receipt_num[i];

            }
            for (i = 0; i < else_receipt_price.Length; i++)
            {
                workSheet_.Cells[row + 1, 2 + i] = else_receipt_price[i];
            }


            // --------產生excel--------------
            //workSheet_.Cells[1, 1] = "日期時間";
            //workSheet_.Cells[1, 2] = "時間錢";
            //workSheet_.Cells[1, 3] = "清潔費";
            //workSheet_.Cells[1, 4] = "折扣";
            //workSheet_.Cells[1, 5] = "總計";
            //int j = 0;
            //for (j = 0; j < menu.Length; j++)
            //{
            //    workSheet_.Cells[1, j + 6] = menu[j];
            //}

            //--------------------------------



            //set visible the Excel will run in background
            excelApp.Visible = false;
            //set false the alerts will not display
            excelApp.DisplayAlerts = false;

            //workBook.SaveAs(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            workBook.Save();
            workBook.Close(false, Missing.Value, Missing.Value);

            //quit and clean up objects
            excelApp.Quit();
            workSheet_ = null;
            workBook = null;
            excelApp = null;
            GC.Collect();
        }

        private void listViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewMenu.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewMenu.SelectedItems[0];
                textBoxName.Text = item.Text;
                textBoxPrice.Text = item.SubItems[1].Text;
                numericUpDownNumber.Value = 1;
                subTotal();
            }
        }

        public void subTotal()
        {
            //if (numericUpDownNumber.Value)
            //{
            
            try
            {
                textBoxSubTotal.Text = "" + (int.Parse(textBoxPrice.Text) * (numericUpDownNumber.Value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            //Type type = typeof(numericUpDownNumber.Value);

            //Console.WriteLine(type);
            // }

        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            subTotal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = textBoxName.Text;
            addSubItem(item, textBoxPrice.Text);
            addSubItem(item, numericUpDownNumber.Value+"");
            addSubItem(item, textBoxSubTotal.Text);
            listViewReceipts.Items.Add(item);
            textBoxTotal.Text = ""+total();
        }

        public void addSubItem(ListViewItem item, String text)
        {
            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
            subItem.Text = text;
            item.SubItems.Add(subItem);
        }

        public int total()
        {
            int total = 0;
            foreach (ListViewItem item in listViewReceipts.Items)
            {
                try
                {
                    int subtotal = int.Parse(item.SubItems[3].Text);
                    total += subtotal;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
                
            }
            return total;
        }
        public string[] receipt_name, receipt_num;
        public string[] else_receipt_price;
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            receipt_name = new string[listViewReceipts.Items.Count];
            receipt_num = new string[listViewReceipts.Items.Count];
            else_receipt_price = new string[4];
            //Console.WriteLine(listViewReceipts.Items.Count);
            string temp;
            for (int i = 0; i < listViewReceipts.Items.Count; i++) {
                
                temp = listViewReceipts.Items[i].Text;
                if(!(temp=="時間" || temp=="清潔費" || temp== "折扣")){
                    int n = Array.IndexOf(menu, temp);
                    receipt_name[i] = Convert.ToString(n);
                    receipt_num[i] = listViewReceipts.Items[i].SubItems[2].Text;
                    //Console.WriteLine(receipt_name[i]);
                    //Console.WriteLine(receipt_num[i]);
                }
                else {
                    if (temp == "時間") {
                        else_receipt_price[0] = listViewReceipts.Items[i].SubItems[3].Text;
                    }
                    else if (temp == "清潔費"){
                        else_receipt_price[1] = listViewReceipts.Items[i].SubItems[3].Text;
                    }
                    else if (temp == "折扣"){
                        else_receipt_price[2] = listViewReceipts.Items[i].SubItems[3].Text;
                    }
                }
            }
            string str = System.IO.Directory.GetCurrentDirectory() + "\\receipt.xlsx";
            Console.WriteLine(str);
            WriteExcel(str);
            listViewReceipts.Items.Clear();
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewReceipts.SelectedItems[0];
                listViewReceipts.Items.Remove(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            textBoxTotal.Text = "" + total();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Time_button_Click(object sender, EventArgs e)
        {
            int minute,money;
            if (Start_hour.Value <= End_hour.Value)
            {
                minute = ((int)End_hour.Value - (int)Start_hour.Value) * 60 + (int)End_minute.Value - (int)Start_minute.Value;
            }
            else {
                minute = (((int)End_hour.Value+24) - (int)Start_hour.Value) * 60 + (int)End_minute.Value - (int)Start_minute.Value;
            }
            money = minute * 2;
            if(19 <= Start_hour.Value ){
                if (money > 120) money = 120;
            }
            else if(student.Checked){
                if (money > 200) money = 200;
            }
            else {
                if (money > 240) money = 240;
            }
            
            ListViewItem item = new ListViewItem();
            item.Text = "時間";
            addSubItem(item, "");
            addSubItem(item, 1 + "");
            addSubItem(item, Convert.ToString(money));
            listViewReceipts.Items.Add(item);
            textBoxTotal.Text = "" + total();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Outside_food_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "清潔費";
            addSubItem(item, Convert.ToString(50));
            addSubItem(item, 1 + "");
            addSubItem(item, Convert.ToString(50));
            listViewReceipts.Items.Add(item);
            textBoxTotal.Text = "" + total();
        }



        private void Discount_button_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            string temp = "-"+discount.Text;
            item.Text = "折扣";
            addSubItem(item, temp);
            addSubItem(item, 1 + "");
            addSubItem(item, temp);
            listViewReceipts.Items.Add(item);
            textBoxTotal.Text = "" + total();
        }
    }
}
