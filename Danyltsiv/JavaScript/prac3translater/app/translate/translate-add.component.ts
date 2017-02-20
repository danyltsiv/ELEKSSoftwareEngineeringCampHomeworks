import {Component} from "@angular/core";
import {Translate} from "./translate";
import {TranslateService} from "./translate.service";

@Component({
    selector: "translate-add",
    templateUrl: "./app/translate/translate-add.component.html"
})
export class TranslateAddComponent {
    constructor(private _translateService: TranslateService) {
    }

    editedTranslate: Translate = new Translate();

    saveTranslate(): void {
        this._translateService.addTranslate(this.editedTranslate);
        this.editedTranslate = new Translate();
    }
}