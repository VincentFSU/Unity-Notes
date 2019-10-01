using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements
{
    private static Achievements _main = new Achievements(); //singleton
    public static Achievements main
    {
        get
        {
            return _main;
        }
        private set
        {
            _main = value;
        }
    }

    Dictionary<int, bool> achievements = new Dictionary<int, bool>();

    private Achievements()
    {

    }

    public void Unlock(int num)
    {
        achievements[num] = true;
    }

    /*
    class Enemy
    {
        public float health = 100;
        static public float maxHealth = 100;
        static public List<Enemy> enemies = new List<Enemy>();


        static public Enemy NewEnemy()
        {
            Enemy e = new Enemy();
            enemies.Add(e);
            return e;
        }
    }

    void Func()
    {
        Enemy e = Enemy.NewEnemy();
        e.health = 50;
        e.health = Enemy.maxHealth;

        List<Enemy> enemiesInScene = Enemy.enemies;
    }
    */
}