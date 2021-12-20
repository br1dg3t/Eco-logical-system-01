using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (koi.jump){
            gameObject.GetComponent<Camera>().enabled = true;
            transform.position = new Vector3(transform.position.x+Random.Range(-3,3),transform.position.y,transform.position.z);
            Invoke("fishCamOff",5.0f);
        }
    }

    void fishCamOff(){
        gameObject.GetComponent<Camera>().enabled = false;
    }
}
