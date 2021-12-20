using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minorRotation : MonoBehaviour
{
   void Start()
    {
        StartCoroutine(fiveSeconds());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator fiveSeconds(){
        while(true){
            transform.position = new Vector3(Random.Range(-40,40),0,Random.Range(-50,50));
            Vector3 newRot = new Vector3(0, Random.Range(-30,30), 0);
            transform.rotation = Quaternion.Euler(newRot);
            yield return new WaitForSeconds(Random.Range(10,180));
        }
    }
}
