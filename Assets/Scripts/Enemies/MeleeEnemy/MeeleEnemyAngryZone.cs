using System;
using UnityEngine;


public class MeeleEnemyAngryZone : MonoBehaviour
{
    public MeeleEnemy meeleEnemy;
    private void OnTriggerEnter(Collider other)
    {
        meeleEnemy.Burn();
    }

    private void OnTriggerExit(Collider other)
    {
        meeleEnemy.Relax();
    }
}
