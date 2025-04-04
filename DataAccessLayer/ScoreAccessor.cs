using GameObjects;

namespace DataAccessLayer
{
    public class ScoreAccessor
    {
        public bool SavePlayer(Player player)
        {
            bool isSaved = false;

            try
            {
                writeScores(player);
                writeList(player);
                isSaved = true;
            }
            catch (Exception)
            {
                throw;
            }
            return isSaved;
        }
        private void writeScores(Player player)
        {
            using (StreamWriter writer =
                new StreamWriter(AppData.DataPath + player))
            {
                writer.WriteLine(player.Name);
                writer.WriteLine(player.Score);
            }
            return;
        }

        private void writeList(Player player)
        {
            List<Player> players = GetPlayerList();
            bool found = false; 

            for (int i = 0; i < players.Count; i++)
            { 
                if (player == players[i])
                {
                    players[i] = player;
                    found = true; 
                    break;
                }
            }
            if (found == false)
            {
                players.Add(player);  
            }

            players = players.OrderByDescending(p => p.Score).ToList();

            // save the list
            using (StreamWriter writer =
                new StreamWriter(AppData.DataPath + "pastPlayers.csv"))
            {
                writer.WriteLine("NAME, SCORE");
                foreach (Player p in players)
                {
                    writer.WriteLine(p.Name + "," +
                                     p.Score);
                }
            }
            return;
        }

        public List<Player> GetPlayerList()
        {
            List<Player> players = new List<Player>();

            char[] separator = { ',' };

            using (StreamReader reader = new StreamReader(AppData.DataPath + "pastPlayers.csv"))
            {
                reader.ReadLine(); // throw away the header line

                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts;

                    if (line.Length > 0)
                    {
                        parts = line.Split(separator);
                        if (parts.Count() == 2)
                        {
                            Player player = new Player();
                            player.Name = parts[0];
                            player.Score = parts[1];
                            players.Add(player);
                        }
                    }
                }
            }
            return players;
        }
    }
}
