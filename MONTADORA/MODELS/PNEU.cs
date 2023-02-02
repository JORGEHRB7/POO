namespace MODELS
{
    public class PNEU
    {
        public class Pneu
        public int Cor { get; set; }
        public int Aro { get; set; }
        public string Tipo { get; set; }
        public bool TWI { get; set; }
        public int  PercentualBorracha { get; set; }
        public bool Estourado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }
        public void Girar(int _Velocidade)
        {

            VelocidadeAtual = VelocidadeAtual + _Velocidade;
        }

        public void Frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;

            if (VelocidadeAtual > VelocidadeMaxima)
            {
                Estourado = true;
                VelocidadeAtual = 0;
            }
        }


    }
}