using GeradorTestes.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }
        public SerieEnum Serie { get; set; }

        public override void atualizar(Materia registro)
        {
            throw new NotImplementedException();
        }
    }
}
