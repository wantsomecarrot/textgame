using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_show : MonoBehaviour
{
    // Start is called before the first frame update
    public int number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadimage(string name) {
        Debug.Log(name);
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>(name);
    } 
}
