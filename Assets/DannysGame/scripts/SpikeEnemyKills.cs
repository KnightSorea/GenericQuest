using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpikeEnemyKills : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.Respawn();
        }
    }
}
