using UnityEngine;

public class SumPosition : MonoBehaviour
{
    private float speed = 5;

    public GameObject cube1;
    public GameObject cube2;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = cube1.transform.position + cube2.transform.position;
    }
}
