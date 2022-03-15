using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Controllers;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnemyController enemy = collision.GetComponent<EnemyController>();

            if (enemy != null)
            {
                Destroy(enemy.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}

