using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    void Update()
    {
        Debug.Log(triggerActive);
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("cipolla");
        }
    }
    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
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
