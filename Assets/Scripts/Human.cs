using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Humanoid // INHERITANCE
{
    void Start()
    {
        Init(" Human", 6, 6);// INHERITANCE and Init() is an // ABSTRACTION
    }

    protected override void Insecurity()// POLYMORPHISME
    {
        speech += "\nYou're ok with humans, right?";
    }
}