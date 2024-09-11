using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private string[] _objectTags;
    [SerializeField] private string[] _collisionTags;

    [SerializeField] private float explosionForce = 500f;
    [SerializeField] private float explosionRadius = 5f;
    [SerializeField] private float upwardModifier = 1f;

    void Start()
    {
        if (_rb != null)
            _rb.linearVelocity = transform.forward * _speed;
    }

    void OnTriggerEnter(Collider collider)
    {
        foreach (string tag in _collisionTags)
        {
            if (collider.gameObject.CompareTag(tag))
            {
                TriggerExplosion();
                Destroy(this);
                return; 
            }
        }
    }
    
    void TriggerExplosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider nearbyObject in colliders)
        {
            foreach (string tag in _objectTags)
            {
                if (nearbyObject.CompareTag(tag))
                {
                    if (nearbyObject.TryGetComponent<Rigidbody>(out var rb))
                    {
                        rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, upwardModifier, ForceMode.Impulse);
                    }
                }
            }
        }
    }
}
