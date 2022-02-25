using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    GameManagerScript gameManager;

    [SerializeField] GameObject goToPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = this;
        gameManager.goToPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            gameManager.goToPanel.SetActive(false);
            Time.timeScale = 1f;
        }

    }


    void LoadScene()
    {

    }
}
