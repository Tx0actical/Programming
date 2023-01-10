const backpack = {
    name: "daily backpack",
    color: "blue",
    strap_length: {
        right: 26,
        left: 26,
    },
    lid_open: true,

    toggleLid: function (lid_status) {
        this.lid_open = lid_status;
    },

    newStrapLength: function (left_len, right_len) {
        this.strap_length.left = left_len;
        this.strap_length.right = right_len;
    },
};

// console.log("The object is:", backpack);

const input = "color";

// console.log("The color property is:", backpack.color); // dot notation
// console.log("The color property is:", backpack[input]); // square bracket notation

const car = {
    name: "audi",
    model: "x1",
    color: "black",
    speed: 80,
    IsDoorOpen: false,
    IsWheelMoving: true,
    seat: {
        material: "leather",
        color: "white",
    },
    IsTankFull: true,
    
    DriveCar: function (__IsDoorOpen, __IsWheelMoving) {
        this.IsDoorOpen = __IsDoorOpen;
        this.IsWheelMoving = __IsWheelMoving;
        
        if(this.IsTankFull) {
            if(this.IsDoorOpen) {
                if(this.IsWheelMoving) {
                    this.IsDoorOpen == false;
                    return "Warning! Door is open, closing... Safely closed";
                } else
                    return "Getting out!"
            } else {
                if(this.IsWheelMoving) {
                    console.log("We're cruising! Speed is:");
                    this.IsTankFull = false;
                    return this.speed;
                }
                else
                    return "Car is parked!";
            }
        }
        else 
            return "Oops! Tank is empty";
    }
}

console.log(car.IsTankFull)
console.log(car.DriveCar(false, true));
console.log(car.IsTankFull)
// console.log(car.name)
// console.log(car.seat.color);

export default car;