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
    public static Song song3 = new Song();
    public static Song song4 = new Song();

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



        song3.bpm = 135.15f;
        song3.offset = 3f;
        song3.speedMultiplier = 4;
        song3.notes = new float[][] {new float[]{0f,la1} , new float[]{0.5f,la1} , new float[]{1f,do2} , new float[]{1.5f,la1}, 
        new float[]{2f,ré2}, new float[]{2.5f,la1}, new float[]{3f,mi2},new float[]{3.5f,ré2}, new float[]{4f,do2},
        new float[]{4.5f,do2}, new float[]{5f,mi2}, new float[]{5.5f,do2}, new float[]{6f,sol2}, new float[]{6.5f,do2},
        new float[]{7f,mi2}, new float[]{7.5f,do2}, new float[]{8f,sol1}, new float[]{8.5f,sol1}, new float[]{9f,si1},
        new float[]{9.5f,sol1}, new float[]{10f,do2}, new float[]{10.5f,sol1}, new float[]{11f,ré2}, new float[]{11.5f,do2}, 
        new float[]{12f,fa1}, new float[]{12.5f,fa1}, new float[]{13f,la1}, new float[]{13.5f,fa1}, new float[]{14f,do2}, 
        new float[]{14.5f,fa1}, new float[]{15f,do2}, new float[]{15.5f,si1}, new float[]{16f,la1}, new float[]{16.5f,la1},
        new float[]{17f,do2}, new float[]{17.5f,la1}, new float[]{18f,ré2}, new float[]{18.5f,la1}, new float[]{19f,mi2},
        new float[]{19.5f,ré2}, new float[]{20f,do2}, new float[]{20.5f,do2}, new float[]{21f,mi2}, new float[]{21.5f,do2},
        new float[]{22f,sol2}, new float[]{22.5f,do2}, new float[]{23f,mi2}, new float[]{23.5f,do2}, new float[]{24f,sol1},
        new float[]{24.5f,sol1}, new float[]{25f,si1}, new float[]{25.5f,sol1}, new float[]{26f,do2}, new float[]{26.5f,sol1},
        new float[]{27f,ré2}, new float[]{27.5f,do2}, new float[]{28f,fa1}, new float[]{28.5f,fa1}, new float[]{29f,la1},
        new float[]{29.5f,fa1}, new float[]{30f,do2}, new float[]{30.5f,fa1}, new float[]{31f,do2}, new float[]{31.5f,si1},
        new float[]{32f,la1}, new float[]{32.75f,la1}, new float[]{33.5f,la1}, new float[]{34.25f,la1}, new float[]{35f,sol1},
        new float[]{35.5f,do2}, new float[]{36f,la1}, new float[]{36.75f,la1}, new float[]{37.5f,la1},new float[]{38.25f,la1},
        new float[]{39f,sol1}, new float[]{39.5f,mi1}, new float[]{40f,la1}, new float[]{40.75f,la1}, new float[]{41.5f,la1},
        new float[]{42.25f,la1},new float[]{43f,sol1}, new float[]{43.5f,do2}, new float[]{44f,la1}, new float[]{44.75f,la1},
        new float[]{45.5f,la1},new float[]{46f,la1}, new float[]{46.25f,la1}, new float[]{46.75f,la1}, new float[]{47,la1},
        new float[]{48f,la1,la2}, new float[]{48.75f,la1,la2}, new float[]{49.5f,la1,la2}, new float[]{50.25f,la1,la2},
        new float[]{51f,sol1,sol2}, new float[]{51.5f,do2,do3}, new float[]{52f,la1,la2}, new float[]{52.75f,la1,la2},
        new float[]{53.5f,la1,la2}, new float[]{54.25f,la1,la2}, new float[]{55f,sol1,sol2}, new float[]{55.5f,mi2,mi1},
        new float[]{56f,la1,la2}, new float[]{56.75f,la1,la2}, new float[]{57.5f,la1,la2}, new float[]{58.25f,la1,la2}, 
        new float[]{59f,sol1,sol2}, new float[]{59.5f,do2,do3}, new float[]{60f,la1,la2}, new float[]{60.75f,la1,la2},
        new float[]{61.5f,la1,la2}, new float[]{62f,la1,la2}, new float[]{62.25f,la1,la2}, new float[]{62.75f,la1,la2},
        new float[]{63f,la1,la2},
        new float[]{64f,la1}, new float[]{64.25f,mi2}, new float[]{64.75f,la1}, new float[]{65f,do2}, new float[]{65.5f,la1},
        new float[]{65.75f,37f}, new float[]{66.25f,la1}, new float[]{66.5f,do2}, new float[]{67f,la1}, new float[]{67.25f,si1},
        new float[]{67.5f,sol1}, new float[]{68f,la1}, new float[]{68.25f,mi2}, new float[]{68.75f,la1}, new float[]{69f,do2},
        new float[]{69.5f,la1}, new float[]{69.75f,37f}, new float[]{70.25f,la1}, new float[]{70.5f,do2}, new float[]{71f,la1},
        new float[]{71.25f,si1}, new float[]{71.5f,sol1}, new float[]{72f,la1}, new float[]{72.25f,mi2}, new float[]{72.75f,la1},
        new float[]{73f,do2}, new float[]{73.5f,la1}, new float[]{73.75f,37f}, new float[]{74.25f,la1}, new float[]{74.5f,do2},
        new float[]{75f,la1}, new float[]{75.25f,si1}, new float[]{75.75f,sol1}, new float[]{76f,la1}, new float[]{76.25f,mi2},
        new float[]{76.75f,la1}, new float[]{77f,do2}, new float[]{77.5f,sol1}, new float[]{77.75f,sol1}, new float[]{78.25f,sol1},
        new float[]{78.5f,la1}, new float[]{79f,la1},
        new float[]{80f,la2}, new float[]{80.25f,mi3}, new float[]{80.75f,la2}, new float[]{81f,do3}, new float[]{81.5f,la2},
        new float[]{81.75f,49f}, new float[]{82.25f,la2}, new float[]{82.5f,do3}, new float[]{83f,la2}, new float[]{83.25f,si2},
        new float[]{83.5f,sol2}, new float[]{84f,la2}, new float[]{84.25f,mi3}, new float[]{84.75f,la2}, new float[]{85f,do3},
        new float[]{85.5f,la2}, new float[]{85.75f,49f}, new float[]{86.25f,la2}, new float[]{86.5f,do3}, new float[]{87f,la2},
        new float[]{87.25f,si2}, new float[]{87.5f,sol2}, new float[]{88f,la2}, new float[]{88.25f,mi3}, new float[]{88.75f,la2},
        new float[]{89f,do3}, new float[]{89.5f,la2}, new float[]{89.75f,49f}, new float[]{90.25f,la2}, new float[]{90.5f,do3},
        new float[]{91f,la2}, new float[]{91.25f,si2}, new float[]{91.75f,sol2}
        };

        song4.bpm = 128.12f;
        song4.offset = 3.2f;
        song4.speedMultiplier = 1.1f;
        song4.notes = new float[][] {
        new float[]{32f,ré2,fa2,la2},new float[]{40f,fa2,la2,do3},new float[]{44f,40f,mi2,la2},
        new float[]{48f,ré2,fa2,la2},new float[]{56f,37f,ré2,fa2},new float[]{60f,40f,mi2,la2},

        new float[]{64f,ré2,fa2,la2},new float[]{72f,fa2,la2,do3},new float[]{76f,40f,mi2,la2},
        new float[]{80f,ré2,fa2,la2},new float[]{88f,37f,ré2,fa2},new float[]{92f,40f,mi2,la2},new float[]{95f,40f},new float[]{95.5f,mi2},

        new float[]{96f,ré2,fa2,la2},new float[]{98f,ré2},new float[]{103f,mi2},new float[]{104f,fa2,la2,do3},new float[]{108f,40f,mi2,la2},new float[]{111f,mi2},
        new float[]{112f,ré2,fa2,la2},new float[]{119f,la1},new float[]{120f,37f,ré2,fa2,49f}, new float[]{124f,40f,mi2,la2},

        new float[]{128f,ré2,fa2,la2},new float[]{135f,mi2},new float[]{136f,fa2,la2,do3},new float[]{139f,la2},new float[]{140f,40f,mi2,la2},new float[]{143f,mi2},
        new float[]{144f,ré2,fa2,la2},new float[]{151f,la1},new float[]{152f,37f,ré2,fa2,49f},new float[]{155f,do3}, new float[]{156f,40f,mi2,la2},new float[]{159f,40f},new float[]{159.5f,mi2},

        new float[]{160f,ré2,fa2,la2},new float[]{162f,ré2},new float[]{167f,mi2},new float[]{168f,fa2,la2,do3},new float[]{171f,la2},new float[]{172f,40f,mi2,la2},new float[]{175f,mi2},
        new float[]{176f,ré2,fa2,la2},new float[]{183f,la1},new float[]{184f,37f,ré2,fa2,49f},new float[]{187f,do3}, new float[]{188f,40f,mi2,la2},
        new float[]{192f,ré2,fa2,la2}

        
        
        };
    }
}
