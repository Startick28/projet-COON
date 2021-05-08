using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SongRepository
{
    public struct Song{
        public float bpm;
        public float offset;

        public float[][] notes;

    }

    public static Song song1 = new Song();

    static SongRepository()
    {
        song1.bpm = 89f;
        song1.offset = 3f;
        song1.notes = new float[][] {new float[]{0.5f,46f} , new float[]{1.5f,46f} , new float[]{2.5f,46f} , new float[]{3.5f,48f} , new float[]{4.5f,50f} , new float[]{6.5f,48f},
        new float[]{8.5f,46f} , new float[]{9.5f,50f} , new float[]{10.5f,48f} , new float[]{11.5f,48f} , new float[]{12.5f,46f}, 
        new float[]{17f,46f} , new float[]{18f,46f} , new float[]{19f,46f} , new float[]{20f,48f} , new float[]{21f,50f} , new float[]{23f,48f},
        new float[]{25f,46f} , new float[]{26f,50f} , new float[]{27f,48f} , new float[]{28f,48f} , new float[]{29f,46f},
        new float[]{33f,46f} , new float[]{34f,46f,} , new float[]{35f,46f} , new float[]{36f,48f} , new float[]{37f,50f} , new float[]{39f,48f},
        new float[]{41f,46f} , new float[]{42f,50f} , new float[]{43f,48f} , new float[]{44f,48f} , new float[]{45f,46f},
        new float[]{49f,48f}, new float[]{50f,48f} , new float[]{51f,48f} , new float[]{52f,48f} , new float[]{53f,43f} , new float[]{55f,43f},
        new float[]{57f,48f} , new float[]{58f,46f} , new float[]{59f,44f} , new float[]{60f,43f} , new float[]{61f,41f}, new float[]{66f,46f}, 
        new float[]{67f,46f} , new float[]{68f,46f} , new float[]{69f,48f} , new float[]{70f,50f} ,new float[] {72f,48f},
        new float[]{74f,46f} , new float[]{75f,50f} , new float[]{76f,48f} , new float[]{77f,48f} , new float[]{78f,46f}};

    }
}
