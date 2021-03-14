using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int health;
    private int currentHealth;
    public Texture2D enemyArrow;
    public Texture2D cursorArrow;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        }
    }

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;

        // Test
        Cursor.SetCursor(enemyArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    
}
