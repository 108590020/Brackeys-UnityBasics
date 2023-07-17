using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    //public Text scoreText;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        scoreText.text = player.position.z.ToString("F0");
    }
}
