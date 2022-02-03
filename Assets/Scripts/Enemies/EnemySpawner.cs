using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   public Transform[] spawnPoints;
   public GameObject enemyMeele; // сюда в инспекторе закладываем префаб врага

   private void Start()
   {
      CreateEnemies(); //включения спавна на 4 точках (добавлять через инспектор нужное кол-во точек)
   }

   public void CreateEnemies()
   {
      for (int i = 0; i < spawnPoints.Length; i++)
      {
         Instantiate(enemyMeele, spawnPoints[i].position, spawnPoints[i].rotation).name += "_"+i;
      }
   }
}
