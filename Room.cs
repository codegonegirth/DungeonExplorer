using System;
using System.Collections.Generic;

public class Room
{
    public string Description { get; set; }
    public Monster Monster { get; set; }
    public Item Item { get; set; }
    public bool Visited { get; set; }

    public Room(string description)
    {
        Description = description;
    }
}