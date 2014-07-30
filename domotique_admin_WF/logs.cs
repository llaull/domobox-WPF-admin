using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;
using CnxMYSQL;
using System.Data;


namespace domotique_admin_WF
{
    public partial class logs : Form
    {

        DBConnect com = new DBConnect();


        /// <summary>
        /// initialisation du formulaire
        /// </summary>
        public logs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// remplissage de la dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">erreure</param>
        private void modules_Load(object sender, EventArgs e)
        {

            module_log.DataSource = com.Select("SELECT * FROM  `domotic_sensor` ORDER BY  `domotic_sensor`.`valeur_temp` DESC LIMIT 0 , 30", null);

        }

        private void ligne_supp_Click(object sender, EventArgs e)
        {
            int id = (int)module_log.SelectedRows[0].Cells[0].Value;            
            com.Delete(id, "domotic_sensor", null);

            module_log.DataSource = com.Select("SELECT * FROM  `domotic_sensor` ORDER BY  `domotic_sensor`.`valeur_temp` ASC LIMIT 0 , 30", null);
        }

    }
}
