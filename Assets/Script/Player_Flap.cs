using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Flap : MonoBehaviour {
    [SerializeField]
    private float GRAVITY = 1f;
    [SerializeField]
    private float JUMP_FORCE = 2f;

    private float velocity = 0;
    private float timer = 0;
    public float time = 60;

    // Start is called before the first frame update
    void Start() {
        timer = time;
    }

    void Update() {
        if (game_manager.game_state == GameState.Playing) {
            velocity -= GRAVITY;
            

            transform.position += new Vector3(0, velocity * Time.deltaTime, 0);
            transform.rotation = Quaternion.Euler(0, 0, velocity * 2);
        }else if(game_manager.game_state == GameState.Idle) {
            timer -= Time.deltaTime;
            if(timer <= 0) {
                velocity = JUMP_FORCE;
                timer = time;
            }
        }
        velocity -= GRAVITY;
        transform.position += new Vector3(0, velocity * Time.deltaTime, 0);
        transform.rotation = Quaternion.Euler(0, 0, velocity * 2);
    }

}
