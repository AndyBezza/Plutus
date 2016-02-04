using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Plutus.CustomControls
{
    public class ColourableListBox : ListBox
    {
        private Color highlight = SystemColors.Highlight;
        private Color[] colorList;

        public ColourableListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;

            this.colorList = new Color[0]; 
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if ((e.Index < 0) || (this.Items.Count == 0))
            {
                return;
            }

            Rectangle rect = base.GetItemRectangle(e.Index);

            Color highlight;
            if ((this.SelectionMode != SelectionMode.None) && ((e.State & DrawItemState.Selected) == DrawItemState.Selected))
                highlight = this.highlight;
            else
                highlight = this.BackColor;

            using (Brush brush = new SolidBrush(highlight))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            Color textColor = Color.Empty;
            if ((this.SelectionMode != SelectionMode.None) && ((e.State & DrawItemState.Selected) != DrawItemState.Selected))
            {
                textColor = GetItemColor(e.Index);

                if (textColor.IsEmpty)
                {
                    textColor = base.ForeColor;
                }
            }
            else
            {
                textColor = GetItemColor(e.Index);
            }

            TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString(), this.Font, rect, textColor, TextFormatFlags.GlyphOverhangPadding);
        }

        public void SetItemColor(int index, Color color)
        {
            if (!(index < colorList.Length))
            {
                Color[] tempArray = new Color[index + 1];
                colorList.CopyTo(tempArray, 0);
                colorList = tempArray; 
            }
            colorList[index] = color;
        }

        public Color GetItemColor(int index)
        {
            if (index < colorList.Length)
            {
                return colorList[index];
            } 
            else
            {
                return Color.HotPink; 
            }
        }
    }
}