using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDone : MonoBehaviour
{
    public GameObject gameObject;
    private float moveSpx = 3f, moveSpy = 0f;
 
    void Update()
    {
       
        if(gameObject.transform.position.x >= 10f && gameObject.transform.position.y >= 6f){
            
            moveSpx = 0f;
            moveSpy = -3f;
        }else if(gameObject.transform.position.x >= 10f && gameObject.transform.position.y <= -6f){
            moveSpx = -3f;
            moveSpy = 0f;
        }else if(gameObject.transform.position.x <= -10f && gameObject.transform.position.y <= -6f){
            moveSpx = 0f;
            moveSpy = 3f;
        }
        else if(gameObject.transform.position.x <= -10f && gameObject.transform.position.y >= 6f){
            moveSpx = 3f;
            moveSpy = 0f;
        }
        else if( -10f <= gameObject.transform.position.x && gameObject.transform.position.x <= 10f && gameObject.transform.position.y >= 6f){
            moveSpx = 3f;
            moveSpy = 0f;
        }
        else if( -10f <= gameObject.transform.position.x && gameObject.transform.position.x <= 10f && gameObject.transform.position.y <= -6f){
            moveSpx = -3f;
            moveSpy = 0f;
        }
        
         gameObject.transform.Translate(moveSpx*Time.deltaTime,moveSpy*Time.deltaTime,0);
        
    }
}
