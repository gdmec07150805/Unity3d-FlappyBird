using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour {
    private AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager._instance.gameState = GameManager.GameState.over;
            audiosource.Play();
        }
    }
}
