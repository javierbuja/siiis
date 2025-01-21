using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MorteTrigger : MonoBehaviour
{
    [SerializeField] private bool isPlayerInTrigger = false;

    void Update()
    {
        // Se il giocatore � nel trigger, riavvia la scena
        if (isPlayerInTrigger)
        {
            // Riavvia la scena corrente
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        // Se l'oggetto che entra nel trigger � il giocatore
        if (other.CompareTag("Player"))
        {
            isPlayerInTrigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        // Se l'oggetto che esce dal trigger � il giocatore
        if (other.CompareTag("Player"))
        {
            isPlayerInTrigger = false;
        }
    }
}
