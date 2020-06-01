unsing system;


namespace ImpostoINSS {

    class ImpostoINSS {
        public  decimal GetAliquotaINSS(decimal RendaBruta){
            
            if (RendaBruta <= 1399.12m ){
                return ConstantINSS.INSS008;
            } else if (RendaBruta >= 1399.13m && RendaBruta <= 2331.88m) {
                return ConstantINSS.INSS009;
            } else {
                return ConstantINSS.INSS011;
            }
        
        }

        public decimal CalcualrInss(decimal RendaBruta) {
            return RendaBruta * GetAliquotaINSS(RendaBruta);
        }
    }
}