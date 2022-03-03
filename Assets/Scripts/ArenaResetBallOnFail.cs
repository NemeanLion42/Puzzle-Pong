using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaResetBallOnFail : MonoBehaviour
{
    public GameObject ball;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.Equals(ball)) {
            ball.GetComponent<ControlBall>().Reset();
            score.GetComponent<UnityEngine.UI.Text>().text = "0";
        }
    }
}