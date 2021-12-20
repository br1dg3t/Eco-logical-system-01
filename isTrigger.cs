using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Collider>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Collider>().enabled){
            goTo.zoomUpdate = false;
        }
        Invoke("triggerOff", 0.1f);

    }

    void triggerOff(){
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
