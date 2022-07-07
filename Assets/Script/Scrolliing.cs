using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolliing : MonoBehaviour {
    [SerializeField]
    private float scrolling = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(scrolling, 0, 0);
    }
}
