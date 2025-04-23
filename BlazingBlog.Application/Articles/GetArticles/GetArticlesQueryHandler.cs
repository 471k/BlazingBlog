using BlazingBlog.Domain.Articles;
using Mapster;
using MediatR;

namespace BlazingBlog.Application.Articles.GetArticles
{
    public class GetArticlesQueryHandler(IArticleRepository articleRepository) : IRequestHandler<GetArticlesQuery, List<ArticleResponse>>
    {
        private readonly IArticleRepository _articleRepository = articleRepository;

        /*public GetArticlesQueryHandler(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }            */

        public async Task<List<ArticleResponse>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            var articles = await _articleRepository.GetAllArticlesAsync();
            return articles.Adapt<List<ArticleResponse>>();
        }
    }
}
