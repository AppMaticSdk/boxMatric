using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public  AudioClip playJump, playDash, playThorn, playFlash, playGravity, playSkill;
     AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        // playSkill = Resource.Load<AudioClip>("skills");
        //playJump = GetComponent<audio>().Load<AudioClip> ("jump");
        // playDash = Resource.Load<AudioClip> ("dash");
        // playThorn = Resource.Load<AudioClip> ("thorn");
        // playFlash = Resource.Load<AudioClip> ("flash");
        // playGravity = Resource.Load<AudioClip> ("gravity");
        audioSrc = GetComponent<AudioSource>();
    }
    public void PlaySource (string source){
        switch(source){
            case "jump":
                //audioSrc.PlayOneShot(playJump);
                Debug.Log("hello");
                break;
                
            case "dash":
                audioSrc.PlayOneShot(playDash);
                break;
            // case "thorn":
            //     playThorn.Play();
            //     break;
            // case "flash":
            //     playFlash.Play();
            //     break;
            // case "gravity":
            //     playGravity.Play();
            //     break;
        }
    }

    public void loggg (){
        Debug.Log("hello");
    }
}
