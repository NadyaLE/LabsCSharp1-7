using System;
using System.Windows.Forms;

namespace FormattedTextBox
{
    public class FormattedTextBox : TextBox
    {
        string TextDefault = "+7 (___) ___­__­__";

        public FormattedTextBox()
        {
        Text = TextDefault;
        Inicializate();
        SelectionStart = 0;
        SelectionLength = 0;
        }
        protected void Inicializate()
        {
            KeyPress += new KeyPressEventHandler(PressButton);
            MouseDown += new MouseEventHandler(MouseClick);
            KeyDown += new KeyEventHandler(ButtonDown);
        }

        protected void PressButton(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == (char)Keys.Back) {
                       
                if (SelectionStart > 8 && SelectionStart < 10) {
                    SelectionStart = 7;
                    SelectionLength = 0;
                }
                if (SelectionStart < 5 && SelectionStart > 0) {
                    SelectionStart = 18;
                    SelectionLength = 0;
                }
                if (SelectionStart == 16) {
                    SelectionStart = 15;
                    SelectionLength = 0;
                }
                if (SelectionStart == 13) {
                    SelectionStart = 12;
                    SelectionLength = 0;
                }
              else {
                int SelTemp = SelectionStart;
                Text = Text.Remove(SelectionStart - 1, 1).Insert(SelectionStart - 1 , "_");
                SelectionStart = SelTemp - 1;
                }
           }
           if (char.IsDigit(e.KeyChar)) {
                if (SelectionStart == 0) {
                    SelectionStart = SelectionStart + 4;
                }
                if (SelectionStart > 6 && SelectionStart < 9) {
                    if (SelectionStart == 7) {
                        SelectionStart = SelectionStart + 2;
                    }
                }
                if (SelectionStart == 12) {
                    SelectionStart = SelectionStart + 1;
                }

                if (SelectionStart == 15) {
                    SelectionStart = SelectionStart + 1;
                }

                if(SelectionStart > 17) {
                    SelectionStart = 4;
                }
                else {
                    int start = SelectionStart;
                    Text = Text.Remove(SelectionStart, 1).Insert(SelectionStart, e.KeyChar.ToString());
                    SelectionStart = start + 1;             
                }
            }
             e.Handled = true;
        }
        protected void ButtonDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back || e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) {
                 e.Handled = true;
            }            
        }
        new void MouseClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                MessageBox.Show("В данном окне действие недоступно.");
            }
            else {
                base.OnClick(e);
            }
        }
    }

}
