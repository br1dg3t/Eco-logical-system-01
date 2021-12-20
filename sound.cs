using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource magicSound;
    // Start is called before the first frame update
    void Start()
    {
        magicSound = GetComponent<AudioSource>();
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
        magicSound.Play();
       //Debug.Log(gameObject.name + "   sound plays");
    }
}
