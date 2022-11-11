using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entities
{
    public interface Empresa
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }
}
