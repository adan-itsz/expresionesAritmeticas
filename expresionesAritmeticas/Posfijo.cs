using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace expresionesAritmeticas
{
    enum prioridad { numero, parentesisIzquierdo, parentesisDerecho, sumaResta, multiplicacionDivision, potencia };
    //los enumeradores asignan un valor numerico a cada miembro comenzando con cero
    class Posfijo
    {
        int tope;
        Regex reg = new Regex("[^0-9]");
        Stack<string> pila = new Stack<string>();
        string notacionPostfija;

        public string postfijo(string infijo)
        {
            tope = 0;
                for (int i = 0; i < infijo.Length; i++)
                {
                    if (infijo[i] == '(')
                    {
                        tope++;
                        pila.Push(Convert.ToString( infijo[i]));
                    }
                    else
                    {
                        if (infijo[i] == ')')
                        {
                            while (Convert.ToChar(pila.Peek()) != '(')// podria ser igual la condicion
                            {
                                tope--;
                                notacionPostfija += pila.Pop();//podria ser pila.pop()
                            }
                            pila.Pop();
                            tope--;
                        }
                        else
                        {
                            if (infijo[i] >= '0' && infijo[i] <= '9')// si es un operando
                            {
                                notacionPostfija += infijo[i];
                            }
                            else { // el char es un operador
                                if (pila.Count == 0)
                                {
                                    tope++;
                                    pila.Push(Convert.ToString(infijo[i]));
                                }
                                else
                                {   // ahora debemos revisar la prioridad de operadores

                                    prioridad simboloActual = prioridadOperador(Convert.ToChar(infijo[i]));
                                    //llamamos metodo que define prioridad de operadores
                                    if (prioridadOperador(Convert.ToChar(pila.Peek())) >= simboloActual)
                                    {
                                        while (pila.Count != 0)
                                        {
                                            tope--;
                                            notacionPostfija += pila.Pop();
                                        }
                                    }
                                    tope++;
                                    pila.Push(Convert.ToString(infijo[i]));
                                }       
                            }// fin else
                        }
                    }
                }
                if (pila.Count != 0)
                {
                    while (pila.Count != 0)
                    {
                        notacionPostfija += pila.Pop();
                    }
                }
                return notacionPostfija;
            }

        

        

        public prioridad prioridadOperador(char operador)
        {
            prioridad operacion;
            switch (operador)
            {
                case '+':
                    operacion = prioridad.sumaResta;
                    break;
                case '-':
                    operacion = prioridad.sumaResta;
                    break;
                case '*':
                    operacion = prioridad.multiplicacionDivision;
                    break;
                case '/':
                    operacion = prioridad.multiplicacionDivision; 
                    break;
                case '(':
                    operacion = prioridad.parentesisIzquierdo;
                    break;
                case ')':
                    operacion = prioridad.parentesisDerecho;
                    break;
                case '^':
                    operacion = prioridad.potencia;
                    break;
                default:
                    operacion = prioridad.numero;
                    break;
            }
            return operacion;
        }
       
    }
}
