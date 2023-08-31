using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication3 {
    public delegate void CustomDrawEventHandler(object sender, CustomDrawEventArgs e);
    public class CustomDrawEventArgs : EventArgs
    {
        GraphicsCache cache;
        RadioGroupItemViewInfo itemInfo;
        CheckObjectPainter checkPainter;
        bool handled;

        public CustomDrawEventArgs(GraphicsCache cache, RadioGroupItemViewInfo itemInfo, CheckObjectPainter checkPainter, bool handled)
        {
            this.cache = cache;
            this.itemInfo = itemInfo;
            this.checkPainter = checkPainter;
            this.handled = handled;
        }

        public GraphicsCache Cache
        {
            get { return cache; }
        }

        public RadioGroupItemViewInfo ItemInfo
        {
            get { return itemInfo; }
        }

        public CheckObjectPainter CheckPainter
        {
            get { return checkPainter; }
        }

        public bool Handled
        {
            get { return handled; }
            set
            {
                if (handled != value)
                    handled = value;
            }
        }
    }
}