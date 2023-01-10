import Car, { NoteBook } from "./main_class.js";

// create new object from class -> Car
const NewCar = new Car (
    "Bugatti",
    "Chiron",
    "Blue",
    "450",
    "January 1, 2023",
    false,
    true,
    true
);

const NewNotebook = new NoteBook (
    30,
    20,
    200,
    true
);
    
console.log("My new car is:", NewCar.name, NewCar.model, 
            ". It's color is:", NewCar.color);

console.log("Date of purchase:", NewCar.PurchaseDate);
console.log("The car is", NewCar.CarAge(NewCar.PurchaseDate), "days old")
console.log("The car object is:", NewCar);

console.log("Length of notebook:", NewNotebook.length)

if(NewNotebook.IsOpen)
    console.log("Notebook is open")
else
    console.log("Notebook is closed")