using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simuprueba1 : MonoBehaviour
{
    //1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
    public int num1;
    public int num2;
    void Start()
    {
        if ( num1 == num2)
        {
            Debug.Log("Son iguales");
        }
        else
        {
            Debug.Log("No son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
