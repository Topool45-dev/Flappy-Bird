using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Flap : MonoBehaviour
{
    [SerializeField]
    private float GRAVITY = 1f;
    [SerializeField]
    private float JUMP_FORCE = 2f;

    private float velocity = 0;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    void Update() {
        velocity -= GRAVITY;
        if (Input.GetKeyDown(KeyCode.W)) {
            velocity = JUMP_FORCE;
        }
        transform.position += new Vector3(0, velocity*Time.deltaTime, 0);
    }

}
