using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public int healt;
    public static int BlockNumbers;
    public bool breakingBlocks;
    private GameManager gm;
    void Start()
    {
        breakingBlocks = (this.tag == "Block");
        if(breakingBlocks){
            BlockNumbers++;
            
        }
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col){
        healt--;
        if(healt <= 0 ){
            BlockNumbers -=1;
            Destroy(gameObject);
            gm.AfterScene();
        }
    }
}
