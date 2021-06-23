using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellocode : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public bool good = false;
    public bool abled = false;
    public int[] value;
    public Sprite[] numimage;
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
    }

    // Update is called once per frame
    void Update()
    {
        if (abled)
            if (value[0] == 3 && value[1] == 8 && value[2] == 2)
                good=true;
    }
}
