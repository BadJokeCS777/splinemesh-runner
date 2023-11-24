using System;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    [SerializeField] private float _maxDistance;
    [SerializeField] private float _explosionForce;
    [SerializeField] private ParticleSystem _particleSystem;

    private void Explode()
    {
        foreach (var item in GetExplodableObjects())
        {
            item.AddExplosionForce(_explosionForce, transform.position, _maxDistance);
        }
    }

    private List<Rigidbody> GetExplodableObjects()
    {
        var hits = Physics.SphereCastAll(transform.position, _maxDistance, Vector3.forward);
        
        List<Rigidbody> barrels = new List<Rigidbody>();

        foreach (var hit in hits)
        {
            if (hit.collider.TryGetComponent(out Rigidbody barrel))
            {
                barrels.Add(barrel);
            }
        }

        return barrels;
    }

    private void OnMouseUpAsButton()
    {
        Explode();
        Instantiate(_particleSystem, transform.position, transform.rotation);
        gameObject.SetActive(false);
    }
}
