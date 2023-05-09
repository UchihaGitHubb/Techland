using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]

public class Options 
{
    [SerializeField] private float cantidadPuntos;
    
    [SerializeField] private Puntaje puntaje;

    public string text = null;
   
    public bool correct = false;
     
    //private void sumarPunticos()
    //{
      //  if (correct == true)
        //{
         //   puntaje.SumarPuntos(cantidadPuntos);
        //}
    }

