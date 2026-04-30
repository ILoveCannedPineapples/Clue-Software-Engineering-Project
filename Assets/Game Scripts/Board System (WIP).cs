using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Board : MonoBehaviour
{

    [System.Serializable]
    public class Room
    {
        public string   roomName;          
        public NewCard  roomCard;           
        
        public int[]    neighbourIndices;
    }

    public List<Room> rooms = new List<Room>();

    public Dictionary<NewCard, Room> cardToRoom = new Dictionary<NewCard, Room>();

    private void Awake()
    {
    
        foreach (var r in rooms)
        {
            if (r.roomCard != null)
                cardToRoom[r.roomCard] = r;
        }
    }
 public Room GetRoomByCard(NewCard card)
    {
        cardToRoom.TryGetValue(card, out var room);
        return room;
    }

    
    public bool AreNeighbours(Room from, Room to)
    {
        if (from == null || to == null) return false;
        // neighbourIndices stores the indices of rooms that can be reached in one move.
        foreach (int idx in from.neighbourIndices)
        {
            if (idx >= 0 && idx < rooms.Count && rooms[idx] == to)
                return true;
        }
        return false;
    }
}