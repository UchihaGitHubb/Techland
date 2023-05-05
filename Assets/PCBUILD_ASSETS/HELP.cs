using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HELP : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject canvas;
    public GameObject este;
    public GameObject butonAtras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Visible()
    {
        if (panel1.activeSelf){
            panel1.SetActive(false);
            panel2.SetActive(true);
        }
        else {
            if (panel2.activeSelf){
                panel2.SetActive(false);
                panel3.SetActive(true);
            }
            else
            {
                if (panel3.activeSelf){
                    panel3.SetActive(false);
                    canvas.SetActive(true);
                    este.SetActive(false);

                }
            }
        }
        
    }
    public void InVisible()
    {
        
        if (panel2.activeSelf)
        {
            butonAtras.SetActive(true);
            panel2.SetActive(false);
            panel1.SetActive(true);
        }
        else
        {
            if (panel3.activeSelf)
            {
                panel2.SetActive(true);
                panel3.SetActive(false);

            }
        }
        

    }
}
