using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour {
    public Transform firstbg;
    public pipe pipe1,pipe2;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag=="Player")
        {
            GameObject startbg = GameObject.Find("startbg");
            Destroy(startbg);
            Transform threeBg = GameManager._instance.threeBg;
            firstbg.position = new Vector3(threeBg.position.x+10, firstbg.position.y, firstbg.position.z);
            GameManager._instance.threeBg = firstbg;
            pipe1.RandomPos();
            pipe2.RandomPos();
        }
    }
}
