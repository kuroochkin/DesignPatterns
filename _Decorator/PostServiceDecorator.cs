namespace _Decorator;

//Непосредственно декоратор сервиса постов
public abstract class PostServiceDecorator : IPostService
{
	protected readonly IPostService postService;

	public PostServiceDecorator(IPostService postService)
	{
		this.postService = postService;
	}

	public abstract Task<Post?> GetPost(int postId);
}
