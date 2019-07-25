using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summonofredball : MonoBehaviour
{
    public GameObject Redball;

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(Redball, new Vector3(0f, 1.08f, 11f), transform.rotation);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
