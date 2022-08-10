using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    bool c = false;
    void Update(){
        if(c){
            Debug.Log("Hello");
        }
    }
    public void testClick(){
        c = true;
    }
    public void down(){
        c = false;
    }
}
