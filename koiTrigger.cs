using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koiTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider collision){
        //Debug.Log(collision.gameObject.name + "  " + gameObject.name+ "   fish TRIGGER");
        koi.jump = true;
    }
}
