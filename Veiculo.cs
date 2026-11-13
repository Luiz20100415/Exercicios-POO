
using System;

public class Veiculo
{
    private int _velocidade;

    public int Velocidade
    {
        get { return _velocidade; }
        set
        {
            if (value >= 0 && value <= 200)
            {
                _velocidade = value;
            }
        }
    }
}