namespace BrightApp.Entity.Exceptions
{
    public sealed class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException(int id) : base($"It's could Not Found id:{id}")
        {
        }

  
    }
}
