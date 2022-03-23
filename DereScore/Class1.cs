using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DereScore
{
    public class Card
    {
        string name;
        ColorType type;
        Rarity rarity;
        int Vocal;
        int Dance;
        int Visual;
        int TotalAppeal
        {
            get
            {
                return Vocal + Dance + Visual;
            }
        }
        int life;

        enum ColorType { CUTE, COOL, PASSION};
        enum Rarity { N, NP, R, RP, SR, SRP, SSR, SSRP};
        enum CenterSkill { BRILLLIANCE, PRINCESS, VOCAL, DANCE, VISUAL, TRIVOICE, TRISTEP, TRIMAKE,
        SKILLUP, TRICOLOR_ABILITY, LIFEUP, CHEER, PRESENT, CHARM, COOL_PASSION, PASSION_COOL};

        CenterSkill cSkill;

        public Boolean isCenterSkillAppliable(Card [] cards)
        {
            switch(cSkill)
            {
                case CenterSkill.PRINCESS:
                case CenterSkill.CHEER:
                    for(int i=0; i< cards.Length; i++)
                    {
                        if (cards[i].type != type)
                            return false;
                    }
                    return true;
                case CenterSkill.TRICOLOR_ABILITY:
                case CenterSkill.TRIMAKE:
                case CenterSkill.TRISTEP:
                case CenterSkill.TRIVOICE:
                    {
                        bool[] has = { false, false, false };
                        has[(int)type] = true;
                        for (int i = 0; i < cards.Length; i++)
                            has[(int)cards[i].type] = true;
                        for (int i = 0; i < has.Length; i++)
                            if (has[i] == false)
                                return false;
                        return true;
                    }
                case CenterSkill.COOL_PASSION:
                case CenterSkill.PASSION_COOL:
                    {
                        bool[] has = { false, false, false};
                        has[(int)type] = true;
                        for (int i = 0; i < cards.Length; i++)
                            has[(int)cards[i].type] = true;
                        return has[(int)ColorType.COOL] && has[(int)ColorType.PASSION];
                    }
                default:
                    return true;
            }
        }

        public int[] ApplyCenterSkill(Card card)
        {
            int[] bonus = new int[6] { 0, 0,0,0,0,0};
            switch (cSkill)
            {
                case CenterSkill.BRILLLIANCE:
                case CenterSkill.DANCE:
                case CenterSkill.VOCAL:
                case CenterSkill.VISUAL:
                case CenterSkill.LIFEUP:

            }

            int rindex = ((int)card.rarity/2)-1;
            for(int i=0; i<6; i++)
            {
                bonus[i] = BonusTable[rindex][(int)cSkill,i];
            }
            return bonus;
        }

        static readonly int[,] BonusTable_R =
        {  
            // R SR SSR
            { 20, 30, 40},      //BRILLIANCE
            { 25, 35, 50},      //PRINCESS
            { 30, 60, 90 },     //VOCAL DANCE VISUAL
            { 30, 60, 90 },     //VOCAL DANCE VISUAL
            { 30, 60, 90 },     //VOCAL DANCE VISUAL
            { 40, 80, 100},
            { 20,30, 40 },       //SKILLUP
            { 0, 0, 50 },       //TRICOLOR_ABILITY
            { 10, 20, 30 },     //LIFEUP
            { 20, 30, 40 },     //CHEER
            { 0, 0, 0 },        //PRESENT
            { 0, 0, 30 },        //CHARM
            { 0, 0, 3530 },        //COOL_PASSION
            { 0, 0, 2530},         //PASSION_COOL
        };
        static readonly int[,] BonusTable_SSR =
        {  
            // VO DA VI LI SK FAN
            { 40, 40, 40, 0, 0, 0},      //BRILLIANCE
            { 50, 50, 50, 0, 0, 0},      //PRINCESS
            { 90, 0, 0, 0, 0, 0},     //VOCAL DANCE VISUAL
            { 0, 90, 0, 0, 0, 0},     //VOCAL DANCE VISUAL
            { 0, 0, 90, 0, 0, 0},     //VOCAL DANCE VISUAL
            { 100, 0, 0, 0, 0, 0},      //TRICOLOR VOICE
            { 0, 100, 0, 0, 0, 0},      //TRICOLOR STEP
            { 0, 0, 100, 0, 0, 0},      //TRICOLOR MAKE
            { 0, 0, 0,  0, 40, 0},       //SKILLUP
            { 0, 0, 0, 0, 50, 0},       //TRICOLOR_ABILITY
            { 0, 0, 0, 30, 0, 0 },     //LIFEUP
            { 0, 0, 0, 40, 0, 0 },     //CHEER
            { 0, 0, 0, 0, 0, 0  },        //PRESENT
            { 0, 0, 0, 0, 0, 30 },        //CHARM
            { 30, 30, 30, 0, 35, 0 },        //COOL_PASSION
            { 30, 30, 30 , 25, 0, 0},         //PASSION_COOL
        };

        internal bool isCenterSkillAppliable(Card[] cards)
        {
            throw new NotImplementedException();
        }

        static readonly int[,] BonusTable_SR =
        {  
            // VO DA VI LI SK FAN
            { 30, 30, 30, 0, 0, 0},      //BRILLIANCE
            { 35, 35, 35, 0, 0, 0},      //PRINCESS
            { 60, 0, 0, 0, 0, 0},     //VOCAL DANCE VISUAL
            { 0, 60, 0, 0, 0, 0},     //VOCAL DANCE VISUAL
            { 0, 0, 60, 0, 0, 0},     //VOCAL DANCE VISUAL
            { 80, 0, 0, 0, 0, 0},      //TRICOLOR VOICE
            { 0, 80, 0, 0, 0, 0},      //TRICOLOR STEP
            { 0, 0, 80, 0, 0, 0},      //TRICOLOR MAKE
            { 0, 0, 0,  0, 30, 0},       //SKILLUP
            { 0, 0, 0, 0, 50, 0},       //TRICOLOR_ABILITY
            { 0, 0, 0, 20, 0, 0 },     //LIFEUP
            { 0, 0, 0, 40, 0, 0 },     //CHEER
            { 0, 0, 0, 0, 0, 0  },        //PRESENT
            { 0, 0, 0, 0, 0, 30 },        //CHARM
            { 30, 30, 30, 0, 35, 0 },        //COOL_PASSION
            { 30, 30, 30 , 25, 0, 0},         //PASSION_COOL
        };
        static readonly int[][,] BonusTable = {BonusTable_R, BonusTable_SR, BonusTable_SSR };
    }
}
