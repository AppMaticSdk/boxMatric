using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openUi : MonoBehaviour
{
    public GameObject[] arraySkill;
    public GameObject array;
    int count;
    void Awake(){
        count = PlayerPrefs.GetInt("save_level", 0);
    }
    void Start()
    {
        //count = array.transform.childCount;
        arraySkill = new GameObject[count];
        for(int i = 0; i < count; i++){
            arraySkill[i] = array.transform.GetChild(i).gameObject;
            arraySkill[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
