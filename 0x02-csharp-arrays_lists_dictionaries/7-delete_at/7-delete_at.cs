﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList.Count - 1 < index || index < 0){
            Console.WriteLine("Index is out of range");
            return myList;
        }
        myList.Remove(myList[index]);
        return myList;
        
    }
}
