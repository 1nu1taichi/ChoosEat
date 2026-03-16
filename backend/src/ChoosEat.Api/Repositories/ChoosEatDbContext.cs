using Microsoft.EntityFrameworkCore;

namespace ChoosEat.Api.Repositories;

public class ChoosEatDbContext(DbContextOptions<ChoosEatDbContext> options) : DbContext(options)
{
}
