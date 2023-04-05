
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
    public class NegocioTipoPessoa
    {
        public bool InsereTipoPessoa(TipoPessoa objTipoPessoa)
        {
            Conexao conn = new Conexao();
            string sql = @"INSERT INTO tbTipoPessoa VALUES (@DESCRICAO)";
            conn.LimparParametros();
            conn.AddParameter("@DESCRICAO", objTipoPessoa.Descricao);
            return conn.executeComand(sql);
        }

        public List<TipoPessoa> RecuperaTipoPessoa()
        {
            List<TipoPessoa> retorno = new List<TipoPessoa>();
            Conexao conn = new Conexao();
            string sql = @"SELECT * FROM tbTipoPessoa";
            DataTable dt = conn.executaDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                TipoPessoa obj = new TipoPessoa();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    obj.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    obj.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                    retorno.Add(obj);
                    obj = null;obj = new TipoPessoa();
                }
            }
            return retorno;
        }
    }
}
