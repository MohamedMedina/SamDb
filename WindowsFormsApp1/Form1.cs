using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using Business;
using Common;
using DataAccess;
using com.idemia.sam.be.Helpers;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connstring = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;//loadConnConfigurations();
            //IUserBLL _IUserBLL = new UserBLL(connstring);


            IUserBLL _IUserBLL = new UserBLL();
            ICollection <UserDTO> Source = _IUserBLL.GetAllUsers();
            dataGridView1.DataSource = Source;



            //ICollection<UserDTO> Source = new List<UserDTO>();

            //UserBusiness _UserBusiness = new UserBusiness();
            //UserList _UserList = _UserBusiness.SelectRows(null, null, null, null);

            //if (_UserList != null && _UserList.Count > 0)
            //    Source = Mapper.MapOutside(_UserList);

            //dataGridView1.DataSource = Source;
        }
    }
}
