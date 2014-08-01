using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CnxMYSQL
{
    class DBConnect
    {
        public MySqlConnection connexion;
        public MySqlCommand cmd;
                
        private string serveur = "10.119.33.10";
        private string basedonnees = "app_domobox";
        private string utilisateur = "jb";
        private string mdp = "jb";

        public DBConnect()
        {
            Authentification();
        }

        private void Authentification()
        {
            string Path;

            Path = "SERVER=" + serveur + ";" + "DATABASE=" + basedonnees + ";" + "UID=" + utilisateur + ";" + "PASSWORD=" + mdp + ";";

            connexion = new MySqlConnection(Path);

            // Ouverture de la connexion à la Base de Données
            try
            {
                connexion.Open();
            }
            catch (MySqlException sqlex)
            {
                //0 : Impossible de se connecter au serveur.
                //1045 : Nom d'utilisateur et/ou Mots de Passe invalides
                switch (sqlex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter au serveur : " + serveur + "Merci de contacter votre administrateur");
                        break;
                    case 1045:
                        MessageBox.Show("Nom d'utilisateur et/ou Mots de Passe invalides, Merci de réessayer");
                        break;
                    default:
                        break;
                }
            }

            //Fermeture de la connexion à la Base de Données
            try
            {
                connexion.Close();
            }
            catch (MySqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SQL">requete select</param>
        /// <param name="paramsarray">NULL</param>
        /// <returns></returns>
        public DataTable Select(string SQL, MySqlParameter[] paramsarray)
        {
            DataTable table = new DataTable();
                connexion.Open();
                cmd = connexion.CreateCommand();
                cmd.CommandText = SQL;
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paramsarray ?? new MySqlParameter[0]);
                table.Load(cmd.ExecuteReader());
                connexion.Close();
            return table;
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id de la table</param>
        /// <param name="tableCible">nom de la table</param>
        /// <param name="paramsarray">WTF</param>
        public void Delete(int id, string tableCible, MySqlParameter[] paramsarray)
        {
            DataTable table = new DataTable();
            connexion.Open();
            cmd = connexion.CreateCommand();
            cmd.CommandText = @"delete from " + tableCible + " where id=" + id + ";";
            cmd.Parameters.Clear();
            cmd.ExecuteNonQuery();
            cmd.Parameters.AddRange(paramsarray ?? new MySqlParameter[0]);
            connexion.Close();           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SQL"></param>
        /// <param name="paramsarray"></param>
        /// <returns></returns>
        public DataTable update(string SQL, MySqlParameter[] paramsarray)
        {
            DataTable table = new DataTable();
            connexion.Open();
            cmd = connexion.CreateCommand();
            cmd.CommandText = SQL;
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paramsarray ?? new MySqlParameter[0]);
            table.Load(cmd.ExecuteReader());
            connexion.Close();
            return table;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SQL"></param>
        /// <param name="paramsarray"></param>
        /// <returns></returns>
        public DataTable insert(string tableCible, string[,] TableauDeDonnee, MySqlParameter[] paramsarray)
        {
            DataTable table = new DataTable();
            connexion.Open();
            cmd = connexion.CreateCommand();

           /* MessageBox.Show(TableauDeDonnee[0, 0]);
            MessageBox.Show(TableauDeDonnee[0, 1]);*/
            //cmd.CommandText = "INSERT INTO `" + tableCible + "` (`" + TableauDeDonnee[i, 0] + "`) VALUES ('" + TableauDeDonnee[i, 1] + "');";
            for (int i = 0; i < TableauDeDonnee.GetLength(0); i++)
            {
               //MessageBox.Show(TableauDeDonnee[i, 0] + " contient :  " + TableauDeDonnee[i, 1]);
                
                
            }
            //cmd.CommandText = "INSERT INTO `domotic_sensor_module` (`module_ref`) VALUES ('9');";

            //cmd.CommandText = "INSERT INTO  " + tableCible + " () VALUES ();";

/* com.insert(@"INSERT INTO  `app_domobox`.`domotic_sensor_module` (

`module_ref` ,
`module_nom` ,
`module_emplacement` ,
`nrf_id` ,
`module_type`
)
VALUES (
'"+New_module_ref+"',  '"+New_module_ref+"',  '"+New_module_ref+"',  '"+New_module_ref+"',  '"+New_module_ref+"');", "domotic_sensor_module", null);*/


            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paramsarray ?? new MySqlParameter[0]);
            table.Load(cmd.ExecuteReader());
            connexion.Close();
            return table;

        }

    }
}
