import { Component, OnInit } from '@angular/core';
import { Country } from 'src/app/models/Country';
import { CountryService } from 'src/app/country.service';

@Component({
  selector: 'app-all-country-component',
  templateUrl: './all-country-component.component.html',
  styleUrls: ['./all-country-component.component.css'],
})
export class AllCountryComponentComponent implements OnInit {
  countries: Country[] = [];
  countriesByName: Country[] = [];

  constructor(private countryService: CountryService) {}

  ngOnInit(): void {
    this.getCountries();
    this.countriesByName = [...this.countries].sort((a, b) =>
      a.name.localeCompare(b.name)
    );
  }

  getCountries() {
    this.countryService
      .getCountry()
      .subscribe((countries) => (this.countries = countries));
  }
}
