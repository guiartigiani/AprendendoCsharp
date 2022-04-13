
public class Calculo
{
    int num1, num2;
    char menu;
    public int Somar(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    public int Multiplicar(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    public int Subtrair(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }
    public int Dividir(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }

    public void escolha()
    {
        switch (menu)
        {
            case '1':
                Somar(num1, num2);
                break;
            case '2':
                Subtrair(num1, num2);
                break;
            case '3':
                Dividir(num1, num2);
                break;
            case '4':
                Multiplicar(num1, num2);
                break;
            default:
                System.Environment.Exit(-1);
                break;

        }
    }
}
