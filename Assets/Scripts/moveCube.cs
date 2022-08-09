using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSp;
    public GameObject gameObject;
    public float maxX, minX;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        gameObject.transform.Translate(moveSp*Time.deltaTime,0,0);
        if(gameObject.transform.position.x > maxX){
            //rb.velocity = new Vector2(-moveSp, rb.velocity.y);
            moveSp = -2f;
            
        }
        if(gameObject.transform.position.x < minX){
            //rb.velocity = new Vector2(moveSp, rb.velocity.y);
             moveSp = 2f;
        }
    
        
    }
}
