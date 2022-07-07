using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_behaviour : MonoBehaviour
{
    public void Start_Game() {
         gameObject.SetActive(false);
         game_manager.game_state = GameState.Playing;
    }

}
