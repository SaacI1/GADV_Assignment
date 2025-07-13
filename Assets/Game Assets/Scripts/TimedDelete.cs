using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDelete : MonoBehaviour
{
    private const float V = 4.0f;
    public float Timer = V;

    public static float V1 => V;

    void Start()
    {
        Destroy(gameObject, Timer);
    }
}