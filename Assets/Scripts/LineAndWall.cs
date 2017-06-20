using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAndWall : MonoBehaviour
{
    [SerializeField]
    WallSetter ws;

	void OnTriggerEnter2D(Collider2D obj)
    {
        ws.Set();
	}
}
