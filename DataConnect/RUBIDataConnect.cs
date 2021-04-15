using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ServicingAPI.Classes;

namespace ServicingAPI.DataConnect
{
    public class RUBIDataConnect : IDisposable
    {
        public const string GetAPIUsersList = "EXEC dbo.PQ_CutomerAPI_GetAPIUsersList"; 
        public const string SubmitDeal = "EXEC dbo.PQ_ServicingAPI_SubmitDeal"; 
        private SqlCommand _GetAPIUsersList;
        private SqlCommand _SubmitDeal;
        private SqlConnection _Connection;
        private SqlDataReader _rs;
        private string _ConnectionString;

        public RUBIDataConnect(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
            _Connection = new SqlConnection(ConnectionString);
            _Connection.Open();

            _GetAPIUsersList = new SqlCommand(GetAPIUsersList, _Connection);
        }

        public List<User> GetAPIUsersListFunc()
        {
            List<User> result = new List<User>();
            string API_User_ID = null;
            string API_User_FirstName = null;
            string API_User_LastName = null;
            string API_User_UserName = null;
            string API_User_Password = null;

            _rs = _GetAPIUsersList.ExecuteReader();

            if (_rs.HasRows)
            {
                while (_rs.Read())
                {
                    API_User_ID = _rs["API_User_ID"].ToString();
                    API_User_FirstName = _rs["API_User_FirstName"].ToString();
                    API_User_LastName = _rs["API_User_LastName"].ToString();
                    API_User_UserName = _rs["API_User_UserName"].ToString();
                    API_User_Password = _rs["API_User_Password"].ToString();
                    User user = new User(API_User_ID, API_User_FirstName, API_User_LastName, API_User_UserName, API_User_Password);
                    result.Add(user);
                }
                _rs.Close();
                return result;
            }
            _rs.Close();
            return result;
        }

        public SubmitDealResponse SubmitDealFunc(SubmitDealRequest submitDealRequest)
        {
            List<User> result = new List<User>();
            string API_User_ID = null;
            string API_User_FirstName = null;
            string API_User_LastName = null;
            string API_User_UserName = null;
            string API_User_Password = null;

            _rs = _GetAPIUsersList.ExecuteReader();

            if (_rs.HasRows)
            {
                while (_rs.Read())
                {
                    API_User_ID = _rs["API_User_ID"].ToString();
                    API_User_FirstName = _rs["API_User_FirstName"].ToString();
                    API_User_LastName = _rs["API_User_LastName"].ToString();
                    API_User_UserName = _rs["API_User_UserName"].ToString();
                    API_User_Password = _rs["API_User_Password"].ToString();
                    User user = new User(API_User_ID, API_User_FirstName, API_User_LastName, API_User_UserName, API_User_Password);
                    result.Add(user);
                }
                _rs.Close();
                return null;
            }
            _rs.Close();
            return null;

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _GetAPIUsersList.Dispose();
                _Connection.Dispose();
                _rs.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
