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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        player.position = new Vector3(Input.mousePosition.x /80, player.position.y, player.position.z);
        if (Input.GetMouseButtonDown(1))
        {
           Instantiate(ball, new Vector3(player.position.x, player.position.y - player.localScale.y/1.5f, player.position.z),new Quaternion(0,0,0,0));
        }
    }
}
