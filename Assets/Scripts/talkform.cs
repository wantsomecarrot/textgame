using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class talkform : ScriptableObject {
    public talkform(string _words, string _speaker,string _emotion,string _effect)
    {
        words = _words;
        speaker = _speaker;
        emotion = _emotion;
        effect = _effect;
    }
    public string words;
    public string speaker;
    public string emotion;
    public string effect;
}
