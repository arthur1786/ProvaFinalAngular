namespace Backend.utils{
    public class Calculo{


        public static double CalcularImc(double altura, double peso){

            var imc = peso / (altura * altura);
            return imc;

        }

        public static string RetornaClassificacao(string classificacao, double imc){
            if(imc < 18.5){
                return "magreza";
            }
            if(imc < 24.9){
                return "normal";
            }
            if(imc < 24.9){
                return "normal";
            }
            if(imc < 29.9){
                return "sobrepeso";
            }
            if(imc < 39.9){
                return "normal";
            }
            else
            return "obesidade grave";
        }
            
        

        
    }
}