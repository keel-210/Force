using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {

    public Vector2 LeftBottom { get; private set; }
    public Vector2 RightTop { get; private set; }

    void Awake ()
    {
        LeftBottom = Camera.main.ScreenToWorldPoint(Vector3.zero);
        RightTop = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
	}
}
