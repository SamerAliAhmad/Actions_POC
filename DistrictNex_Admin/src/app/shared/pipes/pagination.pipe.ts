import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'pagination',
    pure: false
})
export class PaginationPipe implements PipeTransform {
    transform(value: any[], pageIndex, pageSize): any {
        return [...value.slice(pageSize * pageIndex, pageSize * (pageIndex + 1))];
    }
}