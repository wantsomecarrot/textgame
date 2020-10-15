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
    public Dictionary<string, Sprite> spriteDATA=new Dictionary<string, Sprite>();
    public void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        StartCoroutine(Getimage());
        gamemanager.spriteDATA = spriteDATA;
    }
    IEnumerator Getimage()
    {
        for (int i = 0; i < imagename.Count; i++)
        {
            spriteDATA.Add(imagename[i],DATAimage[i]);
        }
        imagename.Clear();
        DATAimage.Clear();
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
                value = 40;
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
                        gamemanager.Speak("一張雙人大床，我剛從上面爬下來。話說回來，為什麼是雙人床？");
                        break;
                    case 2:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "lamp":
                if (gamemanager.flag.Contains("lamp"))
                {

                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak("房間裡的光源，燈火在裏頭搖曳著。");
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
                            gamemanager.Speak("一盞壁燈，房間的光源似乎全都來自於他。");
                            break;
                        case 2:
                            gamemanager.Speak("我：燈罩上好像寫了些字。");
                            break;
                        case 3:
                            gamemanager.Speak("_ _ ：_ 3");
                            break;
                        case 4:
                            gamemanager.flag.Add("lamp");
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

                        gamemanager.Speak("書櫃上頭擺滿了書本，但有些似乎落在了地板上頭。");
                        break;
                    case 2:
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
                            gamemanager.Speak("窗戶似乎無法看出去，外面只有一片漆黑。");
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
                            gamemanager.Speak("我：奇怪？");
                            break;
                        case 2:
                            gamemanager.Speak("喵可：怎麼了？");
                            break;
                        case 3:
                            gamemanager.Speak("我：這裡房間的窗戶是看不到外面的嗎？");
                            break;
                        case 4:
                            gamemanager.Speak("喵可：不……我的房間是看的到外面的呢。");
                            break;
                        case 5:
                            gamemanager.Speak("所以是只有這間房間看不到外面的嗎？");
                            break;
                        case 6:
                            gamemanager.flag.Add("window");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
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
                            gamemanager.Speak("我又嘗試翻了一些其他書頁，但是都是空白的，真奇怪。");
                            break;
                        case 2:
                            gamemanager.Speak("找到了一根胡蘿蔔～");
                            gamemanager.playeritem.Add("carrot");
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
                            gamemanager.Speak("我撿起幾本書翻看。");
                            break;
                        case 2:
                            gamemanager.Speak("我：嗯？");
                            break;
                        case 3:
                            gamemanager.Speak("上頭好像寫了什麼。");
                            break;
                        case 4:
                            gamemanager.Speak("_ 4 ：_ _");
                            break;
                        case 5:
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
                            gamemanager.Speak("毛茸茸的地毯，邊角有狼的花紋裝飾。");
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
                            gamemanager.Speak("毛茸茸的地毯，邊角有狼的花紋裝飾。");
                            break;
                        case 2:
                            gamemanager.Speak("邊角的地方下面好像有什麼東西？");
                            break;
                        case 3:
                            gamemanager.Speak("藏在地毯底下的地板刻著字。");
                            break;
                        case 4:
                            gamemanager.Speak("1_ ：_ _");
                            break;
                        case 5:
                            gamemanager.flag.Add("carpet");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
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
            case "dressingtable":
                switch (level)
                {

                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak("一組造型典雅的梳妝台，上面的鏡子倒映著房間。");
                        break;
                    case 2:
                        gamemanager.Speak("邊邊刻上了貓咪的雕花，真是細緻。");
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
            case "bedsidetable":
                switch (level)
                {

                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak("造型簡單的床頭櫃，櫃子似乎還打不開。");
                        break;
                    case 2:
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

                        gamemanager.Speak("結實的木頭椅子，上面躺著一顆軟墊。");
                        break;
                    case 2:
                        gamemanager.Speak("坐起來感覺很舒服的樣子。");
                        break;
                    case 3:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "bussinesscase":
                if (gamemanager.resentitem == "carrot") {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:

                            gamemanager.Speak("規矩的黑色公事包，在房裡顯得有些突兀。");
                            break;
                        case 2:

                            gamemanager.Speak("我：");
                            break;
                        case 3:

                            gamemanager.Speak("規矩的黑色公事包，在房裡顯得有些突兀。");
                            break;
                        case 4:

                            gamemanager.Speak("規矩的黑色公事包，在房裡顯得有些突兀。");
                            break;
                        case 5:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                    else {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:

                            gamemanager.Speak("規矩的黑色公事包，在房裡顯得有些突兀。");
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "clock":
                if (gamemanager.flag.Contains("key"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak("一個貓咪時鐘，我真的沒想到他居然是貓咪時鐘……");
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if (gamemanager.flag.Contains("curtain") && gamemanager.flag.Contains("carpet") && gamemanager.flag.Contains("book") && gamemanager.flag.Contains("lamp"))
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak("我：這個四字的密碼，很像一個時間呢");
                            break;
                        case 2:
                            gamemanager.Speak("我：這個布穀鳥鐘有沒有辦法調整呢？");
                            break;
                        case 3:
                            gamemanager.Speak("我將房間一旁的椅子搬了過來，取下軟墊踩上去拿下時鐘。");
                            break;
                        case 4:
                            gamemanager.Speak("我：太好了，似乎可以調看看。");
                            break;
                        case 5:
                            gamemanager.Speak("我把時鐘的時間調整到與找到的數字一致，時鐘叮了一聲後，一隻貓咪從裡面彈了出來");
                            break;
                        case 6:
                            gamemanager.Speak("我：居然是貓咪嗎？");
                            break;
                        case 7:
                            gamemanager.Speak("喵可：雖然跟想像的不一樣，但是好可愛喔~我也想裝一個在房間裡了。");
                            break;
                        case 8:
                            gamemanager.Speak("如果是這麼可愛的東西，的確很適合她。");
                            break;
                        case 9:
                            gamemanager.Speak("我觀察了一下沒有回到時鐘裡的貓咪。");
                            break;
                        case 10:
                            gamemanager.Speak("牠的嘴上叼著一根鑰匙。");
                            break;
                        case 11:
                            gamemanager.Speak("喵可：看起來跟門鎖的裝飾一樣呢，應該就是門的要是沒錯了。馬上試試看吧！");
                            break;
                        case 12:
                            gamemanager.flag.Add("key");
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
                            gamemanager.Speak("木製樹屋外觀的時鐘，這麼說來應該是個布穀鳥鐘了。");
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
                            gamemanager.Speak("我：這種房子的造型應該是布穀鳥鐘吧？");
                            break;
                        case 2:
                            gamemanager.Speak("喵可：我還是第一次看到實體的布穀鳥鐘呢。");
                            break;
                        case 3:
                            gamemanager.Speak("我：那你的房間時鐘是什麼樣子的？");
                            break;
                        case 4:
                            gamemanager.Speak("喵可：我是用懷錶在看時間的，所以房間裡沒有擺時鐘呢。");
                            break;
                        case 5:
                            gamemanager.flag.Add("clock");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "door":
                if (gamemanager.flag.Contains("key"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak("鑰匙剛剛好的放入了鎖裡。");
                            break;
                        case 2:
                            gamemanager.Speak("門喀嗤一聲，被打開了。");
                            break;
                        case 3:
                            gamemanager.Speak("喵可：打開了！");
                            break;
                        case 4:
                            gamemanager.Speak("我：真是太好了！你能玩到這邊就代表沒有BUG。第一關BETA已結束！");
                            break;
                        case 5:
                            gamemanager.Speak("目前做到的功能與寫好的文本加起來就到這邊，感謝您的遊玩！");
                            break;
                        case 6:
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
                            gamemanager.Speak("上了鎖的門，想要出去只能快點找到鑰匙了。");
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
                            gamemanager.Speak("轉了轉手把，絲紋不動。");
                            break;
                        case 2:
                            gamemanager.Speak("真的被鎖上了呢……");
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
        }
    }
    
    
}