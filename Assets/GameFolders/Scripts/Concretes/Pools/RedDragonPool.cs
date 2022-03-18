using System.Collections;
using UdemyprojectTutorialBerk1.Abstract.Pools;
using UdemyprojectTutorialBerk1.Controllers;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Pools
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool Instance { get; private set;}

        public override void ResetAllObjects()
        {
            foreach (RedDragonController child in GetComponentsInChildren<RedDragonController>())
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

