using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_level : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void story(string name, float level)
    {
        switch (name)
        {
            case "story":
                switch (level)
        {
            case 0:
                        gamemanager.talk("begin");
                        break;
            case 1:
                gamemanager.Speak("那麼...測試開始。");
                break;
            case 2:
                gamemanager.Speak("看看這樣的場景O不OK。");
                break;
            case 3:
                gamemanager.Speak("各種有的沒的新功能也都會在這裡測試。");
                break;
            case 4:
                        gamemanager.talk("end");
                        break;
            default:
                break;
        }
                break;
            case "ball":
                switch (level)
                {

                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak("這是顆球。");
                        break;
                    case 2:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "box":
                switch (level)
                {

                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        
                        gamemanager.Speak("這是個箱子。");
                        break;
                    case 2:
                        gamemanager.Speak("這東西怎麼會飄在空中？");
                        break;
                    case 3:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "planecarrot":
                switch (level)
                {

                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak("這是貼了透明貼圖的平面物件。");
                        break;
                    case 2:
                        gamemanager.Speak("比紙還要薄，只有一面看得到，另一面甚至看過來是透明的。");
                        break;
                    case 3:
                        gamemanager.Speak("連影子都沒有，跟鬼一樣，可憐那。");
                        break;
                    case 4:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "boardcarrot":
                switch (level)
                {

                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak("這是紙板物件。");
                        break;
                    case 2:
                        gamemanager.Speak("直接輸入圖片，變成一片有厚度的紙板。");
                        break;
                    case 3:
                        gamemanager.Speak("中間的過程讓插件幫你一鍵搞定。");
                        break;
                    case 4:
                        gamemanager.Speak("你居然使用插件！？相容性出事的話你能負責嗎？");
                        break;
                    case 5:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "boxcarrot":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak("這是箱子物件上貼上圖片的透明貼圖。");
                        break;
                    case 2:
                        gamemanager.Speak("有厚度，兩面，但是側面也會出現被擠扁的圖片。");
                        break;
                    case 3:
                        gamemanager.Speak("你還不能裝正常的collider，他會用一整片箱子collider擋你。");
                        break;
                    case 4:
                        gamemanager.Speak("而且沒有影子，透明貼圖是不是都這樣？");
                        break;
                    case 5:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break; 
                
        }

    }


}