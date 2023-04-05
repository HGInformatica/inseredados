
using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.ClassesDeEntidade;

namespace Negocio
{
    public class NegocioCargo
    {
        public bool InsereCargo(Cargo objCargo)
        {
            Conexao conn = new Conexao();
            string sql = @"INSERT INTO tbCARGO VALUES (@DESCRICAO)";
            conn.LimparParametros();
            conn.AddParameter("@DESCRICAO", objCargo.Descricao);
            return conn.executeComand(sql);
        }

        public List<Cargo> RecuperaCargos()
        {
            List<Cargo> retorno = new List<Cargo>();
            Conexao conn = new Conexao();
            string sql = @"SELECT * FROM tbCARGO";
            DataTable dt = conn.executaDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                Cargo obj = new Cargo();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    obj.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    obj.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                    retorno.Add(obj);
                    obj = null;obj = new Cargo();
                }
            }
            return retorno;
        }
    }
}
