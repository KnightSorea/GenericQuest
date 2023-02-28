using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringEnemyController : MonoBehaviour
{
    public Transform detector;
    public float moveSpeed;
    public bool isRotated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        RaycastHit2D groundDetection = Physics2D.Raycast(detector.position, Vector2.down, 2f);
        if (!isRotated)
        {
            RaycastHit2D wallDetection = Physics2D.Raycast(detector.position, Vector2.right, 0.1f);
            if (wallDetection.collider != null || groundDetection.collider == null)
            {
                isRotated = true;
                transform.Rotate(0f, 180f, 0f);
            }
        }
        else
        {
            RaycastHit2D wallDetection = Physics2D.Raycast(detector.position, Vector2.left, 0.1f);
            if (wallDetection.collider != null || groundDetection.collider == null)
            {
                isRotated = false;
                transform.Rotate(0f, 180f, 0f);
            }
        }
    }
}
