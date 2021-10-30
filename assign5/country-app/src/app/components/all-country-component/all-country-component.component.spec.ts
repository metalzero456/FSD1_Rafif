import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllCountryComponentComponent } from './all-country-component.component';

describe('AllCountryComponentComponent', () => {
  let component: AllCountryComponentComponent;
  let fixture: ComponentFixture<AllCountryComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllCountryComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AllCountryComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
