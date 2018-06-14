using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FasionStyle
{
    None, Victorian, Tutor, PinUp
}

public enum StyleTraits
{
    Trait1, Trait2, Trait3, Trait4, Trait5, Trait6, Trait7, Trait8, Trait9
}

public enum ClothingPosition
{
    Hat, Top, Bottom, Feet
}

public class ClothingItem : MonoBehaviour {

    public Texture DisplayImage;
    public Texture ModelImage;
    public ClothingPosition MyPosition;
    public FasionStyle MyStyle = FasionStyle.None;
    public List<StyleTraits> myStyleTraits = new List<StyleTraits>();
}
