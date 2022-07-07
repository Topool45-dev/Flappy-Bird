using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_behaviour : MonoBehaviour
{
    public void Start_Game() {
        if (game_manager.game_state == GameState.Idle) {
            gameObject.SetActive(false);
            game_manager.game_state = GameState.Playing;
        } else {
            game_manager.game_state = GameState.Idle;
        }
    }

    public void Update() {
        if (game_manager.game_state == GameState.GameOver) {
            gameObject.SetActive(true);
        }
    }
}
