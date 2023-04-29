using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeToMaster : MonoBehaviour
{
    public Button backButton;
    public string master;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(BackToMaster);
    }
    private void BackToMaster()
    {
        SceneManager.LoadScene(0);
    }

}
