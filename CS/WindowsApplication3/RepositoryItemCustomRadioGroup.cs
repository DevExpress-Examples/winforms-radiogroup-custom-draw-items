using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using System.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DXSample;

namespace WindowsApplication3 {
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomRadioGroup : RepositoryItemRadioGroup
    {

        static RepositoryItemCustomRadioGroup() { RegisterCustomEdit(); }

        public RepositoryItemCustomRadioGroup() { }

        public const string CustomEditName = "CustomRadioGroup";

        public override string EditorTypeName { get { return CustomEditName; } }

        public static void RegisterCustomEdit()
        {
            Image img = null;
            try
            {
                img = (Bitmap)Bitmap.FromStream(Assembly.GetExecutingAssembly().
                  GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp"));
            }
            catch
            {
            }
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(CustomRadioGroup), typeof(RepositoryItemCustomRadioGroup),
              typeof(RadioGroupViewInfo), new CustomRadioGroupPainter(), true, img));
        }

        static readonly object customDraw = new object();

        public event CustomDrawEventHandler CustomDrawItem
        {
            add { this.Events.AddHandler(customDraw, value); }
            remove { this.Events.RemoveHandler(customDraw, value); }
        }

        internal void RaiseCustomDrawItem(CustomDrawEventArgs e)
        {
            CustomDrawEventHandler handler = (CustomDrawEventHandler)Events[customDraw];
            if (handler != null) handler(GetEventSender(), e);
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemCustomRadioGroup source = item as RepositoryItemCustomRadioGroup;
                if (source == null) return;
                Events.AddHandler(customDraw, source.Events[customDraw]);
            }
            finally
            {
                EndUpdate();
            }
        }
    }

}