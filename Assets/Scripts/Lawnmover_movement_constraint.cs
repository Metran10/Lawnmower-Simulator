using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lawnmover_movement_constraint : MonoBehaviour
{
    private XRGrabInteractableTwoAttach grabInteractable;
    private Transform parent;

    public float verticalMovementLimit = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractableTwoAttach>();

        if(grabInteractable == null)
        {
            return;
        }
        parent = transform;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (grabInteractable.isSelected)
        {
            Vector3 currentPosition = transform.position;

            currentPosition.y = Mathf.Clamp(currentPosition.y, parent.position.y - verticalMovementLimit, parent.position.y + verticalMovementLimit);

            transform.position = currentPosition;

        }


    }
}
