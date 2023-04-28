using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private Difficulty levelDifficulty;
        Foe[] roomFoes;

        public GameLevel(int roomCount, Difficulty levelDifficulty)
        {
            this.levelDifficulty = levelDifficulty;
            roomFoes = new Foe[roomCount];
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            roomFoes[room] = foe;
        }

        public Difficulty GetDifficulty()
        {
            return levelDifficulty;
        }

        public int GetNumRooms()
        {
            return roomFoes.Length;
        }

        public int GetNumFoes()
        {
            return roomFoes.Count(foes => foes != null);
        }

        public void PrintFoes()
        {
            for (int i = 0; i < roomFoes.Length; i++)
            {
                if (roomFoes[i] != null)
                    Console.WriteLine($"Room {i}: {roomFoes[i].GetName()}");
            }
        }
    }
}