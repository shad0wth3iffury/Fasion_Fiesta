using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OutfitGrader : MonoBehaviour {

    public FasionStyle GradedStyle;
    public List<StyleTraits> GradedTraits = new List<StyleTraits>();

    public void TraitChecker(List<ClothingItem> _outfitPieces)
    {
        int pointValue = 0;
        for(int i = 0; i < _outfitPieces.Count; i++)
        {
            ClothingItem piece = _outfitPieces[i];
            if(piece.MyStyle == GradedStyle)
            {
                pointValue += 500;
            }

            int traitCheckValue = TraitCheckLoop(piece);
            pointValue += traitCheckValue;

        }

    }

    int TraitCheckLoop(ClothingItem _piece)
    {
        int tempTraitCheckValue = 0;
        for (int j = 0; j < GradedTraits.Count; j++)
        {
            for (int k = 0; k < _piece.myStyleTraits.Count; k++)
            {
                if (_piece.myStyleTraits[k] == GradedTraits[j])
                {
                    tempTraitCheckValue += 100;
                    break;
                }
            }
        }
        return tempTraitCheckValue;
    }
}
