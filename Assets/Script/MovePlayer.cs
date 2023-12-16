using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 50f;
    public Button downButton;
    public Button upButton;
    public Button rightButton;
    public Button leftButton;
    

    void Start()
    {
        downButton.onClick.AddListener(DownMove);
        upButton.onClick.AddListener(UpMove);
        rightButton.onClick.AddListener(RightMove);
        leftButton.onClick.AddListener(LeftMove);
    }

    void DownMove()
    {
        // Time.deltaTime  Логика перемещения игрока
        // Например:
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    void UpMove()
    {
        // Логика перемещения игрока
        // Например:
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    void RightMove()
    {
        // Логика перемещения игрока
        // Например:
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    void LeftMove()
    {
        // Логика перемещения игрока
        // Например:
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

}



