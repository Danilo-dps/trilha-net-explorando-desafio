namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }  
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //IMPLEMENTADO 
            try{
                if (Suite.Capacidade > hospedes.Count)
                    {
                      Hospedes = hospedes;
                    }
                }
                catch(Exception){
                Console.WriteLine("A capacidade da suíte é menor que o número de hóspedes");
                }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //IMPLEMENTADO
            int tamanho = Hospedes.Count;

            return tamanho;
        }

        public decimal CalcularValorDiaria()
        {
            //IMPLEMENTADO
            decimal valor = DiasReservados * Suite.ValorDiaria;

            //IMPLEMENTADO
            if (DiasReservados >= 10)
            {
                valor *= 0.9m;
            }

            return valor;
        }
    }
}