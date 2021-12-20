using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatDelete : MonoBehaviour
{
    // Start is called before the first frame update

    //private static int currCount =0;
    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if (collision.tag == "float"){
            gameObject.GetComponent<Collider>().isTrigger = false;
            Invoke("repositionFloating", Random.Range(10,180));
        }
    }

    void repositionFloating(){
        GameObject clone = (GameObject)Instantiate(obj, new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)), Quaternion.Euler(0,0,0)); //create clone
        Destroy(gameObject);        
    }
}
