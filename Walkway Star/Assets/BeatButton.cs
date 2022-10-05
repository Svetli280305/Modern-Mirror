using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatButton : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, -200f * Time.deltaTime, 0);
    }
}

