using Branch_project.Views.InterFaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_project.Logic.Presenter
{
    class BranchViewPresenter
    {




        #region Fields

        private readonly IBranchView BranchRepo;



        #endregion



        #region Constractors

        public BranchViewPresenter(IBranchView reop)
        {
            BranchRepo = reop;

           // RefreshData();


        }

        #endregion



        #region Functions



        public SqlConnection SQlConnection()
        {

            try
            {
                string connectionstring = @"data source=SERVER2012\SERVER_2005;initial catalog=EasyErp_newteam;user id=sa;password=walan1@3;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                return con;

            }
            catch (Exception ex) { /*MessageBox.Show(ex.Message);*/ return null; }
        }
        public string AddBranch( SqlConnection Connection,string branchname,string branchename,int currid,string manager,string emanager,string address,string eaddress,string tel1, string tel2 ,string fax,string email,int companyId)
        {
            string ReturnString = "";

            try
            {
               
                SqlCommand sqlCmd = new SqlCommand("spAddBranch",Connection );
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@branchname", SqlDbType.NVarChar).Value = branchname;
                sqlCmd.Parameters.AddWithValue("@branchename", SqlDbType.NVarChar).Value = branchename;
                sqlCmd.Parameters.AddWithValue("@currid", SqlDbType.Int).Value = currid;
                sqlCmd.Parameters.AddWithValue("@manager", SqlDbType.NVarChar).Value = manager;
                sqlCmd.Parameters.AddWithValue("@emanager", SqlDbType.NVarChar).Value = emanager;
                sqlCmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = address;

                sqlCmd.Parameters.AddWithValue("@eaddress", SqlDbType.NVarChar).Value = eaddress;
                sqlCmd.Parameters.AddWithValue("@tel1", SqlDbType.NVarChar).Value = tel1;



                sqlCmd.Parameters.AddWithValue("@tel2", SqlDbType.NVarChar).Value = tel2;


                sqlCmd.Parameters.AddWithValue("@fax", SqlDbType.NVarChar).Value = fax;

                sqlCmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = email;
                sqlCmd.Parameters.AddWithValue("@companyid", SqlDbType.Int).Value = companyId;

                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                ReturnString = "تمت اضافة الفرع بنجاح";


                return ReturnString;
            }
            catch (Exception ex)
            {

                ReturnString = ex.Message;
                return ReturnString;
            }

        }

       
        
        
        
        
        #endregion





    }
}
