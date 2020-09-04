using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent;
    void Start()
    {
        addNonTriggerBoxCollider();
    }

    private void addNonTriggerBoxCollider(){
        Collider enemyBoxCollider = gameObject.AddComponent<BoxCollider>();
        enemyBoxCollider.isTrigger = false;
    }
    void OnParticleCollision(GameObject other)
    {   
        GameObject fx = Instantiate(deathFx, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
