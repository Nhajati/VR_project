using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// TODO: Put health hearts into play, and disable one when the robot crashes into the character.

namespace IGS520b.starter.SampleGame
{    
    public class GameManager : MonoBehaviour
    {
        // [Tooltip("Distance to move before game starts.")]
        // [Range(0.0f, 5f)]
        // public float startDistance;
        // [Tooltip("Game time limit in seconds.")]
        // public int timeLimit = 120;

        [Tooltip("Points text.")]
        public TextMeshProUGUI pointsText;
        private int pointCounter;

        public void AddPointToCounter(){
            pointCounter ++;
        }

        void Start(){
            pointCounter = 0;
        }

        void Update(){
            if(pointCounter >= 12){
                // Game ends
            }
        }
        
    }
}
