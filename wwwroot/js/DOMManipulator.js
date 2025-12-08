'use strict'; 

export class DOMManipulator { 
  
  //Privatized list of Books
  #books; 
  //Initialization of #books
  constructor(books) {
    this.#books = books; 
  }

  static createBook() {
    //Manual entry 
    const bookCreationForm = document.querySelector('#createBookForm'); 
    bookCreationForm.classList.add(''); 
    }

  static createAuthorForBookForm(authorIndex){ 
    const authorContainer = document.getElementById("addAuthorsContainerInput");
    
    //Element to store user input
    const inputElement = document.createElement("div"); 
    inputElement.classList.add("authorInput", "mb-2"); 

    //User input to store 
    const authorInput = document.createElement("input"); 
    authorInput.type="text"; 
    authorInput.classList.add("form-control", "addAuthor"); 
    authorInput.name=`Authors[${authorIndex}].FullName`; 
    authorInput.placeholder="Author Name"; 

    const removeAuthorBtn = document.createElement("button"); 
    removeAuthorBtn.type = "button"; 
    removeAuthorBtn.classList.add("btn", "btn-danger", "removeAuthor"); 
    removeAuthorBtn.textContent = "x"; 

    removeAuthorBtn.addEventListener("click", (e) => {
        e.target.closest('.authorInput').remove();
    }); 

    inputElement.appendChild(authorInput); 
    inputElement.appendChild(removeAuthorBtn);
    authorContainer.appendChild(inputElement); 
  }
} //End of DOMManipulator class