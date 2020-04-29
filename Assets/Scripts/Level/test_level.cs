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
                gamemanager.talkbegin();
               break;
            case 1:
                gamemanager.Speak("Sun is shining,birds are singing.");
                break;
            case 2:
                gamemanager.Speak("A day like this,a kid like you.");
                break;
            case 3:
                gamemanager.Speak("SHOULD BE BURNED IN THE HELL.");
                break;
            case 4:
                gamemanager.talkend();
                break;
            default:
                break;
        }
                break;
            case "ball":
                switch (level)
                {

                    case 0:
                        gamemanager.talkbegin();
                        break;
                    case 1:
                        gamemanager.Speak("This is a ball.");
                        break;
                    case 2:
                        gamemanager.talkend();
                        break;
                    default:
                        break;
                }
                break;
            case "box":
                switch (level)
                {

                    case 0:
                        gamemanager.talkbegin();
                        break;
                    case 1:
                        
                        gamemanager.Speak("This is a box.");
                        break;
                    case 2:
                        gamemanager.Speak("Why is this thing floating above?");
                        break;
                    case 3:
                        gamemanager.talkend();
                        break;
                    default:
                        break;
                }
                break;
        }
    }


}