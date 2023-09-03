namespace _Decorator;

public interface IPostService
{
	Task<Post?> GetPost(int postId);
}
