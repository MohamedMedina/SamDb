using ApplicationBlocks.Layers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBase _database = new DataBase();
            DbConnection _dbconnection=  _database.CreateConnection(_database.GetConnectionString());

            _dbconnection.Open();

            if (_dbconnection != default(DbConnection))
            {
                if (_dbconnection.State == System.Data.ConnectionState.Open)
                {
                }
                else
                {

                }
            }
            else
            {
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
