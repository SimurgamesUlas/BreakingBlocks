using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform Ball;
    public Transform cam;
    private int activeSceneIndex;
    void Start()
    {
        activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    
    void Update()
    {
        CheckBallPos();
    }
    private void CheckBallPos(){
        if(Ball.position.y <= cam.position.y - 7f){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    public void AfterScene(){
        if(BlockController.BlockNumbers <= 0){
            SceneManager.LoadScene(activeSceneIndex + 1);
        }
    }
}
