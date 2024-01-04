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

    public XRRayInteractor leftRay;
    public XRRayInteractor rightRay;

    // Update is called once per frame
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPose, out Vector3 leftNormal, out int leftPosLine, out bool leftIsValidTarget);
        bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPose, out Vector3 rightNormal, out int rightPosLine, out bool rightIsValidTarget);

        leftTP.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0 &&  leftActivation.action.ReadValue<float>() > 0.1f);
        rightTP.SetActive(!rightIsValidTarget && rightCancel.action.ReadValue<float>() == 0 && rightActivation.action.ReadValue<float>() > 0.1f);
    }
}
