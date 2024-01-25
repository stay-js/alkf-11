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
Console.WriteLine($"\nÖsszesen {SumOfLikes()} like érkezett a posztokra.");
#endregion

#region d
Console.WriteLine($"Átlagosan {AvgLikes()} like érkezett egy posztra.");
#endregion

#region e
int minLikesId = MinLikes();
Console.WriteLine($"A(z) {minLikesId + 1}. poszt kapta a legkevesebb likeot, " +
                  $"{data[minLikesId].Author} készítette a posztot.");
#endregion

#region f
int maxLikesId = MaxLikes();
Console.WriteLine($"A(z) {maxLikesId + 1}. poszt kapta a legtöbb likeot, " +
                  $"{data[maxLikesId].Author} készítette a posztot.");
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
    string.Join("\n\t- ", AuthorsWithMin1500Like()));
#endregion

#region i
Console.WriteLine();
Console.WriteLine(FindAuthor(out int likes)
    ? $"A megadott munkatárs {likes} likeot kapott."
    : "A megadott munkatárs nem található.");
#endregion

static Post[] ReadData()
{
    return File.ReadAllLines("like.txt").Select(line =>
    {
        string[] parts = line.Split(';');
        return new Post(parts[0], int.Parse(parts[1]));
    }).ToArray();
}

int SumOfLikes()
{
    int sum = 0;

    foreach (var item in data)
    {
        sum += item.Likes;
    }

    return sum;
}

double AvgLikes()
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Likes;
    }

    return sum / data.Length;
}

int MinLikes()
{
    int min = 0;
    
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Likes < data[min].Likes) min = i;
    }

    return min;
}

int MaxLikes()
{
    int max = 0;
    
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Likes > data[max].Likes) max = i;
    }

    return max;
}

(int, Post)[] SelectPostsWithSpecifiedMinLike()
{
    Console.Write("Adja meg a minimum like-ok számát: ");
    int minLike = int.Parse(Console.ReadLine() ?? "");

    var posts = new (int, Post)[data.Length];
    int len = 0;

    for (int i = 0; i < posts.Length; i++ )
    {
        if (data[i].Likes >= minLike) posts[len++] = (i, data[i]);
    }
    
    Array.Resize(ref posts, len);

    return posts;
}

string[] AuthorsWithMin1500Like()
{
    return data.Where(x => x.Likes > 1500).Select(x => x.Author).ToArray();
}

bool FindAuthor(out int likes)
{
    Console.Write("Adja meg a keresett munkatárs nevét: ");
    string[] name = (Console.ReadLine() ?? "").Split();
    string monogram = $"{name[0][0]}.{name[1][0]}.";

    likes = -1;
    
    foreach (var item in data)
    {
        if (item.Author != monogram) continue;

        likes = item.Likes;
        return true;
    }

    return false;
}

namespace Local
{
    public record Post(string Author, int Likes);
}