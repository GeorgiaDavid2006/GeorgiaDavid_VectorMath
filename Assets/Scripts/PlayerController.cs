using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float step;
    private float scalar = 1;
    public float playerDotEnemyDir;

    private Vector3 startPos;
    private Vector3 enemyDir;

    public GameObject childCube;
    public GameObject enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        childCube.transform.position = transform.position + transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            scalar = scalar + step;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            scalar = scalar - step;
        }

        gameObject.transform.position = startPos * scalar;

        enemyDir = (enemy.transform.position - transform.position).normalized;
        playerDotEnemyDir = Vector3.Dot(transform.forward, enemyDir);
    }
}
