using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Spawners;
using UdemyprojectTutorialBerk1.Controllers;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] EnemyController enemy;

        protected override void Spawn()
        {
            Instantiate(enemy, this.transform);
        }
    }
}
