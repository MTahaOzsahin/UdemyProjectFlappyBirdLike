using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Spawners;
using UdemyprojectTutorialBerk1.Controllers;
using UdemyprojectTutorialBerk1.Movements;
using UdemyprojectTutorialBerk1.Pools;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {
        protected override  void Spawn()
        {
            EnemyController poolEnemy = ObsticlePool.Instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
           
        }
    }
}
