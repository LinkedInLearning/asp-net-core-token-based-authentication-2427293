# ASP.NET Core: Token-Based Authentication
This is the repository for the LinkedIn Learning course ASP.NET Core: Token-Based Authentication. The full course is available from [LinkedIn Learning][lil-course-url].

![ASP.NET Core: Token-Based Authentication][lil-thumbnail-url] 

Are you a developer needing to learn about token-based authentication? This course deep dives into the difference between authentication and authorization, the difference between traditional and token-based authentication, and how to set up this new authentication mechanism in .NET Core applications. Instructor Ervis Trupja steps through everything you need to get started with authentication, then shows you how to set up token-based authentication to generate new access and refresh tokens. He covers generating an access token using a refresh token and explains how to sign up and log in users using tokens. Lastly, Ervis demonstrates how to add role-based constraints and configure roles as part of the token claims.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"


### Instructor

Ervis Trupja 
                            
Software Developer

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/ervis-trupja).

[lil-course-url]: https://www.linkedin.com/learning/asp-dot-net-core-token-based-authentication
[lil-thumbnail-url]: https://cdn.lynda.com/course/2427293/2427293-1629914992559-16x9.jpg
