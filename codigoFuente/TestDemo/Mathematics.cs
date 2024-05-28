namespace TestDemo;
public static class Mathematics
{

     public static bool CalcularFuerza (double m, double a)
    {
        return m * a  == 4500.0 ? true : false;
    }
    public static bool CalcularTrabajo ( double F, double d)
    {
        return F * d  == 29700.0 ? true : false;
    }
    public static bool CalcularEnergiaCinetica ( double m, double v)
    {   
        double e = 2.5;
        return ((e * m) * (v * v))  == 960.0 ? true : false;
    }


   
}
