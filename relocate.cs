using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relocate : MonoBehaviour
{
    private static int dupCount = 10;
    public GameObject obj;

    void Start()
    {
        if (gameObject.name.Contains("shell")){dupCount = 10;}
        else if (gameObject.name.Contains("clover")){dupCount = 55;}
        else if (gameObject.name.Contains("dandelion")){dupCount = 15;}
        else if (gameObject.name.Contains("mushroom")){dupCount = 15;}
        else if (gameObject.name.Contains("acorn")){dupCount = 10;}
        else if (gameObject.name.Contains("strawberry")){dupCount = 10;}
        else if (gameObject.name.Contains("pear")){dupCount = 8;}

        for (int i = 0; i < dupCount; i+=1){
            GameObject clone = (GameObject)Instantiate(obj, new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)), Quaternion.Euler(0,0,0)); //create clone
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision){

        //send info to zoom camera to determine if to create close up
        goTo.zoomCamera  = transform.position; //position for camera to go
        if (goTo.zoomUpdate!=true){
            goTo.zoomUpdate = true;
        }        
        goTo.triggerCount++; //if triggerCount divisible by 5 (only sometimes)

        // duplicate if collided with dup object and there are less than 15 duplicates
        if(collision.tag == "duplicategrow"){ 
            collision.gameObject.GetComponent<Collider>().isTrigger = false; //turn trigger off so object doesn't dup in current position
            transform.position = new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)); //set position of object that was cloned
            collision.transform.position = new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)); //set new position for trigger object
            collision.gameObject.GetComponent<Collider>().isTrigger = true; //turn trigger back on for future
        }
        else if(collision.tag == "dieshrink"){ 
            gameObject.SetActive(false);
            Debug.Log("deactivate");
            Invoke("unhideAndMove", Random.Range(10,180));
        }

    }

    void unhideAndMove(){
        gameObject.SetActive(true);
        Debug.Log("activate");
        transform.position = new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)); //set position of object that was cloned
    }
}
