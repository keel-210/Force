using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserCamera : MonoBehaviour
{
    [SerializeField]
    GameObject _Player;
    public GameObject Player
    {
        get { return _Player; }
        set { _Player = value; }
    }
    [SerializeField]
    float Max_x,Min_x,Max_y,Min_y;
    [SerializeField]
    float ChaserRatio;
    
    [SerializeField]
    float OffsetY;
    
    void FixedUpdate()
    {
        Vector3 NextPos = Vector3.Lerp(transform.position + new Vector3(0, OffsetY, 0), Player.transform.position, ChaserRatio);
        if (NextPos.x <= Max_x && NextPos.x >= Min_x)
        {
            transform.position = new Vector3(NextPos.x, transform.position.y, transform.position.z);
        }
        else if (NextPos.x > Max_x)
        {
            transform.position = new Vector3(Max_x, transform.position.y, transform.position.z);
        }
        else if (NextPos.x < Min_x)
        {
            transform.position = new Vector3(Min_x, transform.position.y, transform.position.z);
        }
        if (NextPos.y <= Max_y && NextPos.y >= Min_y)
        {
            transform.position = new Vector3(transform.position.x, NextPos.y, transform.position.z);
        }
        else if (NextPos.y > Max_y)
        {
            transform.position = new Vector3(transform.position.x, Max_y, transform.position.z);
        }
        else if (NextPos.y < Min_y)
        {
            transform.position = new Vector3(transform.position.x, Min_y, transform.position.z);
        }
    }
}
