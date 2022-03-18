using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Pools;
using UdemyprojectTutorialBerk1.Controllers;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Pools
{
    public class ObsticlePool : GenericPool<ObsticleController>
    {
        public static ObsticlePool Instance { get; private set; }

        public override void ResetAllObjects()
        {
            foreach (ObsticleController child in GetComponentsInChildren<ObsticleController>())
            {
                if (!child.gameObject.activeSelf) continue;

                child.KillGameObject();
            }
        }

        protected override void SingletonObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
