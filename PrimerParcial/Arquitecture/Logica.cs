using Domain;
using System;

namespace Arquitecture
{
    
    public class Logica
    {
        ActivoFijo[] activos;
      
        public void agregar(ActivoFijo a)
        {
            if (activos.Length == 0) {
                activos[0] = a;

            }
            else if(activos.Length > 0)
            {
                ActivoFijo[] tmp = new ActivoFijo[activos.Length + 1];
                Array.Copy(activos, tmp, activos.Length);
                tmp[tmp.Length - 1] = a;
                activos = tmp;
            }
            
        }
        public decimal[] recta(int vida, decimal residual, decimal valor )
        {
            decimal porcent = valor - residual / vida;
            decimal ano1 = valor - porcent;
            decimal ano2 = ano1 - porcent;
            decimal amo3 = ano2 - porcent;
          
            
            decimal[] rectas = new decimal[] { ano1, ano2, amo3 };

            return rectas;
        }
        public decimal[] incremental(int vida, decimal residual, decimal valor)
        {
            int suma = 0;
            for (var c = 0; c < vida; c++)
            {
                suma = c + suma;
            }
            decimal ano1 = (1/suma)* (valor-residual);
            decimal ano2 = (2 / suma) * (valor - residual);
            decimal amo3 = (3 / suma) * (valor - residual);


            decimal[] incremento = new decimal[] { ano1, ano2, amo3 };

            return incremento;
        }

    }
    
   
}
