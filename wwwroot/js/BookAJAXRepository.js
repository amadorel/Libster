'use strict'; 

export class BookAJAXRepository { 
  #baseAddress; 
  constructor(baseAddress) {
    this.#baseAddress = baseAddress; 
  }

  async readAll() {
    const address = `${this.#baseAddress}/all`
    const response = await fetch(address); 
    if (response.ok === false) {
      throw new Error("There was an HTTP error getting book data");
    } return await response.json(); 
  }

    async read(id) {
    const address = `${this.#baseAddress}/book/${id}`; 
    const response = await fetch(address); 
    if (response.ok === false) {
      throw new Error("There was an HTTP error getting book data"); 
    } return await response.json(); 
  } 

  async create(formData) {
    const address = `${this.#baseAddress}/create`;
    const response = await fetch(address, {
      method: "post", 
      body: formData
    }); 
    if (response.ok === false) {
      throw new Error("There was an HTTP error creating the book data"); 
    } return await response.json(); 
  }

  async update(formData) {
    const address = `${this.#baseAddress}/update`;
    const response = await fetch(address, { 
      method: "put",
      body: formData
    });
    if (response.ok === false) {
      throw new Error("There was an HTTP error updating book data.");
    } return await response.text(); 
  } 

  async delete(id) {
    const address = `${this.#baseAddress}/delete/${id}`;
    const response = await fetch(address, {
      method: "delete"
    });
    if (response.ok === false) {
      throw new Error("There was an HTTP error deleting book data.");
    } return await response.text();
  }
}