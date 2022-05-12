using GeradorTestes.Dominio.Compartilhado;
using GeradorTestes.Dominio.ModuloDisciplina;
using GeradorTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTestes.Dominio.ModuloTeste
{
    [Serializable]
    public class Teste : EntidadeBase<Teste>
    {
        public Disciplina Disciplina { get; set; }
        public string Serie;
        public List<Questao> questoes = new List<Questao>();
        public int qtdQuestoes;

        public Teste()
        {

        }

        public override void atualizar(Teste teste)
        {
            this.Disciplina = teste.Disciplina;
            this.Serie = teste.Serie;
            this.questoes = teste.questoes;
            this.qtdQuestoes = teste.qtdQuestoes;
            
        }

        public override string ToString()
        {
            return $"Número: {Numero} - Disciplina: {Disciplina.Nome} - Série: {Serie} - Questões: {qtdQuestoes} ";
        }
    }
}
