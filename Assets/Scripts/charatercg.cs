using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charatercg : MonoBehaviour
{
    private GameManager_s gamemanager;
    private Animator anime;
    public Image character;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void characterappear(Sprite character ,string type)
    {

    }
    void characterdisappear(Sprite character, string type)
    {

    }
}
