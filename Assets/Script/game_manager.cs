using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Idle, Playing, GameOver };

public class game_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
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
        Debug.Log(game_state);
    }
}
