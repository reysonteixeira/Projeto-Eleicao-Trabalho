using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_eleicao
{
    public class Eleicao
    {

        public Eleicao()
        {
            eleicoes.listaCandidato = new List<Candidato>();
        }


        //###################################################  CANDIDATOS  ###############################################################
        public struct Candidato
        {
            public string nomeCompleto, nomeAbreviado, nomePartido, nascimento, foto;
            public int numeroPartido;
        }

        public Candidato candidato = new Candidato();

        public void insereCandidato()
        {
            eleicoes.listaCandidato.Add(candidato);
        }

        private int indice;

        //##################################################  MÉTODO SET  ##############################################################

        public void setNomeCompleto(string nome)
        {
            candidato.nomeCompleto = nome;
        }

        public void setNomeAbreviado(string nome)
        {
            candidato.nomeAbreviado = nome;
        }

        public void setNascimento(string nome)
        {
            candidato.nascimento = nome;
        }

        public void setNomePartido(string nome)
        {
            candidato.nomePartido = nome;
        }

        public void setNumPartido(int num)
        {
            candidato.numeroPartido = num;
        }

        public void setFoto(string foto)
        {
            candidato.foto = foto;
        }

        public void setIndice(int i)
        {
            indice = i;
        }


        //##################################################  MÉTODO GET  ##############################################################

        public string getNomePartido(int i) => eleicoes.listaCandidato[i].nomePartido;

        public string getNascimento(int i) => eleicoes.listaCandidato[i].nascimento;

        public string getNomeAbreviado(int i) => eleicoes.listaCandidato[i].nomeAbreviado;

        public string getNomeCompleto(int i) => eleicoes.listaCandidato[i].nomeCompleto;

        public int getNumPartido(int i) => eleicoes.listaCandidato[i].numeroPartido;

        public string getFoto(int i) => eleicoes.listaCandidato[i].foto;

        public int getIndice() => indice;

        public int getTamListaCandidatos() => eleicoes.listaCandidato.Count;



        public void limpaLista()
        {
            eleicoes.listaCandidato = new List<Candidato>();
        }


        public void removeCandidatoLista(int i)
        {
            eleicoes.listaCandidato.RemoveAt(i);
        }



        //####################################################  ELEIÇÕES  ################################################################

        private int CodEleicao;

        public enum pais
        {
            Argentina = 0, Bolívia = 1, Brasil = 2, Chile = 3, Colômbia = 4, Equador = 5, Guiana = 6, Paraguai = 7
            , Peru = 8, Suriname = 9, Uruguai = 10, Venezuela = 11
        };

        public struct Eleicoes
        {
            public string tituloEleicao;
            public int codigoEleicao;
            public DateTime dataCadastro, dataEleicao;
            public pais codigoPais;
            public string codSeguranca;
            public int situacao;
            public List<Candidato> listaCandidato;
            public List<int> votos;
        }

        public List<Eleicoes> listaEleicoes = new List<Eleicoes>();
        
        public Eleicoes eleicoes = new Eleicoes();

        public void setListaCandidato(int i)
        {
            eleicoes.listaCandidato = listaEleicoes[i].listaCandidato;
        }


        //##################################################  MÉTODO SET  ##############################################################

        public void setSituacaoEleicao(int i)
        {
            eleicoes.situacao = i;
        }

        public void setCodigoSeguranca(string codSeguranca)
        {
            eleicoes.codSeguranca = codSeguranca;
        }

        public void setCodEleicao(int cod)
        {
            CodEleicao = cod;
        }

        public void setTituloEleicao(string titulo)
        {
            eleicoes.tituloEleicao = titulo;
        }

        public void setCodigoEleicao(int codigo)
        {
            eleicoes.codigoEleicao = codigo;
        }

        public void setDataEleicao(DateTime data)
        {
            eleicoes.dataEleicao = data;
        }

        public void setDataCadastro(DateTime data)
        {
            eleicoes.dataCadastro = data;
        }

        public void setPais(int pais)
        {
            eleicoes.codigoPais = (pais)pais;
        }

        //##################################################  MÉTODO GET  ##############################################################

        public int getSituacaoEleicao(int i) => listaEleicoes[i].situacao;

        public string getCandidato() => eleicoes.listaCandidato[0].nomeCompleto;

        public string getCodigoSeguranca(int i) => listaEleicoes[i].codSeguranca;

        public string getTituloEleicao(int i) => listaEleicoes[i].tituloEleicao;

        public int getCodigo(int i) => listaEleicoes[i].codigoEleicao;

        public DateTime getDataEleicao(int i) => listaEleicoes[i].dataEleicao;

        public DateTime getDataCadastro() => eleicoes.dataCadastro;

        public pais getPais(int i) => listaEleicoes[i].codigoPais;

        public int getCodEleicao() => CodEleicao;

        public int getTamanhoEleicao() => listaEleicoes.Count;


        public void restauraEleicao(int i)
        {
            eleicoes = listaEleicoes[i];
        }

        public void insereLista()
        {
            listaEleicoes.Add(eleicoes);
        }

        public void insereLista(int n)
        {
            listaEleicoes[n] = eleicoes;
        }

        public void removeLista(int i)
        {
            listaEleicoes.RemoveAt(i);
        }


        public void insereCandidato(int i)
        {
            eleicoes.listaCandidato[i] = candidato;
        }

        public string getCandCombo(int i) => eleicoes.listaCandidato[i].nomeCompleto;

        public void instanciaVotos()
        {
            eleicoes.votos = new List<int>();
        }

        public void registraVotos(int i)
        {
            eleicoes.votos.Add(i);
        }

        public int getVotos() => listaEleicoes[0].votos[0];

    }
}
