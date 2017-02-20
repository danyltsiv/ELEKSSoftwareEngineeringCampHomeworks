import {Injectable} from "@angular/core";
import {Translate} from "./translate";

@Injectable()
export class TranslateService {
    private _translateList: Translate[] = [
        {
            translateId: 0,
            phrase: "Собака",
            translation: "Dog"
        }, {
            translateId: 1,
            phrase: "Стіл",
            translation: "Table"
        }, {
            translateId: 2,
            phrase: "Яблуко",
            translation: "Apple"
        }
    ];

    getTranslates(): Translate[] {
        return this._translateList;
    }

    addTranslate(translate: Translate): void {
        this._translateList.push(translate);
    }
    
    getTranslate(phrase: string) : Translate {
        var finded = this._translateList.find(g=>g.phrase==phrase);
        return finded;
    }
    
    removeTranslate(translate: Translate): void {
        var index = this._translateList.indexOf(translate, 0);
        this._translateList.splice(index, 1);
    }
}