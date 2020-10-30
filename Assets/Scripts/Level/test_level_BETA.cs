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
                value = 46;
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
                        gamemanager.Speak(new talkform().words = "我緊緊的握住了那雙逐漸冰冷的手。".speaker = " ");
                        break;
                    case 2:
                        gamemanager.Speak(new talkform(words = "我緊緊的握住了那雙逐漸冰冷的手。", speaker = " "));
                        break;
                    case 3:
                        gamemanager.Speak(new talkform(words = "視線是模糊的，分不清是雨水還是淚。", speaker = " "));
                        break;
                    case 4:
                        gamemanager.Speak(new talkform(words = "我做了一個夢，很長，很久。", speaker = " "));
                        break;
                    case 5:
                        gamemanager.Speak(new talkform(words = "我感覺到有人在呼喊我的名字，很遙遠、很遙遠。", speaker = " "));
                        break;
                    case 6:
                        gamemanager.Speak(new talkform(words = "嗚呃。", speaker = "艾德里安"));
                        break;
                    case 7:
                        gamemanager.Speak(new talkform(words = "一本書砸在我的臉上。", speaker = " "));
                        break;
                    case 8:
                        gamemanager.Speak(new talkform(words = "非常……", speaker = "？？？"));
                        break;
                    case 9:
                        gamemanager.Speak(new talkform(words = "……？", speaker = "艾德里安"));
                        break;
                    case 10:
                        gamemanager.Speak(new talkform(words = "非常對不起！！！", speaker = "？？？"));
                        break;
                    case 11:
                        gamemanager.Speak(new talkform(words = "咦？這麼突然？", speaker = " "));
                        break;
                    case 12:
                        gamemanager.Speak(new talkform(words = "你還好嗎！？有沒有哪裡受傷！？", speaker = "？？？"));
                        break;
                    case 13:
                        gamemanager.Speak(new talkform(words = "啊、啊，沒有大礙。", speaker = "艾德里安"));
                        break;
                    case 14:
                        gamemanager.Speak(new talkform(words = "砸在臉上的書已經被我拿到手上。", speaker = " "));
                        break;
                    case 15:
                        gamemanager.Speak(new talkform(words = "看來是她不小心將書砸到我的臉上了。", speaker = " "));
                        break;
                    case 16:
                        gamemanager.Speak(new talkform(words = "那就好了……要是害你怎麼了，大概又要被酒保先生說笑了。", speaker = "？？？"));
                        break;
                    case 17:
                        gamemanager.Speak(new talkform(words = "酒保先生？", speaker = "艾德里安"));
                        break;
                    case 18:
                        gamemanager.Speak(new talkform(words = "聽她一說，我很快的從驚醒中理解到自己來到了一個陌生的地方。", speaker = " "));
                        break;
                    case 19:
                        gamemanager.Speak(new talkform(words = "我並不認識她口中說的人，也不認識「她」本人。", speaker = " "));
                        break;
                    case 20:
                        gamemanager.Speak(new talkform(words = "啊，那個晚點再說吧。", speaker = "？？？"));
                        break;
                    case 21:
                        gamemanager.Speak(new talkform(words = "我是喵可，其實我們現在遇到了有點棘手的問題……", speaker = "？？？"));
                        break;
                    case 22:
                        gamemanager.Speak(new talkform(words = "能先告訴我你的名字嗎？", speaker = "喵可"));
                        break;
                    case 23:
                        gamemanager.Speak(new talkform(words = "一段再正常不過的開場白，理所當然的，我知道自己的名字。", speaker = " "));
                        break;
                    case 24:
                        gamemanager.Speak(new talkform(words = "——卻也只想的起來自己的名字。", speaker = " "));
                        break;
                    case 25:
                        gamemanager.Speak(new talkform(words = "艾德里安，可以叫艾德就好。", speaker = "艾德里安"));
                        break;
                    case 26:
                        gamemanager.Speak(new talkform(words = "說說那個棘手的問題吧，你會先提表示有點緊急？", speaker = "艾德里安"));
                        break;
                    case 27:
                        gamemanager.Speak(new talkform(words = "嗚嗯……其實，在我進來之後，這間房間被反鎖住了。", speaker = "喵可"));
                        break;
                    case 28:
                        gamemanager.Speak(new talkform(words = "……這還真是玄妙的狀況。", speaker = "艾德里安"));
                        break;
                    case 29:
                        gamemanager.Speak(new talkform(words = "艾德會不會知道鑰匙在哪裡呢？", speaker = "喵可"));
                        break;
                    case 30:
                        gamemanager.Speak(new talkform(words = "這是一個好問題。", speaker = " "));
                        break;
                    case 31:
                        gamemanager.Speak(new talkform(words = "……可惜的是，我好像除了名字以外，什麼都想不起來。", speaker = "艾德里安"));
                        break;
                    case 32:
                        gamemanager.Speak(new talkform(words = "字面意思，我的腦袋真的是一片空白。", speaker = " "));
                        break;
                    case 33:
                        gamemanager.Speak(new talkform(words = "想不起來在這裡的原因，想不起來自己過去曾經待在哪裡。", speaker = " "));
                        break;
                    case 34:
                        gamemanager.Speak(new talkform(words = "當然，這間房間我也沒有任何印象。", speaker = " "));
                        break;
                    case 35:
                        gamemanager.Speak(new talkform(words = "………", speaker = "喵可"));
                        break;
                    case 36:
                        gamemanager.Speak(new talkform(words = "………", speaker = "喵可"));
                        break;
                    case 37:
                        gamemanager.Speak(new talkform(words = "不過那個不是重點，先嘗試找到出去的方法吧？", speaker = "艾德里安"));
                        break;
                    case 38:
                        gamemanager.Speak(new talkform(words = "艾德你……", speaker = "喵可"));
                        break;
                    case 39:
                        gamemanager.Speak(new talkform(words = "是？", speaker = "艾德里安"));
                        break;
                    case 40:
                        gamemanager.Speak(new talkform(words = "太過冷靜了吧！一個失去記憶的人會這麼冷靜的嗎？", speaker = "喵可"));
                        break;
                    case 41:
                        gamemanager.Speak(new talkform(words = "喵可說的沒錯，但我的內心卻意外的毫無波瀾。", speaker = " "));
                        break;
                    case 42:
                        gamemanager.Speak(new talkform(words = "一種直覺告訴我，絕對不用擔心找不到自己的記憶。", speaker = " "));
                        break;
                    case 43:
                        gamemanager.Speak(new talkform(words = "我也不曉得，心情意外的平靜。", speaker = "艾德里安"));
                        break;
                    case 44:
                        gamemanager.Speak(new talkform(words = "總而言之，先在房間裡面翻找看看吧？", speaker = "艾德里安"));
                        break;
                    case 45:
                        gamemanager.Speak(new talkform(words = "好、好吧，嗯、嗯，沒問題！", speaker = "喵可"));
                        break;
                    case 56:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            /*case "bed":
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

                            gamemanager.Speak("我：這根蘿蔔應該可以從鎖孔裡面督進去.....嗎？");
                            break;
                        case 3:

                            gamemanager.Speak("總之先試試看吧！");
                            break;
                        case 4:

                            gamemanager.Speak("啊。蘿蔔壞掉了....");
                            break;
                        case 5:
                            gamemanager.resentitem = "empty";
                            gamemanager.playeritem.Remove("carrot");
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
                break;*/
        }
    }
    
    
}