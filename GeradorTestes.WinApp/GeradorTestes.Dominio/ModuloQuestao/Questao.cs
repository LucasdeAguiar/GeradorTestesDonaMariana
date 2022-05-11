using GeradorTestes.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTestes.Dominio.ModuloQuestao
{
    [Serializable]
    public class Questao : EntidadeBase<Questao>
    {
        public List<Alternativa> alternativas = new List<Alternativa>();

        public Questao(string descricao, int bimestre)
        {
            Descricao = descricao;
            Bimestre = bimestre;
        }

        public string Descricao { get; set; }
        public int Bimestre { get; set; }


        public void assinalarCorrreta(Alternativa alternativaCorreta)
        {
            foreach (Alternativa alternativa in alternativas)
            {
                if (alternativa.Descricao == alternativaCorreta.Descricao)
                {
                    alternativa.marcarComoCorreta();
                }
            }
        }

        public override void atualizar(Questao registro)
        {
            throw new NotImplementedException();
        }
    }
}
