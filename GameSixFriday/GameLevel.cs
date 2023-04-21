using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private int roomCount;
        private Difficulty levelDifficulty;
        Foe[] roomFoes;
        int foeCount;

        public GameLevel(int roomCount, Difficulty levelDifficulty)
        {
            this.roomCount = roomCount;
            this.levelDifficulty = levelDifficulty;
            roomFoes = new Foe[roomCount];
            foeCount = 0;
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            roomFoes[room-1] = foe;
            foeCount++;
        }

        public Difficulty GetDifficulty()
        {
            return levelDifficulty;
        }

        public int GetNumRooms()
        {
            return roomCount;
        }

        public int GetNumFoes()
        {
            return foeCount;
        }

        public void PrintFoes()
        {
            for (int i = 0; i < roomCount; i++)
            {
                if (roomFoes[i] != null)
                    Console.WriteLine($"Room {i + 1}: {roomFoes[i].GetName()}");
            }
        }
    }
}