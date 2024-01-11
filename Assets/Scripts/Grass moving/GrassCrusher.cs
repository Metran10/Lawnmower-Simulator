using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GrassCrusher : MonoBehaviour
{
    public bool isCuttable = true;
    public Material activationMaterial;
    public Material starterMaterial;

    private Collider ownCollider;


    // Start is called before the first frame update
    void Start()
    {
        ownCollider = GetComponent<Collider>();
        if(!starterMaterial == null)
        {
            GetComponent<MeshRenderer>().material = starterMaterial;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"Triggered by {other}");

        if (isCuttable)
        {
            
            //GetComponent<MeshRenderer>().material = activationMaterial; 

            if (other.tag == "Lawnmover")
            {
                //Debug.Log($"Cutting grass");
                GameObject otherObject = other.gameObject;

                GetComponent<MeshRenderer>().material = activationMaterial;

                foreach (Transform child in transform)
                {
                    Destroy(child.gameObject);
                }

                isCuttable = false;
            }

            




        }



    }


}
