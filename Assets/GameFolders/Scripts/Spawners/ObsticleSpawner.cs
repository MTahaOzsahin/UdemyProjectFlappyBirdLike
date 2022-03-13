using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Controllers;
using UdemyprojectTutorialBerk1.Movements;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Spawners
{
    public class ObsticleSpawner : MonoBehaviour
    {
        [Range(2.1f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f,1.5f)]
        [SerializeField] float minSpawnTime = 1f;


        [SerializeField] EnemyController[] enemies;

        float _currentSpawnTime;
        float _timeBoundary;
        private void Start()
        {
            ResetTimes();
        }
        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;
            if (_currentSpawnTime > _timeBoundary )
            {
                Spawn();
                ResetTimes();
            }
        }

        private void Spawn()
        {
            // 0 gelebilir ama 4 gelemez.
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], transform.position, transform.rotation,transform);
        }

        private void ResetTimes()
        {
            _currentSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
