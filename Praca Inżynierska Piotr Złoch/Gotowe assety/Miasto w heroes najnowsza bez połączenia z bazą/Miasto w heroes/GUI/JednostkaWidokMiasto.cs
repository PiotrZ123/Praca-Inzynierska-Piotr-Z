using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miasto_w_heroes.GUI;
using Miasto_w_heroes.Model;

namespace Miasto_w_heroes.GUI
{
    public partial class JednostkaWidokMiasto : JednostkaWidok
    {
        public JednostkaWidokMiasto(Jednostka jednostka):base(jednostka)
        {
            InitializeComponent();
        }
    }
}
