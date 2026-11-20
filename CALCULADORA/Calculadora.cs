namespace CALCULADORA;

public class Calculadora
{
    public int ContadorOperaciones = 0;
    

    public int Sumar(int n1, int n2)
    {
        return n1 + n2;
        
    }

    public int Restar(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public double Dividir(int n1, int n2)
    {
        if (n2 == 0) return -1;
        return n1 / n2;
    }

    public double Módulo(int n1, int n2)
    {
        if (n2 == 0) return -1;
        return n1 % n2;
    }

}