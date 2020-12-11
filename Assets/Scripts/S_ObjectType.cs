using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ObjectType : MonoBehaviour
{
    // Tells you whether this gameObject is a disc or tower and it's color
    public bool isDisc; // True is this gameObject is a Disc and false if it is a Tower
    public int objectNum; // Number of Disc/Tower
    public bool isSelected; // True if user has selected this GameObject
    public Stack<int> discStack; // Only for Towers. Contains the disc that are currently in this tower
}
