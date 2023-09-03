namespace _Decorator;

//Декоратор кэширования поста
public class PostServiceCacheDecorator : PostServiceDecorator
{
	private readonly Dictionary<int, Post> cache;

	public PostServiceCacheDecorator(IPostService postService) : base(postService)
	{
		cache = new Dictionary<int, Post>();
	}

	public async override Task<Post?> GetPost(int postId)
	{
		// get post from the cache
		if (cache.TryGetValue(postId, out var post))
		{
			// demo purpose 
			Console.WriteLine($"Получение поста ID: {postId} из кеша");
			return post;
		}

		// otherwise call the API
		post = await postService.GetPost(postId);
		if (post != null)
		{
			cache[postId] = post;
		}
		return post;

	}
}
