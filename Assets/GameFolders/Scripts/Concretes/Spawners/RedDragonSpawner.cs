using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Spawners;
using UdemyprojectTutorialBerk1.Controllers;
using UdemyprojectTutorialBerk1.Pools;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            EnemyController newEnemy = RedDragonPool.Instance.Get();
            newEnemy.transform.position = transform.position;
            newEnemy.gameObject.SetActive(true);
        }
    }
}
