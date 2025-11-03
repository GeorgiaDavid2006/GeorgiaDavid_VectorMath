using UnityEngine;

public class SineTranslator : MonoBehaviour
{
    private float speed = 5;

    public float startPosX = 0;
    public float startPosY = 0;
    public float startPosZ = 0;

    public bool moveX = false;
    public bool moveY = false;
    public bool moveZ = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(moveX == true)
        {
            transform.position = new Vector3(
                Mathf.Sin(Time.time * speed) * speed + startPosX,
                transform.position.y, 
                transform.position.z);
        }
        
        if(moveY == true)
        {
            transform.position = new Vector3(
                transform.position.x ,
                Mathf.Sin(Time.time * speed) * speed + startPosY,
                transform.position.z);
        }

        if (moveZ == true)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                Mathf.Sin(Time.time * speed) * speed + startPosZ);
        }

    }
}
