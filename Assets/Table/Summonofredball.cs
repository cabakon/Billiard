using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summonofredball : MonoBehaviour
{
    public GameObject Redball;
    //Instantiate(Redball, new Vector3(0f, 1.0f, 10f), transform.rotation);
    // Start is called before the first frame update
    void Start()
    {
        int cntBall = 0;
        while(cntBall < 5)
        {
            int cntBallx = cntBall + 1;
            {
                Vector3 position;
                position = new Vector3( -3f + cntBallx , 1f, 13f);

                Instantiate(Redball, position, transform.rotation);
                cntBallx++; 
            }
            cntBall++;
        }
        int cntBall1 = 0;
        while (cntBall1 < 3)
        {
            int cntBallx2 = cntBall1 + 1;
            {
                Vector3 position;
                position = new Vector3(-1f + cntBall1, 1f, 12f);

                Instantiate(Redball, position, transform.rotation);
                cntBallx2++;
            }
            cntBall1++;
        }
        Instantiate(Redball, new Vector3(0f, 1.0f, 11f), transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
