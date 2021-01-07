using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class characterform : ScriptableObject
{
    public characterform(string _name)
    {
        _name = name;
    }
    public Dictionary<string, Sprite> CG = new Dictionary<string, Sprite>();
    public string name;
    
}
