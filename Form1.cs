using System;
using System.Text;
using System.Windows.Forms; // 確保引用 System.Windows.Forms




namespace ASCIIT_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PopulateAsciiTable();
            PopulateAsciiTableGrouped();
        }
        // 輔助方法：取得要顯示的字元 (處理控制字元)
        private string GetDisplayChar(int asciiCode)
        {
            char character = (char)asciiCode;
            if (asciiCode == 32) return "(Space)";
            // 可以加入其他特殊字元處理，如 Tab, LF, CR
            // else if (asciiCode == 9) return "(Tab)";
            // else if (asciiCode == 10) return "(LF)";
            // else if (asciiCode == 13) return "(CR)";
            else if (char.IsControl(character) || asciiCode == 127) // 包含 DEL
            {
                // 可以返回 ASCII 控制字元名稱，或統一符號
                // 簡單起見，返回 "."
                return ".";
            }
            else
            {
                return character.ToString();
            }
        }


        private void PopulateAsciiTableGrouped()
        {

            ListViewAscii.Items.Clear();
            ListViewAscii.BeginUpdate();

            const int groupSize = 32;
            //const int numGroups = 4; // 我們要顯示四組

            // 迴圈跑 32 次，代表 32 列
            for (int i = 0; i < groupSize; i++)
            {
                // 計算每一組對應的 ASCII 基礎值
                int asciiVal1 = i;                  // 組 1: 0-31
                int asciiVal2 = i + groupSize;      // 組 2: 32-63
                int asciiVal3 = i + (groupSize * 2); // 組 3: 64-95
                int asciiVal4 = i + (groupSize * 3); // 組 4: 96-127

                // 建立 ListViewItem，第一欄是第一組的 Char
                ListViewItem item = new ListViewItem(GetDisplayChar(asciiVal1));

                // --- 加入第一組的 Dec, Hex, Oct ---
                item.SubItems.Add(asciiVal1.ToString());                // Dec 1
                item.SubItems.Add(asciiVal1.ToString("X2"));            // Hex 1
                item.SubItems.Add(Convert.ToString(asciiVal1, 8).PadLeft(3, '0')); // Oct 1

                // --- 加入第二組的 Char, Dec, Hex, Oct ---
                item.SubItems.Add(GetDisplayChar(asciiVal2));           // Char 2
                item.SubItems.Add(asciiVal2.ToString());                // Dec 2
                item.SubItems.Add(asciiVal2.ToString("X2"));            // Hex 2
                item.SubItems.Add(Convert.ToString(asciiVal2, 8).PadLeft(3, '0')); // Oct 2

                // --- 加入第三組的 Char, Dec, Hex, Oct ---
                item.SubItems.Add(GetDisplayChar(asciiVal3));           // Char 3
                item.SubItems.Add(asciiVal3.ToString());                // Dec 3
                item.SubItems.Add(asciiVal3.ToString("X2"));            // Hex 3
                item.SubItems.Add(Convert.ToString(asciiVal3, 8).PadLeft(3, '0')); // Oct 3

                // --- 加入第四組的 Char, Dec, Hex, Oct ---
                item.SubItems.Add(GetDisplayChar(asciiVal4));           // Char 4
                item.SubItems.Add(asciiVal4.ToString());                // Dec 4
                item.SubItems.Add(asciiVal4.ToString("X2"));            // Hex 4
                item.SubItems.Add(Convert.ToString(asciiVal4, 8).PadLeft(3, '0')); // Oct 4

                // 將完整的一列加入 ListView
                ListViewAscii.Items.Add(item);
            }

            ListViewAscii.EndUpdate();

            // (可選) 自動調整欄寬，但對於這麼多欄位可能效果不佳，手動設定較好
            // listViewAscii.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void ButTran_Click(object sender, EventArgs e)
        {
            string asciiInput = ASCII_TextBox.Text;
            if (string.IsNullOrEmpty(asciiInput))
            {
                MessageBox.Show("請輸入 ASCII 字串", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder hexBuilder = new StringBuilder();
            foreach (char c in asciiInput)
            {
                hexBuilder.AppendFormat("{0:X2} ", (int)c);
            }

            textBox1.Text = hexBuilder.ToString().Trim();
        }
    }
#if ascii_list
        private void PopulateAsciiTable()
        {
            // 清除 ListView 中可能存在的舊項目 (如果需要重新載入)
            listViewAscii.Items.Clear();

            // 設定 ListView 開始更新，提高效能
            listViewAscii.BeginUpdate();

            // 迴圈處理標準 ASCII (0-127) 或 擴充 ASCII (0-255)
            // 這裡以 0-127 為例
            for (int i = 0; i <= 127; i++)
            {
                // 取得字元表示
                char character = (char)i;
                string displayChar;

                // 特殊處理控制字元 (0-31 和 127)
                if (i == 32) // 空白字元特別標示
                {
                    displayChar = "(Space)";
                }
                // 其他常見的可見空白字元 (可選)
                // else if (i == 9) displayChar = "(Tab)";
                // else if (i == 10) displayChar = "(LF)";
                // else if (i == 13) displayChar = "(CR)";
                else if (char.IsControl(character))
                {
                    // 對於其他控制字元，顯示一個點或其他標記符
                    // 或者你可以查詢 ASCII 控制字元的名稱 (例如 NUL, SOH, STX...)
                    displayChar = ".";
                }
                else
                {
                    // 可顯示的字元直接轉換
                    displayChar = character.ToString();
                }

                // 建立 ListViewItem (代表表格中的一列)
                // 第一個欄位 (Char) 的文字直接設定給 ListViewItem 的 Text 屬性
                ListViewItem item = new ListViewItem(displayChar);

                // 加入後續欄位的子項目 (SubItems)
                // Dec (十進位)
                item.SubItems.Add(i.ToString());

                // Hex (十六進位)，使用 "X2" 格式確保至少兩位數，並補零
                item.SubItems.Add(i.ToString("X2"));

                // Oct (八進位)，使用 Convert.ToString 並左邊補零到三位數
                item.SubItems.Add(Convert.ToString(i, 8).PadLeft(3, '0'));

                // 將這一列項目加入到 ListView
                listViewAscii.Items.Add(item);
            }

            // 設定 ListView 結束更新，一次性顯示所有內容
            listViewAscii.EndUpdate();

            // (可選) 自動調整欄寬以適應內容或標頭
            // listViewAscii.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // listViewAscii.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
#endif

}

