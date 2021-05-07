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
        song1.notes = new float[][] {new float[]{0f,46f} , new float[]{1f,46f,} , new float[]{2f,46f} , new float[]{3f,48f} , new float[]{4f,50f} , new float[]{6f,48f},
        new float[]{8f,46f} , new float[]{9f,50f} , new float[]{10f,48f} , new float[]{11f,48f} , new float[]{12f,46f}, new float[]{16f,46f} , new float[]{17f,46f} , new float[]{18f,46f} , new float[]{19f,48f} , new float[]{20f,50f} , new float[]{22f,48f},
        new float[]{24f,46f} , new float[]{25f,50f} , new float[]{26f,48f} , new float[]{27f,48f} , new float[]{28f,46f},
        new float[]{32f,46f} , new float[]{33f,46f,} , new float[]{34f,46f} , new float[]{35f,48f} , new float[]{36f,50f} , new float[]{38f,48f},
        new float[]{40f,46f} , new float[]{41f,50f} , new float[]{42f,48f} , new float[]{43f,48f} , new float[]{44f,46f},
        new float[]{48f,48f}, new float[]{49f,48f} , new float[]{50f,48f} , new float[]{51f,48f} , new float[]{52f,43f} , new float[]{54f,43f},
        new float[]{56f,48f} , new float[]{57f,46f} , new float[]{58f,44f} , new float[]{57f,43f} , new float[]{60f,41f}, new float[]{64f,46f}, new float[]{65f,46f} , new float[]{66f,46f} , new float[]{67f,48f} , new float[]{68f,50f} ,new float[] {70f,48f},
        new float[]{72f,46f} , new float[]{73f,50f} , new float[]{74f,48f} , new float[]{75f,48f} , new float[]{76f,46f}};

    }
}
