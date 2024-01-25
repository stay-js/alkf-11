using Local;

#region a
var data = ReadData();
#endregion

#region b
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine($"{i + 1}. poszt - készítő: {data[i].Author} likeok: {data[i].Likes}");
}
#endregion

#region c
Console.WriteLine($"\nÖsszesen {data.Sum(x => x.Likes)} like érkezett a posztokra.");
#endregion

#region d
Console.WriteLine($"Átlagosan {data.Average(x => x.Likes)} like érkezett egy posztra.");
#endregion

#region e
var minLikes = data.MinBy(x => x.Likes) ?? new Post("X.Y.", 0);
Console.WriteLine($"A(z) {Array.IndexOf(data, minLikes) + 1}. poszt kapta a legkevesebb likeot, " +
    $"{minLikes.Author} készítette a posztot.");
#endregion

#region f
var maxLikes = data.MaxBy(x => x.Likes) ?? new Post("X.Y.", 0);
Console.WriteLine($"A(z) {Array.IndexOf(data, maxLikes) + 1}. poszt kapta a legtöbb likeot, " +
    $"{maxLikes.Author} készítette a posztot.");
#endregion

#region g
Console.WriteLine();
var postsWithSpecifiedMinLikes = SelectPostsWithSpecifiedMinLike();
Console.WriteLine("Az alábbi posztok érték el a megadott like számot:");
foreach (var (idx, post) in postsWithSpecifiedMinLikes)
{
    Console.WriteLine($"{idx + 1}. poszt  - készítő: {post.Author} likeok: {post.Likes}");
}
#endregion

#region h
Console.WriteLine("\nA következő munkatársaknak nem kell a következő napon poszot írniuk:\n\t- " +
    string.Join("\n\t- ", data.Where(x => x.Likes > 1500).Select(x => x.Author).ToArray()));
#endregion

#region i
Console.WriteLine();
int? likes = FindAuthor();
Console.WriteLine(likes is null
    ? "A megadott munkatárs nem található."
    : $"A megadott munkatárs {likes} likeot kapott.");
#endregion

static Post[] ReadData()
{
    return File.ReadAllLines("like.txt").Select(line =>
    {
        string[] parts = line.Split(';');
        return new Post(parts[0], int.Parse(parts[1]));
    }).ToArray();
}

(int, Post)[] SelectPostsWithSpecifiedMinLike()
{
    Console.Write("Adja meg a minimum like-ok számát: ");
    int minLike = int.Parse(Console.ReadLine() ?? "");

    var posts = new (int, Post)[data.Length];
    int len = 0;

    for (int i = 0; i < posts.Length; i++)
    {
        if (data[i].Likes >= minLike) posts[len++] = (i, data[i]);
    }

    Array.Resize(ref posts, len);

    return posts;
}

int? FindAuthor()
{
    Console.Write("Adja meg a keresett munkatárs nevét: ");
    string[] name = (Console.ReadLine() ?? "").Split();
    string monogram = $"{name[0][0]}.{name[1][0]}.";

    foreach (var item in data)
    {
        if (item.Author == monogram) return item.Likes;
    }

    return null;
}

namespace Local
{
    public record Post(string Author, int Likes);
}