using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    GameObject playerObj;
    RigController player;

    private void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<RigController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.coins++;
        Debug.Log(player.coins);
        Destroy(gameObject);
    }

}
