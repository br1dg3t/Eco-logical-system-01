using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafFall : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
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
            transform.position = new Vector3(transform.position.x + Random.Range(-3,3),transform.position.y + Random.Range(6,10),transform.position.z+ Random.Range(-3,3));
            Vector3 newRot = new Vector3(Random.Range(-70,70), Random.Range(-70,70), Random.Range(-70,70));
            transform.rotation = Quaternion.Euler(newRot);
            rb.angularVelocity = new Vector3(0,0,Random.Range(0,5));
            rb.AddForce(new Vector3(Random.Range(-50,50),0,Random.Range(-50,50)));
            yield return new WaitForSeconds(Random.Range(10,60));
        }
    }
}
