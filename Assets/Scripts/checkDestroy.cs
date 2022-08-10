using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDestroy : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Update()
    {
        if(player.transform.position.x <= -15.2f || player.transform.position.x >= 15.2f
        || player.transform.position.y <= -6.2f || player.transform.position.y >= 6.2f){
            Destroy(player);
        }
    }
}
