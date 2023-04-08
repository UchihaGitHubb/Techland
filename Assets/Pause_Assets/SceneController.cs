using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject gameObject;
    
    
    public void Volver()
    {
        gameObject.SetActive(false);
    }
    public void IrMenu()
    {
        //SceneManager.LoadScene("Menu");
        Debug.Log("VA AL MENU");
    }
    public void Cerrar()
    {
        //Cerrar
        Debug.Log("CIERRA");
    }

    public void Visible() 
    {
        gameObject.SetActive(true);
    }
}
