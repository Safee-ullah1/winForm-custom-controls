using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicUserControls
{
    public partial class CustomTextBox : UserControl
    {
        public Image sideImg;
        public Image sideImage
        {
            get
            {
                return sideImg;
            }
            set
            {
                sideImg = value;
                this.textBoxImage.BackgroundImage = sideImg;
            }
        }
        public string defText;
        public string defaultText
        {
            get
            {
                return defText;
            }
            set
            {
                defText = value;
                this.myTextBox.Text = defText;
            }
        }
        public Font texFont;
        public Font textFont
        {
            get
            {
                return texFont;
            }
            set
            {
                texFont = value;
                this.myTextBox.Font = texFont;
            }
        }
        public Color textBoxBackCol;
        public Color textBoxBackColor
        {
            get
            {
                return textBoxBackCol;
            }
            set
            {
                textBoxBackCol = value;
                this.myTextBox.BackColor = textBoxBackCol;
            }
        }
        public Color textBoxForeCol;
        public Color textBoxForeColor
        {
            get
            {
                return textBoxForeCol;
            }
            set
            {
                textBoxForeCol = value;
            }
        }
        public Color underlinePanelColor = Color.WhiteSmoke;
        public Color UnderLineColor
        {
            get
            {
                return underlinePanelColor;
            }
            set
            {
                underlinePanelColor = value;
                this.textUnderlinePanel.BackColor = underlinePanelColor;
            }
        }

        public Color underlinePanelFocusCol = Color.LightYellow;
        public Color underlineFocusColor
        {
            get
            {
                return underlinePanelFocusCol;
            }
            set
            {
                underlinePanelFocusCol = value;
            }
        }
        public CustomTextBox()
        {
            InitializeComponent();
            this.myTextBox.ForeColor = Color.Silver;
        }
        
        public void clearField(object sender, EventArgs e)
        {
            if (this.myTextBox.Text == defaultText)
            {
                this.myTextBox.Clear();
                this.myTextBox.ForeColor = textBoxForeCol;
                this.textUnderlinePanel.Width += 35;
                this.textUnderlinePanel.Height += 1;
                this.textUnderlinePanel.BackColor = underlinePanelFocusCol;
            }
        }
        public void resetField(object sender, EventArgs e)
        {
            if (this.myTextBox.Text == "" || this.myTextBox.Text.StartsWith(" "))
            {
                this.myTextBox.Text = defaultText;
                this.myTextBox.ForeColor = Color.Silver;
                this.textUnderlinePanel.Width -= 35;
                this.textUnderlinePanel.Height -= 1;
                this.textUnderlinePanel.BackColor = Color.WhiteSmoke;
            }
        }
        public string getText()
        {
            if(this.myTextBox.Text == defText)
            {
                return "";
            }
            else
            {
                return this.myTextBox.Text;
            }
        }
    }
}
