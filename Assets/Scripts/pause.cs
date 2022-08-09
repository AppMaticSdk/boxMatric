using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public static bool isPause = false;
    public GameObject gameUi;

    // Update is called once per frame
    void Update()
    {
        
        // if(isPause){
        //     Resume();
        // }else{
        //     Pause();
        // }
    }
    public void Pause(){
        gameUi.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
    public void Resume(){
        gameUi.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }
}
