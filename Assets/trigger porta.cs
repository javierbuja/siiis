using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerporta : MonoBehaviour
{

    [SerializeField] private bool triggerActive = false;
    [SerializeField] private GameObject muro_apribile_1;
    void Update()
    {
        Debug.Log(triggerActive);
        if (triggerActive && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Destroy(muro_apribile_1);
        }
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
