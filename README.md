# Blazor Dad Jokes

This was created just for enjoyment.  There are a couple of Blazor actions that were needed, but overall it is fairly straight forward to implement.


by [David Gallivan](http://twitter.com/CodingwithDavid)


## Why

This was inspired by Brad at Traversy Media, see link below.  He has a ton of great web videos and courses.  You should check them out.

This is an entertaining project that just felt goos to do.  It randomly gets Dad jokes and display them.  In addition, it will randomly change the dad graphic.

## Getting Started

1. Clone this repository

   ```Command Line
   git clone https://github.com/CodingWithDavid/BlazorDadJokes
   cd BlazorDadJokes
   ```

1.	Open in Visual Studio or Visual Code
a.	With Visual Code you will need to install the C# extensions
b.  With Visual Code you will need to install the Blazor extensions
2.	Press F5

## What's in the App

It is literally a single page.  

1. I make an API call to a service to get the actual joke
2. I take the response of the call and pull out the joke string.
3. I did have to set the media type in the http client request to application/json
4. I created a random number generator that pick the dad image to show.
5. There is a "get Another Joke" button that has an onclick event.

That was about it.

## Deployment

The application was deployed as an Azure Static Website with a custom domain.

## Problems or Suggestions

[Open an issue here]( https://github.com/CodingWithDavid/BlazorDadJokes/issues)

## Thank You


## Resources

- [Traversy Media](https://www.youtube.com/channel/UC29ju8bIPH5as8OGnQzwJyA)
- [Blazor Azure static websites](https://docs.microsoft.com/en-us/azure/static-web-apps/deploy-blazor)
- [VS Code](https://code.visualstudio.com)
- [Visual Studio]( https://visualstudio.microsoft.com/)



