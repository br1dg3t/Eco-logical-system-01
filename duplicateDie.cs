using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicateDie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public static int pearCount = 1;
    public static int cloverCount = 1;
    public static int mushroomCount = 1;
    public static int dandelionCount = 1;
    public static int berryCount = 1;
    public static int acornCount = 1;

    private int currCount = 0;
    void Start()
    {
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

        //set currCount to the count of the object collided with
        if(gameObject.name.Contains("Pear")){currCount = pearCount+10;}
        else if (gameObject.name.Contains("clover")){currCount = cloverCount; }
        else if (gameObject.name.Contains("mushroom")){currCount = mushroomCount;}
        else if (gameObject.name.Contains("dandelion")){currCount = dandelionCount;}
        else if (gameObject.name.Contains("strawberry")){currCount = berryCount+10;}
        else if (gameObject.name.Contains("acorn")){currCount = acornCount+10;}

        // duplicate if collided with dup object and there are less than 15 duplicates
        if(currCount<40 && collision.tag == "duplicategrow"){ 
            currCount++; //increment count
            // Debug.Log(collision.gameObject.name + " duplicated "+ gameObject.name + "      count = "+currCount);
            collision.gameObject.GetComponent<Collider>().isTrigger = false; //turn trigger off so object doesn't dup in current position
            GameObject clone = (GameObject)Instantiate(obj, new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)), Quaternion.Euler(0,0,0)); //create clone
            transform.position = new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)); //set position of object that was cloned
            collision.transform.position = new Vector3(Random.Range(-45,45),0,Random.Range(-30,30)); //set new position for trigger object
            collision.gameObject.GetComponent<Collider>().isTrigger = true; //turn trigger back on for future
            clone.GetComponent<duplicateDie>().enabled = true;
            clone.GetComponent<fullRotation>().enabled = true;
            clone.GetComponent<sound>().enabled = true;
            clone.GetComponent<AudioSource>().enabled = true;
        }
        //destroy
        else if(currCount>1 && collision.tag == "dieshrink"){ 
            currCount--; //decrement curr count
            Debug.Log("DESTROY" + gameObject.name);
            //Debug.Log(collision.gameObject.name + " destroyed "+ gameObject.name + "      count = "+currCount);
            Destroy(gameObject); 
        }

        //reset global count variable to incremented or decremeneted value
        if(gameObject.name.Contains("Pear")){ pearCount = currCount-10; }
        else if (gameObject.name.Contains("clover")){ cloverCount = currCount;}
        else if (gameObject.name.Contains("mushroom")){ mushroomCount = currCount; }
        else if (gameObject.name.Contains("dandelion")){ dandelionCount = currCount; }  
        else if (gameObject.name.Contains("strawberry")){ berryCount = currCount-10; }  
        else if (gameObject.name.Contains("acorn")){ acornCount = currCount-10; } 

        Debug.Log("c:"+cloverCount+", m:"+ mushroomCount+", d:"+ dandelionCount+",s:"+berryCount+", a:"+acornCount);

    }
}
