using ModelDanych;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miasto_w_heroes
{
    public partial class EkranOdczytu : Form
    {
        List<MapaModel> modele;
        bool poprawne;
        int id;
        public EkranOdczytu()
        {
            InitializeComponent();
        }
        public EkranOdczytu(List<MapaModel> modele)
        {
            InitializeComponent();
            this.modele = modele;
            for(int i=0; i<modele.Count; i++)
            {
                ListViewItem item = new ListViewItem(modele[i].Id+"");
                item.SubItems.Add(modele[i].DataICzasUtorzenia.ToString());
                listView1.Items.Add(item);
            }
            poprawne = false;
        }
        public bool Poprawne
        {
            get
            {
                return poprawne;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==1)
            {
                int index = listView1.SelectedIndices[0];

                id = modele[index].Id;
                poprawne = true;
                Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                int index = listView1.SelectedIndices[0];

                id = modele[index].Id;
                Gra.DajInstancje().Usun(id);
                listView1.Items.RemoveAt(index);

            }
        }
    }
}
