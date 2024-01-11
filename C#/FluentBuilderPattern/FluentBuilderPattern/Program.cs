using FluentBuilderPattern;

SocialMediaPost post =new SocialMediaPostBuilder()
                          .AddTittle ("The Builder Pattern")
                          .AddContent("Add the defination of builder")
                          .AddAuthor("Divya")
                          .AddTag("C#")
                          .AddLink(new Uri("https://somelink"))
                          .SetPostDate(System.DateTime.Now)
                          .Build();

Console.WriteLine (post.ToString ());
