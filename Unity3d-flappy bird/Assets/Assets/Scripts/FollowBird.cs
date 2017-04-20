using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBird : MonoBehaviour {
    public GameObject birdGO;
    private Transform birdtransform;
    //private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        birdtransform = birdGO.transform;
        //offset = bird.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager._instance.gameState == GameManager.GameState.play)
        {
            Vector3 birdpos = birdtransform.position;
            transform.position = new Vector3(birdpos.x + 6f, transform.position.y, transform.position.z);
            //this.transform.position = offset + bird.transform.position;
        }
    }
}
