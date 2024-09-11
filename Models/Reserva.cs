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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            int qtd  =  Suite.Capacidade; 
            int cadastro = hospedes.Capacity;           

            if (qtd >= cadastro)
            {
                Hospedes = hospedes;                

            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new System.ArgumentException("Capacidade insuficiente!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            int qtd  =  Hospedes.Capacity; 
            return qtd;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria            
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            return valor;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10)
            {

                valor = DiasReservados * (decimal)Suite.ValorDiaria - (0.1m * DiasReservados * (decimal)Suite.ValorDiaria);

            }

            return valor;
        }
    }
}