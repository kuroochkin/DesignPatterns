using System.Diagnostics;

namespace _Decorator;

//Декоратор логирования
public class PostServiceLoggingDecorator : PostServiceDecorator
{
	public PostServiceLoggingDecorator(IPostService postService)
		: base(postService) { }

	public async override Task<Post?> GetPost(int postId)
	{
		Console.WriteLine($"Обращение к API для получения поста с ID: {postId}");
		var stopwatch = Stopwatch.StartNew();
		try
		{

			var post = await postService.GetPost(postId);
			Console.WriteLine($"Вызов API занял: {stopwatch.ElapsedMilliseconds} ms");
			return post;
		}
		catch (Exception ex)
		{
			Console.WriteLine($"GetPostAsync threw exception: {ex.Message}");
			throw;
		}
		finally
		{
			stopwatch.Stop();
		}
	}
}
