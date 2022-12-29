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

console.log("The object is:", backpack);

var input = "color"

console.log("The color property is:", backpack.color); // dot notation
console.log("The color property is:", backpack[input]); // square bracket notation

const car = {
    name: "audi",
    model: "x1",
    color: "black",
    IsDriverDoorOpen: true,
    IsWheelMoving: false,
    seat: {
        material: "leather",
        color: "white",
    },
    
    IsDrivenNow: function (__IsDriverDoorOpen) {
        this.IsDriverDoorOpen = __IsDriverDoorOpen;

        if(this.IsDriverDoorOpen == true) {
            console.log("Driver-side door is open")
        }
    }
}

console.log(car.IsDrivenNow(true));
console.log(car.name)
console.log(car.seat.color);