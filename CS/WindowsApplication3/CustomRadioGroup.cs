using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace WindowsApplication3 {
    public class CustomRadioGroup : RadioGroup
    {

        static CustomRadioGroup() { RepositoryItemCustomRadioGroup.RegisterCustomEdit(); }

        public CustomRadioGroup() { }

        public override string EditorTypeName { get { return RepositoryItemCustomRadioGroup.CustomEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomRadioGroup Properties
        {
            get { return base.Properties as RepositoryItemCustomRadioGroup; }
        }

    }

}