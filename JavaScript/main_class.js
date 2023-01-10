
export default class Car {
    constructor ( // parameters
        __name,
        __model,
        __color,
        __speed,
        __PurchaseDate,
        __IsDoorOpen,
        __IsWheelMoving,
        __IsTankFull
    ) { // properties
        this.name           = __name;
        this.model          = __model;
        this.color          = __color;
        this.speed          = __speed;
        this.PurchaseDate   = __PurchaseDate;
        this.IsDoorOpen     = __IsDoorOpen;
        this.IsWheelMoving  = __IsWheelMoving;
        this.IsTankFull     = __IsTankFull;
    }

    DriveCar (__IsWheelMoving) { // function inside class is method
        this.IsWheelMoving = __IsWheelMoving;
    }

    CarAge (__PurchaseDate) {
        let today = new Date();
        let bought_on = new Date(__PurchaseDate);
        let time_elapsed_in_days = (today - bought_on) / (1000 * 3600 * 24);
        return Math.floor(time_elapsed_in_days);
    }
}

export class NoteBook {
    constructor (
        __length,
        __width,
        __pages,
        __IsOpen
    ) {
        this.length = __length;
        this.width  = __width;
        this.pages  = __pages;
        this.IsOpen = __IsOpen;
    }
}

