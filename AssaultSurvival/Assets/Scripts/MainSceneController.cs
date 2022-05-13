using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainSceneController : MonoBehaviour
{
    public void CharacterBtnClick(int i)
    {
        switch (i)
        {
            case 1:
                Debug.Log("전사 클릭");
                SceneManager.LoadScene("GameScene");
                break;
            case 2:
                Debug.Log("도적 클릭");
                break;
        }
    } 
}
