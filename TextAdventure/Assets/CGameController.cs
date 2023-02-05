using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CGameController : MonoBehaviour
{
    public Text distyText;
    //public InputAction[] InputAction;
    [HideInInspector] public CRoomNavegation roomNavation;
    [HideInInspector] public List<string> insteractionDescriptionsInRoom = new List<string>();

    List<string> actionLog = new List<string>();

    private void Awake()
    {
        roomNavation = GetComponent<CRoomNavegation>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayRoomText()
    {

    }

    void UnpackRoom()
    {

    }

    void ClearcollectionsForNewRoom()
    {

    }

    public void LogStringWithReturn(string stringToAdd)
    {

    }

    
}
