using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Idle, Playing, GameOver };

public class game_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject button;
    public static GameState game_state = GameState.Idle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -10) {
            game_state = GameState.GameOver;
        }
        if (game_manager.game_state == GameState.GameOver || game_manager.game_state == GameState.Idle) {
            button.SetActive(true);
        } else {
            button.SetActive(false);
        }
        Debug.Log(game_state);
    }
}
