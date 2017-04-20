using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerScore : MonoBehaviour {
    private AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Player")
        {
            GameManager._instance.score++;
            audiosource.Play();
        }
    }
    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 60;
        style.normal.textColor = new Color(255,255,255);
        GUILayout.Label("score:"+ GameManager._instance.score,style);
    }
}
