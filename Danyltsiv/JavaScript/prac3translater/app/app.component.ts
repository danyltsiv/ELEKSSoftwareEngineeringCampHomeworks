import {Component} from '@angular/core';

import {TranslateListComponent} from './translate/translate-list.component';
import {TranslateService} from './translate/translate.service';
import {TranslateQueryComponent} from './translate/translate-query.component';

@Component({
    selector: 'my-app',
    templateUrl:'./app/app.component.html',
    directives: [TranslateListComponent,TranslateQueryComponent],
    providers: [TranslateService]
})
export class AppComponent { }
