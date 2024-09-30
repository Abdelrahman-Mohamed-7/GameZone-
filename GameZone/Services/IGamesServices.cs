using GameZone.ViewModel;

namespace GameZone.Services
{
    public interface IGamesService
    {
        IEnumerable<Game> GetAll();
        Game? GetById(int id);
        Task Create(GameFormViewModel model);
        Task<Game?> Update(EditGameViewModel model);
        bool Delete(int id);

    }
}
