using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicateAnim : MonoBehaviour
{
    // Start is called before the first frame update
    private static int pCount = 1;
    private static int mCount = 1;
    private static int currCount = 0;
    public GameObject obj;
    public Animator anim;
    public AudioSource sound;
    void Start()
    {
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        StartCoroutine(fiveSeconds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

IEnumerator fiveSeconds(){
    while(true){
        if(gameObject.name.Contains("panim")){currCount = pCount;}
        else if (gameObject.name.Contains("manim")){currCount = mCount; }

        if (currCount<8){
            currCount++;
            GameObject clone = (GameObject)Instantiate(obj, new Vector3(Random.Range(-40,40),0,Random.Range(-30,30)), Quaternion.Euler(0,0,0)); //create clone
            clone.GetComponent<AudioSource>().enabled = true;
        }
        transform.position = new Vector3(Random.Range(-45,45),0,Random.Range(-30,30));
        anim.Play("anim01");
        anim.GetComponent<Animator>().Play("anim01", -1, 0);
        sound.Play();

        if(gameObject.name.Contains("panim")){pCount = currCount;}
        else if (gameObject.name.Contains("manim")){mCount = currCount;}

        //if(currCount>1){
        //Invoke("moveReplay",Random.Range(10,35));
        //}

        yield return new WaitForSeconds(Random.Range(20,200));
    }
}
}
