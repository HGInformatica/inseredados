using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClassesDeEntidade
    {

        public class TipoPessoa
        {

            public int ID { get; set; }
            public string Descricao { get; set; }
            public TipoPessoa()
            {}


            public TipoPessoa(int ID, string Descricao)
            {
                this.ID = ID;
                this.Descricao = Descricao;
            }

            public TipoPessoa(int iD)
            {
                this.ID = ID;
            }
        }

        public class Pessoa
        {
            public int ID { get; set; }
            public TipoPessoa objTipoPessoa { get; set; }
            public Endereco objEndereco { get; set; }
            public string descricao { get; set; }
            public string cpf { get; set; }
            public string pis { get; set; }
            public string data_nascimento { get; set; }
            public string estado_civil { get; set; }
            public string status { get; set; }


            public Pessoa()
            {}

            public Pessoa(int ID, TipoPessoa objTipoPessoa, Endereco objEndereco, string descricao, string cpf, string pis, string data_nascimento, string estado_civil, string status)
            {
                this.ID = this.ID;
                this.objTipoPessoa = objTipoPessoa;
                this.objEndereco = objEndereco;
                this.descricao = descricao;
                this.cpf = cpf;
                this.pis = pis;
                this.data_nascimento = data_nascimento;
                this.estado_civil = estado_civil;
                this.status = status;
            }
            public Pessoa(TipoPessoa objTipoPessoa, Endereco objEndereco, string descricao, string cpf, string pis, string data_nascimento, string estado_civil, string status)
            {
                this.objTipoPessoa = objTipoPessoa;
                this.objEndereco = objEndereco;
                this.descricao = descricao;
                this.cpf = cpf;
                this.pis = pis;
                this.data_nascimento = data_nascimento;
                this.estado_civil = estado_civil;
                this.status = status;
            }

            public Pessoa(int ID)
            {
                this.ID = ID;
            }
        }

        public class Cargo
        {

            public int ID { get; set; }
            public string Descricao { get; set; }
            public Cargo()
            { }


            public Cargo(int ID, string Descricao)
            {
                this.ID = ID;
                this.Descricao = Descricao;
            }

            public Cargo(int iD)
            {
                this.ID = ID;
            }
        }

        public class CargoPessoa
        {

            public int ID { get; set; }
            public Pessoa objPessoa { get; set; }
            public Cargo objCargo { get; set; }
            public string DataAdmissao { get; set; }
            public string DataDemissao { get; set; }
            public string Observacao { get; set; }

            public CargoPessoa()
            { }

            public CargoPessoa(int ID, Pessoa objPessoa, string DataAdmissao, string DataDemissao, string Observacao)
            {
                this.ID = ID;
                this.objPessoa = objPessoa;
                this.DataAdmissao = DataAdmissao;
                this.DataDemissao = DataDemissao;
                this.Observacao = Observacao;
            }
            public CargoPessoa(Pessoa objPessoa, string DataAdmissao, string DataDemissao, string Observacao)
            {
                this.objPessoa = objPessoa;
                this.DataAdmissao = DataAdmissao;
                this.DataDemissao = DataDemissao;
                this.Observacao = Observacao;
            }
        }

        public class Endereco
        {

            public int ID { get; set; }
            public Pessoa objPessoa { get; set; }
            public string Cep { get; set; }
            public string Rua { get; set; }
            public string Bairro { get; set; }
            public int Numero { get; set; }

            public Endereco()
            { }

            public Endereco(int ID, Pessoa objPessoa, string Cep, string Rua, string Bairro, int Numero)
            {
                this.ID = ID;
                this.objPessoa = objPessoa;
                this.Cep = Cep;
                this.Rua = Rua;
                this.Bairro = Bairro;
                this.Numero = Numero;
            }

            public Endereco(Pessoa objPessoa, string Cep, string Rua, string Bairro, int Numero)
            {
                this.objPessoa = objPessoa;
                this.Cep = Cep;
                this.Rua = Rua;
                this.Bairro = Bairro;
                this.Numero = Numero;
            }
        }

        public class TipoOcorrencia
        {

            public int ID { get; set; }
            public string Descricao { get; set; }
            public TipoOcorrencia()
            { }


            public TipoOcorrencia(int ID, string Descricao)
            {
                this.ID = ID;
                this.Descricao = Descricao;
            }

            public TipoOcorrencia(int iD)
            {
                this.ID = ID;
            }
        }

        public class OcorrenciasPessoa
        {

            public int ID { get; set; }
            public Pessoa objPessoa { get; set; }
            public TipoOcorrencia objTipoOcorrencia { get; set; }
            public string DataOcorrencia { get; set; }
            public string Observacao { get; set; }
            public string ObservacaoRH { get; set; }
            public string DataObsRH { get; set; }
            public Pessoa objPessoaRH { get; set; }

            public OcorrenciasPessoa()
            { }

            public OcorrenciasPessoa(int ID, Pessoa objPessoa, TipoOcorrencia objTipoOcorrencia, string DataOcorrencia, string Observacao, string ObservacaoRH, string DataObsRH, Pessoa objPessoaRH)
            {
                this.ID = ID;
                this.objPessoa = objPessoa;
                this.objTipoOcorrencia = objTipoOcorrencia;
                this.DataOcorrencia = DataOcorrencia;
                this.Observacao = Observacao;
                this.ObservacaoRH = ObservacaoRH;
                this.DataObsRH = DataObsRH;
                this.objPessoaRH = objPessoaRH;
            }
        }

    }
}

