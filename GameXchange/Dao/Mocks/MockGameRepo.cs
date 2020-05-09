using GameXchange.Dao.Interface;
using GameXchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameXchange.Dao.Mocks
{
    public class MockGameRepo : IGameRepo
    {

        private readonly ICategoryRepo _categoryRepo = new MockCategoryRepo();

        public IEnumerable<GameInfo> GameInfos
        {
            get
            {
                return new List<GameInfo>
                {
                    new GameInfo {
                        Name = "Devil May Cry 5",
                        GamePrice = 7.95M,
                        GameDescription = "The Devil you know returns in this brand new entry in the over-the-top action series available on the PC.",
                        Category = _categoryRepo.GameCategories.First(),
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg",
                        GameQuantity = true,
                        ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg"
                    },
                    //new GameInfo {
                    //    Name = "Devil May Cry",
                    //    GamePrice = 7.95M,
                    //    GameDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                    //    Category = _categoryRepo.GameCategories.First(),
                    //    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg",
                    //    GameQuantity = true,
                    //    ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg"
                    //},
                    // new GameInfo {
                    //    Name = "Devil May Cry",
                    //    GamePrice = 7.95M,
                    //    GameDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                    //    Category = _categoryRepo.GameCategories.First(),
                    //    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg",
                    //    GameQuantity = true,
                    //    ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg"
                    //},
                    //  new GameInfo {
                    //    Name = "Devil May Cry",
                    //    GamePrice = 7.95M,
                    //    GameDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                    //    Category = _categoryRepo.GameCategories.First(),
                    //    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg",
                    //    GameQuantity = true,
                    //    ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg"
                    //},
                    //   new GameInfo {
                    //    Name = "Devil May Cry",
                    //    GamePrice = 7.95M,
                    //    GameDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                    //    Category = _categoryRepo.GameCategories.First(),
                    //    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg",
                    //    GameQuantity = true,
                    //    ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/c/cb/Devil_May_Cry_5.jpg"
                    //}

                };
            }
        }


        IEnumerable<GameInfo> GamePrices { get; set; }
        IEnumerable<GameInfo> IGameRepo.GamePrices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IEnumerable<GameInfo> IGameRepo.GameInfos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GameInfo GetGameById(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
