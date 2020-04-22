using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_s : MonoBehaviour
{
    // Start is called before the first frame update
    private Text_s Text ;
    private  test_level levelmanager;
    private converstation_frame talkframe;
    public float level=0;
    public string gamemode = "converstation";
    void Start()
    {
        Text = GameObject.Find("Words").GetComponent<Text_s>();
        levelmanager = GameObject.Find("LevelManager").GetComponent<test_level>();
        talkframe = GameObject.Find("Text_frame").GetComponent<converstation_frame>();
        levelmanager.story(level);

    }

    // Update is called once per frame
    void Update()
    {
        switch (gamemode)
        {
            case "converstation":
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))//偵測空白鍵，若文字未顯示完畢則加速，否則進入下一段
            if (Text.typing)
                Text.type_delay = 0.01F;
            else
                next_level();
                break;
            case "searching":
                if ( Input.GetMouseButtonDown(0)) {
                }
                    break;
            case "list":
                break;
        }
    }
    public void talkbegin() {
        talkframe.enter();
        gamemode = "converstation";
    }
     public void Speak(string word)//將文字傳給對話框
    {
        Text.type_start(word);
    }
    public void next_level()//關卡數值+1傳給關卡總管
    {
        level++;
        levelmanager.story(level);
    }
}
