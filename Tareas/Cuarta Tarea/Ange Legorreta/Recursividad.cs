using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Recursividad : MonoBehaviour
{
    [SerializeField] int suma;
    [SerializeField] int factorial;
    [SerializeField] int fibonacci;
    [SerializeField] public int[] numberList;
    [SerializeField] List<float> numbersToSum;
    void Update()
    {
        Debug.Log("La suma dio "+SUMA(suma));
        Debug.Log("El exponencial de 5 es" +Factorial(factorial));
        Debug.Log( "Tu numero da como resultado: "+ Fibonacci(fibonacci));
        Debug.Log("La lista contiene "  + ArrayCount(numberList));
        Debug.Log("La suma de tus numeros es" + SumNumberList(numbersToSum));
    }

    public static int SUMA(int n)
    {
        if (n==1)
        {
            return n;
        }
        else
        {
            return n + SUMA(n - 1);
        }
    }
    
    public static int Factorial(int n)
    {
        if (n==1)
        {
            return n;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    public static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    public static int ArrayCount(int[] n)
    {
        if (n.Length == 0)
        {
            return 0; 
        }
        else
        {
            return 1 + ArrayCount(n[1..]);
        }
    }

    public static float SumNumberList(List<float> elements)
    {
        if (elements.Count == 0)
        {
            return 0;
        }
        else
        {
            return elements[0] + SumNumberList(elements.GetRange(1, elements.Count - 1));
        }
    }
}


