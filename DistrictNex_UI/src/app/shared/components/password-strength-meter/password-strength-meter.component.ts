import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { PasswordStrengthMeterService } from './password-strength-meter.service';

@Component({
    selector: 'password-strength-meter',
    templateUrl: './password-strength-meter.component.html',
    styleUrls: ['./password-strength-meter.component.scss']
})
export class PasswordStrengthMeterComponent implements OnChanges {
    @Input() password: string;
    @Input() minPasswordLength = 8;
    @Input() colors: string[] = [];
    @Input() enableFeedback = false;
    @Output() strengthChange = new EventEmitter<number>();

    passwordStrength: number = null;
    feedback: { suggestions: string[]; warning: string } = null;
    private prevPasswordStrength = null;
    private defaultColours = [
        'darkred',
        'orangered',
        'orange',
        'yellowgreen',
        'green'
    ];

    constructor(private passwordStrengthMeterService: PasswordStrengthMeterService) { }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes.password) {
            this.calculatePasswordStrength();
        }
    }

    calculatePasswordStrength(): void {
        if (!this.password) {
            this.passwordStrength = null;
        } else if (this.password && this.password.length < this.minPasswordLength) {
            this.passwordStrength = 0;
        } else {
            if (this.enableFeedback) {
                const result = this.passwordStrengthMeterService.scoreWithFeedback(
                    this.password
                );
                this.passwordStrength = result.score;
                this.feedback = result.feedback;
            } else {
                this.passwordStrength = this.passwordStrengthMeterService.score(
                    this.password
                );
                this.feedback = null;
            }
        }

        // Only emit the passwordStrength if it changed
        if (this.prevPasswordStrength !== this.passwordStrength) {
            this.strengthChange.emit(this.passwordStrength);
            this.prevPasswordStrength = this.passwordStrength;
        }
    }

    getMeterFillColor(strength): string {
        if (!strength || strength < 0 || strength > 5) {
            return this.colors[0] ? this.colors[0] : this.defaultColours[0];
        }

        return this.colors[strength] ? this.colors[strength] : this.defaultColours[strength];
    }
}
