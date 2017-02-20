import {Component} from "@angular/core";
import {Translate} from "./translate";
import {TranslateAddComponent} from "./translate-add.component"
import {TranslateService} from "./translate.service";

@Component({
    selector: "translate-list",
    templateUrl: "./app/translate/translate-list.component.html",
    directives: [TranslateAddComponent]
})
export class TranslateListComponent {
    translates: Translate[];
    
    constructor (private _translateService: TranslateService){ 
        this.translates = _translateService.getTranslates();       
    }
    
    removeTranslate(translate: Translate): void{
        this._translateService.removeTranslate(translate);
    }
}