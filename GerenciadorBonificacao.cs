using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
   public class GerenciadorBonificacao
    {

        private double _TotalBonificacao; 
        
        public void Registrar(Funcionario funcionario)
        {
           _TotalBonificacao+= funcionario.GetBonificacao();
        
        }

        public void Registrar(Diretor diretor)
        {
          
            _TotalBonificacao +=diretor.GetBonificacao();

        }





        public double GetTotalBonificacao() 
        {
            return _TotalBonificacao;
        
        }

        
    
    
    }
}
