using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_lerd : MonoBehaviour
{
    public SpriteRenderer s_render;
    public Color[] s_color;
    private int index = 0;
    public float speed;
    private float change = 0f;

    int len;
    // Start is called before the first frame update
    void Start()
    {
        s_render = GetComponent<SpriteRenderer>();
        len = s_color.Length;
    }

    // Update is called once per frame
    void Update()
    {
        s_render.material.color = Color.Lerp(s_render.material.color, s_color[index], speed*Time.deltaTime);
        change = Mathf.Lerp(change, 1f, speed*Time.deltaTime);
        if(change > 0.9f){
            change = 0f;
            index++;
            index = (index >= len)?0:index;
        }
    }
}
