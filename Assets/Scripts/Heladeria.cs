using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gusto;
    public int peso;
    float precio;
    // Start is called before the first frame update
    void Start()
    {
        if (peso < 250 || peso > 3000)
        {
            Debug.Log("Has ingresado un peso inváildo, ingresa un peso entre 250g y 3000g");
            return;
        }
        if (gusto == "FRU")
        {
            precio = peso * 0.45f;
            Debug.Log("El precio es $" + precio);
        }
       
        if (gusto == "CHO" || gusto == "DDL")
        { 
            precio = peso * 0.5f;
            Debug.Log("El precio es $" + precio);
        }
        else
        {
            Debug.Log("Has ingresado un gusto inváildo, ingresa CHO, FRU o DDL");
            return;
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
