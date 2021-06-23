using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class autotexting : MonoBehaviour
{
    // Start is called before the first frame update
    public Text A;
    public Text B;
    void Start()
    {
        if (A.text.Length>=0)
        StartCoroutine(type(A.text));
        Debug.Log(B.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator type(string word)
    {
        word = word.Replace(' ', ' ');
        string[] content = word.Split('\n');
        if (content.Length >= 0) { 
        for (int i = 1; i <= content.Length; i++) {
            B.text += "case "+ i + ":\ngamemanager.Speak(new talkform(\""+content[i-1] + " \",\" \",\" \"));"+"\n"+"break;"+"\n";
        }
        }
        yield return null;
    }
}
