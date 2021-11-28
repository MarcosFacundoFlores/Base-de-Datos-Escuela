using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GenerarExcel
{
    class DataAccess
    {
        public List<Alumno> GetAlumno(string anio)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("dataDB")))
            {
                return connection.Query<Alumno>("dbo.GENERAR @ANIO", new{ANIO = anio}).ToList();
            }
        }

        public void InsertPassword(string user, string password)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("dataDB")))
            {
                User newUser = new User { Password = password, Dni = user };
                connection.Execute($"INSERT INTO USUARIOS (NOMBRE, CONTRASEÑA) VALUES ('{newUser.Dni}', PwdEncrypt('{newUser.Password}'))");

            }
        }

        public bool Login(string dni, string contraseña)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("dataDB")))
            {
      
                bool exists = connection.ExecuteScalar<bool>($"SELECT * FROM USUARIOS WHERE NOMBRE = '{dni}' and PwdCompare('{contraseña}', CONTRASEÑA) = 1 ");
                return exists;
            }
        }

        public bool Consulta(string dni)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("dataDB")))
            {
                bool exists = connection.ExecuteScalar<bool>($"SELECT * FROM LISTA WHERE LISTA.DOC = '{dni}' ");
                return exists;
            }
        }

        public List<Alumno> ConsultaAlumno(string DNI)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("dataDB")))
            {
                return connection.Query<Alumno>("dbo.CONSULTAR @DOC", new { DOC = DNI }).ToList();
            }

        }

    }
}
