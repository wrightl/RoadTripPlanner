import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";

@Component({
    selector: "app-trips-component",
    templateUrl: "./trips.component.html",
})
export class TripsComponent {
    public trips: TripDto[];

    constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
        http.get<TripDto[]>(baseUrl + "api/" + "trips").subscribe(
            (result) => {
                this.trips = result;
            },
            (error) => console.error(error)
        );
    }
    // public currentCount = 0;

    // public incrementCounter() {
    //     this.currentCount++;
    // }
}

interface TripDto {
    id: string;
    description: string;
}
