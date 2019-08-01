using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : MonoBehaviour
{
    public const int SCORE_VALUE = 1;
    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {

        GameObject gameObjectMaster = GameObject.Find("_GameManager");
        if(gameObjectMaster != null )
        {
            gm = gameObjectMaster.GetComponent<GameMaster>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10f)
        {
            gm.Score += SCORE_VALUE;
            Destroy(gameObject);
        }

    }
}
