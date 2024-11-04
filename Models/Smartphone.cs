namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo { get; set; }  //Adicionei as 3 propriedades que faltavam
        private string IMEI { get; set; }  
        private int Memoria { get; set; }  

        public Smartphone(string numero, string modelo, string imei,int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades

            Modelo = modelo;  //Criados os 3 parâmetros de construção restantes
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}