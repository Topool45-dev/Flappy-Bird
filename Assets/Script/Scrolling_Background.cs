using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Background : MonoBehaviour
{
    [SerializeField]
    private float scrolling = 0f;
    [SerializeField]
    private Material material;
    [SerializeField]
    private Vector2 offset;

    void Start() {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Collision.collision == 0 && game_manager.game_state == GameState.Playing) {
            offset.x += Time.deltaTime * scrolling;
            offset.x %= 1;
            material.SetTextureOffset("_MainTex", offset);
        }
        
    }
}
