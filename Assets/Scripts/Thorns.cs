using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorns : MonoBehaviour
{
    [SerializeField] private AudioSource destroyPlayer;
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag.Equals("Player"))
        {
            
            Destroy(col.gameObject);
            destroyPlayer.Play();
        }
    }
}
