using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Text_s : MonoBehaviour
{
    // Start is called before the first frame update
    public bool typing=false ;
    public float type_delay;
    public Text text;
    void Start()
    {

        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    { 
    }
    public void type_start(string words)
    {
        StartCoroutine(type(words));
    }
    public void type_clear()
    {
        text.text = string.Empty;
    }
    IEnumerator type(string word)
    {
        type_delay = 0.1f;
        type_clear();
        typing = true;
        
        foreach (char letter in word.ToCharArray())
        {
            text.text += letter;
            
            yield return new WaitForSeconds(type_delay);
        }
        typing = false;
    }
}
