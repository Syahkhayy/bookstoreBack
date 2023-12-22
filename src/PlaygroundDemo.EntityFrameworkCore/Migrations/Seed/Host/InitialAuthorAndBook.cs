using PlaygroundDemo.Bookstore;
using PlaygroundDemo.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundDemo.Migrations.Seed.Host
{
    public class InitialAuthorAndBook
    {
        private readonly PlaygroundDemoDbContext _context;

        public InitialAuthorAndBook(PlaygroundDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var joanne = _context.Authors.FirstOrDefault(p => p.EmailAddress == "joannerowling@hp.com");
            if (joanne == null)
            {
                _context.Authors.Add(
                    new Author
                    {
                        FullName = "Joanne Rowling",
                        Age = 58,
                        EmailAddress = "joannerowling@hp.com",
                        Books = new List<Book>
                                {
                                    new Book {
                                    Title = "Harry Potter And The Philosopher's Stone",
                                    YearPublish = "June 1995",
                                    GenresString = "2,5",
                                    },
                                    new Book {
                                    Title = "Harry Potter And The Chamber Of Secret",
                                    YearPublish = "1996",
                                    GenresString = "4,5",
                                    Summary = "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the \"Chamber of Secrets\" has been opened and that the \"heir of Slytherin\" would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.",
                                    },

                                }
                    });
            }

            var hamka = _context.Authors.FirstOrDefault(p => p.EmailAddress == "buyahamka@gmail.com");
            if (hamka == null)
            {
                _context.Authors.Add(
                    new Author
                    {
                        FullName = "Haji Abdul Malik Karim Amrullah",
                        Age = 73,
                        EmailAddress = "buyahamka@gmail.com",
                        Books = new List<Book>
                                {
                                    new Book {
                                    Title = "Tenggelamnya Kapal Van Der Wijck",
                                    YearPublish = "1937",
                                    GenresString = "12,5,8",
                                    Summary = "Zainuddin ialah seorang anak yatim. bapa Minang meninggal dunia dalam buangan selepas membunuh saudara pemilikan; ibu bukan Minang beliau juga telah meninggal dunia. Beliau kini hidup dengan rakan bapanya Mak Base di Batipuh, Sumatra. Sebagai seorang yang berketurunan campuran, beliau menghadapi banyak diskriminasi daripada konservatif Minang. Walaupun dia menyintai Hayati, anak seorang bangsawan tempatan, Hayati tidak dibenarkan untuk bersama dengan beliau. Dia memutuskan untuk bergerak ke Padang Panjang, walaupun dia terus menulis kepada Hayati.",
                                    Collaborators = new List<Author>
                                        {
                                            new Author
                                            {
                                                FullName = "Muhammad Syarkawi",
                                                Age = 65,
                                                EmailAddress = "msyarkawi@gmail.com",
                                                Phone = "0123456789",
                                            },
                                            new Author
                                            {
                                                FullName = "Syahmi Khairul",
                                                Age = 24,
                                                EmailAddress = "syahmi.khairul@infinitilab.com",
                                                Phone = "0197818151",
                                            }

                                        }
                                    },
                                    new Book {
                                    Title = "Sullam Al-Wusyul",
                                    YearPublish = "1984",
                                    GenresString = "13,14",
                                    }
                                }
                    });
            }
        }
    }
}
