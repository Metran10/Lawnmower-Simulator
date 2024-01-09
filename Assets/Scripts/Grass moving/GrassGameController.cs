using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GrassGameController : MonoBehaviour
{
    private GameObject[] grassTiles;
    private int grassTilesCount;

    public TextMeshProUGUI grassCountTextField;
    public string grassText;

    public TextMeshProUGUI victoryText;



    // Start is called before the first frame update
    void Start()
    {
        victoryText.gameObject.SetActive(false);
        grassTiles = GetAllGrassTiles();
        grassTilesCount = grassTiles.Length;
        grassText = $"0/{grassTilesCount}";
        grassCountTextField.SetText(grassText);
    }

    // Update is called once per frame
    void Update()
    {
        int currGrass  = GetCurrenGrassNumber();
        grassText = $"{currGrass}/{grassTilesCount}";
        grassCountTextField.SetText(grassText);


        //victory conditions
        if (currGrass >= grassTilesCount)
        {
            victoryText.gameObject.SetActive(true);
        }


    }



    public GameObject[] GetAllGrassTiles()
    {
        int grassCount = transform.childCount;

        GameObject[] grassTiles = new GameObject[grassCount];

        for (int i = 0; i < grassCount; i++)
        {
            Transform childT = transform.GetChild(i);
            grassTiles[i] = childT.gameObject;

        }

        return grassTiles;
    }

    public int GetCurrenGrassNumber()
    {
        int movedGrass = 0;
        for(int i = 0; i < grassTilesCount; i++)
        {
            GrassCrusher currGrass = grassTiles[i].GetComponent<GrassCrusher>();
            if (!currGrass.isCuttable)
            {
                movedGrass++;
            }


        }

        return movedGrass;
    }


}
