using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld {
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;
    private static Queue<GameObject> availableTables;
    private static Queue<GameObject> unattendedTables;
    private static Queue<GameObject> pendingOrders;
    private static Queue<GameObject> ordersReady;


    static GWorld() {
        world = new WorldStates();
    }

    private GWorld() {
        world = new WorldStates();
        availableTables = new Queue<GameObject>();
        unattendedTables = new Queue<GameObject>();
        pendingOrders = new Queue<GameObject>();
        ordersReady = new Queue<GameObject>();

        var tables = GameObject.FindGameObjectsWithTag("Table");
        foreach (GameObject t in tables)
            availableTables.Enqueue(t);
        if (tables.Length > 0)
            world.ModifyState("AvailableTables", tables.Length);
    }

    public static GWorld Instance {
        get { return instance; }
    }

    public WorldStates GetWorld() {
        return world;
    }

    public GameObject ReserveTable() {
        try {
            GameObject t = availableTables.Dequeue();
            unattendedTables.Enqueue(t);
            world.ModifyState("AvailableTables", -1);
            world.ModifyState("UnattendedTables", 1);
            return t;
        }
        catch {
            return null;
        }
    }

    public void FreeTable(GameObject t) {
        availableTables.Enqueue(t);
        world.ModifyState("AvailableTables", 1);
    }

    public GameObject GetTable() {
        try {
            var t = unattendedTables.Dequeue();
            world.ModifyState("UnattendedTables", -1);
            return t;
        }
        catch {
            return null;
        }
    }

    public void AddOrder(GameObject t) {
        world.ModifyState("PendingOrders", 1);
        pendingOrders.Enqueue(t);
    }

    public GameObject CookOrder() {
        try {
            var o = pendingOrders.Dequeue();
            world.ModifyState("PendingOrders", -1);
            return o;
        }
        catch {
            return null;
        }
    }

    public void AddCookedOrder(GameObject t) {
        world.ModifyState("OrdersReady", 1);
        ordersReady.Enqueue(t);
    }

    public GameObject GetCookedOrder() {
        try {
            var o = ordersReady.Dequeue();
            world.ModifyState("OrdersReady", -1);
            return o;
        }
        catch {
            return null;
        }
    }
}
