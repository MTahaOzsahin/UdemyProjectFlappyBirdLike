using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Controllers;
using UdemyprojectTutorialBerk1.Pools;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
    }
}
