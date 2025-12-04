'use strict'; 
import { DOMManipulator } from "./DOMManipulator.js";
import { BookAJAXRepository } from "./BookAJAXRepository.js"; 

main(); 

function main() { 
  const bookRepo = new BookAJAXRepository('Book/Catalog'); 
  const mdom = new DOMManipulator(); 
}


async function setUpEventHandlers(bookRepo) {
    const bookForm = document.getElementById('createBookForm'); 

    bookForm.addEventListener("submit", async (e) => { e.preventDefault(); 
      console.log("let's see what this is doing here"); 
      const formData = new FormData(bookForm); 
      const result = await bookRepo.create(formData); 
      
      if (result.ok) {
        const bookModalElement = document.getElementById();
        const bookModal = bootstrap.Modal.getInstance(bookModalElement); 

        bookModal.hide(); 
      }
    }); 
    
}
