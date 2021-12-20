using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topRotation : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        StartCoroutine(fiveSeconds());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Destroy(gameObject);
        }
    }

    IEnumerator fiveSeconds(){
        while(true){
            transform.position = new Vector3(Random.Range(-40,40),35,Random.Range(-30,30));
            Vector3 newRot = new Vector3(Random.Range(-70,70), Random.Range(-70,70), Random.Range(-70,70));
            transform.rotation = Quaternion.Euler(newRot);
            //transform.localScale = new Vector3(Random.Range(1,5),Random.Range(1,5),Random.Range(1,5));
            yield return new WaitForSeconds(Random.Range(10,180));
        }
    }
}
