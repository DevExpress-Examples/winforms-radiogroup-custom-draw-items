using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsApplication3;

namespace DXSample
{
    public class CustomRadioGroupPainter : RadioGroupPainter
    {
        public CustomRadioGroupPainter() : base() { }
        protected override void DrawRadioGroupItems(ControlGraphicsInfoArgs info)
        {
            RadioGroupViewInfo vi = info.ViewInfo as RadioGroupViewInfo;
            foreach (RadioGroupItemViewInfo itemInfo in vi.ItemsInfo)
            {
                itemInfo.Cache = info.Cache;
                try
                {
                    CustomDrawEventArgs e = new CustomDrawEventArgs(info.Graphics, itemInfo, vi.RadioPainter, false);
                    RepositoryItemCustomRadioGroup item = vi.Item as RepositoryItemCustomRadioGroup;
                    item.RaiseCustomDrawItem(e);
                    if (!e.Handled)
                        vi.RadioPainter.DrawObject(itemInfo);
                    if (itemInfo.Focused)
                        ControlPaint.DrawFocusRectangle(info.Graphics, vi.GetFocusRect(itemInfo));
                }
                finally
                {
                  itemInfo.Cache = null;
                }
            }
        }
    }

}


