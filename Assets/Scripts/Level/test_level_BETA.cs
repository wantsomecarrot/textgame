using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test_level_BETA : MonoBehaviour
{
    
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public List<Sprite> DATAimage;
    public List<string> imagename;
    public Dictionary<string, Sprite> spriteDATA = new Dictionary<string, Sprite>();
    public Dictionary<string, string> iteminfo = new Dictionary<string, string>();
    public characterform Akun;
    public List<Sprite> Akunimage;
    public List<string> Akunimagename;
    public List<GameObject> cameralist;
    public List<GameObject> zoomlist;
    public void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        Akun = new characterform("akun");
        StartCoroutine(Getimage(imagename, DATAimage,spriteDATA));
        gamemanager.spriteDATA = spriteDATA;
        iteminfo.Add("match","賣女孩的小火柴");
        iteminfo.Add("matchbox", "沒有火柴的火柴盒？");
        iteminfo.Add("burnmatch", "燒毀！");
        iteminfo.Add("key", "開啟命運之門的石之鑰匙");
        StartCoroutine(Getimage(Akunimagename, Akunimage, Akun.CG));
    }
    IEnumerator Getimage(List<string>name,List<Sprite>image,Dictionary<string, Sprite>dictionary)
    {
        for (int i = 0; i < name.Count; i++)
        {
            dictionary.Add(name[i], image[i]);
        }
        name.Clear();
        image.Clear();
        yield return null;
    }
    // Update is called once per frame
    void Update()
    {
    }
    public int skipvalue(string name)
    {
        int value = 0;
        switch (name)
        {
            case "story":
                value = 69;
                break;
            default:
                value = 0;
                break;
        }
        return value;
    }
    public void story(string name, float level)
    {
        switch (name)
        {
            case "story":
                switch (level)
                {
                    case 0:
                        gamemanager.black.state = "on";
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("血液在大雨滂沱中漫開。", " ", " ", " "));

                        break;
                    case 2:
                        gamemanager.Speak(new talkform("我緊緊的握住了那雙逐漸冰冷的手。", " ", " ", " "));

                        break;
                    case 3:
                        gamemanager.Speak(new talkform("視線是模糊的，分不清是雨水還是淚。", " ", " ", " "));
                        break;
                    case 4:
                        gamemanager.Speak(new talkform("我做了一個夢，很長，很久。", " ", " ", " "));
                        break;
                    case 5:
                        gamemanager.Speak(new talkform("我感覺到有人在呼喊我的名字，很遙遠、很遙遠。", " ", " ", " "));
                        break;
                    case 6:
                        gamemanager.Speak(new talkform("在辨認出那是誰的聲音之前，我感受到了一陣疼痛。", " ", " ", " "));
                        break;
                    case 7:
                        gamemanager.effect("blackfadeout");
                        break;
                    case 8:
                        gamemanager.Speak(new talkform("好痛……", "我", " ", " "));
                        break;
                    case 9:
                        gamemanager.Speak(new talkform("額頭好像被什麼結實的東西敲了一下。", " ", " ", " "));
                        break;
                    case 10:
                        gamemanager.Speak(new talkform("我摸索了一下周遭，是一本書。", " ", " ", " "));
                        break;
                    case 11:
                        gamemanager.Speak(new talkform("書？", " ", " ", " "));
                        break;
                    case 12:
                        gamemanager.Speak(new talkform("除了書以外，我發現自己躺在床上。", " ", " ", " "));
                        break;
                    case 13:
                        gamemanager.Speak(new talkform("陌生的觸感，這不是我的床。", " ", " ", " "));
                        break;
                    case 14:
                        gamemanager.Speak(new talkform("非常……", "？？？", " ", " "));
                        gamemanager.CGcontrol("enter", "popout");
                        break;
                    case 15:
                        gamemanager.Speak(new talkform("……？", "我", " ", " "));
                        break;
                    case 16:
                        gamemanager.Speak(new talkform("非常對不起！！！", "？？？", " ", " "));
                        break;
                    case 17:
                        gamemanager.Speak(new talkform("欸？為什麼要突然道歉。", " ", " ", " "));
                        break;
                    case 18:
                        gamemanager.Speak(new talkform("床的一側站著一個少女。", " ", " ", " "));
                        break;
                    case 19:
                        gamemanager.Speak(new talkform("是不認識的面孔，她是誰？", " ", " ", " "));
                        break;
                    case 20:
                        gamemanager.Speak(new talkform("你還好嗎！？有沒有哪裡受傷！？", "？？？", " ", " "));
                        break;
                    case 21:
                        gamemanager.Speak(new talkform("腦袋裡一團混亂，但面前的少女看起來比我更慌亂。", " ", " ", " "));
                        break;
                    case 22:
                        gamemanager.Speak(new talkform("現在顯然不是慌亂的時候。一件事一件事慢慢來，要有條理的整理情況。", " ", " ", " "));
                        break;
                    case 23:
                        gamemanager.Speak(new talkform("嗯，先冷靜下來，深呼吸。", " ", " ", " "));
                        break;
                    case 24:
                        gamemanager.Speak(new talkform("砸在臉上的書已經被我拿到手上。", " ", " ", " "));
                        break;
                    case 25:
                        gamemanager.Speak(new talkform("看來是她不小心將書砸到我的臉上了。", " ", " ", " "));
                        break;
                    case 26:
                        gamemanager.Speak(new talkform("莫名其妙就這樣被打醒，我其實有點煩躁。", " ", " ", " "));
                        break;
                    case 27:
                        gamemanager.Speak(new talkform("起床氣指的應該就是這種感覺。", " ", " ", " "));
                        break;
                    case 28:
                        gamemanager.Speak(new talkform("不過看她慌張的樣子……脾氣還是先緩一緩。", " ", " ", " "));
                        break;
                    case 29:
                        gamemanager.Speak(new talkform("沒事，沒有大礙。", "我", " ", " "));
                        break;
                    case 30:
                        gamemanager.Speak(new talkform("比起那個，讓我在意的事情還有很多。", " ", " ", " "));
                        break;
                    case 31:
                        gamemanager.Speak(new talkform("那就好了……要是害你受傷，大概又要被酒保先生說笑了。", "？？？", " ", " "));
                        break;
                    case 32:
                        gamemanager.Speak(new talkform("酒保先生？", "我", " ", " "));
                        break;
                    case 33:
                        gamemanager.Speak(new talkform("那是誰？這裡的其他人嗎？", " ", " ", " "));
                        break;
                    case 34:
                        gamemanager.Speak(new talkform("我稍微環視了一下整個空間。", " ", " ", " "));
                        break;
                    case 35:
                        gamemanager.Speak(new talkform("這裡的擺設我完全沒有印象，我是怎麼睡的，會在這裡醒來？", " ", " ", " "));
                        break;
                    case 36:
                        gamemanager.Speak(new talkform("這裡...是哪裡呢？", "我", " ", " "));
                        break;
                    case 37:
                        gamemanager.Speak(new talkform("這個……我也不知道怎麼解釋……酒保先生在的話就好了……", "？？？", " ", " "));
                        break;
                    case 38:
                        gamemanager.Speak(new talkform("………", "我", " ", " "));
                        break;
                    case 39:
                        gamemanager.Speak(new talkform("………", "？？？", " ", " "));
                        break;
                    case 40:
                        gamemanager.Speak(new talkform("總覺得。", " ", " ", " "));
                        break;
                    case 41:
                        gamemanager.Speak(new talkform("有點可疑啊……", " ", " ", " "));
                        break;
                    case 42:
                        gamemanager.Speak(new talkform("不過就這麼呆坐在這邊也不是辦法。", " ", " ", " "));
                        break;
                    case 43:
                        gamemanager.Speak(new talkform("聽你剛才的意思，去找那個酒保先生，他就有辦法跟我解釋現在的情況嗎？", "我", " ", " "));
                        break;
                    case 44:
                        gamemanager.Speak(new talkform("是、是的……不過……", "？？？", " ", " "));
                        break;
                    case 45:
                        gamemanager.Speak(new talkform("在那之前，我們有個有點棘手的問題……", "？？？", " ", " "));
                        break;
                    case 46:
                        gamemanager.Speak(new talkform("有點棘手的問題？", " ", " ", " "));
                        break;
                    case 47:
                        gamemanager.Speak(new talkform("啊，失禮了，我還沒有自我介紹吧。我叫喵可，可以告訴我你的名字嗎？", "？？？", " ", " "));
                        break;
                    case 48:
                        gamemanager.Speak(new talkform("艾德里安，叫我艾德就好。", "我", " ", " "));
                        break;
                    case 49:
                        gamemanager.Speak(new talkform("關於剛才你提到的，棘手的問題？", "我", " ", " "));
                        break;
                    case 50:
                        gamemanager.Speak(new talkform("嗚嗯……其實，在我進來之後，這間房間被反鎖住了。", "喵可", " ", " "));
                        break;
                    case 51:
                        gamemanager.Speak(new talkform("怎麼一回事？", "我", " ", " "));
                        break;
                    case 52:
                        gamemanager.Speak(new talkform("我也不知道....門就『喀喇！』一聲自己鎖起來了。", "喵可", " ", " "));
                        break;
                    case 53:
                        gamemanager.Speak(new talkform("……這還真是玄妙的狀況。", "我", " ", " "));
                        break;
                    case 54:
                        gamemanager.Speak(new talkform("的確是有點棘手的問題。", " ", " ", " "));
                        break;
                    case 55:
                        gamemanager.Speak(new talkform("跟一個不認識的女孩鎖在一個陌生的房間裡，尷尬到不行。", " ", " ", " "));
                        break;
                    case 56:
                        gamemanager.Speak(new talkform("如果困在這裡的時間一長，我們的食物、精神也有可能出問題...", " ", " ", " "));
                        break;
                    case 57:
                        gamemanager.Speak(new talkform("不過就剛才喵可說的話，聽起來外面應該還有什麼人。", " ", " ", " "));
                        break;
                    case 58:
                        gamemanager.Speak(new talkform("應該不至於在這裡關一輩子吧....", " ", " ", " "));
                        break;
                    case 59:
                        gamemanager.Speak(new talkform("我剛才原本是想在房間裡找找看鑰匙的，結果一不小心就把書本弄到艾德先生的臉上了。", "喵可", " ", " "));
                        break;
                    case 60:
                        gamemanager.Speak(new talkform("那個……真的非常抱歉！", "喵可", " ", " "));
                        break;
                    case 61:
                        gamemanager.Speak(new talkform("沒想到她還這麼在意書的事情。", " ", " ", " "));
                        break;
                    case 62:
                        gamemanager.Speak(new talkform("雖說要我這麼輕易地相信一個陌生人有些難度。", " ", " ", " "));
                        break;
                    case 63:
                        gamemanager.Speak(new talkform("但是喵可給我的感覺...應該是不會刻意傷害我。", " ", " ", " "));
                        break;
                    case 64:
                        gamemanager.Speak(new talkform("……頂多再砸一本書到我臉上的程度。", " ", " ", " "));
                        break;
                    case 65:
                        gamemanager.Speak(new talkform("別在意了，我也沒受傷。", "我", " ", " "));
                        break;
                    case 66:
                        gamemanager.Speak(new talkform("不過即然我醒了，就讓我也來找找看鑰匙吧。", "我", " ", " "));
                        break;
                    case 67:
                        gamemanager.Speak(new talkform("嗯、嗯，沒問題！", "喵可", " ", " "));
                        break;
                    case 68:
                        gamemanager.Speak(new talkform("那麼就開始吧，先把能看能摸的地方都先看過一次。", " ", " ", " "));
                        break;
                    case 69:
                        gamemanager.CGcontrol("exit", "slide");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "bed":
                if (gamemanager.flag.Contains("bed"))
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("一張雙人大床，我們剛檢查過它。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("哈啾！", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("可惡的灰塵。", "", " ", " "));
                            break;
                        case 4:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("一張雙人大床，我剛從上面爬下來。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("話說回來，床底下會有什麼嗎？", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("我鑽進去看看吧！", "喵可", " ", " "));
                            gamemanager.CGcontrol("enter", "popout");
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("等等，我來吧。", "我", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("知道該說是她神經大條還是什麼呢……", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("她可是穿裙子的啊。", " ", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("我掀開床單，趴下身來看了進去。", " ", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("可惜裡面只有灰塵。", " ", " ", " "));
                            break;
                        case 9:
                            gamemanager.Speak(new talkform("有找到什麼嗎？", "喵可", " ", " "));
                            break;
                        case 10:
                            gamemanager.Speak(new talkform("嗯……空空如也呢。", "我", " ", " "));
                            break;
                        case 11:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("bed");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "light":
                if (gamemanager.flag.Contains("light"))
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("房間裡的光源，燈火在裏頭搖曳著。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("裡面有一片銅片，上頭寫著數字。", " ", " ", " "));
                            openzoom(4);
                            break;
                        case 3:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("一盞壁燈，房間的光源似乎全都來自於他。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("唔、好亮。", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("壁燈裡面有什麼東西在一閃一閃的。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("裡面有一片銅片，上頭寫著數字。", " ", " ", " "));
                            openzoom(4);
                            break;
                        case 5:
                            gamemanager.flag.Add("light");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "bookshelf":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("書櫃上頭擺滿了書本，但有些似乎落在了地板上頭。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "vase":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("盛著某種花卉，但花已經枯萎了。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.CGcontrol("enter", "popout");
                        gamemanager.Speak(new talkform("啊…枯掉了，之後再換上新的一束吧。", "喵可", " ", " "));
                        break;
                    case 3:
                        gamemanager.Speak(new talkform("我是覺得沒什麼必要啦....", " ", " ", " "));
                        break;
                    case 4:
                        gamemanager.CGcontrol("exit", "slide");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "fireplace":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("怪了……壁爐裡面還真是乾淨。", "我", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("簡直跟新的一樣", "我", " ", " "));
                        break;
                    case 3:
                        gamemanager.CGcontrol("enter", "popout");
                        gamemanager.Speak(new talkform("這個說來話長呢……", "喵可", " ", " "));
                        break;
                    case 4:
                        gamemanager.Speak(new talkform("有什麼原因嗎？", "我", " ", " "));
                        break;
                    case 5:
                        gamemanager.Speak(new talkform("有很多事情要跟你解釋才行，在那之前得先出去！", "喵可", " ", " "));
                        break;
                    case 6:
                        gamemanager.Speak(new talkform("現在不能解釋嗎？不太對勁。", " ", " ", " "));
                        break;
                    case 7:
                        gamemanager.Speak(new talkform("……我知道了。", "我", " ", " "));
                        break;
                    case 8:
                        gamemanager.Speak(new talkform("總之先出去吧。", " ", " ", " "));
                        break;
                    case 9:
                        gamemanager.CGcontrol("exit", "slide");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "window":
                if (gamemanager.flag.Contains("window"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("窗戶似乎無法看出去，外面只有一片漆黑。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("奇怪？", "我", " ", " "));
                            break;
                        case 2:
                            gamemanager.CGcontrol("enter","popout");
                            gamemanager.Speak(new talkform("怎麼了？", "喵可", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("這裡房間的窗戶是看不到外面的嗎？", "我", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("不……我的房間是看的到外面的呢。", "喵可", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("所以是只有這間房間看不到外面的嗎？", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("window");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "candle":
                if (gamemanager.resentitem=="burnmatch")
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("我用火柴點燃了燭台上的蠟燭。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("『碦咚』一聲，一個東西從燭台的中間掉了出來。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("是一把鑰匙。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("這該不會就是？", "喵可", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("這該不會就是？", "我", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("拿去試試看吧。", " ", " ", " "));
                            gamemanager.CGcontrol("exit", "slide");
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("獲得了鑰匙！", " ", " ", " "));
                            break;
                        case 8:
                            gamemanager.playeritem.Add("key");
                            gamemanager.useitem();
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("一個燭台。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("我稍微摸了一下。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("這個燭台是空心的。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("有意思。", " ", " ", " "));
                            break;
                        case 5:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "toyplane":
                if (gamemanager.flag.Contains("toyplane"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(5);
                            gamemanager.Speak(new talkform("古銅色的飛機模型，非常精緻。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(5);
                            gamemanager.Speak(new talkform("古銅色的飛機模型，非常精緻。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("裡面有根火柴。", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("是用來點燃壁爐的嗎？", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("但壁爐沒有炭呢……", "我", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("連木柴都沒有一根。", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.flag.Add("toyplane");
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "toyplanetrigger":
                {
                    if (gamemanager.flag.Contains("match")==false) {
                        switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            changzoomimage(5,"plane2");
                            gamemanager.Speak(new talkform("得到了火柴！", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.playeritem.Add("match");
                            gamemanager.flag.Add("match"); 
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                    }
                    
                }
                break;
            case "book":
                if (gamemanager.flag.Contains("book"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("我又嘗試翻了一些其他書頁，但是都是空白的，真奇怪。", " ", " ", " "));
                            break;
                        case 2:
                            openzoom(3);
                            gamemanager.Speak(new talkform("這裡的書本都是白的嗎？", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("我撿起幾本書翻看。", " ", " ", " "));
                            break;
                        case 2:
                            openzoom(3);
                            gamemanager.Speak(new talkform("嗯？", "我", " ", " "));
                            break;
                        case 3:
                            changzoomimage(3,"book2");
                            gamemanager.Speak(new talkform("書頁裡夾著一片透明的碎片。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.flag.Add("book");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "carpet":
                if (gamemanager.flag.Contains("carpet"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(1);
                            gamemanager.Speak(new talkform("毛茸茸的地毯，邊角有狼的花紋裝飾。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(1);
                            gamemanager.Speak(new talkform("毛茸茸的地毯，邊角有狼的花紋裝飾。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "carpettrigger":
                switch (level)
                {
                    case 0:
                        changzoomimage(1,"carpet2");
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("藏在地毯底下的地板刻著字。", " ", " ", " "));
                        break;
                    case 2:
                        if (gamemanager.flag.Contains("carpet")==false)
                            gamemanager.flag.Add("carpet");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
                 case "bussinesscase":
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak(new talkform("規矩的黑色公事包，在房裡顯得有些突兀。", " ", " ", " "));
                                openzoom(0);
                                break;
                            case 2:
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        
                        }
                    break;
            case "bussinesscasetrigger":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        changzoomimage(0, "bussinesscase2");
                        //gamemanager.CGcontrol("enter","popout");
                        gamemanager.Speak(new talkform("…紙球？", "喵可", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("我將紙球攤開。", " ", " ", " "));
                        break;
                    case 3:
                        changzoomimage(0, "bussinesscase3");
                        gamemanager.Speak(new talkform("獲得了打開的便條，上面似乎寫著一段文字。", " ", " ", " "));
                        break;
                    case 4:
                        gamemanager.Speak(new talkform("注意時間……？", "喵可", " ", " "));
                        break;
                    case 5:
                        gamemanager.Speak(new talkform("我抬頭看了一眼時鐘，不知道是半夜三點還是下午三點。", " ", " ", " "));
                        break;
                    case 6:
                        gamemanager.Speak(new talkform("總之不是現在。", " ", " ", " "));
                        break;
                    case 7:
                        gamemanager.flag.Add("bussinesscase");
                        //gamemanager.CGcontrol("exit", "slide");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "dressingtable":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("一組造型典雅的梳妝台，上面的鏡子倒映著房間。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("邊邊刻上了貓咪的雕花，真是細緻。", "我", " ", " "));
                        break;
                    case 3:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "bedsidetable":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak(new talkform("造型簡單的床頭櫃，櫃子似乎還打不開。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "clock":
                if (gamemanager.flag.Contains("clockopened"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(2);
                            gamemanager.Speak(new talkform("一個貓咪時鐘，我真的沒想到他居然是貓咪時鐘……", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if (gamemanager.flag.Contains("bussinesscase") && gamemanager.flag.Contains("carpet") && gamemanager.flag.Contains("book") && gamemanager.flag.Contains("light"))
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(2);
                            gamemanager.Speak(new talkform("說到時間的話，就是時鐘了吧。", "我", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("有沒有辦法調整呢？", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("我將椅子搬了過來，踩上去看了看。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("太好了，似乎可以轉看看。", "我", " ", " "));
                            break;
                        case 5:
                            changzoomimage(2,"clock2");
                            gamemanager.Speak(new talkform("我把時鐘的時間調整到與找到的數字一致，時鐘喵了一聲後，一隻貓咪從裡面彈了出來。", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("居然是貓咪？", "我", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("有貓咪的布榖鐘啊……", "喵可", " ", " "));
                            gamemanager.CGcontrol("enter","popout");
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("她看起來很想要的樣子。", " ", " ", " "));
                            break;
                        case 9:
                            gamemanager.Speak(new talkform("以我的品味來說這鐘確實是過於可愛了，她想要的話或許可以讓她帶走。", " ", " ", " "));
                            break;
                        case 10:
                            gamemanager.Speak(new talkform("我觀察了一下沒有回到時鐘裡的貓咪。", " ", " ", " "));
                            gamemanager.CGcontrol("exit", "slide");
                            break;
                        case 11:
                            changzoomimage(2, "clock3");
                            gamemanager.Speak(new talkform("牠的嘴上咬著空的火柴盒。", " ", " ", " "));
                            break;
                        case 12:
                            changzoomimage(2, "clock4");
                            gamemanager.Speak(new talkform("得到了火柴盒！", " ", " ", " "));
                            break;
                        case 13:
                            gamemanager.playeritem.Add("matchbox");
                            gamemanager.flag.Add("clockopened");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if (gamemanager.flag.Contains("clock"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(2);
                            gamemanager.Speak(new talkform("木製樹屋外觀的時鐘，這麼說來應該是個布穀鳥鐘了。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }

                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(2);
                            gamemanager.Speak(new talkform("這種房子的造型應該是布穀鳥鐘吧？", "我", " ", " "));
                            break;
                        case 2:
                            //gamemanager.CGcontrol("enter","popout");
                            gamemanager.Speak(new talkform("我還是第一次看到實體的布穀鳥鐘呢。", "喵可", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("這個地方沒有其他的布穀鳥鐘？", "我", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("沒有的樣子，大廳到是有一座很大的座鐘。", "喵可", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("高到天花板那麼大喔！", "喵可", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("那還真不是普通的大。", " ", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("我很感興趣呢。", "我", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("不過得先出去就是了。", " ", " ", " "));
                            break;
                        case 9:
                            //gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("clock");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "door":
                if (gamemanager.resentitem==("key"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("鑰匙剛剛好的放入了鎖裡。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("門喀嗤一聲，被打開了。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("打開了！", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.Speak(new talkform("真是太好了！你過了第一關！", "謎之聲", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("請多多提供反饋～指著蘿蔔的鼻子叫他把BUG都修好～", "謎之聲", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("接下來是....第二關的測試！", "謎之聲", " ", " "));
                            break;
                        case 7:
                            gamemanager.nextlevel();
                            gamemanager.useitem();
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if (gamemanager.flag.Contains("door"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("上了鎖的門，想要出去只能快點找到鑰匙了。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("轉了轉手把，絲紋不動。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("真的被鎖上了呢……", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.flag.Add("door");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "setthefire":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("我把火柴點了起來。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("小小的火焰在火柴前端燃起。", " ", " ", " "));
                        break;
                    case 3:
                        gamemanager.Speak(new talkform("它的柄完全沒有要燒短的跡象，感覺可以永遠燒下去，真神奇。", " ", " ", " "));
                        break;
                    case 4:
                        gamemanager.playeritem.Add("burnmatch");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "chair":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak(new talkform("異常柔軟的沙發椅。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("坐在上面感覺自己的骨頭也變軟了。", " ", " ", " "));
                        break;
                    case 3:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "bookshelflv2":
                if (gamemanager.flag.Contains("pianolv2unlock"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("翻了面的樂譜牆上掛著好幾把小刀，以及一把鐵製的大提琴。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("這麼多武器.......？你有看過這面牆嗎？", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("沒、沒有！我是第一次看到這個......", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("雖然不是沒有看過，但這麼多的刀具擺在一起還是很嚇人。", " ", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("不過旁邊這把大提琴更令人在意了，既不是古典的木製大提琴，也不是常見的電子大提琴。", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("大提琴的上面好像有什麼？", "喵可", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("看起來是一些機械的機關，我試著能不能把他解開。", " ", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("大提琴發出了齒輪運轉的聲音，音箱的上蓋被打開了。", " ", " ", " "));
                            break;
                        case 9:
                            gamemanager.Speak(new talkform("打開了！", "喵可", " ", " "));
                            break;
                        case 10:
                            gamemanager.Speak(new talkform("獲得了音樂盒！", " ", " ", " "));
                            break;
                        case 11:
                            gamemanager.Speak(new talkform("音樂盒的上面是抱在一起的家族木偶。", " ", " ", " "));
                            break;
                        case 12:
                            gamemanager.Speak(new talkform("我打開了音樂盒，奏響了曲子。", " ", " ", " "));
                            break;
                        case 13:
                            gamemanager.Speak(new talkform("聽起來不像是常見的古典樂曲。", "我", " ", " "));
                            break;
                        case 14:
                            gamemanager.Speak(new talkform(".......這首曲子老師很常彈呢，老師說是她自己做的曲子。", "喵可", " ", " "));
                            break;
                        case 15:
                            gamemanager.Speak(new talkform("是首很溫暖的曲子呢。", "我", " ", " "));
                            break;
                        case 16:
                            gamemanager.Speak(new talkform("明明是第一次聽到的曲子，卻能沒來由地讓我感到一陣鼻酸。", " ", " ", " "));
                            break;
                        case 17:
                            gamemanager.Speak(new talkform("啊。", "我", " ", " "));
                            break;
                        case 18:
                            gamemanager.Speak(new talkform("我打算把音樂盒翻過來端詳，但盒子卻瞬間在我手上解體了。", " ", " ", " "));
                            break;
                        case 19:
                            gamemanager.Speak(new talkform("欸？我弄壞了嗎？", " ", " ", " "));
                            break;
                        case 20:
                            gamemanager.Speak(new talkform("不，可是我什麼都沒碰啊.......", " ", " ", " "));
                            break;
                        case 21:
                            gamemanager.Speak(new talkform("嗚啊！你、你、你！", "喵可", " ", " "));
                            break;
                        case 22:
                            gamemanager.Speak(new talkform("我發誓我什麼都沒做喔。", "我", " ", " "));
                            break;
                        case 23:
                            gamemanager.Speak(new talkform(".....", "喵可", " ", " "));
                            break;
                        case 24:
                            gamemanager.Speak(new talkform("別一臉惋惜地看著我，我的心臟都愧疚起來了。", " ", " ", " "));
                            break;
                        case 25:
                            gamemanager.Speak(new talkform("有什麼東西在音樂盒解體時落到了地上。", " ", " ", " "));
                            break;
                        case 26:
                            gamemanager.Speak(new talkform("相片？", "我", " ", " "));
                            break;
                        case 27:
                            gamemanager.Speak(new talkform("啪答。", " ", " ", " "));
                            break;
                        case 28:
                            gamemanager.Speak(new talkform("在我彎下腰，撿起相片時，肩膀上突然有股濕濕黏黏的感覺。", " ", " ", " "));
                            break;
                        case 29:
                            gamemanager.Speak(new talkform("嗯？", "我", " ", " "));
                            break;
                        case 30:
                            gamemanager.Speak(new talkform("艾德先生！別動！", "喵可", " ", " "));
                            break;
                        case 31:
                            gamemanager.Speak(new talkform("濕濕黏黏的感覺跑到了頭上，我照著喵可說的不動。", " ", " ", " "));
                            break;
                        case 32:
                            gamemanager.Speak(new talkform("不如說那感覺太噁心了，我僵著根本不敢動。", " ", " ", " "));
                            break;
                        case 33:
                            gamemanager.Speak(new talkform("喝啊！！！", "喵可", " ", " "));
                            break;
                        case 34:
                            gamemanager.Speak(new talkform("呼！的一下，什麼東西的重量從我的頭上消失了。地板上隨機傳來啪嗒地一聲響。", " ", " ", " "));
                            break;
                        case 35:
                            gamemanager.Speak(new talkform("相片的觸覺也從指尖溜走了，不過我還僵著，不敢轉頭去確認。", " ", " ", " "));
                            break;
                        case 36:
                            gamemanager.Speak(new talkform("艾德先生，沒事了。", "喵可", " ", " "));
                            break;
                        case 37:
                            gamemanager.Speak(new talkform("我轉身看向聲音傳來的方向。只見喵可拿起了一旁放在刀鞘內的武士刀，呈現了揮棒完了的姿勢。", " ", " ", " "));
                            break;
                        case 38:
                            gamemanager.Speak(new talkform("她剛剛是拿那個從我的頭上揮過去嗎？", " ", " ", " "));
                            break;
                        case 39:
                            gamemanager.Speak(new talkform("咕嚕，我嚥了一口口水。", " ", " ", " "));
                            break;
                        case 40:
                            gamemanager.Speak(new talkform("要是我再高出個3公分，剛才那下大概會讓我腦震盪。", " ", " ", " "));
                            break;
                        case 41:
                            gamemanager.Speak(new talkform("啊！別跑！", "喵可", " ", " "));
                            break;
                        case 42:
                            gamemanager.Speak(new talkform("我這才往地上確認，那坨濕黏的東西跑得飛快，糊著相片鑽往通風口滑去。", " ", " ", " "));
                            break;
                        case 43:
                            gamemanager.Speak(new talkform("不過似乎因為太胖了，那坨「生物」他......", " ", " ", " "));
                            break;
                        case 44:
                            gamemanager.Speak(new talkform("完美地堵塞在通風口，也就是卡住了。", " ", " ", " "));
                            break;
                        case 45:
                            gamemanager.Speak(new talkform("好茨好茨！", "生物", " ", " "));
                            break;
                        case 46:
                            gamemanager.Speak(new talkform("貓咪......嗎？", "我", " ", " "));
                            break;
                        case 47:
                            gamemanager.Speak(new talkform("兩個尖尖的突起像是貓耳朵形狀，身體則是軟軟的一糊。", " ", " ", " "));
                            break;
                        case 48:
                            gamemanager.Speak(new talkform("身體兩側延伸出兩條細細的軀幹，末端則是圓圓的一球。", " ", " ", " "));
                            break;
                        case 49:
                            gamemanager.Speak(new talkform("那是...手？不對，這整坨糊糊的到底是什麼？", " ", " ", " "));
                            break;
                        case 50:
                            gamemanager.Speak(new talkform("等一下！給我把相片吐出來！", "喵可", " ", " "));
                            break;
                        case 51:
                            gamemanager.Speak(new talkform("好茨好ㄘ——好ㄘ…….", "生物", " ", " "));
                            break;
                        case 52:
                            gamemanager.Speak(new talkform("咚。", " ", " ", " "));
                            break;
                        case 53:
                            gamemanager.Speak(new talkform("喵可的劍鞘又一次揮了下去。", " ", " ", " "));
                            break;
                        case 54:
                            gamemanager.Speak(new talkform("異樣的生物身體整個被砸扁了，但是他完全沒有要把嘴裡的相片放開的樣子。", "", " ", " "));
                            break;
                        case 55:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.Speak(new talkform("這....超出常識了，難以理解。", " ", " ", " "));
                            break;
                        case 56:

                            gamemanager.Speak(new talkform("究竟接下來會如何發展呢....敬請期待囉。", "謎之聲", " ", " "));
                            break;
                        case 57:
                            gamemanager.Speak(new talkform("先讓我睡一下....", "謎之聲", " ", " "));
                            break;
                        case 58:
                            gamemanager.Speak(new talkform("感謝你的遊玩，到這裡就是目前為止的全部內容囉。", "謎之聲", " ", " "));
                            break;
                        case 59:

                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if (gamemanager.flag.Contains("bookshelflv2"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("書櫃上放滿了樂譜，寫著簡譜規則的書被我們翻開來放在一旁。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("一個巨大的書櫃，裡頭放滿了較薄的書本。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("全部都是樂譜。", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("畢竟老師很喜歡音樂嘛。", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("被叫做老師又是放滿樂譜。", "喵可", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("音樂老師？", "我", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("沒錯！聽說老師還有其他的工作，但她本人不怎麼願意講。", "喵可", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("所以詳細是什麼我也不太清楚....", "喵可", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("不為人知的工作啊.......", " ", " ", " "));
                            break;
                        case 9:
                            gamemanager.Speak(new talkform("不，還是別想了。", " ", " ", " "));
                            break;
                        case 10:
                            gamemanager.Speak(new talkform("越想越覺得不妙。", " ", " ", " "));
                            break;
                        case 11:
                            gamemanager.Speak(new talkform("我隨意地拿起一本樂譜來翻看。", " ", " ", " "));
                            break;
                        case 12:
                            gamemanager.Speak(new talkform("啊，是數字譜呢！", "喵可", " ", " "));
                            break;
                        case 13:
                            gamemanager.Speak(new talkform("是簡譜。", "我", " ", " "));
                            break;
                        case 14:
                            gamemanager.Speak(new talkform("恕我失禮，但簡譜很沒有感覺.......", "我", " ", " "));
                            break;
                        case 15:
                            gamemanager.Speak(new talkform("感覺整個房間的格調都被這些數字拉低了。", " ", " ", " "));
                            break;
                        case 16:
                            gamemanager.Speak(new talkform("老師也說過類似的話呢，但是我真的看不懂那些黑色的豆子想表達什麼.....", "喵可", " ", " "));
                            break;
                        case 17:
                            gamemanager.Speak(new talkform("黑色的豆子......算了。", "我", " ", " "));
                            break;
                        case 18:
                            gamemanager.Speak(new talkform("的確對太多接觸樂器的人來說，簡譜比較容易吧。", " ", " ", " "));
                            break;
                        case 19:
                            gamemanager.Speak(new talkform("話說回來......會這樣想的我，應該是學過樂理的？", " ", " ", " "));
                            break;
                        case 20:
                            gamemanager.Speak(new talkform("這或許是幫助我找到記憶的一個關鍵。", " ", " ", " "));
                            break;
                        case 21:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("bookshelflv2");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "violinlv2":
                if (gamemanager.flag.Contains("violinlv2"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("曲面的提琴櫃，裡面放了五把小提琴。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("小提琴上有著不明顯的標記。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("曲面的提琴櫃，裡面放了五把小提琴。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("我拿了一把小提琴擺弄了一下。但沒有聲音。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("喔！姿勢一百分！艾德先生很有架式呢。", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("嗯......？沒有聲音？", "我", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("我應該沒有拉錯才對。", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("等等，這股自信是從哪裡冒出來的？", " ", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("不可能，老師平常都拉得出聲音喔！", "喵可", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("喵可接過小提琴試著拉了一下，還是沒有聲音。", " ", " ", " "));
                            break;
                        case 9:
                            gamemanager.Speak(new talkform("看起來不是我們兩個的問題。", "我", " ", " "));
                            break;
                        case 10:
                            gamemanager.Speak(new talkform("嗯！不過這裡有個數字標記呢。", "喵可", " ", " "));
                            break;
                        case 11:
                            gamemanager.Speak(new talkform("喵可手上的提琴尾部標上了一個數字。", " ", " ", " "));
                            break;
                        case 12:
                            gamemanager.Speak(new talkform("我翻了翻櫃子上的其他提琴，尾部同樣有著標記，但幾乎都快看不清楚了。", " ", " ", " "));
                            break;
                        case 13:
                            gamemanager.Speak(new talkform("真虧你能注意到......看起來並沒有照著順序排。", "我", " ", " "));
                            break;
                        case 14:
                            gamemanager.Speak(new talkform("....有一股想照順序擺好的衝動。", " ", " ", " "));
                            break;
                        case 15:
                            gamemanager.Speak(new talkform("不過要是反而是弄亂好像就有點不好意思了。", " ", " ", " "));
                            break;
                        case 16:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("violinlv2");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                    break;
            case "bedlv2":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("有著絨毛被的床鋪，非常柔軟的樣子。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("如果這是我的床，我會很想躺在上面。", " ", " ", " "));
                        break;
                    case 3:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "pianolv2":
                if (gamemanager.flag.Contains("pianolv2unlock"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("琴鍵上有著隨意標示的符號。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("高音譜記號、音符還有低音譜記號？", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("琴鍵上面為什麼會畫上符號呢？", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("說起來這些符號很常在這個房間的一些地方看到呢，老師的床頭櫃也是這些圖案，意外的很可愛呢。", "喵可", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("該說臻不愧是音樂老師嗎？連家具都是充滿音樂的元素啊。", "我", " ", " "));
                            break;
                        case 6:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if(gamemanager.flag.Contains("violinlv2")&& gamemanager.flag.Contains("pianolv2"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("按照提琴上的音階彈奏後，鋼琴發出了輕脆的旋律後，房間傳來了巨大的撞擊聲。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("艾德先生快看！牆壁翻過來了。", "喵可", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("原先書櫃的位置換成了一面黑色的牆。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("pianolv2unlock");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("傳統的三腳鋼琴，保養得非常好。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("雖然我不會彈，但只要聽到老師演奏鋼琴，心情就會非常好呢。", "喵可", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("........", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("喵可看起來心情不太好的樣子。", " ", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("也是，畢竟老師受到了襲擊。", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("得趕快找找看有沒有什麼線索才行。", " ", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("我繞著鋼琴看了一圈，發現了琴鍵上隨意標記著ㄧ些符號。", " ", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("這些符號似乎有什麼用的樣子，先記起來吧。", "我", " ", " "));
                            break;
                        case 9:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("pianolv2");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "bedsidetablelv2":
                if (gamemanager.flag.Contains("bedsidetablelv2"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("精細的床頭櫃，每一層抽屜都有著漂亮的花紋。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("好想打開來看看。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("....", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("感受到了來自喵可的灼熱視線。", " ", " ", " "));
                            break;
                        case 5:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("可愛的四層櫃子，但放在這間房間裡並不突兀。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("雖然不該翻開來看，但一想到裡面會不會有線索就好好奇啊......", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("艾德先生，我覺得不要亂翻比較好喔。", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("我想也是。", " ", " ", " "));
                            break;
                        case 5:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("bedsidetablelv2");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
                /*
                case "curtain":
                    if (gamemanager.flag.Contains("curtain"))
                    {
                        switch (level)
                        {

                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak("造型典雅的窗簾。");
                                break;
                            case 2:
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (level)
                        {

                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak("造型典雅的窗簾，拉繩上好像綁著一張紙。");
                                break;
                            case 2:
                                gamemanager.Speak("我把紙片抽出來，上面寫著些什麼。");
                                break;
                            case 3:
                                gamemanager.Speak("_ _ ：5 _");
                                break;
                            case 4:
                                gamemanager.flag.Add("curtain");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
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
               */





        }
    }
    public string combine(string a, string b)
    {
        if (a == "match" && b == "matchbox" || b == "match" && a == "matchbox")
            return "setthefire";
        else
            return "fail";
    }
    public void clickbag(string type)
    {
        switch (type)
        {
            case "bussinesscase":
                break;
        }
    }
    public void quite(GameObject zoom)
    {
        zoom.SetActive(false);
    }
    public void openzoom(int num) {
        zoomlist[num].SetActive(true);
    }
    public void changzoomimage(int zoomnum,string image)
    {
        zoomlist[zoomnum].GetComponent<zoomin_basic>().changeimage(spriteDATA[image]);
    }
}