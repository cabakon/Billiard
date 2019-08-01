using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int Score;
    public bool IsWinner = false;
    private Text txtScoreTextComponent;

    private void Start()
    {   
        GameObject txtScoreObject = GameObject.Find("txtScore");
        if (txtScoreObject != null)
        {
            txtScoreTextComponent = txtScoreObject.GetComponent<Text>();
            print(txtScoreTextComponent.text);
            txtScoreTextComponent.text = "0";
        }

    }
private void Update()
    {
        if(!IsWinner && Score >= 5)
        {
            print("Výhra");
            IsWinner = true;
        }

        txtScoreTextComponent.text = Score.ToString();
    }

}
