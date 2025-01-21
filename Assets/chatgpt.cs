using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morte : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private Transform player; // Riferimento al Transform del giocatore
    [SerializeField] private Vector3 teleportPosition = new Vector3(-24.9f, 1.18f, -8f); // Nuove coordinate del teletrasporto
    [SerializeField] private float delayBeforeRestart = 2f; // Tempo di attesa prima del restart

    void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(TeleportAndRestart());
        }
    }

    private IEnumerator TeleportAndRestart()
    {
        // Teletrasporta il giocatore
        if (player != null)
        {
            player.position = teleportPosition;
            Debug.Log($"Player teletrasportato a: {teleportPosition}");
        }
        else
        {
            Debug.LogError("Player non è collegato nello script!");
        }

        // Aspetta prima di ricaricare la scena
        yield return new WaitForSeconds(delayBeforeRestart);

        // Ricarica la scena
        RestartScene();
    }

    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }
}
