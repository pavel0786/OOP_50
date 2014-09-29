using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RRadioButtonList : CheckedListBox
    {
        public RRadioButtonList()
        {
            InitializeComponent();

        }

        public RRadioButtonList(IContainer container)
        {
            
        }

        public virtual void OnItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < this.Items.Count; ++ix)
                    if (e.Index != ix) 
                        this.SetItemChecked(ix, false);
        }
    }
}
