using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.ClassesDeEntidade;

namespace Negocio
{
    public class NegocioOcorrenciaPessoa
    {
        public bool InsereOcorrenciaPessoa(OcorrenciasPessoa objOcorrenciasPessoa)
        {
            string sql = @"INSERT INTO [DBO].[TBOCORRENCIASPESSOA]
                ([ID_PESSOA],[ID_OCORRENCIA],[DATA_OCORRENCIA],[OBSERVACAO_PESSOA])
                VALUES (@IDPESSOA,@IDOCORRENCIA,GETDATE(),@OBSERVACAO)";
            Conexao conn = new Conexao();
            conn.LimparParametros();
            conn.AddParameter("@IDPESSOA", objOcorrenciasPessoa.objPessoa.ID);
            conn.AddParameter("@IDOCORRENCIA", objOcorrenciasPessoa.objTipoOcorrencia.ID);
            conn.AddParameter("@OBSERVACAO", objOcorrenciasPessoa.Observacao);
            return conn.executeComand(sql);
        }
    }
}
