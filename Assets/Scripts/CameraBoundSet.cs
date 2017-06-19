using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CameraPosition))]
public class CameraBoundSet : MonoBehaviour
{
    [SerializeField]
    Transform Top, Bottom, Right, Left;
    CameraPosition camPos;
	void Start ()
    {
        camPos = GetComponent<CameraPosition>();
        if (Top)
        {
            Vector3 pos = Top.position;
            Top.position = new Vector3(pos.x, camPos.RightTop.y, pos.z);
        }
        if (Bottom)
        {
            Vector3 pos = Bottom.position;
            Bottom.position = new Vector3(pos.x, camPos.LeftBottom.y, pos.z);
        }
        if (Right)
        {
            Vector3 pos = Right.position;
            Right.position = new Vector3(camPos.RightTop.x, pos.y, pos.z);
        }
        if (Left)
        {
            Vector3 pos = Left.position;
            Left.position = new Vector3(camPos.LeftBottom.x, pos.y, pos.z);
        }
    }
}
