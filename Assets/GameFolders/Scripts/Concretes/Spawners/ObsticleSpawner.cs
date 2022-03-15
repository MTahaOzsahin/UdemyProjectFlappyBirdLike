using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Spawners;
using UdemyprojectTutorialBerk1.Controllers;
using UdemyprojectTutorialBerk1.Movements;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {
        [SerializeField] EnemyController[] enemies;

       
        protected override  void Spawn()
        {
            // 0 gelebilir ama 4 gelemez.
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], transform.position, transform.rotation,transform);
        }
    }
}
