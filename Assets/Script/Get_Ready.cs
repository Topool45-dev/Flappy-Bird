using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get_Ready : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Image image;
        Color color = image.color;
        color.a = 1;
        image.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        Color.a -= Time.deltaTime;
        I
    }
}
