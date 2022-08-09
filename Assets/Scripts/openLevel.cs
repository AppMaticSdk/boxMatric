using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public int openlevel;
    void Start()
    {
        openlevel = SceneManager.GetActiveScene().buildIndex + openlevel;
    }

    public void OpenLevel(){
        SceneManager.LoadScene(openlevel);
    }
    public void startLevel(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
