using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockniddle : MonoBehaviour
{
    public float angle;
    public float target;
    private GameManager_s gamemanager;
    public bool good = false;
    public bool abled = true;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
    }

    // Update is called once per frame
    void Update()
    {
        angle = transform.localEulerAngles.z;
        if (abled == true)
            good = compare(angle,target);
    }
    void OnMouseDrag()
    { 
        if (abled==true)
        {
        if (Input.GetMouseButton(0)&&gamemanager.gamemode== "searching")
        {
            transform.up = (new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z) - transform.position).normalized;
        }

        }
    }
    private bool compare(float angle,float target)
    {
        bool pass=false;
        float targetwo = target - 360f;
        float trueangle = angle % 360f;
        if ((trueangle<target+5f&& trueangle > target - 5f)|| (trueangle < targetwo + 5f && trueangle > targetwo - 5f))
        {
            pass = true;
        }
        return pass;
    }
}
