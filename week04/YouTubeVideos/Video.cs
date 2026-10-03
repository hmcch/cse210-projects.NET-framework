using System;
//To have access to use Lists
using System.Collections.Generic;

public class Video
{
    // Here the Attributes for the video class
    public string Title { get; set; }
    // Keeping title's track

    public string Author { get; set; }
    // Keeping author's track

    public int Length { get; set; }
    // Keeping timing's track (in seconds)


    // A Private list to hold Comment objects

    private List<Comment> _comments = new List<Comment>();

    // Constructor starting new Video object along basic information

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // Method appending new comment inside list

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Returns total comments amount

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to let Program.cs has access to the comments list and loop through it(the list by itself is private type)

    public List<Comment> GetComments()
    {
        return _comments;
    }

}