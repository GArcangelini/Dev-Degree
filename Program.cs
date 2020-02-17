using System;

namespace GregArcangeliniCoverLetter
{
    class Program
    {

        static void Main(string[] args)
        {
            string segment;
            bool toEnd = false;

            Console.WriteLine("Dear Dev Degree Team,\n");
            Console.WriteLine("My name is Greg Arcangelini, and welcome to my 'cover letter' program. I'm applying to be a Dev Degree student intern, and my goal is to have this cover " +
                "letter show you why I will be a good fit at Shopify. As you can see, I've decided to take a slightly different approach to creating my cover letter, and I hope you " +
                "find this format both interesting and informative. In this program, I will outline why I feel I would be a good fit for the Dev Degree program at Shopify, and why I " +
                "feel I can bring a lot to your organization.\n");
            Console.WriteLine("At the bottom of this message, you'll find several numbers followed by short descriptions. Each number represents a segment of the cover " +
                "letter. Please press the number button corresponding to the segment you'd like to read followed by 'Enter'. " +
                "The segments are in no particular order, and when you're finished, please enter E to go to the end of the cover letter.\n");

            while (toEnd == false)
            {
                Console.WriteLine("Please enter the number of the segment you'd like to view, or enter 'E' to end the cover letter.\n" +
                    "1 : Previous professional experience\n2 : Love of challenges\n3 : Passion for learning\nE : End of cover letter\n");
                Console.Write("I'd like to see segment: ");
                segment = Console.ReadLine();
                switch (segment)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Currently, I work full-time as a mechanical engineer in the United States. While that profession doesn't seem to have much in common with the computer " +
                            "science field, many of the soft skills I've learned can apply in any professional environment. In the time I've spent as a mechanical engineer, " +
                            "I've learned how to effectively communicate with individuals with a wide variety of backgrounds, knowledge, and experience. Where I currently work, I interact with " +
                            "fellow engineers, architects, construction personnel, and building owners on a daily basis. Each of these individuals has a different understanding of what " +
                            "my job is and how it will impact them. Knowing how to effectively communicate with each person I work with in a way that meets their needs is essential in my line " +
                            "of work.\n\nThis skill will translate well to software development where a large amount of people with different backgrounds are working towards the same goal, " +
                            "and each person needs to understand what I do and how I can help them. By being involved in the Dev Degree program, I can further improve this skill " +
                            "by being exposed to multiple aspects of Shopify's development structure. I look forward to working with Shopify's diverse group of employees and building effective" +
                            "lines of communication.\n");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Throughout my life, I've always enjoyed being challenged. When I've been met with challenges in my professional life, I've often " +
                            "sought to create solutions to these problems. For example, in my first job as a mechanical engineer, there was a testing procedure I was performing " +
                            "that required the test samples to be cut in half for analysis. Unfortunately, there was no tool we could use to ensure the samples were cut in " +
                            "the same way each time, and this often led to poorly cut samples. In addition, an employee needed lots of practice to learn how to cut the samples well, " +
                            "slowing the process down and leading to inaccurate results. To fix this, I created a tool that held each sample in the same place each time. As a result, " +
                            "the test samples could now be accurately cut, even by someone who was inexperienced.\n\nTo me, the process of solving problems is an enjoyable one, " +
                            "and the diversity of Shopify's Dev Degree program will provide me with plenty of challenges to fuel this passion.\n");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Over time, I've found that the one thing I enjoy the most is learning something new. Whether learning the controls of a new video game, or " +
                            "how to perform a new task at my job, taking the time to learn new things is what keeps life interesting. The Dev Degree program sounds " +
                            "particularly interesting because it will allow me to learn new things both in and out of the classroom. By approaching the same concept from multiple " +
                            "angles I will be able to learn and understand new concepts faster than if I had used only one approach. I've alwyas been a quick study, and if accepted " +
                            "into the Dev Degree program, I will be able to quickly learn new roles and contribute to project teams quickly.\n\nI want to learn as much as I can. I want to be " +
                            "challenged. I want to see what my limits and capabilities are as a software developer. By working at Shopify, I know I will accomplish all of these goals.\n");
                        break;
                    case "E":
                        toEnd = true;
                        Console.Clear();
                        break;
                    case "e":
                        toEnd = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\nPlease enter one of the numeric values listed, or press E to end the cover letter.\n");
                        break;
                }
            }

            if (toEnd == true)
            {
                Console.Clear();
                Console.WriteLine("Thank you for taking the time to read my cover letter. Hopefully you agree that my combination of experience communicating on a " +
                    "professional level, my passion for taking on challenges, and my love of learning make me a great candidate for the Dev Degree internship program. " +
                    "I hope you found this cover letter format interesting, and if you would like to hear more about my passion for computer science and " +
                    "what I can bring to Shopify, please email me at garcangelini@gmail.com. My email can also be found on my resume along with my phone number and more " +
                    "details of what I can offer. Thank you once again, and I look forward to hearing back from you soon.\n\n" +
                    "Sincerely,\n\n" +
                    "Greg Arcangelini");
            }

        }
    }
}
