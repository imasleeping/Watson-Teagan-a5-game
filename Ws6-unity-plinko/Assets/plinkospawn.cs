using TMPro;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class plinkospawn : MonoBehaviour
{
    public Transform player;
    public GameObject ball;
    float speed = 10;
    float timer = 0;
    public TextMeshPro timertext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update()
    {
        float movex = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Debug.Log(player.position.x);
        if (player.position.x > 7.4f)
        {
            player.position = new Vector3(7.39f, player.position.y, player.position.z);
        }
        if (player.position.x < -7.4f)
        {
            player.position = new Vector3(-7.39f, player.position.y, player.position.z);
        }
        player.position += new Vector3(movex,0,0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer <= 0)
            {
               Instantiate(ball, new Vector3(player.position.x, player.position.y - player.localScale.y/1.5f, player.position.z),new Quaternion(0,0,0,0));
                timer = 3;
            }
            
        }
        timer -= Time.deltaTime;
        if (timer >= 0)
        {
        timertext.text = timer.ToString();
        }
        else
        {
            timertext.text = " ";
        }
    }
}
