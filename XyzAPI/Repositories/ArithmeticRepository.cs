namespace XyzAPI.Repositories
{
    public class ArithmeticRepository : IArithmeticRepository
    {
        public int GetRandom() => new Random().Next(1, 10);
    }
}
