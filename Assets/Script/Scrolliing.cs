using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolliing : MonoBehaviour {
    [SerializeField]
    private float scrolling = 0;
    [SerializeField]
    private float start = 10f;
    [SerializeField]
    private float end = -10f;

    // Update is called once per frame
    void Update() {
        if (Collision.collision == 0 && game_manager.game_state == GameState.Playing) {
            transform.position -= new Vector3(scrolling * Time.deltaTime, 0, 0);
            if (transform.position.x <= end) {
                Player_Flap.score++;
                transform.position = new Vector3(start, Random.Range(0, 5), 0f);
            }
        }
    }
}
