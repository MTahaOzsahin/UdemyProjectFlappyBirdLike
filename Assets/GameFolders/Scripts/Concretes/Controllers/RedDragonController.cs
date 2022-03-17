using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Pools;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }
}

