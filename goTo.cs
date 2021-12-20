using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goTo : MonoBehaviour
{
    public static Vector3 zoomCamera = new Vector3(0,0,0);
    public static bool zoomUpdate = false;
    public static int triggerCount = 0;
   void Start()
    { 
       // transform.position = new Vector3(-23,0,0);
       gameObject.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (zoomUpdate == true && triggerCount%3 == 0){ //jump move
            gameObject.GetComponent<Camera>().enabled = true;
            var tempZoom = zoomCamera;
            transform.position = new Vector3(tempZoom.x, tempZoom.y+3, tempZoom.z-70);
            Invoke("turnOff", 5.0f);
        }
    }

    void turnOff(){
        gameObject.GetComponent<Camera>().enabled = false;
        zoomUpdate = false;
    }
}
