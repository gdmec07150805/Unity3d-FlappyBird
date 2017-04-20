using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour {

	// Use this for initialization
	void Start () {    
       RandomPos();
    }

    public void RandomPos(){
        float pos_y = Random.Range(-0.4f, -0.18f);
        transform.localPosition = new Vector3(transform.localPosition.x, pos_y, transform.localPosition.z);
    }
}
