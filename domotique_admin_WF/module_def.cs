using CnxMYSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domotique_admin_WF
{
    public partial class module_def : Form
    {

        DBConnect com = new DBConnect();

        public module_def()
        {
            InitializeComponent();
        }

        private void module_def_Load(object sender, EventArgs e)
        {
            module__list_def.DataSource = com.Select("SELECT * FROM  `domotic_sensor_module` ORDER BY  `domotic_sensor_module`.`module_nom` DESC LIMIT 0 , 30", null);
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            DataTable ligne = (DataTable)module__list_def.DataSource;

            foreach (DataRow l in ligne.Rows)
            {
                int idLigne = (int)l["id", DataRowVersion.Original];
                
                switch (l.RowState.ToString())
                {
                    case "Unchanged":
                       // MessageBox.Show("modifier");
                        break;
                    case "Modified":                       
                        MessageBox.Show("modifier");
                        break;
                    case "Deleted":
                      
                        MessageBox.Show("Delete " + idLigne);
                        com.Delete(idLigne, "domotic_sensor_module", null);
                        break;
                }

            }

            //DataRow row = plup.NewRow();
            //plup.Rows.Add(row);
        }
    }
}
