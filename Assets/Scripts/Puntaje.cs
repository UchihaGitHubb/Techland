using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Puntaje : MonoBehaviour
{
    
    public float timer = 0;
    public TextMeshProUGUI textMesh;
   

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f){
        timer = 0f;
        }
        textMesh.text = "" + timer.ToString("0");
        
    }


}










