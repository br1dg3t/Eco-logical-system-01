using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enDisable : MonoBehaviour
{
     public AudioSource drop;
     public AudioSource rain;
     private ParticleSystem ps;
    ParticleSystem system
    {
        get
        {
            if (_CachedSystem == null)
                _CachedSystem = GetComponent<ParticleSystem>();
            return _CachedSystem;
        }
    }
    private ParticleSystem _CachedSystem;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        StartCoroutine(fiveSeconds());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator fiveSeconds(){
        int previous = 0;
        var shape = ps.shape;
        var emission = ps.emission;
        while(true){
            rain.Stop();
            int decider = Random.Range(0,10);
            //Debug.Log(decider);
                if (decider < 2){ //storm
                    rain.Play(); //if rain before, drop sound on restart
                    transform.position = new Vector3(0,35,0);
                    shape.scale = new Vector3(120,12,1);
                    emission.rateOverTime = 1000;
                    system.Play();
                }
                else if (decider < 5){ //rain
                    if (previous == 1){ drop.Play(); }
                    transform.position = new Vector3(Random.Range(-40,40),35,Random.Range(-30,30));
                    shape.scale = new Vector3(12,12,1);
                    emission.rateOverTime = 125;
                    system.Play();
                }
                else{ //no rain, decider > 5
                    if (previous == 1){ drop.Play(); } //if rain before, drop sound on stop
                    system.Stop();
                }
                previous = decider;
            // rain plays for 5-30 seconds
            yield return new WaitForSeconds(Random.Range(5,30));
        }
    }
}
