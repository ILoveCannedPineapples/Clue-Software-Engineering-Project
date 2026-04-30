using UnityEngine;

public class FinalEnvelope // Creates murder envelope
{
  public NewCard Person;
  public NewCard Room;
  public NewCard Weapon;

public FinalEnvelope(NewCard FinalPerson, NewCard FinalRoom, NewCard FinalWeapon)
{
   Person = FinalPerson;
   
   Room = FinalRoom;
   
   Weapon = FinalWeapon;

}

public bool Match(NewCard FinalPerson, NewCard FinalRoom, NewCard FinalWeapon)
    {
        return Person == FinalPerson && Room == FinalRoom && Weapon == FinalWeapon;
    }
}
