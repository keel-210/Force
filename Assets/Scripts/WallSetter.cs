using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSetter : MonoBehaviour
{
    [SerializeField]
    Pool pool;
    [SerializeField]
    Transform t;

    void Start()
    {
        Set();
    }

    public void Set()
    {
        float NumOfWall = Random.value * 5 + 10;
        for (int i = 0; i < NumOfWall; i++)
        {
            GameObject obj = pool.Request(transform);
            if (Random.value < 0.5f)
            {
                WallConst(obj, 3);
            }
            else
            {
                WallConst(obj, -3);
            }
        }
    }
    void WallConst(GameObject obj, float x)
    {
        obj.transform.position = new Vector3(x, 100 * Random.value + t.position.y + 5, 0);
        obj.transform.rotation = Quaternion.Euler(0, 0, Random.value * 360);
    }
}
