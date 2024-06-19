using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
namespace ProiectPAW_Faza1
{
    public class DataBase
    {
        private string host;
        private string port;
        private string service;
        private string username;
        private string password;
        public OracleConnection conection;
        private bool closed;
        public DataBase(string host, string port, string service, string username, string password)
        {
            this.host = host;
            this.port = port;
            this.service = service;
            this.username = username;
            this.password = password;
            string connstring = string.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};", host, port, service, username, password);
            conection = new OracleConnection(connstring);
            closed = true;
        }
    public void Open()
        {
            conection.Open();
            closed = false;
        }

    public void Close()
        {
            conection.Close();
            closed = true;
        }
        public bool IsClosed()
        {
            return closed;
        }
        
    }
}
