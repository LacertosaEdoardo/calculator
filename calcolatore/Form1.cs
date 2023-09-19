using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolatore
{
    public partial class CALCULATOR : Form
    {
        public struct btnStruct
        {
            public char Content;
            public bool isBold;
            public btnStruct(char content, bool isBold)
            {
                this.Content = content;
                this.isBold = isBold;
            }
        }

        private btnStruct[,] button =
        {
            {new btnStruct('%',false), new btnStruct('C',false), new btnStruct('c',false), new btnStruct('<',false)},
            {new btnStruct('x',false), new btnStruct('x',false), new btnStruct('c',false), new btnStruct('/',false)},
            {new btnStruct('7',true), new btnStruct('8',true), new btnStruct('9',true), new btnStruct('x',false)},
            {new btnStruct('4',true), new btnStruct('5',true), new btnStruct('6',true), new btnStruct('-',false)},
            {new btnStruct('1',true), new btnStruct('2',true), new btnStruct('3',true), new btnStruct('+',false)},
            {new btnStruct('|',false), new btnStruct('0',false), new btnStruct(',',false), new btnStruct('=',false)}
        };
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void CALCULATOR_Load(object sender, EventArgs e)
        {
            GenerateButton();
        }

        private void GenerateButton()
        {
            int btnWidth = 80;
            int btnHeight = 60;
            int posX = 0;
            int posY = 117;

            for(int i=0;i<6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button myButton = new Button();
                    myButton.Font = new Font("Segoe UI", 16);
                    myButton.Text = button[i,j].Content.ToString();
                    myButton.Height = btnHeight;
                    myButton.Width = btnWidth;
                    myButton.Top = posY;
                    myButton.Left = posX;
                    posX += myButton.Width;
                    this.Controls.Add(myButton);
                }
                posX = 0;
                posY += 60;
            }
        }
    }
}
