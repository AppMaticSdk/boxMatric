using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class right : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{
    bool isPressed = false;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(isPressed){
            player.transform.Translate(8f*Time.deltaTime,0,0);
            player.transform.localScale = new Vector2 ( 1, gameObject.transform.localScale.y );
        }
    }
    public void OnPointerDown(PointerEventData data){
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData data){
        isPressed = false;
    }
}
