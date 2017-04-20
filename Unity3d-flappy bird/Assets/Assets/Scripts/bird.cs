using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
    private float framecount = 0;
    private float timer=0;
    public float frametime = 1;
	public float framenumber = 10;
    private Renderer rd;
    private Rigidbody rb;

    private AudioSource audiosource;
    // Use this for initialization
    void Start () {
        rd = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager._instance.gameState == GameManager.GameState.play)
        {
            timer += Time.deltaTime;
            if (timer >= 1.0f / framenumber)
            {
                framecount++;
                float frameIndex = framecount % 3;
                timer -= 1.0f / framenumber;
                this.rd.material.SetTextureOffset("_MainTex", new Vector2(0.333333f * frameIndex, 0));
            }
        }
        if (GameManager._instance.gameState == GameManager.GameState.play)
        {
            if (Input.GetMouseButton(0))
            {
                audiosource.Play();
                Vector3 vel = rb.velocity;
                rb.velocity = new Vector3(vel.x, 5, vel.z);
            }
        }
    }
    public void BirdGetLife()
    {
        rb.velocity = new Vector3(2, 0, 0);
        rb.useGravity = true;
    }
}
