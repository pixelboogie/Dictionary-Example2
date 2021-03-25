using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
   
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    void Start()
    {
        Item sword = new Item();
        sword.id = 0;
        sword.name = "sword";

        Item bread = new Item();
        bread.id = 1;
        bread.name = "bread";

        Item cape = new Item();
        cape.id = 2;
        cape.name = "cape";        

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);


        // prints keys and values
         Debug.Log("*** Prints keys and values  ***");

        foreach(KeyValuePair<int, Item>item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key + ", Value: " + item.Value.name);
        }

        // prints the key only
        Debug.Log("*** prints the key only  ***");

        foreach(int key in itemDictionary.Keys)
        {
            Debug.Log("Key: " + key);
        }

        // prints the name only
        Debug.Log("*** prints the name only ***");

        foreach(Item item in itemDictionary.Values)
        {
            Debug.Log("Name: " + item.name);
        }

        // check if key is found
        Debug.Log("*** check if key is found  ***");

        if(itemDictionary.ContainsKey(1))
        {
            Debug.Log("Key found!");
            var randomItem = itemDictionary[1];
        }else{
            Debug.Log("Key not found");
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var player1 = itemDictionary[0];
            Debug.Log("Player name: " + player1.name);
        }
    }



}


