'use strict'; 
import { DOMManipulator } from "./DOMManipulator.js";
import { BookAJAXRepository } from "./BookAJAXRepository.js"; 

main(); 

function main() { 
  const bookRepo = new BookAJAXRepository('Book/Catalog'); 
  const mdom = new DOMManipulator();

  
  setUpEventHandlers(bookRepo); 
}


async function setUpEventHandlers(bookRepo) {
    const bookForm = document.getElementById('createBookForm'); 

    bookForm.addEventListener("submit", async (e) => { e.preventDefault(); 
      const authors = Array.from(document.querySelectorAll('.addAuthor'))
        .map(input => ({ FullName: input.value})); 

      const formData = {
        Title: document.getElementsByClassName('bookTitle').value, 
        Authors: authors,
        Genre: document.getElementById('Genre').value, 
        PublicationYear: document.getElementById('pubYear').value, 
        ISBN: document.getElementById('ISBNInput').value 
      }; 

      const result = await bookRepo.create(formData); 
      
      if (result.ok) {
        const bookModalElement = document.getElementById('createBookModal');
        const bookModal = bootstrap.Modal.getInstance(bookModalElement); 

        bookModal.hide(); 
        window.location.reload(); 
      }
    }); 

    let authorIndex = 1; 
    document.getElementById("addAuthorButton").addEventListener("click", () => {
      console.log("clicked"); 
      DOMManipulator.createAuthorForBookForm(authorIndex); 
      authorIndex++;
     });
    
}
