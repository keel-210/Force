using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSetter : MonoBehaviour
{
    [SerializeField]
    Vector3 Offset;
    [SerializeField]
    Pool pool;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject g = pool.Request(transform);
        g.transform.position = new Vector3((Random.value - 0.5f) * 6, 0, Random.value-0.5f);
        transform.position += Offset;
    }
}
