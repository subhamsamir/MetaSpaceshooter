using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHit : MonoBehaviour
{
    [SerializeField] private GameObject asteroidExplosion;

    public void AsteroiDestroyed()
    {
        Instantiate(asteroidExplosion, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
