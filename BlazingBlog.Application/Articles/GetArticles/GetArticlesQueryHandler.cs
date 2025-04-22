using BlazingBlog.Domain.Articles;
using MediatR;

namespace BlazingBlog.Application.Articles.GetArticles
{
    public class GetArticlesQueryHandler(IArticleRepository articleRepository) : IRequestHandler<GetArticlesQuery, List<Article>>
    {
        private readonly IArticleRepository _articleRepository = articleRepository;

        /*public GetArticlesQueryHandler(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }            */

        public async Task<List<Article>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            var articles = await _articleRepository.GetAllArticlesAsync();
            return articles;
        }
    }
}
