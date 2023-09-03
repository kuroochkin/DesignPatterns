using _Decorator;

public class Program
{
	public static async Task Main(string[] args)
	{
		var postServiceCache = new PostServiceCacheDecorator(
			new PostServiceLoggingDecorator(
				new PostService()));
		
		//IPostService postService = new PostService();
		//var postServiceLogging = new PostServiceLoggingDecorator(postService);
		
		//var postServiceCache = new PostServiceCacheDecorator(postServiceLogging);
		try
		{
			//Поста еще нет в кеше
			var post = await postServiceCache.GetPost(1);
			Console.WriteLine(post);

			//Вызываем запрос снова, этот же самый пост уже будет в кеше
			Console.WriteLine("Отправляем запрос снова, зная, что пост уже в кеше:");
			post = await postServiceCache.GetPost(1);
			Console.WriteLine(post);
		}
		catch (Exception)
		{
			throw;
		}
	}

}