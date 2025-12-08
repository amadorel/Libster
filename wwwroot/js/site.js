// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
/*
    site.js
            Author:         Eli Amador
            Creation Date:  2025-11-08
            Last revised:   2024-11-24 
            Description:    JS scripting for global Libster site 
*/


//Constant variables for storing font changing buttons: fontUp, Down, & Reset
const fontUp = document.getElementById("fontUp"); 
      fontDown = document.getElementById("fontDown");
      fontReset = document.getElementById("fontReset");
      
      //Hard-coded values to set limits (max, min, & default) for font changing
      fontMinimum = 12 //px units
      fontMaximum = 26; //in px units
      fontDefault = 16; //in px units 
      fontSizeChange = 1 //in px units 

      fontUp.addEventListener("click", () => {
        let currentFontSize = parseFloat(window.getComputedStyle(document.body).fontSize);

        //if the calculated font size is less than or equal to max, increase it
        if (currentFontSize <= fontMaximum) {
          const newFontSize = currentFontSize += fontSizeChange;
          document.documentElement.style.fontSize = `${newFontSize}px`; 
        } else { //set back to default to avoid going too large // i may change this logic later
          document.documentElement.style.fontSize = fontDefault + "px"
        }
      }); 

      fontDown.addEventListener("click", () => {
        const currentFontSize = parseFloat(window.getComputedStyle(document.body).fontSize);
        if (currentFontSize >= fontMinimum) {
          const newFontSize = currentFontSize - fontSizeChange;
          document.documentElement.style.fontSize = `${newFontSize}px`;
        } else { //Revert back to default size to avoid going too small
          document.documentElement.style.fontSize = fontDefault + "px"
        }
      }); 

      //Simply set back to default font size in px
     fontReset.addEventListener("click", () => {
        document.documentElement.style.fontSize = fontDefault + "px"; 
      }); 