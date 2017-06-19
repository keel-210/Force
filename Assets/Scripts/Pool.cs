using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField]
    Object prefab;

    List<GameObject> list = new List<GameObject>();
    
    public GameObject Request(Transform tra)
    {
        bool InitFlg = false;
        GameObject returnObj = null;
        foreach (GameObject g in list)
        {
            if (!g.activeInHierarchy)
            {
                g.SetActive(true);
                g.transform.parent = tra;
                returnObj = g;
                InitFlg = true;
                break;
            }
        }
        if (!InitFlg)
        {
            GameObject g = (GameObject)Instantiate(prefab);
            list.Add(g);
            g.transform.parent = tra;
            returnObj = g;
        }
        return returnObj;
    }
}
