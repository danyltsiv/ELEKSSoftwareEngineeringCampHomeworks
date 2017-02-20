import {Component} from "@angular/core";
import {Translate} from "./translate";
import {TranslateService} from "./translate.service";

@Component({
    selector: "translate-query",
    templateUrl: "./app/translate/translate-query.component.html",
})

export class TranslateQueryComponent{
    translates: Translate[];
    
    constructor (private _translateService: TranslateService){ 
        this.translates = _translateService.getTranslates();       
    }
    
    queryTranslate: Translate = new Translate();
    
    getTranslation(): void{
        var translate  = this._translateService.getTranslate(this.queryTranslate.phrase);
        
        if (translate==null)
        {
            this.queryTranslate.translation = "No translation yet.";
        }
        else
        {
            this.queryTranslate.translation = translate.translation;
        }
    }
}