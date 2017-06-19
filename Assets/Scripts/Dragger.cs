using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    Vector3 pos = new Vector3(0,-3,0);
    void Update()
    {
        if (Input.touchCount != 0)
        {
            Touch t = Input.touches[0];
            if (t.phase == TouchPhase.Began || t.phase == TouchPhase.Moved || t.phase == TouchPhase.Stationary)
            {
                pos = Camera.main.ScreenToWorldPoint(t.position);
                pos = new Vector3(pos.x, pos.y, 0);
            }
        }
    }
    private void FixedUpdate()
    {
        rb.position = pos;
    }
}
