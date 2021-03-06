﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement.Winforms.Common
{
    public class ComboBoxItem
    {

        public ComboBoxItem() { }

        public ComboBoxItem(object Value, string Text)
        {
            this.Value = Value;
            this.Text = Text;
        }

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }


    }
}
