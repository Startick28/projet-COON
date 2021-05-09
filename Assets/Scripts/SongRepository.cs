using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SongRepository
{
    public struct Song{
        public float bpm;
        public float offset;

        public float[][] notes;
        public float speedMultiplier;
        public static Song song1 = new Song();
        public static Song song2 = new Song();
        }

        public static float do1 = 27f; public static float ré1 = 29f; public static float mi1 = 31f; 
        public static float fa1 = 32f; public static float sol1 = 34f; public static float la1 = 36f; public static float si1 = 38f;
        public static float do2 = 39f; public static float ré2 =  41f; public static float mi2 = 43f ;
        public static float fa2 = 44f;  public static float sol2 = 46f; public static float la2 = 48f;
        public static float si2 = 50f; public static float do3 = 51f; public static float ré3 = 53f;
        public static float mi3 = 55f; public static float fa3 = 56f; public static float sol3 = 58f; 
        public static float la3 = 60f; public static float si3 = 62f; 


    

    public static Song song1 = new Song();
    public static Song song2 = new Song();

    static SongRepository()
    {
        song1.bpm = 89f;
        song1.offset = 3f;
        song1.speedMultiplier = 1;
        song1.notes = new float[][] {new float[]{0.5f,43f} , new float[]{1.5f,43f} , new float[]{2.5f,43f} , new float[]{3.5f,45f} , new float[]{4.5f,47f} , new float[]{6.5f,45f},
        new float[]{8.5f,43f} , new float[]{9.5f,47f} , new float[]{10.5f,45f} , new float[]{11.5f,45f} , new float[]{12.5f,43f}, 
        new float[]{17f,43f} , new float[]{18f,43f} , new float[]{19f,43f} , new float[]{20f,45f} , new float[]{21f,47f} , new float[]{23f,45f},
        new float[]{25f,43f} , new float[]{26f,47f} , new float[]{27f,45f} , new float[]{28f,45f} , new float[]{29f,43f} ,
        new float[]{33f,43f} , new float[]{34f,43f} , new float[]{35f,43f} , new float[]{36f,45f} , new float[]{37f,47f} , new float[]{39f,45f},
        new float[]{41f,43f} , new float[]{42f,47f} , new float[]{43f,45f} , new float[]{44f,45f} , new float[]{45f,43f} ,
        new float[]{49f,45f} , new float[]{50f,45f} , new float[]{51f,45f} , new float[]{52f,45f} , new float[]{53f,40f} , new float[]{55f,40f},
        new float[]{57f,45f} , new float[]{58f,43f} , new float[]{59f,41f} , new float[]{60f,40f} , new float[]{61f,38f} , new float[]{66f,43f}, 
        new float[]{67f,43f} , new float[]{68f,43f} , new float[]{69f,45f} , new float[]{70f,47f} ,new float[] {72f,45f} ,
        new float[]{74f,43f} , new float[]{75f,47f} , new float[]{76f,45f} , new float[]{77f,45f} , new float[]{78f,43f}};
   

        

        

        song2.bpm = 107f;
        song2.offset = 3f;
        song2.speedMultiplier = 2;
        song2.notes = new float[][] {new float[]{0f,fa1,ré1} , new float[]{0.75f, fa3} , new float[]{1f,mi3} , 
        new float[]{1.25f,fa3} , new float[]{1.5f,ré3} , new float[]{2.25f,fa3} , new float[]{2.5f,mi3},
        new float[]{2.75f,fa3} , new float[]{3f,si2} , new float[]{4f,sol1,ré1} , new float[]{8f,do1,mi1} , new float[]{8.75f,mi3},
        new float[]{9f,ré3} , new float[]{9.25f,mi3} , new float[]{9.5f,do3} , new float[]{10.25f,mi3} , new float[]{10.5f,ré3} ,
        new float[]{10.75f,mi3}, new float[]{11f,la2} , new float[]{12f,do1} , new float[]{16f,fa1,ré1} , new float[]{16.75f,fa3} ,
        new float[]{17f,mi3}, new float[]{17.25f,fa3} , new float[]{17.5f,ré3} , new float[]{18.25f,fa3} , new float[]{18.5f,mi3} ,
        new float[]{18.75f,fa3} , new float[]{19f,si2}, new float[]{20f,ré1,sol1} , new float[]{24f,do1,mi1} , new float[]{24.75f,mi3} ,
        new float[]{25f,ré3} , new float[]{25.25f,mi3}, new float[]{25.5f,do3}, new float[]{25.75f,mi3} , new float[]{26f,si2} , 
        new float[]{26.25f,mi3} , new float[]{26.5f,la2} , new float[]{28f,do1},

        new float[]{32f,fa1,ré1} , new float[]{32.75f, fa3,la3} , new float[]{33f,mi3,sol3} , 
        new float[]{33.25f,fa3,la3} , new float[]{33.5f,ré3,fa3} , new float[]{34.25f,fa3,la3} , new float[]{34.5f,mi3,sol3},
        new float[]{34.75f,fa3,la3} , new float[]{35f,si2,ré3} , new float[]{36f,sol1,ré1} , new float[]{40f,do1,mi1} , new float[]{40.75f,mi3,sol3},
        new float[]{41f,ré3,fa3} , new float[]{41.25f,mi3,sol3} , new float[]{41.5f,do3,mi3} , new float[]{42.25f,mi3,sol3} , new float[]{42.5f,ré3,fa3} ,
        new float[]{42.75f,mi3,sol3}, new float[]{43f,la2,do3} , new float[]{44f,do1} , new float[]{48f,fa1,ré1} , new float[]{48.75f,ré3,fa3} ,
        new float[]{49f,do3,mi3}, new float[]{49.25f,ré3,fa3} , new float[]{49.5f,si2,ré3} , new float[]{50.25f,ré3,fa3} , new float[]{50.5f,do3,mi3} ,
        new float[]{50.75f,ré3,fa3} , new float[]{51f,sol2,si2}, new float[]{52f,ré1,sol1} , new float[]{56f,do1,mi1} , new float[]{56.75f,do3,mi3} ,
        new float[]{57f,si2,ré3} , new float[]{57.25f,do3,mi3}, new float[]{57.5f,la2,do3}, new float[]{57.75f,do3,mi3} , new float[]{58f,fa2,si2} , 
        new float[]{58.25f,do3,mi3} , new float[]{58.5f,mi2,la2}};

    }
}
