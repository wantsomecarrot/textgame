using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_level_BETA : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public  
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
                gamemanager.Speak("？？？：快醒醒！");
                break;
            case 2:
                gamemanager.Speak("瞬間張開的眼睛眨了眨。");
                break;
            case 3:
                gamemanager.Speak("胸前呼吸困難的感覺伴隨著大聲的叫喚一起轟炸身體。");
                break;
                    case 4:
                        gamemanager.Speak("我的眼皮子好不容易適應了光線，這才愣愣地發現一顆金色的腦袋瓜子壓在自己胸上盯著自己看。");
                        break;
                    case 5:
                        gamemanager.Speak("？？？：嗚啊！？");
                        break;
                    case 6:
                        gamemanager.Speak("過於接近的腦袋讓我倒彈了一下，金髮的少女也沒多停留，一個蹦跳就從床上跳了下來。");
                        break;
                    case 7:
                        gamemanager.Speak("我：你是誰？怎麼在我房間裡？");
                        break;
                    case 8:
                        gamemanager.Speak("沒睜眼多久就看到陌生人的我不禁嚇了好大一跳，連睡意都給嚇走了。");
                        break;
                    case 9:
                        gamemanager.Speak("奇怪？這裡是哪裡？");
                        break;
                    case 10:
                        gamemanager.Speak("我這才發現自己身處的地方有些陌生。");
                        break;
                    case 11:
                        gamemanager.Speak("房間的擺設很陌生。");
                        break;
                    case 12:
                        gamemanager.Speak("但卻有些東西讓我感到很熟悉。");
                        break;
                    case 13:
                        gamemanager.Speak("我摸索了一陣子房間中的東西，儘管有些眼熟，但所有的物品都彷彿放錯了時空，和房間產生了ㄧ些突兀感。");
                        break;
                    case 14:
                        gamemanager.Speak("？？？：對不起把你叫起來了，但我真的很需要你的幫忙。");
                        break;
                    case 15:
                        gamemanager.Speak("雖然少女沒有回答他的問題，我抹了把臉，決定先聽聽少女的需求。");
                        break;
                    case 16:
                        gamemanager.Speak("我：我明白了，但你能先告訴我，你的名字嗎？還有發生什麼事了。");
                        break;
                    case 17:
                        gamemanager.Speak("？？？：我叫做喵可，是這裡的房客。對了，也能告訴我你的名字嗎？");
                        break;
                    case 18:
                        gamemanager.Speak("少女露出了一個大大的笑容自我介紹著，同時非常自然的詢問了我的名字。");
                        break;
                    case 19:
                        gamemanager.Speak("我：我叫塔艾。");
                        break;
                    case 20:
                        gamemanager.Speak("我跟著對方，介紹自己，但卻意識到腦袋裡有些空白。");
                        break;
                    case 21:
                        gamemanager.Speak("等等，我是……");
                        break;
                    case 22:
                        gamemanager.Speak("我才發現自己不但不知道自己為什麼在這裡，似乎還遺忘了很多事情。");
                        break;
                    case 23:
                        gamemanager.Speak("喵可：塔艾，是個很風雅的名字呢。");
                        break;
                    case 24:
                        gamemanager.Speak("少女順著我的話接了下去。");
                        break;
                    case 25:
                        gamemanager.Speak("很感謝她沒有過問太多。");
                        break;
                    case 26:
                        gamemanager.Speak("喵可：那麼，塔艾知道怎麼從這間房間出去嗎？");
                        break;
                    case 27:
                        gamemanager.Speak("我：出去？");
                        break;
                    case 28:
                        gamemanager.Speak("難道出不去嗎？");
                        break;
                    case 29:
                        gamemanager.Speak("我：你不是開這道門進來這間房間的嗎？");
                        break;
                    case 30:
                        gamemanager.Speak("喵可：不是的，我今天一醒來就在這裡了。本來想在你發現之前趕快離開的，結果門早就被鎖起來了。於是就嘗試找了一下鑰匙，但……");
                        break;
                    case 31:
                        gamemanager.Speak("她垂下了肩膀，看起來非常困擾的樣子。");
                        break;
                    case 32:
                        gamemanager.Speak("如此懸疑的狀況，我皺了皺眉頭。");
                        break;
                    case 33:
                        gamemanager.Speak("我們被關起來了？為什麼？");
                        break;
                    case 34:
                        gamemanager.Speak("但總而言之，得先想點辦法出去才行。");
                        break;
                    case 35:
                        gamemanager.Speak("我：無論如何，先找到能夠把門打開的方法吧。");
                        break;
                    case 36:
                        gamemanager.Speak("我與她分頭開始找起了打開門的方法。");
                        break;
                    case 37:
                        gamemanager.Speak("鑒於她似乎尋找過鑰匙的下落，我決定換個思考，將眼前所見的事物都拿起來一一看過。");
                        break;
                    case 38:
                        gamemanager.Speak("順便……");
                        break;
                    case 39:
                        gamemanager.Speak("我也必須搞清楚房間裡的事物究竟為什麼讓我感到這麼的熟悉。");
                        break;
                    case 40:
                        gamemanager.talk("end");
                        break;
            default:
                break;
        }
                break;
            case "bed":
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
            case "lamp":
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
            case "bookshelf":
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
            case "window":
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
            case "books":
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
            case "plane":
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
            case "chuanglian":
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
            case "mirrordesk":
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