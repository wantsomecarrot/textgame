using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enter ()
    {
        transform.localPosition = new Vector3(0, 0,0);
    }
    public void exit()
    {
        transform.localPosition = new Vector3(0,500,0);
    }
}
