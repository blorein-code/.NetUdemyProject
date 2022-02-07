using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Contexts
{
    internal class ArticleMapping : IEntityTypeConfiguration<object>
    {
        void IEntityTypeConfiguration<object>.Configure(EntityTypeBuilder<object> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}