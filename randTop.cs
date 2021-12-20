using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randTop : MonoBehaviour
{
    // Start is called before the first frame update
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
            transform.position = new Vector3(Random.Range(-40,40),Random.Range(35,60),Random.Range(-30,30));
            //transform.localScale = new Vector3(Random.Range(1,5),Random.Range(1,5),Random.Range(1,5));
            yield return new WaitForSeconds(Random.Range(10,180));
        }
    }
}
