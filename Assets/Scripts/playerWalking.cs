using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalking : MonoBehaviour
{
    private float speed;
    public float jumpSpeed;
    private Rigidbody2D rigidbody;
    private float moveInput;
    private SpriteRenderer sprRend;
    public Animator animator;
    public GameObject walkParticle;
    public bool grounded;
    private float jumpTimeCounter;
    private bool isJumping;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public GameObject dashParticle;
    public TrailRenderer trailRenderer;
    private GameObject cam;
    private Animator camAnim;
    private bool move;
    public int use = 1;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        camAnim = cam.GetComponent<Animator>();
        move = false;
        rigidbody = GetComponent<Rigidbody2D>();

        dashTime = startDashTime;

        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.cyan, 0.0f), new GradientColorKey(Color.white, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
        );
        trailRenderer.colorGradient = gradient;
    }
    public void moveDown(){
            move = true;
        }
    public void moveUp(){
            move = false;
        }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(moveInput*speed, rigidbody.velocity.y);
        // if (moveInput > 0f)
        // {
        //     gameObject.transform.localScale = new Vector2 ( 1, gameObject.transform.localScale.y );
        // }else if (moveInput < 0f){
        //     gameObject.transform.localScale = new Vector2 ( -1, gameObject.transform.localScale.y );
        // }
        // if (moveInput != 0)
        // {
        //     animator.SetBool("walking", true);
        //     if (grounded == true)
        //     {
        //         Instantiate(walkParticle,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f),Quaternion.identity);
        //     }
        // }else{
        //     animator.SetBool("walking", false);
        // }
        
        if(move){
            Instantiate(dashParticle,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Quaternion.identity);
            animator.SetTrigger("dash");
            camAnim.SetTrigger("zoomin");
            direction = 1;
            if(dashTime <= 0){
                direction = 0;
                dashTime = startDashTime;
                rigidbody.velocity = Vector2.zero;
                Gradient gradient = new Gradient();
                gradient.SetKeys(
                    new GradientColorKey[] { new GradientColorKey(Color.cyan, 0.0f), new GradientColorKey(Color.white, 1.0f) },
                    new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
                );
                trailRenderer.colorGradient = gradient;
            }else
            {
                Gradient gradient2 = new Gradient();
                gradient2.SetKeys(
                    new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.yellow, 1.0f) },
                    new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
                );
                trailRenderer.colorGradient = gradient2;
                Instantiate(dashParticle,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Quaternion.identity);
                dashTime -= Time.deltaTime;
                if(gameObject.transform.localScale.x == -1)
                {
                    rigidbody.velocity = Vector2.left * dashSpeed;
                }else if (gameObject.transform.localScale.x == 1)
                {
                    rigidbody.velocity = Vector2.right * dashSpeed;
                }
                
            }
        }
        
    }
    private void jumpButton()
    {
        if(rigidbody.velocity.y == 0)
        {
            for(int i = 0;i <= 50;i++)
            {
                Instantiate(walkParticle,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f),Quaternion.identity);
            }
            animator.SetTrigger("jump");
            rigidbody.velocity = Vector2.up * jumpSpeed;
        }
    }
    public void useSkill(){
        if(use == 1){
            jumpButton();
        }else if(use == 2){
            dash();
        }
    }
    private void dash(){
        move = true;
    }
}