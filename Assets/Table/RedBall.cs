using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : MonoBehaviour
{
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        print("Ahoj ja jsem cervena koule");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10f)
        {
            Destroy(gameObject);
            Score++;
        }

    }
}
