using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDie : MonoBehaviour {
    public AudioSource hitAudio;
    public AudioSource dieAudio;
    void Start()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            GameManager._instance.gameState = GameManager.GameState.over;
            hitAudio.Play();
            dieAudio.Play();
        }
    }
}
