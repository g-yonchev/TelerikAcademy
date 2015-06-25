/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
    var library = (function () {
        var books, categories;

        books = [];
        categories = [];

        function listBooks(option) {
            var booksToReturn, property;

            booksToReturn = books.slice(0);

            if (option) {
                for (property in option) {
                    if (option.hasOwnProperty(property)) {
                        booksToReturn = booksToReturn.filter(function (item) {
                            return item[property] === option[property];
                        });
                    }
                }
            }

            return booksToReturn.sort(function (first, second) {
                return first.id - second.id;
            });
        }

        function addBook(book) {
            validateBookTitleAndCategory(book.title);
            validateBookISBN(book.isbn);
            validateBookAuthor(book.author);

            checkUniqueParametar(books, book.title, 'title');

            checkUniqueParametar(books, book.isbn, 'isbn');

            if (categories.indexOf(book.category) < 0) {
                addCategory(book.category);
            }

            book.isbn = book.isbn.toString();
            book.ID = books.length + 1;

            categories[book.category].books.push(book);

            books.push(book);

            return book;
        }

        function checkUniqueParametar(books, parametar, type) {
            var i, len, currentBook;

            for (i = 0, len = books.length; i < len; i += 1) {
                currentBook = books[i];
                if (currentBook[type] === parametar) {
                    throw new Error('Book must have unique ' + type);
                }
            }
        }

        function validateBookAuthor(author) {
            if (author === '') {
                throw new Error('Author cannot be non-empty string');
            }
        }

        function validateBookISBN(isbn) {
            if (isbn.toString().length !== 10 && isbn.toString().length !== 13) {
                throw new Error('ISBN must contains either 10 or 13 digits');
            } else if (!/[0-9]+/.test(isbn)) {
                throw new Error('ISBN must be only digits');
            }
        }

        function validateBookTitleAndCategory(title) {
            if (typeof title !== 'string') {
                throw new Error('Book title must be a string');
            } else if (title.length < 2 || title.length > 100) {
                throw new Error('Book title must be between 2 and 100 characters');
            }
        }

        function listCategories() {
            return categories.slice();
        }

        function addCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            };
        }

        function listCategories(category) {
            var categoriesNames;

            categoriesNames = [];
            Array.prototype.push.apply(categoriesNames, Object.keys(categories));

            return categoriesNames;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
var library = solve();
var book = {
    title: 'Knigata na Pesho',
    isbn: '0123456789',
    author: 'Pesho PESHOV'
};

var book2 = {
    title: 'Knigata na Gosho',
    isbn: '2123456789',
    author: 'Gosho GOSHOV'
};
module.exports = solve;
