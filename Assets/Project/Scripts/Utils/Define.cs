using UnityEngine;

namespace DongleSuika
{
    public static class Define
    {
        public enum eSound
        {
            BGM,
            EFFECT,
            MAX_COUNT,
        }

        public enum eScene
        {
            UNKNOWN,
            LOADING_SCENE,
            INTRO,
            LOBBY,
            DEMO,
            GAME
        }
    }
}
