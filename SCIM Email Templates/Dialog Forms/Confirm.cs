using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCIM_Email_Templates.Dialog_Forms
{
    public partial class Confirm : Form
    {
        /// <summary>
        /// Create a new instance of the Confirm dialog
        /// </summary>
        /// <param name="Title">The title for the Confirms Dialog</param>
        /// <param name="Message">The Message for the Confirm Dialog</param>
        public Confirm(String Title, String Message)
        {
            InitializeComponent();
            this.lblMessage.Text = Message;
            this.lblTitle.Text = Title;
        }
    }
}
