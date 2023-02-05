using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRoomNavegation : MonoBehaviour
{

    public CRoom currentRoom;

    Dictionary<string, CRoom> exitDictionary = new Dictionary<string, CRoom>();
    CGameController controller;

    private void Awake()
    {
        controller = GetComponent<CGameController>();
    }
    // Start is called before the first frame update
    public void UnpackExitInRoom()
    {
        for(int i = 0; i < currentRoom.exists.Length;i++)
        {
            exitDictionary.Add(currentRoom.exists[i].keyString, currentRoom.exists[i].ValueRoom);
            controller.insteractionDescriptionsInRoom.Add(currentRoom.exists[i].existDescription);
        }
    }

    public void AtteptToChangeRooms(string directionDown)
    {
        //Code Search Key Exist disponibles
    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }

}
