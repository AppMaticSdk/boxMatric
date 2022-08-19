using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private int nextLevel;
    [SerializeField] private AudioSource next;
    // Start is called before the first frame update
    void Start()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision){
        next.Play();
        if(PlayerPrefs.GetInt("save_level") != null){
            if(PlayerPrefs.GetInt("save_level") < nextLevel){
                PlayerPrefs.SetInt("save_level", nextLevel-1);
                PlayerPrefs.Save();
            }    
        }else{
            PlayerPrefs.SetInt("save_level", nextLevel-1);
            PlayerPrefs.Save();
        }
        StartCoroutine("nextScene");
    }
    IEnumerator nextScene(){
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(nextLevel);
    }
}
