using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue; //por valor, so copian el valor son idependientes 
            copiaValor++; //incrementa solo la copiano el origianlvalue 

            var copiaProducto = product; //no crea un objeto nuevo, copia la refenrecia 
            copiaProducto.SetDescription("Producto Modificado"); //modifica el objeto, pero como ambos apuntan al mismo entonces cambia todo 

            return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
        }
    }
}
