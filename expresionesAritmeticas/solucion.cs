using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expresionesAritmeticas
{
    class solucion
    {
        int valor1;
        int valor2;
        int res;
        int aux;
        Stack<int> pila = new Stack<int>();
        public  double resultadoExpresion(string posfija)
        {
            for (int i = 0; i < posfija.Length; i++)
            {
                if (posfija[i] >= '0' && posfija[i] <= '9')//si es numero lo aplia
                {
                    aux = Convert.ToInt32(posfija[i]-'0');
                    pila.Push(aux);
                }
                else if (posfija[i] == '+' || posfija[i] == '-' || posfija[i] == '*' || posfija[i] == '/' || posfija[i] == '^')
                {
                    valor2 = pila.Pop();
                    valor1 = pila.Pop();
                    switch (posfija[i])// evalua el operador en el que va la iteraccion
                    {
                        case '+':
                            res = valor1 + valor2;
                            break;
                        case '-':
                            res = valor1 - valor2;
                            break;
                        case '*':
                            res = valor1 * valor2;
                            break;
                        case '/':
                            res = valor1 / valor2;
                            break;
                        case '^':
                            res = Convert.ToInt32( Math.Pow(valor1, valor2));
                            break;
                    }
                    pila.Push(res);
                }
            }
            return res;

        }

    }
}
