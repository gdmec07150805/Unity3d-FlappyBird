using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Transform threeBg;
    [HideInInspector]public int score = 0;
    public Text setstart;
    public Text setover;
    //单例模式，如果在别的脚本上写上 GameManager._instance.firstBg便能获得firstBg;
    [HideInInspector]public static GameManager _instance;
    [HideInInspector]public enum GameState
    {
        start, play, over
    };
    [HideInInspector]public GameState gameState = GameState.start;
    private GameObject getbird;

    // Use this for initialization
    void Awake() {
        //单例模式的实例化
        _instance = this;
        getbird = GameObject.FindGameObjectWithTag("Player");
        setover.text = "";

    }

    // Update is called once per frame
    void Update() {
        if (gameState == GameState.start)
        {
            setstart.text = "点击开始游戏";
            if (Input.GetMouseButtonDown(0))
            {
                setstart.text = "";
                gameState = GameState.play;
                getbird.SendMessage("BirdGetLife");
            }
        }
        if (gameState == GameState.over)
        {
            setover.text = "GAME OVER!";
            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel(0);
            }
            return;
        }
    }
    
}
