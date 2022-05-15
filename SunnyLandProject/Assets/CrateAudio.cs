using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAudio : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource boxSource;

    public AudioClip boxHit;
    public AudioClip boxMove;
    
    void Start()
    {
        boxSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        boxSource.clip = boxHit;
        boxSource.Play();
        Debug.Log ("box kaboom into something");
    }
}
