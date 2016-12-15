using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFontGenerator
{
    public partial class Form1 : Form
    {

        private int charactersPerRow = 10;
        private int charactersPerColumn = 0;

        private int BMPHeight = 0;
        private int BMPWidth = 0;

        private int bitCount = 0;
        private int wasteBit = 0;
        private int blockSize = 0;

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            _fileDialog.Filter = "Bitmap Image|*.bmp";
            //_charWidth.Enabled = false;
            //_charHeight.Enabled = false;
            _blockType.SelectedIndex = 1;
            setLabelsAndChangeBMPReqs();
        }

        public void setLabelsAndChangeBMPReqs()
        {
            int mod = (_size.Value % charactersPerRow > 0)? 1: 0;
            charactersPerColumn = ((int)_size.Value / charactersPerRow) + mod;
            BMPHeight = charactersPerColumn * (int)_charHeight.Value;
            BMPWidth = charactersPerRow * (int)_charWidth.Value;
            _bmpWidthLabel.Text = Convert.ToString(BMPWidth) + "px";
            _bmpHeightLabel.Text = Convert.ToString(BMPHeight) + "px";

            switch (_blockType.SelectedIndex) {
                case 0://uint8
                    bitCount = 8;
                    break;
                case 1://uint16
                    bitCount = 16;
                    break;
                case 2://uint32
                    bitCount = 32;
                    break;
            }

            int neededBit = (int)_charHeight.Value * (int)_charWidth.Value;
            int minBit;
            blockSize = 0;
            for (minBit = 0; minBit < neededBit; minBit += bitCount) {
                blockSize++;
            };
            wasteBit = minBit - neededBit;
            _wastedBitsLabel.Text = Convert.ToString(wasteBit) + " Bits";
            _blockSize.Text = Convert.ToString(blockSize) + " x "+_blockType.SelectedItem.ToString()+" ("+bitCount*blockSize/8+" Bytes)";

            int memUsage = (int)_size.Value * blockSize * (bitCount / 8);
            _memSize.Text = memUsage + " Bytes";

            int wastedMem = (int)_size.Value * wasteBit / 8;
            _wastedMem.Text = wastedMem + " Bytes";
        }

        public String convertToHex(String binary)
        {
            switch (bitCount)
            {
                case 8:
                    return "0x" + Convert.ToSByte(binary, 2).ToString("X");
                case 16:
                    return "0x" + Convert.ToUInt16(binary, 2).ToString("X");
                case 32:
                    return "0x" + Convert.ToUInt32(binary, 2).ToString("X");
                default:
                    return null;
            }
        }

        public String readBMP(String filePath)
        {

            int chrAmount = (int) _size.Value;
            int colCount = charactersPerRow;
            int rowCount = charactersPerColumn;
            int chrWidth = (int) _charWidth.Value;
            int chrHeight = (int) _charHeight.Value;

            String hexBuffer = "";
            String arrayBuffer = 
                
                "struct FONT "+_name.Text+";\n"
                + _name.Text + ".block_size = " + blockSize+";\n"
                + _name.Text + ".charCount = "+chrAmount+";\n"
                + _name.Text + ".charHeight = "+chrHeight+";\n"
                + _name.Text + ".charWidth = "+chrWidth+";\n"
                + _name.Text + ".name = \""+_name.Text+"\";\n"
                + _name.Text + ".chars[] = {\n";

            int index = 0;

            Bitmap bmp = new Bitmap(filePath);
            if (bmp.Height != BMPHeight && bmp.Width != BMPWidth) {
                return null;
            }

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {

                    int bitC = 0;
                        for (int y = 0; y < chrHeight; y++)
                        {
                        for (int x = 0; x < chrWidth; x++)
                        {
                            //start of each cell


                            //check data here
                            //goes from right to left, then down for cells
                            //goes from right to left, then down in cells
                            // 0 * 6 + 0 = 0
                            // 1 * 6 + 0 = 6
                            // 2 * 6 + 0 = 12 
                            int cx = (col * chrWidth) + x;
                            int cy = (row * chrHeight) + y;
                            int b = 0;

                            Color c = bmp.GetPixel(cx, cy);
                            if (c.R == 0 && c.G == 0 && c.B == 0)
                            {
                                b = 1;
                                hexBuffer += "1";
                            }else
                            {
                                b = 0;
                                hexBuffer += "0";
                            }

                            Debug.Print("COLUMN[{0}] ROW[{1}] CX[{2}] CY[{3}] INDEX[{4}] BIT[{5}]", col, row, cx, cy, index,b);

                            if (bitC == bitCount - 1)
                            {
                                
                                arrayBuffer += convertToHex(hexBuffer) + ",";
                                hexBuffer = "";
                                bitC = 0;
                            }
                            else
                            {
                                bitC++;
                            }
                        }
                    }

                    if (bitC != 0) {
                        for(int i = 0; i < wasteBit; i++)
                        {
                            hexBuffer += '0';
                            bitC = 0;
                        }
                        String comment = (33 + index == 92) ? "\t//left slash" : "\t//"+(char)(33 + index);
                        comment = (_comment.Checked) ? comment : null; 
                        char comma = (index == chrAmount - 1) ? ' ' : ',';
                        arrayBuffer += convertToHex(hexBuffer) + comma + comment +"\n" ;
                        hexBuffer = "";
                    }

                    if(index == chrAmount - 1)
                    {
                        arrayBuffer += "};";
                        Clipboard.SetText(arrayBuffer);                  
                        return arrayBuffer;
                    }
                    index++;
                    //end of each cell
                }
            }

            arrayBuffer += "};";
            Clipboard.SetText(arrayBuffer);
            return arrayBuffer;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fileDialog.ShowDialog();
        }

        private void _fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //TODO INSERT EXTENSION CHECK HERE!!!!!!!!!!!!!!
            String path = _fileDialog.FileName;
            _filePath.Text = path;
            button2.Enabled = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = readBMP(_fileDialog.FileName);
            if (s != null) {
                MessageBox.Show("Font has been copied to your clipboard!","Information",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("BMP size does not match the required sizes (BMP size should be equal to "
                    + BMPWidth + " (Width) , "+BMPHeight+" (Height))","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            setLabelsAndChangeBMPReqs();
        }

        private void _size_ValueChanged(object sender, EventArgs e)
        {
            setLabelsAndChangeBMPReqs();
        }

        private void _blockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelsAndChangeBMPReqs();
        }

        private void _name_MouseClick(object sender, MouseEventArgs e)
        {
            if (_name.Text == "UnknownFont") _name.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String definition = "//definition of the FONT type:\n"
                + "struct FONT\n"
                + "{\n"
                + "\tuint8_t block_size;\n"
                + "\tuint8_t charCount;\n"
                + "\tuint8_t charHeight;\n"
                + "\tuint8_t charWidth;\n"
                + "\tchar *name;\n"
                + "\t" + _blockType.SelectedItem.ToString().ToLower() + " chars[];\n"
                + "};\n";
            Clipboard.SetText(definition);
            MessageBox.Show("Struct definition has been copied to your clipboard!", "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _charWidth_ValueChanged(object sender, EventArgs e)
        {
            setLabelsAndChangeBMPReqs();
        }

        private void _bmpHeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void _wastedBitsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
