using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCoin : MonoBehaviour
{
    public GameObject ball;
    public GameObject score;
    float size = 0.4f;
    float angle = 0;
    float rotationSpeed = Mathf.PI;
    // Start is called before the first frame update
    void Start()
    {
        InitializeCoin();
    }

    // Update is called once per frame
    void Update()
    {
        angle += (rotationSpeed * Time.deltaTime) % Mathf.PI;
        transform.localScale = new Vector3(Mathf.Cos(angle)*size, size, 1);
    }

    void InitializeCoin() {
        transform.position = new Vector2(Random.Range(-3, 3), Random.Range(-3, 3));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.Equals(ball)) {
            score.GetComponent<UnityEngine.UI.Text>().text = (int.Parse(score.GetComponent<UnityEngine.UI.Text>().text) + 1).ToString();
            InitializeCoin();
        }
    }
}