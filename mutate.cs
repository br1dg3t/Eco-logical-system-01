using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutate : MonoBehaviour
{
    public Animator anim;
    public static bool reverse = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider collision){
        //Debug.Log(collision.gameObject.name+" and " +gameObject.name+" collide");
        goTo.triggerCount++;
        goTo.zoomCamera  = transform.position;
        if (goTo.zoomUpdate!=true){
            goTo.zoomUpdate = true;
        }
        
        if(collision.tag == "mutate" || collision.tag == "float"){
            Debug.Log("mutate animation");
            anim.Play("anim01");
            anim.GetComponent<Animator>().Play("anim01", -1, 0);
        }
    }
}
