using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreHolder : MonoBehaviour
{
    [SerializeField]
    Transform tra;
    private void Update()
    {
        if(tra.position.y > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", tra.position.y);
        }
        Debug.Log(PlayerPrefs.GetFloat("HighScore"));
    }
}
