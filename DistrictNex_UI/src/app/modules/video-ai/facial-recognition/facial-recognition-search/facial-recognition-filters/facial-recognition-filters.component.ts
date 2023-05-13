import { Subject } from 'rxjs';
import { cloneDeep } from 'lodash';
import { Component, Inject, OnDestroy } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Facial_Recognition_Filters } from './../facial-recognition-search.component';

@Component({
    selector: 'facial-recognition-filters',
    templateUrl: './facial-recognition-filters.component.html',
    styleUrls: ['./facial-recognition-filters.component.scss']
})
export class FacialRecognitionFiltersComponent implements OnDestroy {
    categorySearchInput: string = '';
    oList_Search_Category: string[] = [];
    oList_Genders: string[] = ['Male', 'Female'];
    oList_Emotions: string[] = ['Unknown', 'Happy', 'Surprised', 'Sad', 'Angry', 'Neutral'];
    oList_Age_Groups: string[] = ['1-19', '20-29', '30-39', '40-49', '50-59', '60-69', '70-100'];

    oFacial_Recognition_Filters: Facial_Recognition_Filters = new Facial_Recognition_Filters();

    private _unsubscribeAll: Subject<void> = new Subject<void>();

    constructor(
        @Inject(MAT_DIALOG_DATA) public data: any,
        private dialogRef: MatDialogRef<FacialRecognitionFiltersComponent>
    ) {
        if (data.facial_recognition_filters) {
            this.oFacial_Recognition_Filters = cloneDeep(data.facial_recognition_filters);
            if (!this.oFacial_Recognition_Filters.List_Selected_Category) {
                this.oFacial_Recognition_Filters.List_Selected_Category = [];
            }
        }
        if (data.categories) {
            this.oList_Search_Category = data.categories;
        }
    }

    applyFilter(): void {
        localStorage.setItem('facialRecognitionFilters', JSON.stringify(this.oFacial_Recognition_Filters));
        this.dialogRef.close(true);
    }

    genderSelection(gender): void {
        this.oFacial_Recognition_Filters.Selected_Gender = gender.value;
    }

    ageSelection(age): void {
        this.oFacial_Recognition_Filters.Selected_Age_Group = age.value;
    }

    emotionSelection(emotion): void {
        this.oFacial_Recognition_Filters.Selected_Emotion = emotion.value;
    }

    maskSelection(mask): void {
        this.oFacial_Recognition_Filters.HasMask = mask.value;
    }

    filter_Categories() {
        return this.oList_Search_Category.filter(search_category => !this.oFacial_Recognition_Filters.List_Selected_Category.some(selected_category => selected_category == search_category) && search_category.toLowerCase().includes(this.categorySearchInput.toLowerCase()));
    }

    addCategoryChoice(chosenCategory: string): void {
        this.oFacial_Recognition_Filters.List_Selected_Category.unshift(chosenCategory);
        this.categorySearchInput = '';
    }

    removeCategoryChoice(chosenCategory: string): void {
        this.oFacial_Recognition_Filters.List_Selected_Category.splice(this.oFacial_Recognition_Filters.List_Selected_Category.indexOf(chosenCategory), 1);
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

}
