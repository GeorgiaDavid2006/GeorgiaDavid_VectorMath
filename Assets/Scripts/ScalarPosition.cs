using UnityEngine;

public class ScalarPosition : MonoBehaviour
{
    public float step;
    private float scalar = 1;

    private Vector3 startPos;

    void Start()
    {
        startPos = new Vector3(0f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            scalar = scalar + step;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            scalar = scalar - step;
        }

        gameObject.transform.position = startPos * scalar;
    }
}
