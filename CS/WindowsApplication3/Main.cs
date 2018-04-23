using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;


namespace WindowsApplication3 {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
      
        private void OnCustomDrawItem(object sender, CustomDrawEventArgs e)
        {
            if (e.ItemInfo.CheckState == CheckState.Checked)
            {
                e.ItemInfo.Appearance.Font = new Font(e.ItemInfo.Appearance.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (e.ItemInfo.State == DevExpress.Utils.Drawing.ObjectState.Hot)
            {
                LinearGradientBrush brush = new LinearGradientBrush(e.ItemInfo.Bounds, Color.LightBlue, Color.Indigo, LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRectangle(brush, e.ItemInfo.Bounds);
                e.CheckPainter.DrawObject(e.ItemInfo);
                
                e.Handled = true;
            }
        }
    }
}
