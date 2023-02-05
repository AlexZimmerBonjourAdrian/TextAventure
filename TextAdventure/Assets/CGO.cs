using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Go")]
public class CGO : CInputAction
{
    public override void RespondToInput(CGameController controller, string[] separatedInputWords)
    {
        controller.roomNavation.AtteptToChangeRooms(separatedInputWords[1]);
    }
}
