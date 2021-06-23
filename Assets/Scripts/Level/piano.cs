using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano : MonoBehaviour
{
    private GameManager_s gamemanager;
    public bool good = false;
    public bool abled = true;
    public string code;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
    }

    // Update is called once per frame
    void Update()
    {
        if (abled == true)
            if (code.Contains("13454"))
                good = true;

    }
    public void entercode(string add)
    {
        code += add;
    }
    public void clearcode() {
        code = "";
    }
}
