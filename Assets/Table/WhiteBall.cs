using UnityEngine;

public class WhiteBall : MonoBehaviour
{
    public GameObject whiteball;
    Ray ray;
    RaycastHit hit;
    Rigidbody rb;
    public float punchpower;

    // Start is called before the first frame update
    void Start()
    {           
    }
    private void FixedUpdate()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
               
                if (hit.collider.name == "White ball")
                {
                    hit.transform.GetComponent<Rigidbody>().AddForce(ray.direction * punchpower);
                }
            }
        }
    }
}