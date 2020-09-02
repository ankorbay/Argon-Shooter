using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;
    [SerializeField] GameObject deathFX;

    private void OnTriggerEnter(Collider other)
    {
        print ("Collider detected" + other.gameObject);
        StartDeathSequence();
    }

    private void StartDeathSequence(){
        // SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("ReloadScene",levelLoadDelay);
    }

    private void ReloadScene(){
        SceneManager.LoadScene(1);
    }

}
