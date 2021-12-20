using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladybugCam : MonoBehaviour
{
   void Start()
    { 
       gameObject.GetComponent<Camera>().enabled = false;
       StartCoroutine(fiveSeconds());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            gameObject.GetComponent<Camera>().enabled = true;
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            gameObject.GetComponent<Camera>().enabled = false;
        }
    }

    IEnumerator fiveSeconds(){
        while(true){
            gameObject.GetComponent<Camera>().enabled = true;
            Invoke("camOff", Random.Range(8,30));
            yield return new WaitForSeconds(Random.Range(100,300));
        }
    }

    void camOff(){
        gameObject.GetComponent<Camera>().enabled = false;   
    }
}