using GameCatalog.Models;

namespace GameCatalog
{
    public static class GameClient
    {
        private static readonly List<Game> games = new()
        {
            new Game()
            {
                Id = 1,
                Name = "Street Fighter II",
                Grenre = "fightting",
                Price = 19.99M,
                ReleaseDate = new DateTime(1991,2,1)
            },
            new Game()
            {
                Id = 2,
                Name = "Firnal Fantasy XIV",
                Grenre = "Roleplaying",
                Price = 59.99M,
                ReleaseDate = new DateTime(2010,9,30)
            },
            new Game()
            {
                Id = 3,
                Name = "Fifa 23",
                Grenre = "Sports",
                Price = 69.99M,
                ReleaseDate = new DateTime(2022,9,27)
            }
        };

        public static Game[] GetGames()
        {
            return games.ToArray();
        }
        public static void AddGame(Game game)
        {
            game.Id = games.Max(game => game.Id) + 1;
            games.Add(game);
        }
        public static Game GetGame(int id)
        {
            return games.Find(game => game.Id == id) ?? throw new Exception("Could not find Game!");
        }
        public static void UpdateGame(Game updategame)
        {
            Game existingGame = GetGame(updategame.Id);
            existingGame.Name = updategame.Name;
            existingGame.Grenre = updategame.Grenre;
            existingGame.Price = updategame.Price;
            existingGame.ReleaseDate = updategame.ReleaseDate;
        }
        public static void DeleteGame(int id)
        {
            Game game = GetGame(id);
            games.Remove(game);
        }
    }
}