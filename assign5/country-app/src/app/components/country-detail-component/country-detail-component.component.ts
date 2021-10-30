import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Country } from 'src/app/models/Country';
import { CountryService } from 'src/app/country.service';

@Component({
  selector: 'app-country-detail-component',
  templateUrl: './country-detail-component.component.html',
  styleUrls: ['./country-detail-component.component.css'],
})
export class CountryDetailComponentComponent implements OnInit {
  country_id: string;
  country: Country = {} as Country;

  constructor(
    private actRoute: ActivatedRoute,
    private productService: CountryService
  ) {
    this.country_id = this.actRoute.snapshot.params.id;
  }

  ngOnInit(): void {
    this.getOneCountry(this.country_id);
  }

  getOneCountry(id: string) {
    let country: Country;
    this.productService
      .getOneCountry(id)
      .subscribe((country) => (this.country = country));
  }
}
