namespace Ingresso19
{
    public class Vip : Ingresso
    {
        public bool beVip { get; set; }
        public float ValorVip { get; set; }
        public float DescontoVip = 5.5f;
        public bool SeTornarVip()
        {
            if(beVip == true){
                return true;
            }else{ 
                return false;
            }
        }
        public void IngressoVip(){
            if(beVip == true){
            ValorVip = Valor - DescontoVip;
            System.Console.WriteLine($"O valor do ingresso com o Vip é de: R$ {ValorVip}");
            }else{
                ValorVip = Valor - DescontoVip;
                System.Console.WriteLine("você não é Vip, O valor do ingresso com o Vip é de: R$ "+ ValorVip);
            }
        }
    }
}