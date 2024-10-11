using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ComprobarCadena
{
    public class Check
    {

        public string Comprobar(string input1, string input2)
        {
            string msg = EsPalindromo(input1) ? "La primer palabra es un palíndromo\n" : "La primer palabra no es un palíndromo.\n";
            msg += EsPalindromo(input2) ? "La segunda palabra es un palíndromo.\n" : "La segunda palabra no es un palíndromo.\n";
            msg += EsAnagrama(input1, input2) ? "Las palabras son anagramas.\n" : "Las palabras no son anagramas.\n";
            msg += EsIsograma(input1) ? "La primer palabra es isograma.\n" : "La primer palabra no es isograma.\n";
            msg += EsIsograma(input2) ? "La segunda palabra es isograma.\n" : "La segunda palabra no es isograma.\n";
            return msg;

        }
        //La palabra es palindromo si se lee igual de izquierda a derecha que de derecha a izquierda
        private bool EsPalindromo(string palabra)
        {
            char[] arreglo = palabra.ToCharArray();
            for (int i = 0; i < arreglo.Length / 2; i++)
            {
                if (arreglo[i] != arreglo[arreglo.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        //Las palabras son anagramas si la primer palabra tiene las mismas letras que la segunda palabra
        private bool EsAnagrama(string palabra1, string palabra2)
        {
          
            List<char> lista1 = new List<char>(palabra1.ToCharArray());
            List<char> lista2 = new List<char>(palabra2.ToCharArray());
            if (lista1.Count != lista2.Count)
            {
                return false;
            }
            else 
            {

                for (int i = 0; i < lista1.Count; i++)
                {
                    if (lista2.Contains(lista1[i]))
                    {
                        lista2.Remove(lista1[i]);
                       
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
           
        }
        //Si las letras de la palabra se repiten el mismo numero de veces, es un isograma
        private bool EsIsograma(string palabra)
        {
            var diccionario = new Dictionary<char, int>();

            foreach (char letra in palabra)
            {
                if (letra == ' ')
                    continue;

                if (diccionario.ContainsKey(letra))
                {
                    diccionario[letra] += 1;
                }
                else
                {
                    diccionario.Add(letra, 1);
                }
            }

            // Si el diccionario está vacío o tiene solo un elemento, es un isograma
            if (diccionario.Count <= 1)
                return true;

            int frecuenciaReferencia = diccionario.Values.First();

            foreach (var frecuencia in diccionario.Values)
            {
                if (frecuencia != frecuenciaReferencia)
                {
                    return false;
                }
            }
            // Si todas las frecuencias son iguales, es un isograma
            return true;
        }

    }
}