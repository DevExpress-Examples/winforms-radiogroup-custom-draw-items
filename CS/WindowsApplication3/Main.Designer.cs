namespace WindowsApplication3 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.customRadioGroup1 = new WindowsApplication3.CustomRadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.customRadioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // customRadioGroup1
            // 
            this.customRadioGroup1.Location = new System.Drawing.Point(110, 40);
            this.customRadioGroup1.Name = "customRadioGroup1";
            this.customRadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("A", "A"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("B", "B"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "C")});
            this.customRadioGroup1.Properties.CustomDrawItem += new WindowsApplication3.CustomDrawEventHandler(this.OnCustomDrawItem);
            this.customRadioGroup1.Size = new System.Drawing.Size(361, 229);
            this.customRadioGroup1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 311);
            this.Controls.Add(this.customRadioGroup1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "RadioGroup Custom Draw";
            ((System.ComponentModel.ISupportInitialize)(this.customRadioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private CustomRadioGroup customRadioGroup1;
    }
}

