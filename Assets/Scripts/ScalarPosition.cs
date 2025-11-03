using UnityEngine;

public class ScalarPosition : MonoBehaviour
{
    public float step;
    private float scalar = 1;

    private Vector3 startPos;

    void Start()
    {
        Vector3 startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            
        }

        gameObject.transform.position = startPos * scalar;
    }
}
