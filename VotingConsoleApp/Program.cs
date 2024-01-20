using System;
using ConsoleTables;

namespace VotingConsoleApp
{
    class Program
    {
        private static List<User> _users;
        private static List<Vote> _votes;
        private static List<Category> _categories;
        private static User? _currentUser;

        static void Main()
        {
            SeedData();

            Console.WriteLine("Welcome to voting app");

            ShowStartupMenu();
        }
        private static void SeedData()
        {
            _users = new List<User>(){
                new User(){
                    FirstName = "John",
                    LastName = "Doe",
                    Username = "johndoe",
                    Email = "1",
                    Password = "1",
                },
                new User(){
                    FirstName = "Jane",
                    LastName = "Doe",
                    Username = "janedoe",
                    Email = "2",
                    Password = "2",
                }
            };

            _categories = new List<Category>(){
                new Category(){
                    Name = "Football"
                },
                new Category(){
                    Name = "Cars"
                },
                new Category(){
                    Name = "Guns"
                },
                new Category(){
                    Name = "Movies"
                },
                new Category(){
                    Name = "TV Series"
                },
                new Category(){
                    Name = "Celebrities"
                },
                new Category(){
                    Name = "Countries"
                },
                new Category(){
                    Name = "Colors"
                },
                new Category(){
                    Name = "Science"
                },
                new Category(){
                    Name = "Fashion"
                },
                new Category(){
                    Name = "Games"
                },
                new Category(){
                    Name = "Coding"
                },
            };

            _votes = new List<Vote>(){
                new Vote(){
                    Content = "Which character do you hate most at Breaking Bad ?",
                    Category = _categories.Find(x => x.Name.Contains("TV Series")),
                    Answers = new List<Answer>(){
                        new Answer(){
                            Content = "Skyler White"
                        },
                        new Answer(){
                            Content = "Ted Beneke"
                        },
                        new Answer(){
                            Content = "Todd Alquist"
                        },
                        new Answer(){
                            Content = "Marie Schrader"
                        },
                    },
                    UserAnswers = new List<UserAnswer>(),
                    ExpiredAt = new DateTime(2024,01,29),
                    CreatedUser = _users.First(x => x.Username == "johndoe")
                }
            };
        }
        private static void ShowStartupMenu()
        {
            Console.WriteLine("To vote anything, you have to login or register.");
            Console.WriteLine("1 -) Login");
            Console.WriteLine("2 -) Register");
            Console.WriteLine("3 -) Exit App");

            string[] validKeys = ["1", "2", "3"];

            while (true)
            {
                Console.Write("Enter a key: ");
                string key = Console.ReadLine().Trim();

                if (!validKeys.Contains(key))
                {
                    SendMessage("Invalid key, try again.", MessageTypeEnum.Error);
                }
                else
                {
                    switch (key)
                    {
                        case "1":
                            ShowLoginMenu();
                            break;
                        case "2":
                            ShowRegisterMenu();
                            break;
                        case "3":
                            Environment.Exit(0);
                            break;
                    }
                }
            }


        }
        private static void ShowLoginMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("To login, please enter your email and password.");
            Console.Write("Email: ");
            string emailAddress = Console.ReadLine().Trim();
            Console.Write("Password: ");
            string password = Console.ReadLine().Trim();

            //Check if informations has written wrong

            User? foundUser = _users.Find(x => x.Email == emailAddress);
            if (foundUser is null)
            {
                SendMessage("User could not found, please try again.", MessageTypeEnum.Error);
                ShowLoginMenu();
            }
            else if (foundUser.Password != password)
            {
                SendMessage("Email address or password is incorrect, please try again.", MessageTypeEnum.Error);
                ShowLoginMenu();
            }
            else
            {
                _currentUser = foundUser;

                SendMessage("You have successfully logged in", MessageTypeEnum.Success);
                ShowAppMenu();
            }
        }
        private static void ShowRegisterMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("To register, you have to follow these instructions.");
            Console.WriteLine("You have to type your first name, last name, username, email and password");
            Console.WriteLine("with these format : John,Doe,johndoe,johndoe@hotmail.com,12345");

            Console.Write("Enter your informations: ");
            string informations = Console.ReadLine().Trim();

