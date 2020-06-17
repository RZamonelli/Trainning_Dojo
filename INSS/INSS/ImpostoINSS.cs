using System;
using INSS;
using INSS.Util;


namespace ImpostoINSS
{

    public abstract class ImpostoINSS
    {
        public abstract decimal CalcularINSS(decimal ValorRendaBruta);
    }

    public class FaixaINSS1: ImpostoINSS
    {
        public override decimal CalcularINSS(decimal ValorRendaBruta)
        {
            return ConstantINSS.INSS008 * ValorRendaBruta;
        }
    }

    public class FaixaINSS2: ImpostoINSS
    {
        public override decimal CalcularINSS(decimal ValorRendaBruta)
        {
            return ConstantINSS.INSS009 * ValorRendaBruta;
        }
    }
    public class FaixaINSS3: ImpostoINSS
    {
        public override decimal CalcularINSS(decimal ValorRendaBruta)
        {
            return ConstantINSS.INSS011 * ValorRendaBruta;
        }
    }
}