using System;
using System.Text;
using System.Windows.Forms; // �T�O�ޥ� System.Windows.Forms




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
        // ���U��k�G���o�n��ܪ��r�� (�B�z����r��)
        private string GetDisplayChar(int asciiCode)
        {
            char character = (char)asciiCode;
            if (asciiCode == 32) return "(Space)";
            // �i�H�[�J��L�S��r���B�z�A�p Tab, LF, CR
            // else if (asciiCode == 9) return "(Tab)";
            // else if (asciiCode == 10) return "(LF)";
            // else if (asciiCode == 13) return "(CR)";
            else if (char.IsControl(character) || asciiCode == 127) // �]�t DEL
            {
                // �i�H��^ ASCII ����r���W�١A�βΤ@�Ÿ�
                // ²��_���A��^ "."
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
            //const int numGroups = 4; // �ڭ̭n��ܥ|��

            // �j��] 32 ���A�N�� 32 �C
            for (int i = 0; i < groupSize; i++)
            {
                // �p��C�@�չ����� ASCII ��¦��
                int asciiVal1 = i;                  // �� 1: 0-31
                int asciiVal2 = i + groupSize;      // �� 2: 32-63
                int asciiVal3 = i + (groupSize * 2); // �� 3: 64-95
                int asciiVal4 = i + (groupSize * 3); // �� 4: 96-127

                // �إ� ListViewItem�A�Ĥ@��O�Ĥ@�ժ� Char
                ListViewItem item = new ListViewItem(GetDisplayChar(asciiVal1));

                // --- �[�J�Ĥ@�ժ� Dec, Hex, Oct ---
                item.SubItems.Add(asciiVal1.ToString());                // Dec 1
                item.SubItems.Add(asciiVal1.ToString("X2"));            // Hex 1
                item.SubItems.Add(Convert.ToString(asciiVal1, 8).PadLeft(3, '0')); // Oct 1

                // --- �[�J�ĤG�ժ� Char, Dec, Hex, Oct ---
                item.SubItems.Add(GetDisplayChar(asciiVal2));           // Char 2
                item.SubItems.Add(asciiVal2.ToString());                // Dec 2
                item.SubItems.Add(asciiVal2.ToString("X2"));            // Hex 2
                item.SubItems.Add(Convert.ToString(asciiVal2, 8).PadLeft(3, '0')); // Oct 2

                // --- �[�J�ĤT�ժ� Char, Dec, Hex, Oct ---
                item.SubItems.Add(GetDisplayChar(asciiVal3));           // Char 3
                item.SubItems.Add(asciiVal3.ToString());                // Dec 3
                item.SubItems.Add(asciiVal3.ToString("X2"));            // Hex 3
                item.SubItems.Add(Convert.ToString(asciiVal3, 8).PadLeft(3, '0')); // Oct 3

                // --- �[�J�ĥ|�ժ� Char, Dec, Hex, Oct ---
                item.SubItems.Add(GetDisplayChar(asciiVal4));           // Char 4
                item.SubItems.Add(asciiVal4.ToString());                // Dec 4
                item.SubItems.Add(asciiVal4.ToString("X2"));            // Hex 4
                item.SubItems.Add(Convert.ToString(asciiVal4, 8).PadLeft(3, '0')); // Oct 4

                // �N���㪺�@�C�[�J ListView
                ListViewAscii.Items.Add(item);
            }

            ListViewAscii.EndUpdate();

            // (�i��) �۰ʽվ���e�A�����o��h���i��ĪG���ΡA��ʳ]�w���n
            // listViewAscii.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void ButTran_Click(object sender, EventArgs e)
        {
            string asciiInput = ASCII_TextBox.Text;
            if (string.IsNullOrEmpty(asciiInput))
            {
                MessageBox.Show("�п�J ASCII �r��", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // �M�� ListView ���i��s�b���¶��� (�p�G�ݭn���s���J)
            listViewAscii.Items.Clear();

            // �]�w ListView �}�l��s�A�����į�
            listViewAscii.BeginUpdate();

            // �j��B�z�з� ASCII (0-127) �� �X�R ASCII (0-255)
            // �o�̥H 0-127 ����
            for (int i = 0; i <= 127; i++)
            {
                // ���o�r�����
                char character = (char)i;
                string displayChar;

                // �S��B�z����r�� (0-31 �M 127)
                if (i == 32) // �ťզr���S�O�Х�
                {
                    displayChar = "(Space)";
                }
                // ��L�`�����i���ťզr�� (�i��)
                // else if (i == 9) displayChar = "(Tab)";
                // else if (i == 10) displayChar = "(LF)";
                // else if (i == 13) displayChar = "(CR)";
                else if (char.IsControl(character))
                {
                    // ����L����r���A��ܤ@���I�Ψ�L�аO��
                    // �Ϊ̧A�i�H�d�� ASCII ����r�����W�� (�Ҧp NUL, SOH, STX...)
                    displayChar = ".";
                }
                else
                {
                    // �i��ܪ��r�������ഫ
                    displayChar = character.ToString();
                }

                // �إ� ListViewItem (�N���椤���@�C)
                // �Ĥ@����� (Char) ����r�����]�w�� ListViewItem �� Text �ݩ�
                ListViewItem item = new ListViewItem(displayChar);

                // �[�J������쪺�l���� (SubItems)
                // Dec (�Q�i��)
                item.SubItems.Add(i.ToString());

                // Hex (�Q���i��)�A�ϥ� "X2" �榡�T�O�ܤ֨��ơA�øɹs
                item.SubItems.Add(i.ToString("X2"));

                // Oct (�K�i��)�A�ϥ� Convert.ToString �å���ɹs��T���
                item.SubItems.Add(Convert.ToString(i, 8).PadLeft(3, '0'));

                // �N�o�@�C���إ[�J�� ListView
                listViewAscii.Items.Add(item);
            }

            // �]�w ListView ������s�A�@������ܩҦ����e
            listViewAscii.EndUpdate();

            // (�i��) �۰ʽվ���e�H�A�����e�μ��Y
            // listViewAscii.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // listViewAscii.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
#endif

}

