using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koi : MonoBehaviour
{
    public Animator anim;
    public AudioSource splash;
    public static bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        splash = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jump == true){
            //Debug.Log("FISH JUMP");
            Invoke("delay",1f);
            jump = false;
        }
    }

    void delay(){
        anim.Play("anim01");
        anim.GetComponent<Animator>().Play("anim01", -1, 0);
        splash.Play();
    }
}
