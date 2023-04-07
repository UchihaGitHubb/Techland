using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items1 : MonoBehaviour
{
    [SerializeField]
    private Transform item1;
    private Vector2 initialPosition1;
    private float deltaX, deltaY;
    public static bool locked;
    // Use this for initializationl

    void Start() 
    {
        initialPosition1 = transform.position; 
    }
    private void Update() {
        if (Input.touchCount > 0 && !locked) {
            Touch touch =  Input.GetTouch(0);
            Vector2 touchPos =  Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase) {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)){
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;
                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)){
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY); 
                    }
                    break;

                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - item1.position.x)<= 0.5f && Mathf.Abs(transform.position.y - item1.position.y)<= 0.5f){
                        transform.position = new Vector2(item1.position.x, item1.position.y);
                        locked = true;
                    }
                    else {
                        transform.position = new Vector2(initialPosition1.x, initialPosition1.y); 
                    }
                    break;

            }
        } 
    }
}
