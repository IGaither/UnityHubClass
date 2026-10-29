using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int healthpoints;
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);
    }

    // Update is called once per frame
    void Update()
    {

    }
    int UsePotion(int health)
    {
    health = health + 400;
    return health;
    }
}