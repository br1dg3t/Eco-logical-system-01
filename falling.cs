using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    public GameObject obj;
    private static int lilyCount = 1;
    private static int leafCount = 1;
    private static int currCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fiveSeconds());
    }

    // Update is called once per frame
    IEnumerator fiveSeconds()
    {
        while(true){
            if (gameObject.name.Contains("Lily")){currCount = lilyCount;}
            else if (gameObject.name.Contains("Leaf")){currCount = leafCount;}


            if(currCount<10){
                currCount++;
                GameObject clone = Instantiate(obj, new Vector3(Random.Range(-40,40),35,Random.Range(-30,30)),Quaternion.Euler(0,0,0));
                Vector3 newRot = new Vector3(Random.Range(-70,70), Random.Range(-70,70), Random.Range(-70,70));
                clone.transform.rotation = Quaternion.Euler(newRot);
            }

            if (gameObject.name.Contains("Lily")){ lilyCount = currCount; }       
            else if (gameObject.name.Contains("Leaf")){ leafCount = currCount; }      
            
            if(currCount>1){
                Invoke("delete", Random.Range(30,180));
            }

            yield return new WaitForSeconds(Random.Range(10,180));
        }
    }

    void delete(){
        if(gameObject.name.Contains("Lily")){lilyCount--;}
        else if (gameObject.name.Contains("Leaf")){leafCount--;}
        Destroy(gameObject);
    }
}
