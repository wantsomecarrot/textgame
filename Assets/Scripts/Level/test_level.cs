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
    public void story(float level) {
        switch (level) {
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
            default:
                break;
        }

    }
}
