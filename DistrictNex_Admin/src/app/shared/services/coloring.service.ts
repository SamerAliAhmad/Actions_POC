import { Injectable } from '@angular/core';
import chroma from 'chroma-js';
import { isPlainObject, isString, mergeWith, pick } from 'lodash';

@Injectable({
    providedIn: 'root'
})
export class ColoringService {

    generateThemeColor(hexColor) {
        if (hexColor == null) {
            return;
        }
        const palette = this.generatePalette(hexColor);
        document.body.style.setProperty('--smartr-primary-50', palette[50]);
        document.body.style.setProperty('--smartr-primary-50-rgb', this.hexToRgb(palette[50]).r + ', ' + this.hexToRgb(palette[50]).g + ', ' + this.hexToRgb(palette[50]).b);
        document.body.style.setProperty('--smartr-primary-100', palette[100]);
        document.body.style.setProperty('--smartr-primary-100-rgb', this.hexToRgb(palette[100]).r + ', ' + this.hexToRgb(palette[100]).g + ', ' + this.hexToRgb(palette[100]).b);
        document.body.style.setProperty('--smartr-primary-200', palette[200]);
        document.body.style.setProperty('--smartr-primary-200-rgb', this.hexToRgb(palette[200]).r + ', ' + this.hexToRgb(palette[200]).g + ', ' + this.hexToRgb(palette[200]).b);
        document.body.style.setProperty('--smartr-primary-300', palette[300]);
        document.body.style.setProperty('--smartr-primary-300-rgb', this.hexToRgb(palette[300]).r + ', ' + this.hexToRgb(palette[300]).g + ', ' + this.hexToRgb(palette[300]).b);
        document.body.style.setProperty('--smartr-primary-400', palette[400]);
        document.body.style.setProperty('--smartr-primary-400-rgb', this.hexToRgb(palette[400]).r + ', ' + this.hexToRgb(palette[400]).g + ', ' + this.hexToRgb(palette[400]).b);
        document.body.style.setProperty('--smartr-primary-500', palette[500]);
        document.body.style.setProperty('--smartr-primary-500-rgb', this.hexToRgb(palette[500]).r + ', ' + this.hexToRgb(palette[500]).g + ', ' + this.hexToRgb(palette[500]).b);
        document.body.style.setProperty('--smartr-primary-600', palette[600]);
        document.body.style.setProperty('--smartr-primary-600-rgb', this.hexToRgb(palette[600]).r + ', ' + this.hexToRgb(palette[600]).g + ', ' + this.hexToRgb(palette[600]).b);
        document.body.style.setProperty('--smartr-primary-700', palette[700]);
        document.body.style.setProperty('--smartr-primary-700-rgb', this.hexToRgb(palette[700]).r + ', ' + this.hexToRgb(palette[700]).g + ', ' + this.hexToRgb(palette[700]).b);
        document.body.style.setProperty('--smartr-primary-800', palette[800]);
        document.body.style.setProperty('--smartr-primary-800-rgb', this.hexToRgb(palette[800]).r + ', ' + this.hexToRgb(palette[800]).g + ', ' + this.hexToRgb(palette[800]).b);
        document.body.style.setProperty('--smartr-primary-900', palette[900]);
        document.body.style.setProperty('--smartr-primary-900-rgb', this.hexToRgb(palette[900]).r + ', ' + this.hexToRgb(palette[900]).g + ', ' + this.hexToRgb(palette[900]).b);
        document.body.style.setProperty('--smartr-primary', hexColor);
        document.body.style.setProperty('--smartr-primary-rgb', this.hexToRgb(hexColor).r + ', ' + this.hexToRgb(hexColor).g + ', ' + this.hexToRgb(hexColor).b);
    }

    hexToRgb(hex) {
        var result = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(hex);
        return result ? {
            r: parseInt(result[1], 16),
            g: parseInt(result[2], 16),
            b: parseInt(result[3], 16)
        } : null;
    }

    generatePalette(config) {
        // Prepare an empty palette
        const palette = {
            50: null,
            100: null,
            200: null,
            300: null,
            400: null,
            500: null,
            600: null,
            700: null,
            800: null,
            900: null
        };

        // If a single color is provided,
        // assign it to the 500
        if (isString(config)) {
            palette[500] = chroma.valid(config) ? config : null;
        }

        // If a partial palette is provided,
        // assign the values
        if (isPlainObject(config)) {
            if (!chroma.valid(config[500])) {
                throw new Error('You must have a 500 hue in your palette configuration! Make sure the main color of your palette is marked as 500.');
            }

            // Remove everything that is not a hue/color entry
            config = pick(config, Object.keys(palette));

            // Merge the values
            mergeWith(palette, config, (objValue, srcValue) => chroma.valid(srcValue) ? srcValue : null);
        }

        // Prepare the colors array
        const colors = Object.values(palette).filter((color) => color);

        // Generate a very dark and a very light versions of the
        // default color to use them as the boundary colors rather
        // than using pure white and pure black. This will stop
        // in between colors' hue values to slipping into the grays.
        colors.unshift(
            chroma.scale(['white', palette[500]])
                .domain([0, 1])
                .mode("lrgb")
                .colors(50)[1]
        );
        colors.push(
            chroma.scale(['black', palette[500]])
                .domain([0, 1])
                .mode("lrgb")
                .colors(10)[1]
        );

        // Prepare the domains array
        const domain = [
            0,
            ...Object.entries(palette)
                .filter(([key, value]) => value)
                .map(([key]) => parseInt(key) / 1000),
            1
        ];

        // Generate the color scale
        const scale = chroma.scale(colors)
            .domain(domain)
            .mode('lrgb');

        // Build and return the final palette
        return {
            50: scale(0.05).hex(),
            100: scale(0.1).hex(),
            200: scale(0.2).hex(),
            300: scale(0.3).hex(),
            400: scale(0.4).hex(),
            500: scale(0.5).hex(),
            600: scale(0.6).hex(),
            700: scale(0.7).hex(),
            800: scale(0.8).hex(),
            900: scale(0.9).hex()
        };
    };
}
