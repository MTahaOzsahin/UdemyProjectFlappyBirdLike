using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Abstract.Spawners;
using UdemyprojectTutorialBerk1.Controllers;
using UdemyprojectTutorialBerk1.Pools;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Combat
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] float delayProjectile = 1f;

        float _currentDelayTime;
        bool _canLaunch = false;

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }

        public void LaunchAction()
        {
            if (_canLaunch)
            {
                //EnemyController poolProjectile = ProjectilePool.Instance.Get();
                //poolProjectile.transform.position = this.transform.position;
                //poolProjectile.gameObject.SetActive(true);
                ProjectileController newProjectile =
                    Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.transform.rotation,transform);


                _canLaunch = false;
            }
        }

        
    }
}

