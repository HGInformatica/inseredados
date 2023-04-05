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
    public class NegocioPessoa
    {

        #region METODOS REF INSERCOES PESSOA E ENDERECO
        public bool InserePessoa(Pessoa objPessoa)
        {
            Conexao conn = new Conexao();
            bool retorno = false;
            try
            {
          
                if (conn.OpenTransaction())
                {

                    int ID = 0;
                    string sql = @"INSERT INTO TBPESSOA VALUES
                        (@ID_TPESSOA,@DESCRICAO,@CPF,@PIS,@DATANASCIMENTO,@ESTADOCIVIL,@STATUS)";
                    conn.LimparParametros();
                    conn.AddParameter("ID_TPESSOA", objPessoa.objTipoPessoa.ID);
                    conn.AddParameter("@DESCRICAO", objPessoa.descricao);
                    conn.AddParameter("@CPF", objPessoa.cpf);
                    conn.AddParameter("@PIS", objPessoa.pis);
                    conn.AddParameter("@DATANASCIMENTO", objPessoa.data_nascimento);
                    conn.AddParameter("@ESTADOCIVIL", objPessoa.estado_civil);
                    conn.AddParameter("@STATUS", 'A');

                    ID = conn.executaComandoAI(sql, "TBPESSOA");
               
                    if(ID > 0)
                    {
                  
                        string sql2 = @"INSERT INTO TBENDERECO VALUES (@IDPESSOA,@CEP,@RUA,@BAIRRO,@NUM)";
                        conn.LimparParametros();
                        conn.AddParameter("@IDPESSOA", ID);
                        conn.AddParameter("@CEP", objPessoa.objEndereco.Cep);
                        conn.AddParameter("@RUA", objPessoa. objEndereco.Rua);
                        conn.AddParameter("@BAIRRO", objPessoa.objEndereco.Bairro);
                        conn.AddParameter("@NUM", objPessoa.objEndereco.Numero);
                        retorno = conn.executeComand(sql2);
                    }

                }
            }
            catch (Exception)
            {
                retorno = false;
                throw new Exception();
            }
            finally
            {
                if (retorno)
                    conn.COMMIT();
                else
                    conn.ROLLBACK();
            }

            return retorno;
        }

        public List<Pessoa> RecuperaPessoa()
        {
            List<Pessoa> retorno = new List<Pessoa>();
            string sql = "SELECT * FROM PESSOA";
            Conexao conn = new Conexao();
            DataTable dt = conn.executaDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                Pessoa objPessoa = new Pessoa();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objPessoa.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                    objPessoa.objTipoPessoa.ID = Convert.ToInt32(dt.Rows[i]["ID_TPESSOA"].ToString());
                    objPessoa.cpf = dt.Rows[i]["cpf"].ToString();
                    objPessoa.pis = dt.Rows[i]["pis"].ToString();
                    objPessoa.data_nascimento = dt.Rows[i]["data_nascimento"].ToString();
                    objPessoa.estado_civil = dt.Rows[i]["estado_civil"].ToString();
                    objPessoa.status = dt.Rows[i]["status"].ToString();
                    retorno.Add(objPessoa);
                    objPessoa = null;objPessoa = new Pessoa();

                }
            }
            return retorno;
        }
        #endregion

        #region METODOS REF A VINCULO DOS CARGO C/ PESSOAS
        public bool VinculaPessoaACargo(CargoPessoa objCargoPessoa)
        {
            string sql = @"INSERT INTO TBCARGOPESSOA VALUES (@IDPESSOA,@IDCARGO,@DATAADM,@DATADM,@OBS)";
            Conexao conn = new Conexao();
            conn.LimparParametros();
            conn.AddParameter("@IDPESSOA", objCargoPessoa.objPessoa.ID);
            conn.AddParameter("@IDCARGO", objCargoPessoa.objCargo.ID);
            conn.AddParameter("@DATAADM", objCargoPessoa.DataAdmissao);
            conn.AddParameter("@DATADM", null);
            conn.AddParameter("@OBS", objCargoPessoa.Observacao);
            return conn.executeComand(sql);
        }
        #endregion

     
    }
}
