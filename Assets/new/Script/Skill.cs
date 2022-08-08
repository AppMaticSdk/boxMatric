using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{   [SerializeField]
     public GameObject[] arraySkill;
     public GameObject array;
    public GameObject player;
     int count = 0;
     int check = 0;
     public float jumpSpeed = 15f;
    [SerializeField] private Rigidbody2D rb;
    private Move move;
    public float flashSP = 10f;
    private bool dash;
    private float dashTime;
    public float stdashTime;
    private void Awake()
    {
        move = GetComponent<Move>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dash = false;
        dashTime = stdashTime;
        count = array.transform.childCount;
        arraySkill = new GameObject[count];
        for(int i = 0; i < count; i++){
            arraySkill[i] = array.transform.GetChild(i).gameObject;
        }
    }

    void Update(){
        if(dash){
            if(dashTime <= 0){
                dash = false;
                dashTime = stdashTime;
                rb.velocity = Vector2.zero;
            }else{
            dashTime -= Time.deltaTime;
            if(move.check() == 1){
                    rb.velocity = Vector2.right * 50f; 
            }else{
                     rb.velocity = Vector2.left * 50f; 
            }
            }
        }
    }

    public void useSkill(){
        if(check < count){
        if(arraySkill[check].gameObject.tag.Equals("up")){
              jumpButton();
              
        }else if(arraySkill[check].gameObject.tag.Equals("flash")){
            if(move.check() == 1){
                    //flash(flashSP);
                    dash = true;
                    
            }else{
                    flash(-flashSP);

        }
        }
        //Destroy(GameObject.FindGameObjectsWithTag("up"));
    }
    }
    public void down(){
            dash = false;
        }
    public void jumpButton()
    {
        if(rb.velocity.y == 0)
        {
            rb.velocity = Vector2.up * jumpSpeed;
            destroySkin();
        }
    }

    public void flash(float number)
    {
        player.transform.position = new Vector2(player.transform.position.x + number,
        player.transform.position.y);
        destroySkin();
    }
    private void destroySkin(){
            Destroy(arraySkill[check].gameObject);
            check+=1;
    }
    }

