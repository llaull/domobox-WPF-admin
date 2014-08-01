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
               
                switch (l.RowState.ToString())
                {
                    case "Unchanged":
                       // MessageBox.Show("rien de nouveau");
                        break;

                    //si ligne ajouter au dataView    
                    case "Added":
                       
                        //MessageBox.Show(l.RowState.ToString() + " " + idLigneNew);

                        string[,] donnees = new string[5, 2] { 
                                                                { "module_ref", Convert.ToString(l["module_ref", DataRowVersion.Current]) }, 
                                                                { "module_nom", (String)l["module_nom", DataRowVersion.Current] },
                                                                { "module_emplacement", (String)l["module_emplacement", DataRowVersion.Current] },
                                                                { "nrf_id", Convert.ToString(l["nrf_id", DataRowVersion.Current])},
                                                                { "module_type", Convert.ToString(l["module_type", DataRowVersion.Current]) }
                                                              };

                        com.insert("domotic_sensor_module", donnees, null);
                        
                        break;

                    //si ligne modifier du dataView
                    case "Modified":                       
                        MessageBox.Show("modifier");
                        break;

                    //si ligne supprimer du dataView
                    case "Deleted":
                        int idLigne = (int)l["id", DataRowVersion.Original];
                       // MessageBox.Show("Delete " + idLigne);
                        com.Delete(idLigne, "domotic_sensor_module", null);
                        break;
                }

            }

            //DataRow row = plup.NewRow();
            //plup.Rows.Add(row);NULL ,  '"+New_module_ref+"',  '"+New_module_ref+"',  '"+New_module_ref+"',  '"+New_module_ref+"',  '"+New_module_ref+"');", "domotic_sensor_module", null);
        }
    }
}
