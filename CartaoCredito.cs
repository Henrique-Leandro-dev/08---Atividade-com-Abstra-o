namespace Abstração
{
    public class CartaoCredito : Cartao
    {
        public float limite {get;set;}
        public void AumentarLimite(float acrescimo){
            token = "sifhiasdfhs";
            limite = limite + acrescimo;
        }
        
    }
}