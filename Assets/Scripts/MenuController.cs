using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuController : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurnProvider;
    public ActionBasedContinuousTurnProvider continuousTurnProvider;


    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            snapTurnProvider.enabled = false;
            continuousTurnProvider.enabled = true;
        }
        else if(index == 1)
        {
            snapTurnProvider.enabled = true;
            continuousTurnProvider.enabled = false;
        }
    }

}
