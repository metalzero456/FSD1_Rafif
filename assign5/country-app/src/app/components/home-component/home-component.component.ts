import { Component, Input, OnInit } from '@angular/core';
import { Country } from 'src/app/models/Country';
import { CountryService } from 'src/app/country.service';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-home-component',
  templateUrl: './home-component.component.html',
  styleUrls: ['./home-component.component.css'],
})
export class HomeComponentComponent implements OnInit {
  countries: Country[] = [];
  countriesByArea: Country[] = [];
  countriesByPopulation: Country[] = [];
  countriesByGDP: Country[] = [];

  constructor(private countryService: CountryService) {}

  ngOnInit(): void {
    this.getCountries();
    this.countriesByArea = [...this.countries].sort((a, b) => b.area - a.area);
    this.countriesByPopulation = [...this.countries].sort(
      (c, d) => d.population - c.population
    );
    this.countriesByGDP = [...this.countries].sort((c, d) => d.gdp - c.gdp);
  }

  getCountries() {
    this.countryService
      .getCountry()
      .subscribe((countries) => (this.countries = countries));
  }
}
