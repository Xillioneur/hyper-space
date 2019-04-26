using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
  [Tooltip("In Second")][SerializeField] float levelLoadDelay = 1f;
  [Tooltip("Prefab on player")] [SerializeField] GameObject deathFX;

  private void OnTriggerEnter(Collider other)
  {
    StartDeathSequence();
    deathFX.SetActive(true);
    Invoke("ReloadScene", levelLoadDelay);
  }

  private void StartDeathSequence()
  {
    SendMessage("OnPlayerDeath");
  }

  private void ReloadScene()
  {
    SceneManager.LoadScene(1);
  }
}
