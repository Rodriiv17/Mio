import { HttpClient, HttpHeaders, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, catchError, tap, throwError } from "rxjs";
import { IPersonaCreacion } from "./PersonaDTOCreacion";
import { IPersona } from "./PersonaDTO";

@Injectable({
    providedIn: 'root'
})

export class PersonaServicio {
    private apiUrl = 'https://localhost:7187/api/personas';

    constructor(private http: HttpClient) { }

    postPersona(persona: IPersonaCreacion): Observable<any> {
        return this.http.post<any>(this.apiUrl, persona).pipe(
            tap(data => console.log('All', JSON.stringify(data))),
            catchError(this.handleError)
        );
    }

    getPersonas(): Observable<IPersona[]> {


        return this.http.get<IPersona[]>(this.apiUrl).pipe(
            tap(data => console.log('All', JSON.stringify(data))),
            catchError(this.handleError)
        );
    }

    // getPersonas(): Observable<any> {


    //     return this.http.get<IPersona[]>(this.apiUrl);
    // }

    //BACKUP en caso de que la mia no vaya
    //   createPersona(persona: IPersona): Observable<IPersona> {
    //     const httpOptions = {
    //       headers: new HttpHeaders({
    //         'Content-Type': 'application/json'
    //       })
    //     };

    //     return this.http.post<IPersona>(this.apiUrl, persona, httpOptions);
    //   }

    private handleError(err: HttpErrorResponse) {
        // in a real world app, we may send the server to some remote logging infrastructure
        // instead of just logging it to the console
        let errorMessage = '';
        if (err.error instanceof ErrorEvent) {
            // A client-side or network error occurred. Handle it accordingly.
            errorMessage = `An error occurred: ${err.error.message}`;
        } else {
            // The backend returned an unsuccessful response code.
            // The response body may contain clues as to what went wrong,
            errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
        }
        console.error(errorMessage);
        return throwError(() => errorMessage);
    }
}