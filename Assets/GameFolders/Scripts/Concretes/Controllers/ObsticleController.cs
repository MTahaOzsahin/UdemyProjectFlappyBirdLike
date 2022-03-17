using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Pools;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Controllers
{
    public class ObsticleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObsticlePool.Instance.Set(this);
        }
    }

}