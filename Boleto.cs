using System;

namespace Abstração
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get;set;}
        public string bancoEmissor {get;set;}
        public string coddeBarras {get;set;}

        public string Registrar(){
            return "Boleto registrado com sucesso!";
        }
        
    }
}