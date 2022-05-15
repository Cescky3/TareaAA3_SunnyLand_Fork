using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    AudioSource jumpSource;
    AudioSource footstepSource;
    AudioSource crouchSource;
    AudioSource cherrySource;

    public AudioClip Jump1;
    public AudioClip Jump2;
    public AudioClip Land1;
    public AudioClip Land2;
    public AudioClip Crouch;
    public AudioClip Run;

    // keep track of the jumping state ... 
    bool isJumping = false;
    // make sure to keep track of the movement as well !
    bool isMoving = false;
    Rigidbody2D rb; // note the "2D" prefix 
    
    // Start is called before the first frame update
    void Start()
    {
	rb = GetComponent<Rigidbody2D>();
	// get the references to your audio sources here !                 !!!!!!REVISAR ARRAYS SI NO FUNCIONA
    footstepSource = GetComponents<AudioSource>()[0];    
    jumpSource = GetComponents<AudioSource>()[1];
    crouchSource = GetComponents<AudioSource>()[2];                    // CROUCH NECESSITA ARRAY?? GET COMPONENT/S?
    cherrySource = GetComponents<AudioSource>()[3];
    }

    // FixedUpdate is called whenever the physics engine updates
    void FixedUpdate()
    {
    
	// Use the ridgidbody instance to find out if the fox is
	// moving, and play the respective sound !
	// Make sure to trigger the movement sound only when
	// the movement begins ...
    
	// Use a magnitude threshold of 1 to detect whether the
	// fox is moving or not !
	// i.e.
	// if ( ??? > 1 && ???) {
	//    play sound here !
	// } else if ( ??? < 1 &&) {
	//   stop sound here !
	// }	
    }
    
    // trigger your landing sound here !
    public void OnLanding() {
        isJumping = false;
        float randomLand = Random.Range (0,100);
        if (randomLand > 50){
        jumpSource.clip = Land2;
        } else {
        jumpSource.clip = Land1;
        }
	    jumpSource.Play();
        print("the fox has landed");
	// to keep things cleaner, you might want to
	// play this sound only when the fox actually jumoed ...
    }

    // trigger your crouching sound here
    public void OnCrouching() {
        crouchSource.clip = Crouch;
        crouchSource.Play();
        print("the fox is crouching");
    }
 
    // trigger your jumping sound here !
    public void OnJump() {
        isJumping = true;
        float randomJump = Random.Range (0,100);
        if (randomJump > 50){
        jumpSource.clip = Jump2;
        } else {
        jumpSource.clip = Jump1;
        }
	    jumpSource.Play();
        print("the fox has jumped");
    }

    // trigger your cherry collection sound here !
    public void OnCherryCollect() {
        cherrySource.Play();
        print("the fox has collected a cherry");
    }
}
