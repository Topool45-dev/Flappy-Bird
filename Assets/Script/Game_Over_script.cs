using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over_script : MonoBehaviour
{

    private void Update() {
        if (Input.anyKey) {
            game_manager.game_state = GameState.Idle;
            Collision.collision = 0;
            Player_Flap.score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
