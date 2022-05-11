using GeradorTestes.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTestes.Dominio.ModuloQuestao
{
    [Serializable]
    public class Alternativa 
    {
        public string Descricao { get; set; }

        public bool estaCorreta{ get; set; }

        public Alternativa(string descricao, bool estaCorreta)
        {
            Descricao = descricao;
            this.estaCorreta = false;
        }

        public override string ToString()
        {
            return Descricao;
        }

        public void marcarComoCorreta()
        {
            estaCorreta = true;
        }

        internal void MarcarComoFalsa()
        {
            estaCorreta = false;
        }
    }
}
