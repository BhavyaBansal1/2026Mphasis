import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";



@Injectable()
export class AccountService
{
    private Apiurl="http://localhost:5045/api/Account/Create"
    private Apiurl1="http://localhost:5045/api/Account/Login"
    constructor(private objHttp:HttpClient)
    {

    }
    createAcount(data:any):Observable<any>
    {
        //will call core webapi endpoint
        return this.objHttp.post<any>(this.Apiurl,data);
    }
    Login(data:any):Observable<any>
    {
   return this.objHttp.post<any>(this.Apiurl1,data);
    }

}