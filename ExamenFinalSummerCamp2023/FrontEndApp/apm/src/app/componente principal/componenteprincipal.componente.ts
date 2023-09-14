import { Component } from "@angular/core";
// import { UsuarioService } from "../usuarios/usuario.services";
import { IPersonaCreacion } from "./PersonaDTOCreacion";
import { IPersona } from "./PersonaDTO";
import { PersonaServicio } from "./persona.servicio";
import { Subscription } from "rxjs";
import { OnInit } from "@angular/core";

@Component({
    selector: "pm-compPrincipal",
    templateUrl: "\componenteprincipal.componente.html",
    styleUrls: []
})

export class ComponentePrincipalModule implements OnInit{ 
    pageTitle: string = "Home";
    errorMessage: string = '';
    sub!: Subscription;
    personas: IPersona[] = [] ;

    formData: IPersonaCreacion = {
        Nombre: '',
        FechaNacimiento: new Date(),
        Telefono: ''
      };

    constructor(public personaServicio: PersonaServicio){}

    onSubmit(){

        this.personaServicio.postPersona(this.formData).subscribe({

            next: result => {

                console.log("Persona dada de alta satisfactoriamente")
                this.updateHistorial();
          
            },
            error: err => this.errorMessage = err,
        })
        
        
    }

    ngOnInit(): void {
        this.updateHistorial();


    }

    updateHistorial():void{
        this.sub = this.personaServicio.getPersonas().subscribe({
          next: data => {
            this.personas = data;
            // console.log(data);
            // console.log(data[0].Id)
          },
          error: err => this.errorMessage = err
        });
        
      }

      ngOnDestroy(): void {
        this.sub.unsubscribe();
      }
}