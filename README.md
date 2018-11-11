# Sorting-MVC-Project
A second side project I'm doing during my Tech Elevator course using ASP.NET MVC 5

I've been very interested in algorithms so during my Tech Elevator bootcamp course.
I decided to tie together MVC, which I have just learned, and sorting algorithms that
I have been studying on the side to create a cool web application.
At the moment I have a visual represantation of a Bubble Sort, Selection Sort and
QuickSort. I plan on adding more as time goes on.

After I get a sufficient amount of sorts in there I will add a section for searching
algorithms. I also will create a database to store stats on how many passthroughs each
sort/search takes using dependency injection.

Instructions:
On the homepage, 15 random numbers are generated already for the user. The user can
enter however many random numbers the would like to generate. The View will then
generate a bar graph of randomly generated numbers and display them in a block
using the CSS grid.
At the top of the nav bar the user can select how they would like the numbers
to be sorted. MVC will then call that Action result and perform the sorting
algorithm in the Model. The user will see then click a button to watch the 
next pass through. After it is sorted, the user will be redirected to the homepage
and will see how many pass throughs it took. This number was recoreded using
Session[].

I had fun making this and have learned a lot making it. It's pretty cool.

Tools Used:
Razor, HTML, CSS, ASP.NET, MVC, C#