            string[] splittedInformations = informations.Split(',');
            if (splittedInformations.Length != 5)
            {
                //Check which information user didn't fill
            }
            else
            {
                //Check if informations has written wrong

                if (_users.Any(x => x.Email == splittedInformations[3]))
                {
                    SendMessage("This email address is already taken, please register again.", MessageTypeEnum.Error);
                    ShowRegisterMenu();
                }

                User user = new User()
                {
                    FirstName = splittedInformations[0],
                    LastName = splittedInformations[1],
                    Username = splittedInformations[2],
                    Email = splittedInformations[3],
                    Password = splittedInformations[4],
                };

                _users.Add(user);

                SendMessage("You have successfully registered.", MessageTypeEnum.Success);

                ShowStartupMenu();
            }
        }
        private static void ShowAppMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to application, please select what do you want at this menu.");
            Console.WriteLine("1 -) Show votes");
            Console.WriteLine("2 -) Show categories");
            Console.WriteLine("3 -) Create vote");
            Console.WriteLine("4 -) Show my created votes");
            Console.WriteLine("5 -) Logout");

            string[] validKeys = ["1", "2", "3", "4", "5"];


            while (true)
            {
                Console.Write("Enter a key: ");
                string key = Console.ReadLine().Trim();

                if (!validKeys.Contains(key))
                {
                    SendMessage("Invalid key, try again.", MessageTypeEnum.Error);
                }
                else
                {
                    switch (key)
                    {
                        case "1":
                            ShowVotes();
                            break;
                        case "2":
                            ShowCategories();
                            break;
                        case "3":
                            CreateVote();
                            break;
                        case "4":
                            ShowUsersCreatedVotes();
                            break;
                        case "5":
                            ShowStartupMenu();
                            break;
                    }
                }
            }
        }
        private static void SendMessage(string message, MessageTypeEnum messageType)
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            switch (messageType)
            {
                case MessageTypeEnum.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case MessageTypeEnum.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageTypeEnum.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }


            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }
        private static void ShowUsersCreatedVotes()
        {
            List<Vote> usersCreatedVotes = _votes.Where(x => x.CreatedUser.Id == _currentUser.Id).ToList();

            int pageSize = 5;
            int totalPages = (int)Math.Ceiling((double)_votes.Count / pageSize);

            int currentPage = 1;

            do
            {
                Console.Clear();
                Console.WriteLine($"Page {currentPage} of {totalPages}\n");

                DisplayVotesAsPagination(currentPage, pageSize, usersCreatedVotes);

                Console.WriteLine("\nPress 'N' for the next page, \n " +
                "'P' for the previous page, \n " +
                "'S' for the select vote, \n " +
                "'D' for the delete vote, \n " +
                "'SD' for the show vote details \n " +
                "or any other key to go back main menu.");

                string key = Console.ReadLine().Trim();

                if (key == "N" && currentPage < totalPages)
                {
                    currentPage++;
                }
                else if (key == "P" && currentPage > 1)
                {
                    currentPage--;
                }
                else if (key == "S")
                {
                    SelectVote();
                }
                else if (key == "D")
                {
                    DeleteVote();
                }
                else if (key == "SD")
                {
                    ShowVoteDetails();
                }
                else
                {
                    break;
                }

            } while (true);

            ShowAppMenu();
        }
        private static void ShowVotes()
        {
            int pageSize = 5;
            int totalPages = (int)Math.Ceiling((double)_votes.Count / pageSize);

            int currentPage = 1;

            do
            {
                Console.Clear();
                Console.WriteLine($"Page {currentPage} of {totalPages}\n");

                DisplayVotesAsPagination(currentPage, pageSize, _votes);

                Console.WriteLine("\nPress 'N' for the next page, \n " +
                "'P' for the previous page, \n " +
                "'S' for the select vote, \n " +
                "'SD' for the show vote details \n " +
                "or any other key to go back main menu.");

                string key = Console.ReadLine().Trim();

                if (key == "N" && currentPage < totalPages)
                {
                    currentPage++;
                }
                else if (key == "P" && currentPage > 1)
                {
                    currentPage--;
                }
                else if (key == "S")
                {
                    SelectVote();
                }
                else if (key == "SD")
                {
                    ShowVoteDetails();
                }
                else
                {
                    break;
                }

            } while (true);

            ShowAppMenu();
        }
        private static void DeleteVote()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter vote ID: ");
            string voteId = Console.ReadLine().Trim();

            Vote? foundVote = _votes.Find(x => x.Id == voteId);
            if (foundVote is null)
            {
                SendMessage("Vote could not found", MessageTypeEnum.Error);
                ShowAppMenu();
            }
            else if (foundVote.CreatedUser.Id != _currentUser.Id)
            {
                SendMessage("You cannot delete this vote because you didn't create this vote", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            _votes.Remove(foundVote);
            SendMessage("You successfully deleted vote", MessageTypeEnum.Success);
            ShowAppMenu();
        }
        private static void ShowVoteDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter vote ID: ");
            string voteId = Console.ReadLine().Trim();

            Vote? foundVote = _votes.Find(x => x.Id == voteId);
            if (foundVote is null)
            {
                SendMessage("Vote could not found", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            int totalAnswered = foundVote.UserAnswers.Count;

            if (totalAnswered == 0)
            {
                SendMessage("Nobody voted this vote. You can be first.", MessageTypeEnum.Warning);
                ShowAppMenu();
            }

            Console.WriteLine("Statistics of answers of vote");

            var table = new ConsoleTable("Answer", "Count", "Percent");

            for (int i = 0; i < foundVote.Answers.Count; i++)
            {
                Answer currentAnswer = foundVote.Answers[i];

                int countOfAnswerUserSelected = foundVote.UserAnswers.Count(x => x.Answer.Id == foundVote.Answers[i].Id);
                float percent = countOfAnswerUserSelected / totalAnswered * 100;

                table.AddRow(currentAnswer.Content, countOfAnswerUserSelected, $"{percent}%");
            }

            table.Write();

            ShowAppMenu();
        }
        private static void SelectVote()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter vote ID: ");
            string voteId = Console.ReadLine().Trim();

            Vote? foundVote = _votes.Find(x => x.Id == voteId);
            if (foundVote is null)
            {
                SendMessage("Vote could not found", MessageTypeEnum.Error);
                ShowAppMenu();
            }
            else if (foundVote.ExpiredAt < DateTime.Now)
            {
                SendMessage("Vote has been expired", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            string[] validKeys = new string[foundVote.Answers.Count + 1];

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Vote {foundVote.Id}");
            Console.WriteLine(foundVote.Content);
            Console.WriteLine("Answers: ");
            for (int i = 0; i < foundVote.Answers.Count; i++)
            {
                string validKey = Convert.ToChar(65 + i).ToString();
                validKeys[i] = validKey;
                Console.WriteLine($"{validKey} -) {foundVote.Answers[i].Content}");
            }

            validKeys[validKeys.Length - 1] = "e";

            Console.WriteLine("");
            Console.Write("Please pick one of the answers or enter 'e' to exit vote: ");
            string key = Console.ReadLine().Trim();

            while (true)
            {
                if (!validKeys.Contains(key))
                {
                    SendMessage("Invalid key, try again.", MessageTypeEnum.Error);
                }
                else
                {
                    if (key == "e")
                    {
                        ShowAppMenu();
                    }
                    else
                    {
                        bool sameUserAlreadyVotedCheck = foundVote.UserAnswers.Any(x => x.User.Id == _currentUser.Id);

                        if (!sameUserAlreadyVotedCheck)
                        {
                            int index = Convert.ToChar(key) - 65;

                            Answer currentAnswer = foundVote.Answers[index];

                            Console.Write($"Are you sure you want to select {currentAnswer.Content} ? Enter 'Y' for select any key for deny: ");
                            string key2 = Console.ReadLine().Trim();

                            if (key2 == "Y")
                            {
                                _votes.Find(x => x.Id == foundVote.Id).UserAnswers.Add(new UserAnswer()
                                {
                                    User = _currentUser,
                                    Answer = currentAnswer
                                });
                                SendMessage("You have successfully voted.", MessageTypeEnum.Success);
                                ShowAppMenu();
                            }
                            else
                            {
                                Console.Write("Please pick one of the answers or enter 'e' to exit vote: ");
                                key = Console.ReadLine().Trim();
                                continue;
                            }

                        }
                        else
                        {
                            int index = Convert.ToChar(key) - 65;
                            Answer currentAnswer = foundVote.Answers[index];

                            foundVote.UserAnswers.Find(x => x.User.Id == _currentUser.Id).Answer = currentAnswer;

                            Console.Write($"Are you sure you want to select {currentAnswer.Content} ? Enter 'Y' for select any key for deny: ");
                            string key2 = Console.ReadLine().Trim();

                            if (key2 == "Y")
                            {
                                _votes.Find(x => x.Id == foundVote.Id).UserAnswers.Add(new UserAnswer()
                                {
                                    User = _currentUser,
                                    Answer = currentAnswer
                                });
                                SendMessage("You have successfully voted.", MessageTypeEnum.Success);
                                ShowAppMenu();
                            }
                            else
                            {
                                Console.Write("Please pick one of the answers or enter 'e' to exit vote: ");
                                key = Console.ReadLine().Trim();
                                continue;
                            }
                        }
                    }
                }
            }
        }
        private static void ShowCategories()
        {
            int pageSize = 5;
            int totalPages = (int)Math.Ceiling((double)_categories.Count / pageSize);

            int currentPage = 1;

            do
            {
                Console.Clear();
                Console.WriteLine($"Page {currentPage} of {totalPages}\n");

                DisplayCategoriesAsPagination(currentPage, pageSize);

                Console.WriteLine("\nPress 'N' for the next page, 'P' for the previous page or any other key to go back main menu.");

                string key = Console.ReadLine().Trim();

                if (key == "N" && currentPage < totalPages)
                {
                    currentPage++;
                }
                else if (key == "P" && currentPage > 1)
                {
                    currentPage--;
                }
                else
                {
                    break;
                }

            } while (true);

            ShowAppMenu();
        }
        private static void CreateVote()
        {
            Console.WriteLine("To create vote, you have to enter content, category, expired date and answers");

            Console.Write("Enter content: ");
            string content = Console.ReadLine().Trim();

            Console.Write("Enter category ID: ");
            string categoryId = Console.ReadLine().Trim();

            Category? foundCategory = _categories.Find(x => x.Id == categoryId);

            if (foundCategory is null)
            {
                SendMessage("Category could not found, please try again", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            Console.Write("Enter a expired date (yyyy-MM-dd): ");
            string enteredExpiredDate = Console.ReadLine().Trim();

            if (!DateTime.TryParse(enteredExpiredDate, out DateTime expiredDate))
            {
                SendMessage("Invalid date format. Please enter a valid date.", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            Console.Write("Enter how many answer do you want to add. (Minimum 2, maximum 5): ");
            string typedAnswerCount = Console.ReadLine().Trim();
            int answerCount = Convert.ToInt16(typedAnswerCount);

            Answer[] answers = new Answer[answerCount];

            for (int i = 0; i < answerCount; i++)
            {
                Console.WriteLine();
                Console.Write($"Enter answer {i + 1}: ");
                string answerContent = Console.ReadLine().Trim();

                Answer answer = new Answer()
                {
                    Content = answerContent
                };

                answers[i] = answer;
            }

            Vote newVote = new Vote()
            {
                Answers = answers.ToList(),
                Content = content,
                Category = foundCategory,
                UserAnswers = new List<UserAnswer>(),
                ExpiredAt = expiredDate
            };

            _votes.Add(newVote);

            SendMessage("You have successfully created new vote.", MessageTypeEnum.Success);
            ShowAppMenu();
        }
        private static void DisplayCategoriesAsPagination(int currentPage, int pageSize)
        {
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, _categories.Count);

            var table = new ConsoleTable("ID", "Name");

            for (int i = startIndex; i < endIndex; i++)
            {
                table.AddRow(_categories[i].Id, _categories[i].Name);
            }

            table.Write();
        }
        private static void DisplayVotesAsPagination(int currentPage, int pageSize, List<Vote> votes)
        {
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, votes.Count);

            var table = new ConsoleTable("ID", "Content", "Expired At");

            for (int i = startIndex; i < endIndex; i++)
            {
                string customDateFormat = "yyyy-MM-dd";
                string formattedDateTime = votes[i].ExpiredAt.ToString(customDateFormat);
                table.AddRow(votes[i].Id, votes[i].Content, formattedDateTime);
            }

            table.Write();
        }
    }
}
