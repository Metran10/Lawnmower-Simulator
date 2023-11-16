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

    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;


    // Update is called once per frame
    void Update()
    {
        leftTP.SetActive(leftCancel.action.ReadValue<float>() == 0 &&  leftActivation.action.ReadValue<float>() > 0.1f);
        rightTP.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActivation.action.ReadValue<float>() > 0.1f);
    }
}
