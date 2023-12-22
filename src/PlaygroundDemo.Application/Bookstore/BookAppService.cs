using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Microsoft.EntityFrameworkCore;
using PlaygroundDemo.Bookstore.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundDemo.Bookstore
{
    public class BookAppService : PlaygroundDemoAppServiceBase, IBookAppService
    {
        private readonly IRepository<Book> _bookRepository;
        private readonly IRepository<Author> _authorRepository;

        public BookAppService(IRepository<Book> bookRepository, IRepository<Author> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public ListResultDto<BookListDto> GetBook(GetBookInput input)
        {
            var books = _bookRepository
            .GetAll()
            .Include(p => p.Author)
            .Include(p => p.Collaborators)
            .WhereIf(
                !input.BookFilter.IsNullOrEmpty(),
                p => p.Title.Contains(input.BookFilter) ||
                     p.YearPublish.Contains(input.BookFilter) ||
                     p.Author.FullName.Contains(input.BookFilter) ||
                     p.Genres.Any(genre => Enum.TryParse<Genre>(input.BookFilter, out var filterGenre) && genre == filterGenre)
            //Equals(Enum.TryParse<Genre>(input.BookFilter, out Genre filterGenre))
            )
            .OrderBy(p => p.Title)
            .ThenBy(p => p.YearPublish)
            .ToList();

            return new ListResultDto<BookListDto>(ObjectMapper.Map<List<BookListDto>>(books));
        }

        public async Task CreateBook(CreateBookInput input)
        {

            var book = ObjectMapper.Map<Book>(input);

            if (input.CollaboratorsId != null && input.CollaboratorsId.Any())
            {
                // Initialize the Collaborators collection
                if (book.Collaborators == null)
                {
                    book.Collaborators = new List<Author>();
                }

                foreach (var collaboratorId in input.CollaboratorsId)
                {
                    var collaborator = await _authorRepository.GetAsync(collaboratorId);
                    if (collaborator != null)
                    { 
                        book.Collaborators.Add(collaborator);
                    }
                }
            }
            await _bookRepository.InsertAsync(book);
        }

        public async Task DeleteBook(EntityDto input)
        {
            await _bookRepository.DeleteAsync(input.Id);
        }

        public async Task<GetBookForEditOutput> GetBookForEdit(GetBookForEditInput input)
        {
            var book = await _bookRepository
            .GetAll()
            .Include(p => p.Collaborators)
            .FirstOrDefaultAsync(p => p.Id == input.Id);

            return ObjectMapper.Map<GetBookForEditOutput>(book);
        }

        public async Task EditBook(EditBookInput input)
        {
            var book = await _bookRepository
            .GetAll()
            .Include(p => p.Collaborators)
            .FirstOrDefaultAsync(p => p.Id == input.Id);

            book.Title = input.Title;
            book.YearPublish = input.YearPublish;
            book.Genres = input.Genres;
            book.Summary = input.Summary;
            book.AuthorId = input.AuthorId;

            if (input.CollaboratorsId != null && input.CollaboratorsId.Any())
            {
                // Initialize the Collaborators collection
                if (book.Collaborators == null)
                {
                    book.Collaborators = new List<Author>();
                }

                var currentCollaboratorIds = new HashSet<int>(book.Collaborators.Select(c => c.Id)); // To check contains in input or not
                // Add new collaborators
                foreach (var collaboratorId in input.CollaboratorsId)
                {
                    if (!currentCollaboratorIds.Contains(collaboratorId))
                    {
                        var collaborator = await _authorRepository.GetAsync(collaboratorId);
                        if (collaborator != null)
                        {
                            book.Collaborators.Add(collaborator);
                            currentCollaboratorIds.Add(collaboratorId);
                        }
                    }
                }

            }

            var collaboratorsToRemove = book.Collaborators
                    .Where(c => !input.CollaboratorsId.Contains(c.Id))
                    .ToList();

            foreach (var collaborator in collaboratorsToRemove)
            {
                book.Collaborators.Remove(collaborator);
            }

            await _bookRepository.UpdateAsync(book);
        }

    }
}
