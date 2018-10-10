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


        public enum pais {Argentina = 0, Bolívia = 1, Brasil = 2, Chile = 3, Colômbia = 4, Equador = 5, Guiana = 6, Paraguai = 7
        ,Peru = 8, Suriname = 9, Uruguai = 10, Venezuela = 11};

        public struct Candidato
        {
            public string nomeCompleto, nomeAbreviado, nomePartido, nascimento, foto;
            public int numeroPartido, codigoEleicao;
        }

        public struct Eleicoes
        {
            public string tituloEleicao;
            public int codigoEleicao;
            public DateTime dataCadastro, dataEleicao;
            public pais codigoPais;
            public string codSeguranca;
            public int situacao;
            public List<Candidato> listaCandidato;
        }

        public List<Eleicoes> listaEleicoes = new List<Eleicoes>();
        

        public Candidato candidato = new Candidato();
        public Eleicoes eleicoes = new Eleicoes();

        public void insereCandidato()
        {
            eleicoes.listaCandidato.Add(candidato);
        }

        public void setSituacaoEleicao(int i)
        {
            eleicoes.situacao = i;
        }

        public int getSituacaoEleicao(int i) => listaEleicoes[i].situacao;

        public void insereCandidato(int i)
        {
            eleicoes.listaCandidato[i] = candidato;
        }


        public string getCandidato() => eleicoes.listaCandidato[0].nomeCompleto;

        public string getCodigoSeguranca(int i) => listaEleicoes[i].codSeguranca;

        public void  setCodigoSeguranca(string codSeguranca)
        {
            eleicoes.codSeguranca = codSeguranca;
        }

        private int CodEleicao;

        public string getTituloEleicao(int i) => listaEleicoes[i].tituloEleicao;

        public int getCodigo(int i) => listaEleicoes[i].codigoEleicao;

        public DateTime getDataEleicao(int i) => listaEleicoes[i].dataEleicao;

        public DateTime getDataCadastro() => eleicoes.dataCadastro;
        
        public pais getPais(int i) => listaEleicoes[i].codigoPais;

        public int getCodEleicao() => CodEleicao;

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

        public void setListaCandidato(int i)
        {
            eleicoes.listaCandidato = listaEleicoes[i].listaCandidato;
        }

        public void insereLista()
        {
            listaEleicoes.Add(eleicoes);
        }

        public int Tamanhoeleicao() => listaEleicoes.Count;

        public void insereLista(int n)
        {
            listaEleicoes[n] = eleicoes;
        }

        public void removeLista(int i)
        {
            listaEleicoes.RemoveAt(i);
        }
        
        private int indice;

        public int TamanhoCandidatos(int cod) => listaEleicoes[cod].listaCandidato.Count;

        //-DEFINE O VALOR PARA O NOME COMPLETO ATRAVÉS DE DADO RECEBIDO VIA PARAMETRO
        public void setNomeCompleto(string nome)
        {
            candidato.nomeCompleto = nome;
        }

        //-DEFINE O VALOR PARA O NOME ABREVIADO ATRAVÉS DE DADO RECEBIDO VIA PARAMETRO
        public void setNomeAbreviado(string nome)
        {
            candidato.nomeAbreviado = nome;
        }
        public string getNomeAbreviado(int i) => eleicoes.listaCandidato[i].nomeAbreviado;

        public string getNomeCompleto(int i) => eleicoes.listaCandidato[i].nomeCompleto;

        public void setNascimento(string nome)
        {
            candidato.nascimento = nome;
        }
        public string getNascimento(int i) => eleicoes.listaCandidato[i].nascimento;

        public void setNomePartido(string nome)
        {
            candidato.nomePartido = nome;
        }

        public string getNomePartido(int i) => eleicoes.listaCandidato[i].nomePartido;

        public void setNumPartido(int num)
        {
            candidato.numeroPartido = num;
        }
        public int getNumPartido(int i) => eleicoes.listaCandidato[i].numeroPartido;
        public void setFoto(string foto)
        {
            candidato.foto = foto;
        }

        public string getFoto(int i) => eleicoes.listaCandidato[i].foto;

        public void setIndice(int i)
        {
            indice = i;
        }

        public void setEleicao(int codigo)
        {
            candidato.codigoEleicao = codigo;
        }

        public string getCandCombo(int i) => eleicoes.listaCandidato[i].nomeCompleto;

        //public int getQuantiCandidatos() => listaCandidatos.Count;



        //---MÉTODOS GET DOS ATRIBUTOS DA CLASSE---
        //-RETORNA O TAMANHO DA LISTA (QUANTIDADE DE ELEMENTOS JA CADASTRADOS)

            
        //-RETORNA O NOME COMPLETO DO CADASTRO PRESENTE NA LISTA EM POSIÇÃO ENVIADA COMO PARAMETRO
        public string getNomeCompleto() => listaEleicoes[1].listaCandidato[0].nomeCompleto;
        
    //    public string getNomeCompleto(int i) => listaCandidatos[i].nomeCompleto;
              
        public void limpaLista()
        {
            eleicoes.listaCandidato = new List<Candidato>();
        }


         public int getIndice() => indice;

        public int getTamListaCandidatos() => eleicoes.listaCandidato.Count;
      

        public int getTamanhoEleicao() => listaEleicoes.Count;

       
        public void removeCandidatoLista(int i)
        {
            eleicoes.listaCandidato.RemoveAt(i);
        }

        public void restauraEleicao(int i)
        {
            eleicoes = listaEleicoes[i];
        }
    }


}
