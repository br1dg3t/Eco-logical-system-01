using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angularVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,Random.Range(0,3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
