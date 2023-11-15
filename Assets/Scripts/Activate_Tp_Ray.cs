using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Activate_Tp_Ray : MonoBehaviour
{
    public GameObject leftTP;
    public GameObject rightTP;

    public InputActionProperty leftActivation;
    public InputActionProperty rightActivation;


    

    // Update is called once per frame
    void Update()
    {
        leftTP.SetActive(leftActivation.action.ReadValue<float>() > 0.1f);
        rightTP.SetActive(rightActivation.action.ReadValue<float>() > 0.1f);
    }
}
