using System;

namespace encapsulamentoPOO
{
     class Program
    {
        static void Main(string[] args)
        {

            // tentem chamar atributos que estão como private / protected, não funcionará
            Cartao card = new Cartao();

            Mastercard master = new Mastercard();
            master.titular = "Gabriel";
            master.parcelas = 6;
            master.ComprarComDescontoMastercard(45f);
            
        }
    }
}
