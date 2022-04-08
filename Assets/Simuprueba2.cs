using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simuprueba2 : MonoBehaviour
{
    //2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos 
    //   y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible
    //   .Luego indicar cuánto dinero sobra o falta.
    public float num;
         public float num1;
          public float num2;
          float total;
    public float totaldisponible;
    void Start()
    {
        total = num1 + num + num2;
        if (total > totaldisponible)
        {
            Debug.Log("Te sobran " + (total - totaldisponible) + "$");
        }
       else if (totaldisponible > total)
        {
            Debug.Log("Te faltan " + (totaldisponible - total) + "$");
        }
        else if (totaldisponible == total)
        {
            Debug.Log("Estas justo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
