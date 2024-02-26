using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3pd3.BL
{
    internal class Shiritori
    {
        public List<string> words;
        public bool game_over;

        public Shiritori()
        {
            words = new List<string>();
            game_over = false;
        }

        public List<string> Play(string word)
        {
            if (game_over)
            {
                Console.WriteLine("Game over");
                return null;
            }

            if (words.Count == 0 || word[0] == words[words.Count - 1][1] && !words.Contains(word))
            {
                words.Add(word);
                return words;
            }
            else
            {
                game_over = true;
                Console.WriteLine("Game over");
                return null;
            }
        }

        public string Restart()
        {
            words.Clear();      
            game_over = false; 
            return "Game restarted";
        }
    }
}
