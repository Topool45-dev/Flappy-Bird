using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public static int collision;

    void Update() {
        
    }

    void OnTriggerEnter2D() {
        collision = 1;
    }
}
