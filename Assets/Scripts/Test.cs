using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start () {
        InterParent i = GameObject.Find("Test").GetComponent<InterParent>();
        i.test();
	}
}
