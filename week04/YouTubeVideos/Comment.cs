public class Comment
{
    //Public to make possible other classes can access it

    public string Name { get; set; }

    //Storing author's comment

    public string Text { get; set; }

    //Storing content's comment


    //Constructor to initialize new Comment object

    public Comment(string name, string text)
    {
        //Using the notation of Capitalized Name that equals to class property
        //The Lowercase name is parameter passed
        Name = name;
        Text = text;
    }
}