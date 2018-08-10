import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { BookListComponent } from "../book/list/book-list.component";
import { BookRegisterComponent } from "../book/register/book-register.component";

const routes: Routes = [
    {
        path: "",
        redirectTo: "/livros", 
        pathMatch: "full"
    },
    {
        path: "livros",
        component: BookListComponent
    },
    {
        path: "livro-cadastro",
        component: BookRegisterComponent
    },
    {
        path: "livro-editar/:id",
        component: BookRegisterComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }