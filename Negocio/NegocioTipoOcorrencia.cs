
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
    public class NegocioTipoOcorrencia
    {
        public bool InsereTipoOcorrencia(TipoOcorrencia objTipoPessoa)
        {
            Conexao conn = new Conexao();
            string sql = @"INSERT INTO tbTipoOcorrencia VALUES (@DESCRICAO)";
            conn.LimparParametros();
            conn.AddParameter("@DESCRICAO", objTipoPessoa.Descricao);
            return conn.executeComand(sql);
        }

        public List<TipoOcorrencia> RecuperaTipoOcorrencias()
        {
            List<TipoOcorrencia> retorno = new List<TipoOcorrencia>();
            Conexao conn = new Conexao();
            string sql = @"SELECT * FROM tbTipoOcorrencia";
            DataTable dt = conn.executaDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                TipoOcorrencia obj = new TipoOcorrencia();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    obj.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    obj.Descricao = dt.Rows[i]["DESCRICAO"].ToString();
                    retorno.Add(obj);
                    obj = null;obj = new TipoOcorrencia();
                }
            }
            return retorno;
        }
    }
}
