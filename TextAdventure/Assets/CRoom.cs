using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRoom : ScriptableObject
{
    // Start is called before the first frame update
    [TextArea]
    public string description;
    public string roomName;
    public CExist[] exists;
}


